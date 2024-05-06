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
        User user;
        
        Guna2Button btnCurrentFriend;
        Guna2Button btnCurrentRequest;
        public MessageForm()
        {
            InitializeComponent();
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
        private void MessageForm_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                user = new User(this.Tag.ToString());
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
                friend.Start();
                notFriend.Start();
                requests.Start();

                timmerLoadTN.Start();
            }
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void KillTheThread()
        {
            friend.Abort();
            notFriend.Abort();
            requests.Abort();
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
            user = new User(this.Tag.ToString());
            foreach (var item in user.ListFriend)
            {
                int id = 0;
                User friend = new User(item, id);
                Guna2Button btn = new Guna2Button()
                {
                    Tag = friend.UserID.ToString(),
                    Image = Image.FromFile($"Resources\\{friend.Avatar}.png"),
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
                    Text = friend.UserName.ToString(),
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

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btnCurrentFriend = btn;
            if (e.Button == MouseButtons.Left)
            {
                pnShowMess.Tag = btn.Tag;
                lbUserName.Text = btn.Text;
                lbUserName.ForeColor = Color.FromArgb(255, 128, 128);
                lbMessage.Hide();
                picUserAvatar.Image = btn.Image;
                curentTinNhan = null;
                LoadpnShowMess();
            }
            else if(e.Button == MouseButtons.Right)
            {
                contextmnFriend.Tag = btn.Tag;
                contextmnFriend.Show(MousePosition);
            }
        }

        private void LoadNotFriend()
        {
            user = new User(this.Tag.ToString());
            foreach (var item in user.ListNotFriend)
            {
                int id = 0;
                User friend = new User(item, id);
                Guna2Button btnNotFriend = new Guna2Button()
                {
                    Tag = friend.UserID.ToString(),
                    Image = Image.FromFile($"Resources\\{friend.Avatar}.png"),
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
                    Text = friend.UserName.ToString(),
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
            user = new User(this.Tag.ToString());
            foreach (var item in user.ListRequest)
            {
                int id = 0;
                User friend = new User(item, id);
                Guna2Button btnRequest = new Guna2Button()
                {
                    Tag = friend.UserID.ToString(),
                    Image = Image.FromFile($"Resources\\{friend.Avatar}.png"),
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
                    Text = friend.UserName.ToString(),
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

        private void BtnRequest_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btnCurrentRequest = btn;
            if (e.Button == MouseButtons.Left)
            {
                DialogResult result = MessageBox.Show("Acept this friend request?", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    user.AceptFriendRequest(btn.Tag.ToString());
                    pnFriendRequests.Controls.Remove(btnCurrentRequest);
                }
                else if(result == DialogResult.No)
                {
                    user.NoAceptFriendRequest(btn.Tag.ToString());
                    pnFriendRequests.Controls.Remove(btnCurrentRequest);
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
            user.UnFriend(contextmnFriend.Tag.ToString());
            pnFriend.Controls.Remove(btnCurrentFriend);
            
        }

        private void btnShowInfor_Friend_Click(object sender, EventArgs e)
        {
            InforUserForm inforForm = new InforUserForm() { Tag = contextmnFriend.Tag };
            inforForm.ShowDialog();
        }

        private void btnShowInfor_NotFriend_Click(object sender, EventArgs e)
        {
            InforUserForm inforForm = new InforUserForm() { Tag = contextmnNotFriend.Tag };
            inforForm.ShowDialog();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            user.FriendRequest(contextmnNotFriend.Tag.ToString());
        }

        private void btnShowInfor_Requests_Click(object sender, EventArgs e)
        {
            InforUserForm inforForm = new InforUserForm() { Tag = contextmnRequests.Tag };
            inforForm.ShowDialog();
        }
        #endregion

        #region Hàm gửi nhận tin nhắn
        
        TinNhan curentTinNhan;
        int slTinNhan;
        private void AddInMess(string mess, string time)
        {
            TinNhan tn = new TinNhan(mess, time, mstype.In);
            
            if(curentTinNhan == null)
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

        private void AddOutMess(string mess, string time)
        {
            TinNhan tn = new TinNhan(mess, time, mstype.Out);

            if(curentTinNhan == null)
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
                if (tbxMess.Text != string.Empty)
                {
                    user.SendTo(pnShowMess.Tag.ToString(), tbxMess.Text);

                    tbxMess.Text = string.Empty;
                }
            }
        }
        private void tbxMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pnShowMess.Tag != null)
                {
                    if (tbxMess.Text != string.Empty)
                    {
                        user.SendTo(pnShowMess.Tag.ToString(), tbxMess.Text);

                        tbxMess.Text = string.Empty;
                    }
                }
            }
        }

        private void LoadpnShowMess()
        {
            pnShowMess.Controls.Clear();

            List<Message> list = user.GetMess(pnShowMess.Tag.ToString());
            slTinNhan = list.Count;
            foreach(var item in list)
            {
                if(item.IdSend == user.UserID)
                {
                    AddOutMess(item.Content, item.NgayMess);
                }
                else
                {
                    AddInMess(item.Content, item.NgayMess);
                }
            }
        }
        #endregion

        private void timmerLoadTN_Tick(object sender, EventArgs e)
        {
            if (pnShowMess.Tag != null)
            {
                List<Message> list = user.GetMess(pnShowMess.Tag.ToString());
                list = user.GetMess(pnShowMess.Tag.ToString());
                if (slTinNhan != list.Count)
                {
                    for (int i = slTinNhan; i < list.Count; i++)
                    {
                        if (list[i].IdSend == user.UserID)
                        {
                            AddOutMess(list[i].Content, list[i].NgayMess);
                        }
                        else
                        {
                            AddInMess(list[i].Content, list[i].NgayMess);
                        }
                        slTinNhan++;
                    }
                }
            }
        }

        private void btnEmotion_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
        }
    }
}
