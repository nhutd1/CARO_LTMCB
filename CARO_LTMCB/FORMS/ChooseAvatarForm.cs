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
    public partial class ChooseAvatarForm : Form
    {
        User user;
        public ChooseAvatarForm()
        {
            InitializeComponent();
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

        #endregion

        private void ChooseAvatarForm_Load(object sender, EventArgs e)
        {
            if (MyUser.user != null)
            {
                user = MyUser.user;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(1);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(2);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(3);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(4);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(5);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(11);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(12);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(6);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(7);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(8);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(9);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (user != null)
            {
                try
                {
                    DTBase.ChangeAvatar(10);
                }
                catch
                {
                    MessageBox.Show("Error connect to Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            this.Close();
        }
    }
}
