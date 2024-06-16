using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CARO_LTMCB.FORMS
{
    public partial class ProfileForm : Form
    {
        User user;
        Thread historyThread;
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (MyUser.user != null)
            {
                user = MyUser.user;
                tbxID.Text = user.userID.ToString();
                tbxUsername.Text = user.userName;
                tbxMail.Text = user.userMail;
                tbxWinrate.Text = user.winRate.ToString() + " %";
                tbxScore.Text = user.score.ToString();
                tbxDate.Text = $"{user.ngayTao.Day}/{user.ngayTao.Month}/{user.ngayTao.Year}";
                picProfile.Image = Image.FromFile($"Resources\\{user.avatar.ToString()}.png");

                historyThread = new Thread(LoadHistoryMatch);
                historyThread.IsBackground = true;
                historyThread.Start();
            }
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            FORMS.ChooseAvatarForm avtf = new FORMS.ChooseAvatarForm();
            avtf.ShowDialog();
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag != null)
            {
                historyThread.Abort();
            }
        }

        MatchHistoryControl curentMatch;
        private void LoadHistoryMatch()
        {
            List<Match> list = new List<Match>();
            try
            {
                list = DTBase.HistoryMatch();
                foreach (var item in list)
                {
                    if (item.idUserWin == user.userID)
                    {
                        MatchHistoryControl matchControl = new MatchHistoryControl(item.idUserLoss, item.ngayMatch, result.win);
                        if (curentMatch == null)
                        {
                            matchControl.Location = new Point(25, 5);
                        }
                        else
                        {
                            matchControl.Location = new Point(25, curentMatch.Bottom + 10);
                        }

                        pnLSDau.Invoke((MethodInvoker)delegate {
                            pnLSDau.Controls.Add(matchControl);
                        });

                        curentMatch = matchControl;
                    }
                    else
                    {
                        MatchHistoryControl matchControl = new MatchHistoryControl(item.idUserWin, item.ngayMatch, result.loss);
                        if (curentMatch == null)
                        {
                            matchControl.Location = new Point(25, 5);
                        }
                        else
                        {
                            matchControl.Location = new Point(25, curentMatch.Bottom + 10);
                        }

                        pnLSDau.Invoke((MethodInvoker)delegate {
                            pnLSDau.Controls.Add(matchControl);
                        });

                        curentMatch = matchControl;
                    }
                }
            }
            catch
            {
            }
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            if (MyUser.user != null)
            {
                if (picProfile.Image != Image.FromFile($"Resources\\{user.avatar}.png"))
                {
                    picProfile.Image = Image.FromFile($"Resources\\{user.avatar}.png");
                }
            }
        }
    }
}
