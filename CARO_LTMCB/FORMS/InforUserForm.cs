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
                int id = Convert.ToInt32(this.Tag);
                try
                {
                    user = DTBase.GetUserUID(id);
                    picAvatar.Image = Image.FromFile($"Resources\\{user.avatar}.png");
                    lbID.Text = user.userID.ToString();
                    lbUsername.Text = user.userName;
                    lbWinRate.Text = user.winRate.ToString() + " %";
                    lbScore.Text = user.score.ToString();
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
