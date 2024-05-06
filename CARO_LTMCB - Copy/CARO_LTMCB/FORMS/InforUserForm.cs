using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_LTMCB.FORMS
{
    public partial class InforUserForm : Form
    {
        User user;
        public InforUserForm()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InforUserForm_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                int i = 0;
                user = new User(Tag.ToString(), i);
                picAvatar.Image = Image.FromFile($"Resources\\{user.Avatar}.png");
                lbID.Text = user.UserID.ToString();
                lbUsername.Text = user.UserName;
                lbWinRate.Text = user.WinRate.ToString() + " %";
                lbScore.Text = user.Score.ToString();
            }
        }

        #region Kéo form 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
