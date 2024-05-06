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
            if (this.Tag != null)
            {
                user = new User(Tag.ToString());
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
                user.ChangeAvatar(1);
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
                user.ChangeAvatar(2);
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
                user.ChangeAvatar(3);
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
                user.ChangeAvatar(4);
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
                user.ChangeAvatar(5);
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
                user.ChangeAvatar(11);
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
                user.ChangeAvatar(12);
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
                user.ChangeAvatar(6);
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
                user.ChangeAvatar(7);
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
                user.ChangeAvatar(8);
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
                user.ChangeAvatar(9);
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
                user.ChangeAvatar(10);
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
