﻿using System;
using System.Collections.Generic;
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
            if (MyUser.user != null)
            {
                txtName.Text = MyUser.user.userName;
                txtID.Text = MyUser.user.userID.ToString();
                txtMail.Text = MyUser.user.userMail;
            }
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

                //Đính kèm file
                if (listPathFile != null)
                {
                    foreach (string item in listPathFile)
                    {
                        Attachment attachment = new Attachment(item);
                        mail.Attachments.Add(attachment);
                    }
                }

                smtpServer.Port = 587; // hoặc 465 tùy thuộc vào nhà cung cấp email
                smtpServer.Credentials = new NetworkCredential("usercarogame@gmail.com", password);
                smtpServer.EnableSsl = true;

                try
                {
                    smtpServer.Send(mail);
                    richTextBox1.Text = string.Empty;
                    listPathFile = null;
                    btnFile.Text = "Attached File";
                    NotifyForm nf = new NotifyForm("Message sent!", "Notification", NotifyForm.BoxBtn.Ok);
                    nf.ShowDialog();
                }
                catch
                {
                    NotifyForm nf = new NotifyForm("Message can't be sent!", "Error", NotifyForm.BoxBtn.Error);
                    nf.ShowDialog();
                }

            }
            catch
            {
                // Hiển thị thông báo lỗi nếu việc gửi email thất bại
                NotifyForm nf = new NotifyForm("An error occurred while sending!", "Error", NotifyForm.BoxBtn.Error);
                nf.ShowDialog();
            }
        }

        List<string> listPathFile;
        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.ShowDialog();

            listPathFile = new List<string>();
            foreach (string item in ofd.FileNames)
            {
                listPathFile.Add(item);
            }

            btnFile.Text = $"Attached File ({listPathFile.Count})";
        }
    }
}
