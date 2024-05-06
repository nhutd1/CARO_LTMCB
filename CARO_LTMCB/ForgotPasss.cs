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
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace CARO_LTMCB
{
    public partial class ForgotPasss : Form
    {
        public ForgotPasss()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfirmCode_Click(object sender, EventArgs e)
        {

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
                tbxMail.ForeColor = Color.LightGray;
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
                tbxUsername.ForeColor = Color.LightGray;
            }
        }

        private void btnForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
            this.Hide();
        }

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

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-DAHF1F7B\SQLEXPRESS;Initial Catalog=CARO_LTMCB;Integrated Security=True");

        #region Gửi code qua mail người dùng
        private bool IsUserAndMailExist()
        {
            bool result = false;
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkUserMail = $"SELECT * FROM users WHERE username='{tbxUsername.Text}' AND mail='{tbxMail.Text}'";

                    using (SqlCommand check = new SqlCommand(checkUserMail, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(check);
                        DataTable dttable = new DataTable();
                        adapter.Fill(dttable);

                        if (dttable.Rows.Count > 0)
                        {
                            result = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error connect to database!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return result;
        }

        string randomcode;
        
        private void btnGetcode_Click(object sender, EventArgs e)
        {
            if(tbxMail.Text != "example@gmail.com" && tbxUsername.Text != "username")
            {
                if (IsUserAndMailExist())
                {
                    string from, pass, messageBody,to;
                    Random rand = new Random();
                    randomcode = (rand.Next(999999)).ToString();

                    MailMessage message = new MailMessage();

                    to = tbxMail.Text;
                    from = "carogameserver@gmail.com";
                    pass = "iotb mxrh byqb xizh";
                    messageBody = "Your code is: " + randomcode;

                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "PASSWORD RESET CODE";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code send successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error to send code: "+ ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username is not exists or wrong E-MAIL!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void btnConfirmcode_Click_1(object sender, EventArgs e)
        {
            if(tbxConfirmcode.Text == randomcode)
            {
                tbxNewpass.Enabled = true;
                tbxConfirmpass.Enabled = true;
                btnChangepass.Enabled = true;
                MessageBox.Show("Confirm successfully! You need to change your password below.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong code!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            if (tbxNewpass.Text != "" && tbxConfirmpass.Text !="")
            {
                if (tbxNewpass.Text == tbxConfirmpass.Text) 
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updatePass = $"UPDATE users SET userpass = '{tbxConfirmpass.Text}' WHERE username='{tbxUsername.Text}' AND mail='{tbxMail.Text}'";
                            using (SqlCommand updatePassCmd = new SqlCommand(updatePass, connect))
                            {
                                updatePassCmd.ExecuteNonQuery();
                                MessageBox.Show("Change password successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginForm lgf = new LoginForm();
                                lgf.Show();
                                this.Hide();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error connect to database!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please confirm the correct password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the new password!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
