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
    public partial class ChooseIconForm : Form
    {
        public string icon = "=icon=";
        public ChooseIconForm()
        {
            InitializeComponent();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            icon += pictureBox1.Tag.ToString();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            icon += pictureBox2.Tag.ToString();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            icon += pictureBox3.Tag.ToString();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            icon += pictureBox4.Tag.ToString();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            icon += pictureBox5.Tag.ToString();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            icon += pictureBox6.Tag.ToString();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            icon += pictureBox7.Tag.ToString();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            icon += pictureBox8.Tag.ToString();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            icon += pictureBox10.Tag.ToString();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            icon += pictureBox9.Tag.ToString();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            icon += pictureBox11.Tag.ToString();
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            icon += pictureBox12.Tag.ToString();
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            icon += pictureBox14.Tag.ToString();
            this.Close();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            icon += pictureBox18.Tag.ToString();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            icon += pictureBox20.Tag.ToString();
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            icon += pictureBox13.Tag.ToString();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            icon += pictureBox15.Tag.ToString();
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            icon += pictureBox17.Tag.ToString();
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            icon += pictureBox16.Tag.ToString();
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            icon += pictureBox19.Tag.ToString();
            this.Close();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            icon += pictureBox21.Tag.ToString();
            this.Close();
        }

        #region Kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
