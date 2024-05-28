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
            if(this.Tag != null)
            {
                user = new User(this.Tag.ToString());
                tbxID.Text = user.UserID.ToString();
                tbxUsername.Text = user.UserName;
                tbxMail.Text = user.Mail;
                tbxWinrate.Text = user.WinRate.ToString() + " %";
                tbxScore.Text = user.Score.ToString();
                tbxDate.Text = $"{user.NgayTao.Day}/{user.NgayTao.Month}/{user.NgayTao.Year}";
                picProfile.Image = Image.FromFile($"Resources\\{user.Avatar.ToString()}.png");

                //tmAvtChange.Start();

                historyThread = new Thread(LoadHistoryMatch);
                historyThread.Start();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            FORMS.ChooseAvatarForm avtf = new FORMS.ChooseAvatarForm() {Tag = this.Tag };
            avtf.ShowDialog();
        }

        private void tmAvtChange_Tick(object sender, EventArgs e)
        {
            User userChange = new User(this.Tag.ToString());
            if(picProfile.Image != Image.FromFile($"Resources\\{userChange.Avatar}.png"))
            {
                picProfile.Image = Image.FromFile($"Resources\\{userChange.Avatar}.png");
            }
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Tag != null)
            {
                //tmAvtChange.Stop();
                historyThread.Abort();
            }
        }

        MatchHistoryControl curentMatch;
        private void LoadHistoryMatch()
        {
            user = new User(this.Tag.ToString());
            List<Match> list= new List<Match>();
            list = user.GetMatch();
            foreach (var item in list)
            {
                if(item.IdWin == user.UserID)
                {
                    MatchHistoryControl matchControl = new MatchHistoryControl(item.IdLoss.ToString(), item.NgayMatch, result.win);
                    if(curentMatch == null)
                    {
                        matchControl.Location = new Point(25, 5);
                    }
                    else
                    {
                        matchControl.Location = new Point(25, curentMatch.Bottom + 10);
                    }

                    pnLSDau.Invoke((MethodInvoker) delegate {
                        pnLSDau.Controls.Add(matchControl);
                    });

                    curentMatch = matchControl;
                }
                else
                {
                    MatchHistoryControl matchControl = new MatchHistoryControl(item.IdWin.ToString(), item.NgayMatch, result.loss);
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

        private void picProfile_Click(object sender, EventArgs e)
        {
            if(this.Tag != null)
            {
                User userChange = new User(this.Tag.ToString());
                if (picProfile.Image != Image.FromFile($"Resources\\{userChange.Avatar}.png"))
                {
                    picProfile.Image = Image.FromFile($"Resources\\{userChange.Avatar}.png");
                }
            }        }

        private void tbxMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
