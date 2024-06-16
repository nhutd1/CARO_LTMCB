using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace CARO_LTMCB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lbWrong.Hide();
            lbFill.Hide();
        }

        #region Buttons event
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            SignUpForm signf = new SignUpForm();
            signf.Location = new Point(this.Location.X, this.Location.Y);
            signf.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            try
            {
                Application.Exit();
            }
            catch
            {
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

        private void btnForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            ForgotPasss fgf = new ForgotPasss();
            fgf.Location = new Point(this.Location.X, this.Location.Y);
            fgf.Show();
            this.Hide();
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            if (iconPictureBox5.IconChar == IconChar.Eye)
            {
                iconPictureBox5.IconChar = IconChar.EyeSlash;
                tbxPass.PasswordChar = '\0';
            }
            else
            {
                iconPictureBox5.IconChar = IconChar.Eye;
                tbxPass.PasswordChar = '*';
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if(tbxUsername.Text == "username")
            {
                tbxUsername.Text = "";
                tbxUsername.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
                tbxUsername.ForeColor = Color.Black;
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
            {
                tbxUsername.Text = "username";
                tbxUsername.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                tbxUsername.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            if (tbxPass.Text == "password")
            {
                tbxPass.Text = "";
                tbxPass.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
                tbxPass.ForeColor = Color.Black;
            }
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (tbxPass.Text == "")
            {
                tbxPass.Text = "password";
                tbxPass.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                tbxPass.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }
        #endregion

        #region Kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (tbxUsername.Text != "username" && tbxPass.Text != "password")
            {
                try
                {
                    if (DTBase.CheckLogin(tbxUsername.Text, tbxPass.Text))
                    {
                        DTBase.GetUserUName(tbxUsername.Text);
                        DTBase.UserOnline();
                        MenuForm mnf = new MenuForm();
                        mnf.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbFill.Hide();
                        lbWrong.Show();
                    }
                }
                catch
                {
                    NotifyForm nf = new NotifyForm("Error connect to Database", "Error Message", NotifyForm.BoxBtn.Error);
                    nf.ShowDialog();
                }
            }
            else
            {
                lbWrong.Hide();
                lbFill.Show();
            }
        }
    }
}
