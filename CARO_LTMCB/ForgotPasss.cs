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
using System.Net;
using System.Net.Mail;


namespace CARO_LTMCB
{
    public partial class ForgotPasss : Form
    {
        public ForgotPasss()
        {
            InitializeComponent();
            lbFill1.Hide();
            lbFill2.Hide();
            lbWrong1.Hide();
            lbWrong2.Hide();
            lbConfirm.Hide();
            lbEnter.Hide();
        }
        #region Buttons event
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            Application.Exit();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            if (iconPictureBox5.IconChar == IconChar.Eye)
            {
                iconPictureBox5.IconChar = IconChar.EyeSlash;
                tbxNewpass.PasswordChar = '\0';
            }
            else
            {
                iconPictureBox5.IconChar = IconChar.Eye;
                tbxNewpass.PasswordChar = '*';
            }
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            if (iconPictureBox6.IconChar == IconChar.Eye)
            {
                iconPictureBox6.IconChar = IconChar.EyeSlash;
                tbxConfirmpass.PasswordChar = '\0';
            }
            else
            {
                iconPictureBox6.IconChar = IconChar.Eye;
                tbxConfirmpass.PasswordChar = '*';
            }
        }

        private void tbxMail_Enter(object sender, EventArgs e)
        {
            if (tbxMail.Text == "example@gmail.com")
            {
                tbxMail.Text = "";
                tbxMail.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
                tbxMail.ForeColor = Color.Black;
            }
        }

        private void tbxMail_Leave(object sender, EventArgs e)
        {
            if (tbxMail.Text == "")
            {
                tbxMail.Text = "example@gmail.com";
                tbxMail.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                tbxMail.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "username")
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

        private void btnForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            LoginForm lgf = new LoginForm();
            lgf.Show();
            lgf.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
        #endregion

        #region Kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Gửi code qua mail người dùng
        string randomcode;
        private void btnGetcode_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (tbxMail.Text != "example@gmail.com" && tbxUsername.Text != "username")
            {
                try
                {
                    if (DTBase.CheckUNameUMail(tbxUsername.Text, tbxMail.Text))
                    {
                        string from, pass, messageBody, to;
                        Random rand = new Random();
                        randomcode = (rand.Next(999999)).ToString();

                        MailMessage message = new MailMessage();

                        to = tbxMail.Text;
                        from = "carogameserver@gmail.com";
                        pass = "iotb mxrh byqb xizh";
                        messageBody = "Your code is: " + randomcode;
                        try
                        {
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messageBody;
                            message.Subject = "Code Verification";

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);

                            try
                            {
                                smtp.Send(message);
                                MessageBox.Show("Code send successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnConfirmcode.Enabled = true;
                                lbFill1.Hide();
                                lbFill2.Hide();
                                lbWrong1.Hide();
                                lbWrong2.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error to send code: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        lbFill1.Hide();
                        lbFill2.Hide();
                        lbWrong1.Show();
                        lbWrong2.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbWrong1.Hide();
                lbWrong2.Hide();
                lbFill1.Show();
                lbFill2.Show();
            }
        }
        #endregion

        private void btnConfirmcode_Click_1(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (tbxConfirmcode.Text == randomcode)
            {
                tbxNewpass.Enabled = true;
                tbxConfirmpass.Enabled = true;
                btnChangepass.Enabled = true;
                btnConfirmcode.Enabled = false;
                DTBase.GetUserUName(tbxUsername.Text);
                MessageBox.Show("Confirm successfully! You need to change your password below.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong code!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (tbxNewpass.Text != "" && tbxConfirmpass.Text != "")
            {
                if (tbxNewpass.Text == tbxConfirmpass.Text)
                {
                    try
                    {
                        DTBase.ChangePass(tbxConfirmpass.Text);
                        LoginForm lgf = new LoginForm();
                        lgf.Show();
                        lgf.Location = new Point(this.Location.X, this.Location.Y);
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lbEnter.Hide();
                    lbConfirm.Show();
                }
            }
            else
            {
                lbConfirm.Hide();
                lbEnter.Show();
            }
        }
    }
}
