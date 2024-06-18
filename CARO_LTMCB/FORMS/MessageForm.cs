using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Threading;
using System.Security.Permissions;

namespace CARO_LTMCB.FORMS
{
    public partial class MessageForm : Form
    {
        Guna2Button btnCurrentFriend;
        Guna2Button btnCurrentRequest;
        public MessageForm()
        {
            InitializeComponent();
            picOnline.Hide();
        }

        #region TextBox Change
        private void tbxSearchFriend_Enter(object sender, EventArgs e)
        {
            if (tbxFindFriend.Text == "Find Friend")
            {
                tbxFindFriend.Text = "";
            }
        }

        private void tbxSearchFriend_Leave(object sender, EventArgs e)
        {
            if (tbxFindFriend.Text == "")
            {
                tbxFindFriend.Text = "Find Friend";
            }
        }

        private void tbxFindUser_Enter(object sender, EventArgs e)
        {
            if (tbxFindUser.Text == "Find Another User")
            {
                tbxFindUser.Text = "";
            }
        }

        private void tbxFindUser_Leave(object sender, EventArgs e)
        {
            if (tbxFindUser.Text == "")
            {
                tbxFindUser.Text = "Find Another User";
            }
        }
        private void tbxFindFriend_TextChanged(object sender, EventArgs e)
        {
            if (menuButtonFriend != null)
            {
                foreach (Guna2Button btn in menuButtonFriend)
                {
                    if (btn.Text.ToLower().Contains(tbxFindFriend.Text.ToLower()) || tbxFindFriend.Text == "Find Friend")
                    {
                        btn.Show();
                    }
                    else
                    {
                        btn.Hide();
                        continue;
                    }
                }
            }
        }
        private void tbxFindUser_TextChanged(object sender, EventArgs e)
        {
            if (menuButtonNotFriend != null)
            {
                foreach (Guna2Button btn in menuButtonNotFriend)
                {
                    if (btn.Text.ToLower().Contains(tbxFindUser.Text.ToLower()) && tbxFindUser.Text != "")
                    {
                        btn.Show();
                    }
                    else
                    {
                        btn.Hide();
                        continue;
                    }
                }
            }
        }
        #endregion

        #region Load danh sách
        private IEnumerable<Guna2Button> menuButtonFriend;
        private IEnumerable<Guna2Button> menuButtonNotFriend;
        Thread friend;
        Thread notFriend;
        Thread requests;
        Thread threadLoadingMess;

        User user;
        private void MessageForm_Load(object sender, EventArgs e)
        {
            if (MyUser.user != null)
            {
                user = MyUser.user;
                friend = new Thread(() =>
                {
                    LoadFriend();
                });
                notFriend = new Thread(() =>
                {
                    LoadNotFriend();
                });
                requests = new Thread(() =>
                {
                    LoadRequests();
                });
                threadLoadingMess = new Thread(() =>
                {
                    LoadingMessage();
                });
                friend.IsBackground = true;
                notFriend.IsBackground = true;
                requests.IsBackground = true;
                threadLoadingMess.IsBackground = true;
                friend.Start();
                notFriend.Start();
                requests.Start();
                threadLoadingMess.Start();

                //timmerLoadTN.Start();
            }
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void KillTheThread()
        {
            friend.Abort();
            notFriend.Abort();
            requests.Abort();
            threadLoadingMess.Abort();
        }
        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user != null)
            {
                KillTheThread();
            }
        }
        private void LoadFriend()
        {
            List<int> listFriend = new List<int>();
            try
            {
                listFriend = DTBase.ListFriends();
                foreach (var item in listFriend)
                {
                    User friend = DTBase.GetUserUID(item);
                    Guna2Button btn = new Guna2Button()
                    {
                        Tag = friend.userID,
                        Image = Image.FromFile($"Resources\\{friend.avatar}.png"),
                        ImageAlign = HorizontalAlignment.Left,
                        ImageOffset = new Point(10, 0),
                        ImageSize = new Size(50, 50),
                        BorderColor = Color.LightCyan,
                        BorderThickness = 3,
                        FillColor = Color.FromArgb(255, 128, 128),
                        Dock = DockStyle.Top,
                        ForeColor = Color.White,
                        Font = new Font("Cooper Black", 12),
                        Size = new Size(230, 70),
                        Text = friend.userName.ToString(),
                        TextAlign = HorizontalAlignment.Left,
                        TextOffset = new Point(20, 0),
                        ContextMenuStrip = contextmnFriend,
                    };
                    btn.MouseDown += Btn_MouseDown;
                    pnFriend.Invoke((MethodInvoker)delegate {
                        pnFriend.Controls.Add(btn);
                    });
                }
                menuButtonFriend = pnFriend.Controls.OfType<Guna2Button>();
            }
            catch
            {

            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btnCurrentFriend = btn;
            if (e.Button == MouseButtons.Left)
            {
                User friend = new User();
                try
                {
                    friend = DTBase.GetUserUID(Convert.ToInt32(btn.Tag));
                    if(friend.isOnline == 1)
                    {
                        picOnline.IconColor = Color.FromArgb(32, 178, 170);
                    }
                    else
                    {
                        picOnline.IconColor = Color.FromArgb(180, 180, 180);
                    }
                }
                catch
                {

                }
                picOnline.Show();
                pnShowMess.Tag = btn.Tag;
                lbUserName.Text = btn.Text;
                lbUserName.ForeColor = Color.FromArgb(255, 128, 128);
                lbMessage.Hide();
                picUserAvatar.Image = btn.Image;
                curentTinNhan = null;
                LoadpnShowMess();
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextmnFriend.Tag = btn.Tag;
                contextmnFriend.Show(MousePosition);
            }
        }

        private void LoadNotFriend()
        {
            List<int> listNotFriend = new List<int>();
            try
            {
                listNotFriend = DTBase.ListNotFriends();
                foreach (var item in listNotFriend)
                {
                    User nfriend = DTBase.GetUserUID(item);
                    Guna2Button btnNotFriend = new Guna2Button()
                    {
                        Tag = nfriend.userID,
                        Image = Image.FromFile($"Resources\\{nfriend.avatar}.png"),
                        ImageAlign = HorizontalAlignment.Left,
                        ImageOffset = new Point(10, 0),
                        ImageSize = new Size(50, 50),
                        BorderColor = Color.LightCyan,
                        BorderThickness = 3,
                        FillColor = Color.FromArgb(255, 128, 128),
                        Dock = DockStyle.Top,
                        ForeColor = Color.White,
                        Font = new Font("Cooper Black", 12),
                        Size = new Size(230, 70),
                        Text = nfriend.userName.ToString(),
                        TextAlign = HorizontalAlignment.Left,
                        TextOffset = new Point(20, 0),
                        ContextMenuStrip = contextmnNotFriend,
                    };
                    btnNotFriend.MouseDown += BtnNotFriend_MouseDown;
                    pnNotFriend.Invoke((MethodInvoker)delegate {
                        pnNotFriend.Controls.Add(btnNotFriend);
                    });
                    btnNotFriend.Invoke((MethodInvoker)delegate
                    {
                        btnNotFriend.Hide();
                    });
                }
                menuButtonNotFriend = pnNotFriend.Controls.OfType<Guna2Button>();
            }
            catch
            {

            }
        }
        private void BtnNotFriend_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (e.Button == MouseButtons.Right)
            {
                contextmnNotFriend.Tag = btn.Tag;
                contextmnNotFriend.Show(MousePosition);
            }
        }
        private void LoadRequests()
        {
            try
            {
                List<int> listRequests = new List<int>();
                listRequests = DTBase.ListRequests();
                foreach (var item in listRequests)
                {
                    User request = DTBase.GetUserUID(item);
                    Guna2Button btnRequest = new Guna2Button()
                    {
                        Tag = request.userID,
                        Image = Image.FromFile($"Resources\\{request.avatar}.png"),
                        ImageAlign = HorizontalAlignment.Left,
                        ImageOffset = new Point(10, 0),
                        ImageSize = new Size(50, 50),
                        BorderColor = Color.LightCyan,
                        BorderThickness = 3,
                        FillColor = Color.FromArgb(255, 128, 128),
                        Dock = DockStyle.Top,
                        ForeColor = Color.White,
                        Font = new Font("Cooper Black", 12),
                        Size = new Size(230, 70),
                        Text = request.userName.ToString(),
                        TextAlign = HorizontalAlignment.Left,
                        TextOffset = new Point(20, 0),
                        ContextMenuStrip = contextmnRequests,
                    };
                    btnRequest.MouseDown += BtnRequest_MouseDown;
                    pnFriendRequests.Invoke((MethodInvoker)delegate {
                        pnFriendRequests.Controls.Add(btnRequest);
                    });
                }
            }
            catch
            {

            }
        }
        private void BtnRequest_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btnCurrentRequest = btn;
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    NotifyForm nf = new NotifyForm("Acept this friend request?", "Notification", NotifyForm.BoxBtn.YesNo);
                    nf.ShowDialog();
                    if (nf.isYes)
                    {
                        DTBase.AcceptFriendRequest(Convert.ToInt32(btn.Tag));
                        pnFriendRequests.Controls.Remove(btnCurrentRequest);
                    }
                    else if (nf.isNo)
                    {
                        DTBase.RejectFriendRequest(Convert.ToInt32(btn.Tag));
                        pnFriendRequests.Controls.Remove(btnCurrentRequest);
                    }
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextmnRequests.Tag = btn.Tag;
                contextmnRequests.Show(MousePosition);
            }
        }
        #endregion

        #region Context menustrip button
        private void btnUnfriend_Click(object sender, EventArgs e)
        {

        }

        private void btnShowInfor_Friend_Click(object sender, EventArgs e)
        {
            InforUserForm inforForm = new InforUserForm(Convert.ToInt32(contextmnFriend.Tag));
            inforForm.ShowDialog();
        }

        private void btnShowInfor_NotFriend_Click(object sender, EventArgs e)
        {
            InforUserForm inforForm = new InforUserForm(Convert.ToInt32(contextmnNotFriend.Tag));
            inforForm.ShowDialog();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {

            try
            {
                DTBase.SendFriendRequest(Convert.ToInt32(contextmnRequests.Tag));
            }
            catch
            {
                NotifyForm nf = new NotifyForm("Error connect to Database", "Error", NotifyForm.BoxBtn.Error);
                nf.ShowDialog();
            }
        }

        private void btnShowInfor_Requests_Click(object sender, EventArgs e)
        {
            InforUserForm inforForm = new InforUserForm(Convert.ToInt32(contextmnRequests.Tag));
            inforForm.ShowDialog();
        }
        #endregion

        #region Hàm gửi nhận tin nhắn
        TinNhan curentTinNhan;
        int slTinNhan;
        private void AddInMess(string mess, DateTime time)
        {
            TinNhan tn = new TinNhan(mess, time, mstype.In);

            if (curentTinNhan == null)
            {
                tn.Location = new Point(15, 10);
            }
            else
            {
                tn.Location = new Point(15, curentTinNhan.Bottom + 10);
            }
            pnShowMess.Controls.Add(tn);
            pnShowMess.VerticalScroll.Value = pnShowMess.VerticalScroll.Maximum;

            curentTinNhan = tn;
        }

        private void AddOutMess(string mess, DateTime time)
        {
            TinNhan tn = new TinNhan(mess, time, mstype.Out);

            if (curentTinNhan == null)
            {
                tn.Location = new Point(120, 10);
            }
            else
            {
                tn.Location = new Point(120, curentTinNhan.Bottom + 10);
            }
            pnShowMess.Controls.Add(tn);
            pnShowMess.VerticalScroll.Value = pnShowMess.VerticalScroll.Maximum;

            curentTinNhan = tn;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (pnShowMess.Tag != null)
            {
                try
                {
                    int idReceive = Convert.ToInt32(pnShowMess.Tag);
                    if (tbxMess.Text != string.Empty)
                    {
                        DTBase.SendMessTo(idReceive, tbxMess.Text);
                        tbxMess.Text = string.Empty;
                    }
                }
                catch
                {
                    NotifyForm nf = new NotifyForm("Error connect to Database", "Error", NotifyForm.BoxBtn.Error);
                    nf.ShowDialog();
                }
            }
        }
        private void tbxMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pnShowMess.Tag != null)
                {
                    try
                    {
                        int idReceive = Convert.ToInt32(pnShowMess.Tag);
                        if (tbxMess.Text != string.Empty)
                        {
                            DTBase.SendMessTo(idReceive, tbxMess.Text);
                            tbxMess.Text = string.Empty;
                        }
                    }
                    catch
                    {
                        NotifyForm nf = new NotifyForm("Error connect to Database", "Error", NotifyForm.BoxBtn.Error);
                        nf.ShowDialog();
                    }
                }
            }
        }

        private void LoadpnShowMess()
        {
            pnShowMess.Controls.Clear();
            List<Message> list = new List<Message>();
            try
            {
                int idUser = Convert.ToInt32(pnShowMess.Tag);
                list = DTBase.ListMessWith(idUser);
                slTinNhan = list.Count;
                foreach (var item in list)
                {
                    if (item.idSend == user.userID)
                    {
                        AddOutMess(item.content, item.ngayMess);
                    }
                    else
                    {
                        AddInMess(item.content, item.ngayMess);
                    }
                }
            }
            catch
            {
                NotifyForm nf = new NotifyForm("Error connect to Database", "Error", NotifyForm.BoxBtn.Error);
                nf.ShowDialog();
            }
        }
        private void timmerLoadTN_Tick(object sender, EventArgs e)
        {
            if (pnShowMess.Tag != null)
            {
                int idUser = Convert.ToInt32(pnShowMess.Tag);
                try
                {
                    List<Message> list = new List<Message>();
                    list = DTBase.ListMessWith(idUser);
                    if (slTinNhan != list.Count)
                    {
                        for (int i = slTinNhan; i < list.Count; i++)
                        {
                            if (list[i].idSend == user.userID)
                            {
                                AddOutMess(list[i].content, list[i].ngayMess);
                            }
                            else
                            {
                                AddInMess(list[i].content, list[i].ngayMess);
                            }
                            slTinNhan++;
                        }
                    }
                }
                catch
                {
                    NotifyForm nf = new NotifyForm("Error connect to Database", "Error", NotifyForm.BoxBtn.Error);
                    nf.ShowDialog();
                }
            }
        }
        private void LoadingMessage()
        {
            while (true)
            {
                if (pnShowMess.Tag != null)
                {
                    int idUser = Convert.ToInt32(pnShowMess.Tag);
                    try
                    {
                        List<Message> list = new List<Message>();
                        list = DTBase.ListMessWith(idUser);
                        if (slTinNhan != list.Count)
                        {
                            for (int i = slTinNhan; i < list.Count; i++)
                            {
                                if (list[i].idSend == user.userID)
                                {
                                    this.Invoke((MethodInvoker)(() =>
                                    {
                                        AddOutMess(list[i].content, list[i].ngayMess);
                                    }));
                                }
                                else
                                {
                                    AddInMess(list[i].content, list[i].ngayMess);
                                    this.Invoke((MethodInvoker)(() =>
                                    {
                                        AddInMess(list[i].content, list[i].ngayMess);
                                    }));
                                }
                                slTinNhan++;
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        
        #endregion
        private void btnEmotion_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (pnShowMess.Tag != null)
            {
                FORMS.ChooseIconForm avtf = new FORMS.ChooseIconForm();
                avtf.ShowDialog();
                if (avtf.icon != "=icon=")
                {
                    try
                    {
                        int idReceive = Convert.ToInt32(pnShowMess.Tag);
                        DTBase.SendMessTo(idReceive, avtf.icon);
                    }
                    catch
                    {
                        NotifyForm nf = new NotifyForm("Error connect to Database", "Error", NotifyForm.BoxBtn.Error);
                        nf.ShowDialog();
                    }
                }
            }
            
        }
    }
}
