using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tpying_Race
{
    public partial class Main : Form
    {
        private int cPos = 0;
        private int cCountLimited = 1;
        private int cCorrect = 0;
        private int cIncorrect = 0;
        private int cSecound = 0;
        private int wCount = 0;
        private string[] importedData;
        private List<string> Words;
        private Stopwatch SW;
        private Generate P;
        private SpeechSynthesizer SS;

        public Main()
        {
            InitializeComponent();
            Config.TextColor = Color.FromArgb(224, 224, 224);
            Config.SelectColor = Color.CornflowerBlue;
            Config.TextFont = new Font("Miramonte", 21);
            Config.SpeechEnabled = false;
            SetupGame();
        }
        private void SetupGame()
        {
            this.P = new Generate();
            this.SW = new Stopwatch();
            this.SS = new SpeechSynthesizer();
            this.TopicTitleLabel.Text = P.GetTitle();
            this.RichTB.Text = P.GetData();
            this.importedData = new string[GetCharacterCount()];
            this.ProgBar.MaxValue = GetCharacterCount();
            this.Words = RichTB.Text.Split(' ').ToList();

            for (int i = 0; i < GetCharacterCount(); i++)
            {
                importedData[i] = RichTB.Text[i].ToString();
            }
            this.ActiveControl = StartBtn;
        }
        private void Checktext(string text)
        {
            if (text[cPos] == RichTB.Text[cPos])
            {
                RichTB.Select(cPos, cCountLimited);
                RichTB.SelectionColor = Config.SelectColor;
                cPos++;
                cCorrect++;
                ProgBar.Value++;

                if (cPos == GetCharacterCount())
                {
                    SpeedTimer.Stop();
                    InputTb.Enabled = false;
                    ResetBtn.Enabled = true;
                    StopBtn.Enabled = false;
                    ResultSwitch.Value = true;
                    wCount++;
                    UpdateResults();
                    ResetBtn.Focus();
                }
                if (RichTB.Text[cPos].ToString() == " ")
                {
                    wCount++;

                    if (Config.SpeechEnabled)
                        SS.Speak(Words[wCount], 0);
                }
            }
            else
            { cIncorrect++; }
        }
        private int GetCharacterCount()
        {
            return RichTB.TextLength;
        }
        private int GetWordCount()
        {
             return RichTB.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }
        private void InputTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (InputTb.Text[0].ToString() == RichTB.Text[0].ToString() && InputTb.Text != string.Empty)
                {
                    if (InputTb.Text.Length == 1)
                    {
                        this.SW.Start();
                        this.SpeedTimer.Start();
                    }
                    Checktext(InputTb.Text);
                }
            }
            catch { return; }
        }
        private void SpeedTimer_Tick(object sender, EventArgs e)
        {
            cSecound++;
            UpdateResults();
        }
        private void UpdateResults()
        {
            if (ResultSwitch.Value)
            {
                CSecLabel.Text = string.Format("{0:hh\\:mm\\:ss}", SW.Elapsed);
                CCorrectLabel.Text = (cCorrect - cIncorrect).ToString();
                CIncorrectLabel.Text = cIncorrect.ToString();
                CCountLabel.Text = cCorrect + " / " + GetCharacterCount();
                WCountLabel.Text = wCount + " / " + GetWordCount();
                WPMLabel.Text = Math.Round((double)GetWordCount() / cSecound * 60 * 10, 2).ToString();
                CPMLabel.Text = Math.Round((double)GetCharacterCount() / cSecound * 60 * 10, 2).ToString();
            }
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.StartBtn.Enabled = false;
            this.ResetBtn.Enabled = false;
            this.InputTb.Enabled = true;
            this.StopBtn.Enabled = true;
            this.InputTb.Focus();

            if (Config.SpeechEnabled)
                SS.Speak(Words[0], 0);
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (StopBtn.Text == "Stop")
            {
                SW.Stop();
                SpeedTimer.Stop();
                StopBtn.Text = "Continue";
                ResetBtn.Enabled = true;
                InputTb.Enabled = false;
                SS.PauseAsynth();
            }
            else
            {
                SW.Start();
                SpeedTimer.Start();
                StopBtn.Text = "Stop";
                ResetBtn.Enabled = false;
                InputTb.Enabled = true;
                SS.ContinueAsynth();
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            cPos = 0;
            cCorrect = 0;
            cIncorrect = 0;
            cSecound = 0;
            ProgBar.Value = 0;
            wCount = 0;
            RichTB.Clear();
            InputTb.Clear();
            SW.Reset();
            CSecLabel.Text = "00:00:00";
            CCorrectLabel.Text = "0";
            CIncorrectLabel.Text = "0";
            CCorrectLabel.Text = "0";
            WCountLabel.Text = "0 / 0";
            WPMLabel.Text = "0";
            CPMLabel.Text = "0";
            StopBtn.Text = "Stop";
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            InputTb.Enabled = false;
            SetupGame();
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings SettingsFrm = new Settings();
            SettingsFrm.ShowDialog();

            RichTB.ForeColor = Config.TextColor;
            RichTB.Font = Config.TextFont;
            InputTb.ForeColor = Config.TextColor;
            InputTb.Font = Config.TextFont;
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { SS.AbortAsynth(); Application.Exit(); }
            catch { return; }
        }
    }
}
