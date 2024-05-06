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
using System.Data.SqlClient;

namespace CARO_LTMCB
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
            lgf.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

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
                tbxPass.PasswordChar = '\0';
            }
            else
            {
                iconPictureBox5.IconChar = IconChar.Eye;
                tbxPass.PasswordChar = '*';
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
                tbxPass.ForeColor = Color.LightGray;
            }
        }

        private void tbxConfirmpass_Enter(object sender, EventArgs e)
        {
            if (tbxConfirmpass.Text == "password")
            {
                tbxConfirmpass.Text = "";
                tbxConfirmpass.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
                tbxConfirmpass.ForeColor = Color.Black;
            }
        }

        private void tbxConfirmpass_Leave(object sender, EventArgs e)
        {
            if (tbxConfirmpass.Text == "")
            {
                tbxConfirmpass.Text = "password";
                tbxConfirmpass.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                tbxConfirmpass.ForeColor = Color.LightGray;
            }
        }

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

        SqlConnection connect = new SqlConnection(@"Data Source=34.87.92.114;Initial Catalog=CARO;User ID=sqlserver;Password=carogame123");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (tbxMail.Text == "example@gmail.com" || tbxUsername.Text == "username" || tbxPass.Text == "password")
            {
                MessageBox.Show("Please fill all the information!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = $"SELECT * FROM users WHERE username = '{tbxUsername.Text}'";
                        using (SqlCommand check = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(check);
                            DataTable dttable = new DataTable();
                            adapter.Fill(dttable);

                            if (dttable.Rows.Count > 0)
                            {
                                MessageBox.Show(tbxUsername.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                if (tbxPass.Text == tbxConfirmpass.Text)
                                {
                                    DateTime date = DateTime.Now;
                                    string adduser = $"INSERT INTO users VALUES ('{tbxUsername.Text}','{tbxPass.Text}','{tbxMail.Text}','{date}','0','0','0')";
                                    using (SqlCommand insertcmd = new SqlCommand(adduser, connect))
                                    {
                                        insertcmd.ExecuteNonQuery();
                                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LoginForm lgf = new LoginForm();
                                        lgf.Show();
                                        lgf.Location = new Point(this.Location.X, this.Location.Y);
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please confirm the correct password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
