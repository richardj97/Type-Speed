namespace Tpying_Race
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.InputTb = new System.Windows.Forms.TextBox();
            this.SpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.ResultsGB = new System.Windows.Forms.GroupBox();
            this.WPMLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CSecLabel = new System.Windows.Forms.Label();
            this.CPMLabel = new System.Windows.Forms.Label();
            this.CCountLabel = new System.Windows.Forms.Label();
            this.CCorrectLabel = new System.Windows.Forms.Label();
            this.CIncorrectLabel = new System.Windows.Forms.Label();
            this.ProgBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Seperator = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Label1 = new System.Windows.Forms.Label();
            this.TopicTitleLabel = new System.Windows.Forms.Label();
            this.RichTB = new System.Windows.Forms.RichTextBox();
            this.ResultSwitch = new Bunifu.Framework.UI.BunifuSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StopBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ResetBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SettingsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ResultsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTb
            // 
            this.InputTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.InputTb.Enabled = false;
            this.InputTb.Font = new System.Drawing.Font("Miramonte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputTb.Location = new System.Drawing.Point(13, 512);
            this.InputTb.Multiline = true;
            this.InputTb.Name = "InputTb";
            this.InputTb.Size = new System.Drawing.Size(593, 149);
            this.InputTb.TabIndex = 1;
            this.InputTb.TextChanged += new System.EventHandler(this.InputTb_TextChanged);
            // 
            // SpeedTimer
            // 
            this.SpeedTimer.Tick += new System.EventHandler(this.SpeedTimer_Tick);
            // 
            // ResultsGB
            // 
            this.ResultsGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsGB.Controls.Add(this.WPMLabel);
            this.ResultsGB.Controls.Add(this.label10);
            this.ResultsGB.Controls.Add(this.WCountLabel);
            this.ResultsGB.Controls.Add(this.label4);
            this.ResultsGB.Controls.Add(this.CSecLabel);
            this.ResultsGB.Controls.Add(this.CPMLabel);
            this.ResultsGB.Controls.Add(this.CCountLabel);
            this.ResultsGB.Controls.Add(this.CCorrectLabel);
            this.ResultsGB.Controls.Add(this.CIncorrectLabel);
            this.ResultsGB.Controls.Add(this.ProgBar);
            this.ResultsGB.Controls.Add(this.Label7);
            this.ResultsGB.Controls.Add(this.Label8);
            this.ResultsGB.Controls.Add(this.Label9);
            this.ResultsGB.Controls.Add(this.Label5);
            this.ResultsGB.Controls.Add(this.Label6);
            this.ResultsGB.Controls.Add(this.shapeContainer1);
            this.ResultsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResultsGB.Location = new System.Drawing.Point(613, 46);
            this.ResultsGB.Name = "ResultsGB";
            this.ResultsGB.Size = new System.Drawing.Size(229, 460);
            this.ResultsGB.TabIndex = 4;
            this.ResultsGB.TabStop = false;
            this.ResultsGB.Text = " Results ";
            // 
            // WPMLabel
            // 
            this.WPMLabel.AutoSize = true;
            this.WPMLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WPMLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.WPMLabel.Location = new System.Drawing.Point(123, 145);
            this.WPMLabel.Name = "WPMLabel";
            this.WPMLabel.Size = new System.Drawing.Size(18, 19);
            this.WPMLabel.TabIndex = 15;
            this.WPMLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(17, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Word per min:";
            // 
            // WCountLabel
            // 
            this.WCountLabel.AutoSize = true;
            this.WCountLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCountLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.WCountLabel.Location = new System.Drawing.Point(115, 178);
            this.WCountLabel.Name = "WCountLabel";
            this.WCountLabel.Size = new System.Drawing.Size(42, 19);
            this.WCountLabel.TabIndex = 13;
            this.WCountLabel.Text = "0 / 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Words to go:";
            // 
            // CSecLabel
            // 
            this.CSecLabel.AutoSize = true;
            this.CSecLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSecLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CSecLabel.Location = new System.Drawing.Point(104, 37);
            this.CSecLabel.Name = "CSecLabel";
            this.CSecLabel.Size = new System.Drawing.Size(71, 19);
            this.CSecLabel.TabIndex = 11;
            this.CSecLabel.Text = "00:00:00";
            // 
            // CPMLabel
            // 
            this.CPMLabel.AutoSize = true;
            this.CPMLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPMLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CPMLabel.Location = new System.Drawing.Point(150, 73);
            this.CPMLabel.Name = "CPMLabel";
            this.CPMLabel.Size = new System.Drawing.Size(18, 19);
            this.CPMLabel.TabIndex = 10;
            this.CPMLabel.Text = "0";
            // 
            // CCountLabel
            // 
            this.CCountLabel.AutoSize = true;
            this.CCountLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCountLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CCountLabel.Location = new System.Drawing.Point(141, 110);
            this.CCountLabel.Name = "CCountLabel";
            this.CCountLabel.Size = new System.Drawing.Size(42, 19);
            this.CCountLabel.TabIndex = 9;
            this.CCountLabel.Text = "0 / 0";
            // 
            // CCorrectLabel
            // 
            this.CCorrectLabel.AutoSize = true;
            this.CCorrectLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCorrectLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CCorrectLabel.Location = new System.Drawing.Point(150, 214);
            this.CCorrectLabel.Name = "CCorrectLabel";
            this.CCorrectLabel.Size = new System.Drawing.Size(18, 19);
            this.CCorrectLabel.TabIndex = 8;
            this.CCorrectLabel.Text = "0";
            // 
            // CIncorrectLabel
            // 
            this.CIncorrectLabel.AutoSize = true;
            this.CIncorrectLabel.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIncorrectLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CIncorrectLabel.Location = new System.Drawing.Point(160, 246);
            this.CIncorrectLabel.Name = "CIncorrectLabel";
            this.CIncorrectLabel.Size = new System.Drawing.Size(18, 19);
            this.CIncorrectLabel.TabIndex = 7;
            this.CIncorrectLabel.Text = "0";
            // 
            // ProgBar
            // 
            this.ProgBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgBar.animated = false;
            this.ProgBar.animationIterval = 5;
            this.ProgBar.animationSpeed = 300;
            this.ProgBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgBar.BackgroundImage")));
            this.ProgBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgBar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProgBar.LabelVisible = true;
            this.ProgBar.LineProgressThickness = 8;
            this.ProgBar.LineThickness = 5;
            this.ProgBar.Location = new System.Drawing.Point(38, 299);
            this.ProgBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgBar.MaxValue = 100;
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgBar.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.ProgBar.Size = new System.Drawing.Size(148, 148);
            this.ProgBar.TabIndex = 5;
            this.ProgBar.Value = 0;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label7.Location = new System.Drawing.Point(17, 108);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(126, 19);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Characters to go:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label8.Location = new System.Drawing.Point(17, 71);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(136, 19);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Character per min:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label9.Location = new System.Drawing.Point(17, 36);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(89, 19);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Time taken:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label5.Location = new System.Drawing.Point(17, 245);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(146, 19);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Incorrect characters:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label6.Location = new System.Drawing.Point(17, 212);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(136, 19);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Correct characters:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Seperator});
            this.shapeContainer1.Size = new System.Drawing.Size(223, 441);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // Seperator
            // 
            this.Seperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Seperator.BorderColor = System.Drawing.Color.White;
            this.Seperator.Name = "Seperator";
            this.Seperator.X1 = -3;
            this.Seperator.X2 = 225;
            this.Seperator.Y1 = 270;
            this.Seperator.Y2 = 270;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label1.Location = new System.Drawing.Point(8, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 26);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Topic Title: ";
            // 
            // TopicTitleLabel
            // 
            this.TopicTitleLabel.AutoSize = true;
            this.TopicTitleLabel.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicTitleLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TopicTitleLabel.Location = new System.Drawing.Point(114, 13);
            this.TopicTitleLabel.Name = "TopicTitleLabel";
            this.TopicTitleLabel.Size = new System.Drawing.Size(0, 26);
            this.TopicTitleLabel.TabIndex = 8;
            // 
            // RichTB
            // 
            this.RichTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.RichTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RichTB.DetectUrls = false;
            this.RichTB.Font = new System.Drawing.Font("Miramonte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RichTB.Location = new System.Drawing.Point(13, 53);
            this.RichTB.Name = "RichTB";
            this.RichTB.ReadOnly = true;
            this.RichTB.Size = new System.Drawing.Size(593, 453);
            this.RichTB.TabIndex = 3;
            this.RichTB.Text = "";
            // 
            // ResultSwitch
            // 
            this.ResultSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResultSwitch.BorderRadius = 0;
            this.ResultSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResultSwitch.Location = new System.Drawing.Point(750, 20);
            this.ResultSwitch.Name = "ResultSwitch";
            this.ResultSwitch.Oncolor = System.Drawing.Color.CornflowerBlue;
            this.ResultSwitch.Onoffcolor = System.Drawing.Color.DarkGray;
            this.ResultSwitch.Size = new System.Drawing.Size(51, 19);
            this.ResultSwitch.TabIndex = 9;
            this.ResultSwitch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResultSwitch.Value = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(656, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Show results";
            // 
            // StartBtn
            // 
            this.StartBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.BorderRadius = 0;
            this.StartBtn.ButtonText = "Start";
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.DisabledColor = System.Drawing.Color.Gray;
            this.StartBtn.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.StartBtn.Iconimage = null;
            this.StartBtn.Iconimage_right = null;
            this.StartBtn.Iconimage_right_Selected = null;
            this.StartBtn.Iconimage_Selected = null;
            this.StartBtn.IconMarginLeft = 0;
            this.StartBtn.IconMarginRight = 0;
            this.StartBtn.IconRightVisible = true;
            this.StartBtn.IconRightZoom = 0D;
            this.StartBtn.IconVisible = true;
            this.StartBtn.IconZoom = 90D;
            this.StartBtn.IsTab = false;
            this.StartBtn.Location = new System.Drawing.Point(613, 512);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(6);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StartBtn.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.StartBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.StartBtn.selected = false;
            this.StartBtn.Size = new System.Drawing.Size(229, 46);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartBtn.Textcolor = System.Drawing.Color.White;
            this.StartBtn.TextFont = new System.Drawing.Font("Miramonte", 15.75F);
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Activecolor = System.Drawing.Color.IndianRed;
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBtn.BackColor = System.Drawing.Color.IndianRed;
            this.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopBtn.BorderRadius = 0;
            this.StopBtn.ButtonText = "Stop";
            this.StopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBtn.DisabledColor = System.Drawing.Color.Gray;
            this.StopBtn.Enabled = false;
            this.StopBtn.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.StopBtn.Iconimage = null;
            this.StopBtn.Iconimage_right = null;
            this.StopBtn.Iconimage_right_Selected = null;
            this.StopBtn.Iconimage_Selected = null;
            this.StopBtn.IconMarginLeft = 0;
            this.StopBtn.IconMarginRight = 0;
            this.StopBtn.IconRightVisible = true;
            this.StopBtn.IconRightZoom = 0D;
            this.StopBtn.IconVisible = true;
            this.StopBtn.IconZoom = 90D;
            this.StopBtn.IsTab = false;
            this.StopBtn.Location = new System.Drawing.Point(613, 563);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(6);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Normalcolor = System.Drawing.Color.IndianRed;
            this.StopBtn.OnHovercolor = System.Drawing.Color.IndianRed;
            this.StopBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.StopBtn.selected = false;
            this.StopBtn.Size = new System.Drawing.Size(229, 46);
            this.StopBtn.TabIndex = 11;
            this.StopBtn.Text = "Stop";
            this.StopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StopBtn.Textcolor = System.Drawing.Color.White;
            this.StopBtn.TextFont = new System.Drawing.Font("Miramonte", 15.75F);
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetBtn.BorderRadius = 0;
            this.ResetBtn.ButtonText = "Reset";
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ResetBtn.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ResetBtn.Iconimage = null;
            this.ResetBtn.Iconimage_right = null;
            this.ResetBtn.Iconimage_right_Selected = null;
            this.ResetBtn.Iconimage_Selected = null;
            this.ResetBtn.IconMarginLeft = 0;
            this.ResetBtn.IconMarginRight = 0;
            this.ResetBtn.IconRightVisible = true;
            this.ResetBtn.IconRightZoom = 0D;
            this.ResetBtn.IconVisible = true;
            this.ResetBtn.IconZoom = 90D;
            this.ResetBtn.IsTab = false;
            this.ResetBtn.Location = new System.Drawing.Point(613, 615);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.ResetBtn.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.ResetBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ResetBtn.selected = false;
            this.ResetBtn.Size = new System.Drawing.Size(229, 46);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBtn.Textcolor = System.Drawing.Color.White;
            this.ResetBtn.TextFont = new System.Drawing.Font("Miramonte", 15.75F);
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Image = global::Tpying_Race.Properties.Resources.icons8_settings_50;
            this.SettingsBtn.ImageActive = null;
            this.SettingsBtn.Location = new System.Drawing.Point(818, 17);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(24, 23);
            this.SettingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsBtn.TabIndex = 13;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Zoom = 10;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(854, 676);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultSwitch);
            this.Controls.Add(this.TopicTitleLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ResultsGB);
            this.Controls.Add(this.RichTB);
            this.Controls.Add(this.InputTb);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Speed typing - by Richard Jacobs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResultsGB.ResumeLayout(false);
            this.ResultsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputTb;
        private System.Windows.Forms.Timer SpeedTimer;
        private System.Windows.Forms.GroupBox ResultsGB;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label TopicTitleLabel;
        private System.Windows.Forms.RichTextBox RichTB;
        private System.Windows.Forms.Label Label7;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgBar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape Seperator;
        private Bunifu.Framework.UI.BunifuSwitch ResultSwitch;
        private System.Windows.Forms.Label CIncorrectLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CCorrectLabel;
        private System.Windows.Forms.Label CCountLabel;
        private System.Windows.Forms.Label CPMLabel;
        private System.Windows.Forms.Label CSecLabel;
        private System.Windows.Forms.Label WCountLabel;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton StartBtn;
        private Bunifu.Framework.UI.BunifuFlatButton StopBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ResetBtn;
        private System.Windows.Forms.Label WPMLabel;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuImageButton SettingsBtn;
    }
}

