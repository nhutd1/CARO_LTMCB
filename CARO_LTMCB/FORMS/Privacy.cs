using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CARO_LTMCB.FORMS
{
    public partial class Privacy : Form
    {
        public Privacy()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if(tbxPass.Text == "password" || tbxNewPass.Text == "password" || tbxConfirmPass.Text == "password")
            {
                NotifyForm nf = new NotifyForm("Fill all the blank!", "Notification", NotifyForm.BoxBtn.Ok);
                nf.ShowDialog();
                return;
            }
            if (MyUser.user != null)
            {

                if (tbxPass.Text == MyUser.user.userPass)
                {
                    if (tbxNewPass.Text == tbxConfirmPass.Text)
                    {
                        DTBase.ChangePass(tbxNewPass.Text);
                        NotifyForm nf = new NotifyForm("Changed successfully!", "Notification", NotifyForm.BoxBtn.Ok);
                        nf.ShowDialog();
                    }
                    else
                    {
                        NotifyForm nf = new NotifyForm("Passwords are not match!", "Notification", NotifyForm.BoxBtn.Error);
                        nf.ShowDialog();
                    }
                }
                else
                {
                    NotifyForm nf = new NotifyForm("Incorrect password!", "Notification", NotifyForm.BoxBtn.Error);
                    nf.ShowDialog();
                }
            }
        }
        private void HideShowPass(TextBox textBox, IconPictureBox iconPictureBox)
        {
            if (iconPictureBox.IconChar == IconChar.Eye)
            {
                iconPictureBox.IconChar = IconChar.EyeSlash;
                textBox.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                iconPictureBox.IconChar = IconChar.Eye;
                textBox.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
        private void SetDefaultText(TextBox textBox, string defaultText)
        {
            if (textBox.Text == "")
            {
                textBox.Text = defaultText;
                textBox.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                textBox.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void SetEnteredText(TextBox textBox, string enteredText)
        {
            if (textBox.Text == enteredText)
            {
                textBox.Text = "";
                textBox.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
                textBox.ForeColor = Color.Black;
            }
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            HideShowPass(tbxPass, iconPictureBox4);
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            HideShowPass(tbxNewPass, iconPictureBox5);
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            HideShowPass(tbxConfirmPass, iconPictureBox6);
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            SetEnteredText(tbxPass, "password");
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            SetDefaultText(tbxPass, "password");
        }

        private void tbxNewPass_Enter(object sender, EventArgs e)
        {
            SetEnteredText(tbxNewPass, "password");
        }

        private void tbxNewPass_Leave(object sender, EventArgs e)
        {
            SetDefaultText(tbxNewPass, "password");
        }

        private void tbxConfirmPass_Enter(object sender, EventArgs e)
        {
            SetEnteredText(tbxConfirmPass, "password");
        }

        private void tbxConfirmPass_Leave(object sender, EventArgs e)
        {
            SetDefaultText(tbxConfirmPass, "password");
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
