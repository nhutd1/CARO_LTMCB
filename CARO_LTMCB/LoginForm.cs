using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;

namespace CARO_LTMCB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signf = new SignUpForm();
            signf.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasss fgf = new ForgotPasss();
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

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-DAHF1F7B\SQLEXPRESS;Initial Catalog=CARO_LTMCB;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxUsername.Text!="username" && tbxPass.Text != "password")
            {
                if(connect.State!= ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = $"SELECT * FROM users WHERE username = '{tbxUsername.Text}' AND userpass = '{tbxPass.Text}'";
                        using(SqlCommand check = new SqlCommand(checkUsername,connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(check);
                            DataTable dttable = new DataTable();
                            adapter.Fill(dttable);

                            if(dttable.Rows.Count > 0)
                            {
                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MenuForm mnf = new MenuForm();
                                mnf.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                tbxUsername.Text = "username";
                                tbxUsername.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                                tbxUsername.ForeColor = Color.LightGray;

                                tbxPass.Text = "password";
                                tbxPass.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic);
                                tbxPass.ForeColor = Color.LightGray;
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
            }
            else
            {
                MessageBox.Show("Please fill all the information!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
