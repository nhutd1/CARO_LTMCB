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
    public partial class TinNhan : UserControl
    {
        public TinNhan()
        {
            InitializeComponent();
            SetHeight();
        }
        public TinNhan(string mess, DateTime date, mstype messtype)
        {
            InitializeComponent();
            if(mess == "1")
            {
                pictureBox1.Image = Image.FromFile("Resources\\1.png");
                lbMess.Hide();
            }
            else
            {
                lbMess.Text = mess;
                lbTime.Text = $"{date.Day}/{date.Month}/{date.Year} - {date.Hour}:{date.Minute}";

                SetHeight();
            }
            if (messtype == mstype.In)
            {
                this.BackColor = Color.FromArgb(32, 178, 170);
                lbMess.BackColor = Color.FromArgb(32, 178, 170);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 128, 128);
                lbMess.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        void SetHeight()
        {
            Size maxSize = new Size(390, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lbMess.Text, lbMess.Font, lbMess.Width);

            lbMess.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lbTime.Top = lbMess.Bottom + 10;
            this.Height = lbTime.Bottom + 10;
        }

        private void lbMess_Resize(object sender, EventArgs e)
        {
            SetHeight();
        }

    }
    public enum mstype
    {
        In,
        Out
    }
}
