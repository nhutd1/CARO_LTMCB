
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

namespace CARO_LTMCB.FORMS
{
    
    public partial class Account : Form
    {
        public string Gender;
        public Account()
        {
            InitializeComponent();
            if (MyUser.user != null)
            {
                // Hiển thị thông tin người dùng
                tbxUsername.Text = MyUser.user.userName;
                tbxID.Text = MyUser.user.userID.ToString();
                tbxMail.Text = MyUser.user.userMail;
                Gender = MyUser.user.gender;
                // Kiểm tra giới tính và hiển thị hình ảnh tương ứng
                if (MyUser.user.gender == "male")
                {
                    picBoxOnMale.BringToFront(); // Hiển thị hình ảnh male
                    picBoxOffFemale.BringToFront(); // Ẩn hình ảnh female
                }
                else if (MyUser.user.gender == "female")
                {
                    picBoxOffMale.BringToFront(); // Ẩn hình ảnh male
                    picBoxOnFemale.BringToFront(); // Hiển thị hình ảnh female
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MyUser.user != null)
            {
                string newUsername = tbxUsername.Text;
                string newEmail = tbxMail.Text;

                
                if (MyUser.user.userName != newUsername || MyUser.user.userMail != newEmail || MyUser.user.gender != Gender)
                {
                    // Cập nhật thông tin trong đối tượng MyUser.user
                    MyUser.user.userName = newUsername;
                    MyUser.user.userMail = newEmail;
                    MyUser.user.gender = Gender; 

                    
                    DTBase.UpdateUserInfo(MyUser.user.userID, newUsername, newEmail, Gender);
                }
                else
                {
                    MessageBox.Show("No changes to save.");
                }
            }

        }

        private void iconCopy_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbxID.Text))
            {
                Clipboard.SetText(tbxID.Text);
            }
            else
            {
                MessageBox.Show("No text selected to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconCopy_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void picBoxOnMale_Click(object sender, EventArgs e)
        {
            picBoxOffMale.BringToFront();
            picBoxOnFemale.BringToFront();
            Gender = "female";
        }

        private void picBoxOffMale_Click(object sender, EventArgs e)
        {
            picBoxOnMale.BringToFront();
            picBoxOffFemale.BringToFront();
            Gender = "male";
        }

        private void Account_Load(object sender, EventArgs e)
        {
            
        }

        private void picBoxOnFemale_Click(object sender, EventArgs e)
        {
            picBoxOnMale.BringToFront();
            picBoxOffFemale.BringToFront();
            Gender = "male";
        }

        private void picBoxOffFemale_Click(object sender, EventArgs e)
        {
            picBoxOffMale.BringToFront();
            picBoxOnFemale.BringToFront();
            Gender = "female";
        }
    }
}
