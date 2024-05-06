using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_LTMCB.FORMS
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private Form currentForm;
        private void OpenForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private IconButton currentBtn;
        //private Panel leftPannelBtn;

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                OpenForm(new FORMS.General());
                currentBtn = sender as IconButton;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                OpenForm(new FORMS.Account());
                currentBtn = sender as IconButton;
            }
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                OpenForm(new FORMS.Privacy());
                currentBtn = sender as IconButton;
            }
        }
    }
}
