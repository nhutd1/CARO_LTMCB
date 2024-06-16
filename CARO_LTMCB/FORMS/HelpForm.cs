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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            OpenForm(new FORMS.ReportForm());
            currentBtn = btnReport;
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
            pnHelp.Controls.Add(childForm);
            pnHelp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private IconButton currentBtn;
        //private Panel leftPannelBtn;

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                OpenForm(new FORMS.ReportForm());
                currentBtn = sender as IconButton;
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            if (currentBtn != sender)
            {
                OpenForm(new FORMS.GuideForm());
                currentBtn = sender as IconButton;
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
