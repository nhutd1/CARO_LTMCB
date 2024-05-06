using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_LTMCB
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Tag = Tag;
            mf.Show();
            this.Hide();
            timer1.Stop();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            AudioPlayer.PlayAudio("themesong1");
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
