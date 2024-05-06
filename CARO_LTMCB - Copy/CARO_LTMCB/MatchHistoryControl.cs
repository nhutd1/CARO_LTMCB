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
    public partial class MatchHistoryControl : UserControl
    {
        public MatchHistoryControl()
        {
            InitializeComponent();
        }
        public MatchHistoryControl(string userID,string time, result matchResult)
        {
            InitializeComponent();
            int i = 0;
            User user = new User(userID, i);
            lbUserName.Text = user.UserName;
            lbTime.Text = time;

            if(matchResult == result.win)
            {
                lbResult.Text = "WIN";
                lbResult.ForeColor = Color.FromArgb(32, 178, 170);
                label2.ForeColor = Color.FromArgb(32, 178, 170);
                lbUserName.ForeColor = Color.FromArgb(32, 178, 170);
                lbTime.ForeColor = Color.FromArgb(32, 178, 170);
            }
            else
            {
                lbResult.Text = "LOSS";
                lbResult.ForeColor = Color.FromArgb(255, 128, 128);
                label2.ForeColor = Color.FromArgb(255, 128, 128);
                lbUserName.ForeColor = Color.FromArgb(255, 128, 128);
                lbTime.ForeColor = Color.FromArgb(255, 128, 128);
            }
        }

    }
    public enum result
    {
        win,
        loss
    }
}
