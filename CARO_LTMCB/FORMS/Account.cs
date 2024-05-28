using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace CARO_LTMCB.FORMS
{
    public partial class Account : Form
    {
        User user;
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                user = new User(this.Tag.ToString());
                tbxID.Text = user.UserID.ToString();
                tbxUsername.Text = user.UserName;
                tbxMail.Text = user.Mail;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }

            
            if (user == null)
            {
                MessageBox.Show("Không thể lưu thông tin vì không có dữ liệu người dùng.");
                return;
            }

            // Kiểm tra xem thông tin đã thay đổi chưa
            if (tbxUsername.Text == user.UserName && tbxMail.Text == user.Mail)
            {
                MessageBox.Show("Không có thay đổi nào để lưu.");
                return;
            }

            // Cập nhật thông tin người dùng
            user.UpdateUserInfo(tbxUsername.Text, tbxMail.Text);
            MessageBox.Show("Thông tin đã được lưu.");
        }

        private void iconCopy_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (string.IsNullOrWhiteSpace(tbxID.Text))
            {
                MessageBox.Show(" Hãy nhập ID ! ");
                return;
            }
            Clipboard.SetText(tbxID.Text);
            // Kiểm tra lại Clipboard để xác nhận
            if (Clipboard.GetText() == tbxID.Text)
            {
                MessageBox.Show(" Đã copy ID ");
            }
            else
            {
                MessageBox.Show(" Không thể copy ID ");
            }
        }
    }
}
