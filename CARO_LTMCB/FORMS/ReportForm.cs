using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CARO_LTMCB.FORMS
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string ID = txtID.Text;
            string email = txtMail.Text;
            string password = "gkbx ggdt nguk gxdk";
            string message = richTextBox1.Text;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(email);
                mail.To.Add("carogame2024@gmail.com");
                mail.Subject = "Thắc mắc từ người chơi: " + name + "-" + ID;
                mail.Body = $"Email: {email}\nNội dung:\n{message}";

                smtpServer.Port = 587; // hoặc 465 tùy thuộc vào nhà cung cấp email
                smtpServer.Credentials = new NetworkCredential("usercarogame@gmail.com", password);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                MessageBox.Show("Tin nhắn của bạn đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu việc gửi email thất bại
                MessageBox.Show("Có lỗi xảy ra khi gửi tin nhắn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
