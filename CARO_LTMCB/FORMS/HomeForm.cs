using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_LTMCB.FORMS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            btnBack.Hide();
            pnMessage.Hide();
            pnPvP.Hide();
            pnChessBoard.Enabled = false;
            pnAnotherUser.Hide();
            btnReady.Hide();
            if (MyUser.user != null)
                picMyUser.Image = Image.FromFile($"Resources\\{MyUser.user.avatar}.png");

            socket = new SocketManager();
            DrawChessBoard();
        }

        #region Thuộc tính 

        List<List<Button>> matrix;
        int currentPlayer = 1;
        int myTurn;
        int played = 0;
        public static bool isReady = true; //Sẵn sàng bắt đầu ván cờ mới
        int countChesss = 0;
        int gameMode = 1;
        //Chế độ chơi :
        //    1 - Tự chơi
        //    2 - PvCom
        //    3 - PvP

        Button currentChess;
        SocketManager socket;
        User anotherUser;
        #endregion

        #region Tạo bàn cờ, xử lý nước đi
        Button curentBtn = null;
        private void DrawChessBoard()
        {
            currentPlayer = 1;
            pnChessBoard.Controls.Clear();
            countChesss = 0;
            matrix = new List<List<Button>>();
            currentChess = new Button();
            prcbPlayer1.Value = 0;
            prcbPlayer2.Value = 0;
            tmCoolDown.Stop();
            for (int i = 0; i < 18; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < 21; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 35,
                        Height = 35,
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Standard,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        //Lưu vị trí hàng của btn trong mảng matrix
                        TabIndex = i,
                        //Ô chưa đánh có giá trị 0
                        Tag = "0"
                    };
                    if (curentBtn != null)
                    {
                        btn.Location = new Point(curentBtn.Right, curentBtn.Top);
                    }
                    else
                    {
                        btn.Location = new Point(0, 0);
                    }
                    btn.Click += Btn_Click;
                    pnChessBoard.Controls.Add(btn);

                    curentBtn = btn;

                    matrix[i].Add(btn);
                }
                curentBtn.Location = new Point(-35, curentBtn.Bottom);
            }
            curentBtn = null;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point point = new Point(matrix[btn.TabIndex].IndexOf(btn), btn.TabIndex);

            if (btn.BackgroundImage != null) return;

            if (gameMode == 1)
            {
                PutChess(point);
                prcbPlayer1.Value = 0;
                prcbPlayer2.Value = 0;
                tmCoolDown.Start();

                //Kiểm tra thắng thua mỗi khi đi một nước
                if (IsEndGame(currentChess))
                {
                    isReady = true;
                    EndGame();
                }
            }
            else if (gameMode == 2)
            {
                PutChess(point);
                if (IsEndGame(currentChess))
                {
                    isReady = true;
                    EndGame();
                    return;
                }

                StartBot();
                if (IsEndGame(currentChess))
                {
                    isReady = true;
                    EndGame();
                }
            }
            else
            {
                PutChess(point);
                countChesss++;
                prcbPlayer1.Value = 0;
                prcbPlayer2.Value = 0;
                tmCoolDown.Start();

                try
                {
                    pnChessBoard.Enabled = false;
                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", point));
                    Listen();
                }
                catch
                {

                }

                if (IsEndGame(currentChess))
                {
                    myTurn = 2;
                    tmCoolDown.Stop();
                    isReady = true;
                    //pnChessBoard.Enabled = false;
                    DTBase.AddMatch(anotherUser.userID);
                    NotifyForm nf = new NotifyForm("You win!", "Notification", NotifyForm.BoxBtn.Ok);
                    nf.ShowDialog();
                    pnChessBoard.Enabled = false;
                    btnReady.Show();
                }
            }
        }
        private void OrtherBtnClick(Point point)
        {
            if (matrix[point.Y][point.X].BackgroundImage != null) return;

            pnChessBoard.Enabled = true;

            PutChess(point);
            countChesss++;
            prcbPlayer1.Value = 0;
            prcbPlayer2.Value = 0;
            tmCoolDown.Start();

            if (IsEndGame(currentChess))
            {
                myTurn = 1;
                tmCoolDown.Stop();
                isReady = true;
                //pnChessBoard.Enabled = false;
                NotifyForm nf = new NotifyForm("You lost!", "Notification", NotifyForm.BoxBtn.Ok);
                nf.ShowDialog();
                pnChessBoard.Enabled = false;
                btnReady.Show();
            }
        }
        private void PutChess(Point point)
        {
            if (currentPlayer == 1)
            {
                matrix[point.Y][point.X].Tag = 1;
                matrix[point.Y][point.X].BackgroundImage = Image.FromFile("Resources\\X.png");
                currentPlayer = 2;
            }
            else
            {
                matrix[point.Y][point.X].Tag = 2;
                matrix[point.Y][point.X].BackgroundImage = Image.FromFile("Resources\\O.png");
                currentPlayer = 1;
            }

            currentChess = matrix[point.Y][point.X];
        }
        #endregion
        
        #region Check Game
        //Đánh cờ tại vị trí (x,y) , lưu quân của người chơi vào tag 

        private bool IsEndGame(Button btn)
        {
            return Check_Horizontal(btn) || Check_Vertical(btn) || Check_PrincipalDiagonal(btn) || Check_SecondaryDiagonal(btn);
        }

        //Lấy tọa độ của button vừa được click
        private Point GetPoint(Button btn)
        {
            int y = btn.TabIndex;
            int x = matrix[y].IndexOf(btn);

            Point point = new Point(x, y);
            return point;
        }

        //Check hàng ngang
        private bool Check_Horizontal(Button btn)
        {
            Point point = GetPoint(btn);
            int countLeft = 0;
            int countRight = 0;

            //Biến kiểm tra chặn 2 đầu
            bool block_A = false;
            bool block_B = false;

            //Kiểm tra bên trái
            for (int i = point.X - 1; i >= 0; i--)
            {
                if (matrix[point.Y][i].Tag.ToString() == btn.Tag.ToString())
                {
                    countLeft++;
                }
                else if (matrix[point.Y][i].Tag.ToString() != "0")
                {
                    block_A = true;
                    break;
                }
                else
                    break;
            }

            //Kiểm tra bên phải
            for (int i = point.X + 1; i < 20; i++)
            {
                if (matrix[point.Y][i].Tag.ToString() == btn.Tag.ToString())
                {
                    countRight++;
                }
                else if (matrix[point.Y][i].Tag.ToString() != "0")
                {
                    block_B = true;
                    break;
                }
                else
                    break;
            }

            return (countLeft + countRight >= 4) && !(block_A && block_B);
        }

        //Check hàng dọc
        private bool Check_Vertical(Button btn)
        {
            Point point = GetPoint(btn);
            int countTop = 0;
            int countBot = 0;

            //Biến kiểm tra chặn 2 đầu
            bool block_A = false;
            bool block_B = false;

            //Kiểm tra phía trên
            for (int i = point.Y - 1; i >= 0; i--)
            {
                if (matrix[i][point.X].Tag.ToString() == btn.Tag.ToString())
                {
                    countTop++;
                }
                else if (matrix[i][point.X].Tag.ToString() != "0")
                {
                    block_A = true;
                    break;
                }
                else
                    break;
            }

            //Kiểm tra phía dưới
            for (int i = point.Y + 1; i < 18; i++)
            {
                if (matrix[i][point.X].Tag.ToString() == btn.Tag.ToString())
                {
                    countBot++;
                }
                else if (matrix[i][point.X].Tag.ToString() != "0")
                {
                    block_B = true;
                    break;
                }
                else
                    break;
            }

            return (countTop + countBot >= 4) && !(block_A && block_B);
        }

        //Check chéo chính
        private bool Check_PrincipalDiagonal(Button btn)
        {
            Point point = GetPoint(btn);
            int countTopLeft = 0;
            int countBotRight = 0;

            //Biến kiểm tra chặn 2 đầu
            bool block_A = false;
            bool block_B = false;

            //Kiểm tra phía trên bên trái
            int left = point.X - 1;
            for (int i = point.Y - 1; i >= 0; i--)
            {
                //Nếu đánh ở cột ngoài cùng bên trái thì không kiểm tra
                if (left < 0)
                {
                    break;
                }

                if (matrix[i][left].Tag.ToString() == btn.Tag.ToString())
                {
                    countTopLeft++;
                    left--;
                }
                else if (matrix[i][left].Tag.ToString() != "0")
                {
                    block_A = true;
                    break;
                }
                else
                    break;
            }

            //Kiểm tra phía dưới bên phải
            int right = point.X + 1;
            for (int i = point.Y + 1; i < 18; i++)
            {
                //Nếu đánh ở cột ngoài cùng bên phải thì không kiểm tra
                if (right >= 20)
                {
                    break;
                }
                if (matrix[i][right].Tag.ToString() == btn.Tag.ToString())
                {
                    countBotRight++;
                    right++;
                }
                else if (matrix[i][right].Tag.ToString() != "0")
                {
                    block_B = true;
                    break;
                }
                else
                    break;
            }

            return (countTopLeft + countBotRight >= 4) && !(block_A && block_B);
        }

        //Check chéo phụ
        private bool Check_SecondaryDiagonal(Button btn)
        {
            Point point = GetPoint(btn);
            int countTopRight = 0;
            int countBotLeft = 0;

            //Biến kiểm tra chặn 2 đầu
            bool block_A = false;
            bool block_B = false;

            //Kiểm tra phía trên bên phải
            int right = point.X + 1;
            for (int i = point.Y - 1; i >= 0; i--)
            {
                //Nếu đánh ở cột ngoài cùng bên phải thì không kiểm tra
                if (right >= 20)
                {
                    break;
                }

                if (matrix[i][right].Tag.ToString() == btn.Tag.ToString())
                {
                    countTopRight++;
                    right++;
                }
                else if (matrix[i][right].Tag.ToString() != "0")
                {
                    block_A = true;
                    break;
                }
                else
                    break;
            }

            //Kiểm tra phía dưới bên phải
            int left = point.X - 1;
            for (int i = point.Y + 1; i < 18; i++)
            {
                //Nếu đánh ở cột ngoài cùng bên trái thì không kiểm tra
                if (left < 0)
                {
                    break;
                }

                if (matrix[i][left].Tag.ToString() == btn.Tag.ToString())
                {
                    countBotLeft++;
                    left--;
                }
                else if (matrix[i][left].Tag.ToString() != "0")
                {
                    block_B = true;
                    break;
                }
                else
                    break;
            }

            return (countTopRight + countBotLeft >= 4) && !(block_A && block_B);
        }
        #endregion

        #region Tìm nước đi cho Máy
        private long[] arr_ATK_Score = new long[7] { 0, 3, 24, 192, 1536, 12288, 98304 };
        private long[] arr_DEF_Score = new long[7] { 0, 1, 9, 81, 729, 6561, 59049 };

        //Khởi động bot đánh nước đi
        private void StartBot()
        {
            Point point = FindChessForBot();
            PutChess(point);
        }

        //Tìm kiếm nước đi cho bot
        private Point FindChessForBot()
        {
            Point point = new Point();
            long maxScore = 0;
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (matrix[i][j].Tag.ToString() == "0")
                    {
                        long atkScore = ATK_Score_Horizontal(j, i) + ATK_Score_Vertical(j, i) + ATK_Score_Principal(j, i) + ATK_Score_Secondary(j, i);
                        long defScore = DEF_Score_Horizontal(j, i) + DEF_Score_Vertical(j, i) + DEF_Score_Principal(j, i) + DEF_Score_Secondary(j, i);
                        long temp = atkScore > defScore ? atkScore : defScore;
                        if (maxScore < temp)
                        {
                            maxScore = temp;
                            point = new Point(j, i);
                        }
                    }
                }
            }
            return point;
        }

        //Tính điểm ATK hàng ngang
        private long ATK_Score_Horizontal(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt phải
            for (int i = 1; i < 6 && cot + i < 20; i++)
            {
                if (matrix[dong][cot + i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong][cot + i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Duyệt trái
            for (int i = 1; i < 6 && cot - i >= 0; i++)
            {
                if (matrix[dong][cot - i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong][cot - i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Nếu bị chặn 2 đầu trả về 0
            if (count_QuanDich == 2)
                return 0;

            score -= arr_DEF_Score[count_QuanDich + 1];
            score += arr_ATK_Score[count_QuanTa];

            return score;
        }

        //Tính điểm ATK hàng dọc
        private long ATK_Score_Vertical(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt từ trên xuống 
            for (int i = 1; i < 6 && dong + i < 18; i++)
            {
                if (matrix[dong + i][cot].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong + i][cot].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Duyệt từ dưới lên 
            for (int i = 1; i < 6 && dong - i >= 0; i++)
            {
                if (matrix[dong - i][cot].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong - i][cot].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Nếu bị chặn 2 đầu trả về 0
            if (count_QuanDich == 2)
                return 0;

            score -= arr_DEF_Score[count_QuanDich + 1];
            score += arr_ATK_Score[count_QuanTa];

            return score;
        }

        //Tính điểm ATK chéo chính
        private long ATK_Score_Principal(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt phải dưới
            for (int i = 1; i < 6 && dong + i < 18 && cot + i < 20; i++)
            {
                if (matrix[dong + i][cot + i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong + i][cot + i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Duyệt trái trên
            for (int i = 1; i < 6 && dong - i >= 0 && cot - i >= 0; i++)
            {
                if (matrix[dong - i][cot - i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong - i][cot - i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Nếu bị chặn 2 đầu trả về 0
            if (count_QuanDich == 2)
                return 0;

            score -= arr_DEF_Score[count_QuanDich + 1];
            score += arr_ATK_Score[count_QuanTa];

            return score;
        }

        //Tính điểm ATK chéo phụ
        private long ATK_Score_Secondary(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt trái dưới
            for (int i = 1; i < 6 && dong + i < 18 && cot - i >= 0; i++)
            {
                if (matrix[dong + i][cot - i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong + i][cot - i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Duyệt phải trên
            for (int i = 1; i < 6 && dong - i >= 0 && cot + i < 20; i++)
            {
                if (matrix[dong - i][cot + i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                }
                else if (matrix[dong - i][cot + i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                    break;
                }
                else
                    break;
            }

            //Nếu bị chặn 2 đầu trả về 0
            if (count_QuanDich == 2)
                return 0;

            score -= arr_DEF_Score[count_QuanDich + 1];
            score += arr_ATK_Score[count_QuanTa];

            return score;
        }

        //Tính điểm DEF hàng ngang
        private long DEF_Score_Horizontal(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt phải
            for (int i = 1; i < 6 && cot + i < 20; i++)
            {
                if (matrix[dong][cot + i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong][cot + i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Duyệt trái
            for (int i = 1; i < 6 && cot - i >= 0; i++)
            {
                if (matrix[dong][cot - i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong][cot - i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Nếu 2 đầu đều là quân ta thì ko cần phòng ngự
            if (count_QuanTa == 2)
                return 0;

            score += arr_DEF_Score[count_QuanDich];

            return score;
        }

        //Tính điểm DEF hàng dọc
        private long DEF_Score_Vertical(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt từ trên xuống 
            for (int i = 1; i < 6 && dong + i < 18; i++)
            {
                if (matrix[dong + i][cot].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong + i][cot].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Duyệt từ dưới lên 
            for (int i = 1; i < 6 && dong - i >= 0; i++)
            {
                if (matrix[dong - i][cot].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong - i][cot].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Nếu 2 đầu đều là quân ta thì ko cần phòng ngự
            if (count_QuanTa == 2)
                return 0;

            score += arr_DEF_Score[count_QuanDich];

            return score;
        }

        //Tính điểm DEF chéo chính
        private long DEF_Score_Principal(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt phải dưới
            for (int i = 1; i < 6 && dong + i < 18 && cot + i < 20; i++)
            {
                if (matrix[dong + i][cot + i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong + i][cot + i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Duyệt trái trên
            for (int i = 1; i < 6 && dong - i >= 0 && cot - i >= 0; i++)
            {
                if (matrix[dong - i][cot - i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong - i][cot - i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Nếu 2 đầu đều là quân ta thì ko cần phòng ngự
            if (count_QuanTa == 2)
                return 0;

            score += arr_DEF_Score[count_QuanDich];

            return score;
        }

        //Tính điểm DEF chéo phụ 
        private long DEF_Score_Secondary(int cot, int dong)
        {
            long score = 0;
            int count_QuanTa = 0;
            int count_QuanDich = 0;

            //Duyệt trái dưới
            for (int i = 1; i < 6 && dong + i < 18 && cot - i >= 0; i++)
            {
                if (matrix[dong + i][cot - i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong + i][cot - i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Duyệt phải trên
            for (int i = 1; i < 6 && dong - i >= 0 && cot + i < 20; i++)
            {
                if (matrix[dong - i][cot + i].Tag.ToString() == "1")
                {
                    count_QuanDich++;
                }
                else if (matrix[dong - i][cot + i].Tag.ToString() == "2")
                {
                    count_QuanTa++;
                    break;
                }
                else
                    break;
            }

            //Nếu 2 đầu đều là quân ta thì ko cần phòng ngự
            if (count_QuanTa == 2)
                return 0;

            score += arr_DEF_Score[count_QuanDich];

            return score;
        }

        #endregion

        #region Events
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (gameMode == 3 && played == 1)
            {
                if (!isReady && countChesss != 0)
                {
                    NotifyForm nf = new NotifyForm("If quit, you will loss!", "Notification", NotifyForm.BoxBtn.OkCancel);
                    nf.ShowDialog();
                    if (nf.isOk)
                    {
                        try
                        {
                            socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                            Listen();
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    NotifyForm nf = new NotifyForm("Do you want to quit?", "Notification", NotifyForm.BoxBtn.OkCancel);
                    nf.ShowDialog();
                    if (nf.isOk)
                    {
                        try
                        {
                            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
                            Listen();
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                played = 0;
                if (socket.isServer)
                {
                    socket.client.Close();
                    socket.server.Close();
                }
                else
                {
                    socket.client.Close();
                }
                DrawChessBoard();
            }
            btnReady.Hide();
            anotherUser = null;
            if (MyUser.user != null)
                picMyUser.Image = Image.FromFile($"Resources\\{MyUser.user.avatar}.png");
            picAnotherUser.Image = Image.FromFile("Resources\\O.png");
            rtbxCurMess.Text = string.Empty;
            pnAnotherUser.Hide();
            btnBack.Hide();
            pnMessage.Hide();
            pnPvP.Hide();
            pnChessBoard.Enabled = false;
            pnButtons.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PvP();
            picMyUser.Image = Image.FromFile("Resources\\X.png");
            picAnotherUser.Image = Image.FromFile("Resources\\O.png");
            pnChessBoard.Enabled = true;
            pnButtons.Hide();
            btnBack.Text = btnPractice.Text;
            btnBack.Show();
            pnAnotherUser.Show();
            DrawChessBoard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PvCom();
            pnChessBoard.Enabled = true;
            pnButtons.Hide();
            btnBack.Text = btnPvBot.Text;
            btnBack.Show();
            DrawChessBoard();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            if(gameMode == 1)
            {
                if (currentPlayer == 1)
                {
                    prcbPlayer1.PerformStep();
                    if (prcbPlayer1.Value >= prcbPlayer1.Maximum)
                    {
                        EndGame();
                        DrawChessBoard();
                    }
                }
                else
                {
                    prcbPlayer2.PerformStep();
                    if (prcbPlayer2.Value >= prcbPlayer2.Maximum)
                    {
                        EndGame();
                        DrawChessBoard();
                    }
                }
            }
            else if(gameMode == 3 && anotherUser!=null)
            {
                if (pnChessBoard.Enabled)
                {
                    prcbPlayer1.PerformStep();
                    if (prcbPlayer1.Value >= prcbPlayer1.Maximum)
                    {
                        EndGame();
                    }
                }
                else
                {
                    prcbPlayer2.PerformStep();
                    if (prcbPlayer2.Value >= prcbPlayer2.Maximum)
                    {
                        EndGame();
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            gameMode = 3;
            pnButtons.Hide();
            btnBack.Text = btnPvP.Text;
            btnBack.Show();
            pnAnotherUser.Show();
            pnPvP.Show();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            played = 1;
            pnMessage.Show();
            pnPvP.Hide();
            string ip = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(ip))
            {
                ip = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }

            socket.IP = ip;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnChessBoard.Enabled = true;
                socket.CreateServer();
                Listen();
            }
            else
            {
                isReady = false;
                socket.isServer = false;
                pnChessBoard.Enabled = false;
                Listen();
            }
        }
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            played = 1;
            pnMessage.Show();
            pnPvP.Hide();
            string ip = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(ip))
            {
                ip = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }

            socket.IP = ip;
            socket.isServer = true;
            pnChessBoard.Enabled = true;
            socket.CreateServer2();
            Listen();
            
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gameMode == 3 && played == 1)
            {
                if (socket.isServer)
                {
                    socket.client.Close();
                    socket.server.Close();
                }
                else
                {
                    socket.client.Close();
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(tbxMess.Text != string.Empty)
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.SEND_MESS, tbxMess.Text, new Point()));
                    Listen();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        rtbxCurMess.Text += "Me: " + tbxMess.Text + "\n";
                        tbxMess.Text = string.Empty;
                        tbxMess.VerticalScroll.Value = tbxMess.VerticalScroll.Maximum;
                    }));

                }
                catch
                {

                }
            }
        }

        private void picAnotherUser_Click(object sender, EventArgs e)
        {
            if (anotherUser != null)
            {
                FORMS.InforUserForm info = new FORMS.InforUserForm(anotherUser.userID);
                info.ShowDialog();
            }
        }

        private void btnEmotion_Click(object sender, EventArgs e)
        {
            FORMS.ChooseIconForm iconF = new FORMS.ChooseIconForm();
            iconF.ShowDialog();
            if (iconF.icon != "=icon=")
            {
                try
                {
                    picIcon1.Image = Image.FromFile($"Resources\\{iconF.icon}.png");
                    tmCD_Icon1.Start();

                    socket.Send(new SocketData((int)SocketCommand.SEND_EMOJI, iconF.icon, new Point()));
                    Listen();
                }
                catch
                {
                }
            }
        }

        private void tmCD_Icon2_Tick(object sender, EventArgs e)
        {
            picIcon2.Image = null;
            tmCD_Icon2.Stop();
        }

        private void tmCD_Icon1_Tick(object sender, EventArgs e)
        {
            picIcon1.Image = null;
            tmCD_Icon1.Stop();
        }
        private void btnReady_Click(object sender, EventArgs e)
        {
            btnReady.Hide();
            try
            {
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "new", new Point()));
                Listen();
            }
            catch
            {
            }
        }
        #endregion

        #region Functions
        private void PvP()
        {
            isReady = true;
            currentPlayer = 1;
            gameMode = 1;
        }
        private void PvCom()
        {
            isReady = true;
            currentPlayer = 1;
            gameMode = 2;
        }
        private void PvP_LAN()
        {
            isReady = true;
            currentPlayer = 1;
            gameMode = 3;
        }
        private void EndGame()
        {
            tmCoolDown.Stop();
            if (gameMode == 1)
            {
                if (currentChess.Tag.ToString() == "1")
                {
                    NotifyForm f = new NotifyForm("Player X win", "Notification", NotifyForm.BoxBtn.Ok);
                    f.ShowDialog();
                }
                else
                {
                    NotifyForm f = new NotifyForm("Player O win", "Notification", NotifyForm.BoxBtn.Ok);
                    f.ShowDialog();
                }
                DrawChessBoard();
            }
            else if (gameMode == 2)
            {
                if (currentChess.Tag.ToString() == "1")
                {
                    NotifyForm f = new NotifyForm("Player win", "Notification", NotifyForm.BoxBtn.Ok);
                    f.ShowDialog();
                }
                else
                {
                    NotifyForm f = new NotifyForm("Bot win", "Notification", NotifyForm.BoxBtn.Ok);
                    f.ShowDialog();
                }
                DrawChessBoard();
            }
            else if (gameMode == 3)
            {
                if (prcbPlayer1.Value >= prcbPlayer1.Maximum)
                {
                    myTurn = 1;
                    NotifyForm f = new NotifyForm("Time out! You lost!", "Notification", NotifyForm.BoxBtn.Ok);
                    f.ShowDialog();
                    btnReady.Show();
                }
                else if (prcbPlayer2.Value >= prcbPlayer2.Maximum)
                {
                    try
                    {
                        DTBase.AddMatch(anotherUser.userID);
                    }
                    catch
                    {
                    }
                    myTurn = 2;
                    NotifyForm f = new NotifyForm("Time out! You win!", "Notification", NotifyForm.BoxBtn.Ok);
                    f.ShowDialog();
                    btnReady.Show();
                }
                pnChessBoard.Enabled = false;
            }
        }
        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch
                {

                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }
        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.SEND_USERINFO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        anotherUser = new User();
                        int id = Convert.ToInt32(data.Message);
                        anotherUser = DTBase.GetUserUID(id);
                        picAnotherUser.Image = Image.FromFile($"Resources\\{anotherUser.avatar}.png");
                        picAnotherUser.Tag = anotherUser.userID;
                    }));
                    break;

                case (int)SocketCommand.SEND_MESS:
                    rtbxCurMess.Text += $"{anotherUser.userName}: " + data.Message + "\n";
                    break;

                case (int)SocketCommand.SEND_EMOJI:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        picIcon2.Image = Image.FromFile($"Resources\\{data.Message}.png");
                        tmCD_Icon2.Start();
                    }));
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if(data.Message == "new")
                        {
                            NotifyForm nf = new NotifyForm("Play new game?", "Notification", NotifyForm.BoxBtn.OkCancel);
                            nf.ShowDialog();
                            if (nf.isOk)
                            {
                                try
                                {
                                    socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "yes", new Point()));
                                    Listen();
                                    if (myTurn == 1)
                                        pnChessBoard.Enabled = true;
                                    else
                                        pnChessBoard.Enabled = false;
                                    DrawChessBoard();
                                }
                                catch
                                {
                                }
                            }
                            else
                            {
                                try
                                {
                                    socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "no", new Point()));
                                    Listen();
                                    if (socket.isServer)
                                    {
                                        socket.client.Close();
                                        socket.server.Close();
                                    }
                                    else
                                    {
                                        socket.client.Close();
                                    }
                                    tmCoolDown.Stop();
                                    anotherUser = null;
                                    if (MyUser.user != null)
                                        picMyUser.Image = Image.FromFile($"Resources\\{MyUser.user.avatar}.png");
                                    picAnotherUser.Image = Image.FromFile("Resources\\O.png");
                                    pnAnotherUser.Hide();
                                    pnMessage.Hide();
                                    btnBack.Hide();
                                    pnChessBoard.Enabled = false;
                                    pnButtons.Show();
                                    DrawChessBoard();
                                }
                                catch
                                {
                                }
                            }
                        }
                        else if(data.Message == "yes")
                        {
                            if (myTurn == 1)
                                pnChessBoard.Enabled = true;
                            else
                                pnChessBoard.Enabled = false;
                            DrawChessBoard();
                        }
                        else
                        {
                            NotifyForm nf = new NotifyForm("The player has exited!", "Notification", NotifyForm.BoxBtn.OkCancel);
                            nf.ShowDialog();
                            if (socket.isServer)
                            {
                                socket.client.Close();
                                socket.server.Close();
                            }
                            else
                            {
                                socket.client.Close();
                            }
                            tmCoolDown.Stop();
                            anotherUser = null;
                            if (MyUser.user != null)
                                picMyUser.Image = Image.FromFile($"Resources\\{MyUser.user.avatar}.png");
                            picAnotherUser.Image = Image.FromFile("Resources\\O.png");
                            pnAnotherUser.Hide();
                            pnMessage.Hide();
                            btnBack.Hide();
                            pnChessBoard.Enabled = false;
                            pnButtons.Show();
                            DrawChessBoard();
                        }
                    }));
                    break;

                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pnChessBoard.Enabled = true;
                        OrtherBtnClick(data.Point);
                    }));
                    break;

                case (int)SocketCommand.END_GAME:
                    if (gameMode == 3)
                    {
                        if (socket.isServer)
                        {
                            socket.client.Close();
                            socket.server.Close();
                        }
                        else
                        {
                            socket.client.Close();
                        }
                    }
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NotifyForm nf = new NotifyForm("The player has exited!", "Notification", NotifyForm.BoxBtn.Ok);
                        nf.ShowDialog();
                        tmCoolDown.Stop();
                        anotherUser = null;
                        if (MyUser.user != null)
                            picMyUser.Image = Image.FromFile($"Resources\\{MyUser.user.avatar}.png");
                        picAnotherUser.Image = Image.FromFile("Resources\\O.png");
                        pnAnotherUser.Hide();
                        pnMessage.Hide();
                        btnBack.Hide();
                        pnChessBoard.Enabled = false;
                        pnButtons.Show();
                        DrawChessBoard();
                    }));
                    break;

                case (int)SocketCommand.QUIT:
                    if (gameMode == 3)
                    {
                        if (socket.isServer)
                        {
                            socket.client.Close();
                            socket.server.Close();
                        }
                        else
                        {
                            socket.client.Close();
                        }
                    }
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NotifyForm nf = new NotifyForm("The player has exited. You win!", "Notification", NotifyForm.BoxBtn.Ok);
                        DTBase.AddMatch(anotherUser.userID);
                        nf.ShowDialog();
                        tmCoolDown.Stop();
                        anotherUser = null;
                        if (MyUser.user != null)
                            picMyUser.Image = Image.FromFile($"Resources\\{MyUser.user.avatar}.png");
                        picAnotherUser.Image = Image.FromFile("Resources\\O.png");
                        pnAnotherUser.Hide();
                        pnMessage.Hide();
                        btnBack.Hide();
                        pnChessBoard.Enabled = false;
                        pnButtons.Show();
                        DrawChessBoard();
                    }));
                    break;

                default:
                    break;
            }

            Listen();
        }
        #endregion
    }
}
