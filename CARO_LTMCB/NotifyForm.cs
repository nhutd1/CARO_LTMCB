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

namespace CARO_LTMCB
{
    public partial class NotifyForm : Form
    {
        public bool isOk = false;
        public bool isCancel = false;
        public bool isYes = false;
        public bool isNo = false;
        public NotifyForm(string content, string sub, BoxBtn btn)
        {
            InitializeComponent();
            pnOK.Parent = pn1;
            pnYesNo.Parent = pn1;
            lbSub.Text = sub;
            lbMess.Text = content;
            if (btn == BoxBtn.YesNo)
            {
                pnOK.Hide();
                pic.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            }
            else if (btn == BoxBtn.Ok)
            {
                pnYesNo.Hide();
                pic.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            }
            else
            {
                pnYesNo.Hide();
                pic.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            }
        }

        public enum BoxBtn
        {
            YesNo,
            Ok,
            Error
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            isYes = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            isNo = true;
            this.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            isOk = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }

        #region Kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pn1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbMess_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbSub_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
