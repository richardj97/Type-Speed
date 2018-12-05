using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tpying_Race
{
    public partial class Settings : Form
    {
        private ColorDialog CD = new ColorDialog();
        private FontDialog FD = new FontDialog();
        private SpeechSynthesizerDevice SSD = new SpeechSynthesizerDevice();
        private SpeechSynthesizer SD = new SpeechSynthesizer();

        public Settings()
        {
            InitializeComponent();
        }
        private void S1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = CD.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.BackColor = CD.Color;
            }
            Config.TextColor = pictureBox1.BackColor;
        }
        private void S2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = CD.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox2.BackColor = CD.Color;
            }
            Config.SelectColor = pictureBox2.BackColor;
        }
        private void S3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Font = FD.Font;
            }
            Config.TextFont = FD.Font;
        }
        private void DefaultBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to reset the configations to default settings?", "Reset to default", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Config.TextColor = Color.FromArgb(224, 224, 224);
                Config.SelectColor = Color.CornflowerBlue;
                Config.TextFont = new Font("Miramonte", 21);
                this.Close();
            } else { return; }
        }
        private void ResultSwitch_Click(object sender, EventArgs e)
        {
            if (ResultSwitch.Value)
                Config.SpeechEnabled = true;
            else
                Config.SpeechEnabled = false;
        }
        private void SpeechCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.SpeechOperator = SpeechCmb.SelectedIndex;
            SD.aSynth.SelectVoice(SpeechCmb.Text);
        }
        private void Settings_Shown(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Config.TextColor;
            this.pictureBox2.BackColor = Config.SelectColor;
            this.textBox1.Font = Config.TextFont;
            this.SpeechCmb.DataSource = SSD.GetInstalledVoices();
            this.ResultSwitch.Value = Config.SpeechEnabled;
            this.SpeechCmb.SelectedItem = Config.SpeechOperator;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
