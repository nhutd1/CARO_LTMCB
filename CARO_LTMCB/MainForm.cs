using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CARO_LTMCB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            currentBtn = btnHome;
            leftPannelBtn = new Panel();
            leftPannelBtn.Size = new Size(15, 80);
            leftPannelBtn.BackColor = Color.FromArgb(255, 128, 128);
            leftPannelBtn.Location = new Point(0, btnHome.Location.Y);
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            pnMenu.Controls.Add(leftPannelBtn);
            leftPannelBtn.BringToFront();

            OpenForm(new FORMS.HomeForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        #region Button event
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            NotifyForm nf = new NotifyForm("Are you sure you want to log out?", "Notification", NotifyForm.BoxBtn.OkCancel);
            nf.ShowDialog();
            if (nf.isOk)
            {
                AudioPlayer.StopAudio();
                if (MyUser.user != null)
                {
                    try
                    {
                        DTBase.UserOffline();
                    }
                    catch
                    {

                    }
                }
                LoginForm lgf = new LoginForm();
                lgf.Show();
                this.Hide();
            }
        }
        private void btnMinisize_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            NotifyForm nf = new NotifyForm("Are you sure you want to log out?", "Notification", NotifyForm.BoxBtn.OkCancel);
            nf.ShowDialog();
            if (nf.isOk)
            {
                AudioPlayer.StopAudio();
                if (MyUser.user != null)
                {
                    try
                    {
                        DTBase.UserOffline();
                    }
                    catch
                    {

                    }
                }
                LoginForm lgf = new LoginForm();
                lgf.Show();
                this.Hide();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                ChangeBtn(sender);
                OpenForm(new FORMS.HomeForm());
            }
        }
        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                ChangeBtn(sender);
                FORMS.MessageForm mf = new FORMS.MessageForm();
                OpenForm(mf);
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                ChangeBtn(sender);
                FORMS.ProfileForm pf = new FORMS.ProfileForm();
                OpenForm(pf);
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                ChangeBtn(sender);
                OpenForm(new FORMS.SettingForm());
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                ChangeBtn(sender);
                OpenForm(new FORMS.HelpForm());
            }
        }
        #endregion

        #region Kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private IconButton currentBtn;
        private Panel leftPannelBtn;
        private void ChangeBtn(object senderbtn)
        {
            if (senderbtn != null)
            {
                RemoveChangeBtn();
                currentBtn = senderbtn as IconButton;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftPannelBtn.Location = new Point(0, currentBtn.Location.Y);
                leftPannelBtn.Visible = true;
                leftPannelBtn.BringToFront();

                picIconForm.IconChar = currentBtn.IconChar;
                lbNameForm.Text = currentBtn.Text;
            }
        }
        private void RemoveChangeBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private Form currentForm;
        private void OpenForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
