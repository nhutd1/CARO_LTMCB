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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            comboBox1.Items.Add("themesong1");
            comboBox1.Items.Add("themesong2");
            comboBox1.Items.Add("themesong3");
            comboBox1.Items.Add("themesong4");
            comboBox1.Items.Add("themesong5");
            comboBox1.Items.Add("themesong6");
            comboBox1.Items.Add("themesong7");
            comboBox1.SelectedIndex = 0;
        }

        private void btnMusicOff_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            AudioPlayer.StopAudio();
        }

        private void btnMusicOn_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            // Lấy tên file nhạc được chọn từ ComboBox
            string selectedMusic = comboBox1.SelectedItem.ToString();

            // Gọi hàm PlayAudio từ AudioPlayer với tên file nhạc được chọn
            AudioPlayer.PlayAudio(selectedMusic);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EffectManager.IsEffectEnabled())
            {
                Effect.PlayEffect("effect");
            }
            AudioPlayer.StopAudio();

            // Lấy tên file nhạc được chọn từ ComboBox
            string selectedMusic = comboBox1.SelectedItem.ToString();

            // Gọi hàm PlayAudio từ AudioPlayer với tên file nhạc được chọn
            AudioPlayer.PlayAudio(selectedMusic);
        }

        private void btnEffectOff_Click(object sender, EventArgs e)
        {
            EffectManager.DisableEffect();
        }

        private void btnEffectOn_Click(object sender, EventArgs e)
        {
            EffectManager.EnableEffect();
        }

    }
}
