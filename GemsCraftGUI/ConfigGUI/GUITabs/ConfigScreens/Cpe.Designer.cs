namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class Cpe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cpe));
            this.gboEnvColors = new MetroFramework.Controls.MetroTile();
            this.numHourLength = new System.Windows.Forms.NumericUpDown();
            this.lblHourLength = new MetroFramework.Controls.MetroLabel();
            this.chkTimeBasedSky = new System.Windows.Forms.CheckBox();
            this.chkEnvColorsAllowed = new System.Windows.Forms.CheckBox();
            this.gboMessageType = new MetroFramework.Controls.MetroTile();
            this.btnSeeKeyWords = new MetroFramework.Controls.MetroButton();
            this.chkAnnouncementMT = new System.Windows.Forms.CheckBox();
            this.chkBottomRight3 = new System.Windows.Forms.CheckBox();
            this.txtBottomRight3 = new MetroFramework.Controls.MetroTextBox();
            this.chkBottomRight2 = new System.Windows.Forms.CheckBox();
            this.txtBottomRight2 = new MetroFramework.Controls.MetroTextBox();
            this.chkBottomRight1 = new System.Windows.Forms.CheckBox();
            this.txtBottomRight1 = new MetroFramework.Controls.MetroTextBox();
            this.chkStatus3 = new System.Windows.Forms.CheckBox();
            this.txtStatus3 = new MetroFramework.Controls.MetroTextBox();
            this.chkStatus2 = new System.Windows.Forms.CheckBox();
            this.txtStatus2 = new MetroFramework.Controls.MetroTextBox();
            this.chkStatus1 = new System.Windows.Forms.CheckBox();
            this.txtStatus1 = new MetroFramework.Controls.MetroTextBox();
            this.chkMessageTypeAllowed = new System.Windows.Forms.CheckBox();
            this.gboHeldBlock = new MetroFramework.Controls.MetroTile();
            this.chkHeldBlockAllowed = new System.Windows.Forms.CheckBox();
            this.gboCustomBlocks = new MetroFramework.Controls.MetroTile();
            this.clbBlocks = new System.Windows.Forms.CheckedListBox();
            this.chkCustomBlocksAllowed = new System.Windows.Forms.CheckBox();
            this.gboClickDistance = new MetroFramework.Controls.MetroTile();
            this.chkClickDistanceAllowed = new System.Windows.Forms.CheckBox();
            this.lblAboutCPE = new MetroFramework.Controls.MetroLabel();
            this.gboEnvColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourLength)).BeginInit();
            this.gboMessageType.SuspendLayout();
            this.gboHeldBlock.SuspendLayout();
            this.gboCustomBlocks.SuspendLayout();
            this.gboClickDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboEnvColors
            // 
            this.gboEnvColors.ActiveControl = null;
            this.gboEnvColors.Controls.Add(this.numHourLength);
            this.gboEnvColors.Controls.Add(this.lblHourLength);
            this.gboEnvColors.Controls.Add(this.chkTimeBasedSky);
            this.gboEnvColors.Controls.Add(this.chkEnvColorsAllowed);
            this.gboEnvColors.Location = new System.Drawing.Point(356, 60);
            this.gboEnvColors.Name = "gboEnvColors";
            this.gboEnvColors.Size = new System.Drawing.Size(187, 136);
            this.gboEnvColors.TabIndex = 10;
            this.gboEnvColors.TabStop = false;
            this.gboEnvColors.Text = "Environment Colors";
            this.gboEnvColors.UseSelectable = true;
            // 
            // numHourLength
            // 
            this.numHourLength.Location = new System.Drawing.Point(131, 71);
            this.numHourLength.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numHourLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numHourLength.Name = "numHourLength";
            this.numHourLength.Size = new System.Drawing.Size(50, 20);
            this.numHourLength.TabIndex = 6;
            this.numHourLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numHourLength.ValueChanged += new System.EventHandler(this.numHourLength_ValueChanged);
            // 
            // lblHourLength
            // 
            this.lblHourLength.Location = new System.Drawing.Point(6, 67);
            this.lblHourLength.Name = "lblHourLength";
            this.lblHourLength.Size = new System.Drawing.Size(119, 41);
            this.lblHourLength.TabIndex = 5;
            this.lblHourLength.Text = "Day Length (in hours)";
            // 
            // chkTimeBasedSky
            // 
            this.chkTimeBasedSky.AutoSize = true;
            this.chkTimeBasedSky.BackColor = System.Drawing.Color.Transparent;
            this.chkTimeBasedSky.Location = new System.Drawing.Point(6, 45);
            this.chkTimeBasedSky.Name = "chkTimeBasedSky";
            this.chkTimeBasedSky.Size = new System.Drawing.Size(103, 17);
            this.chkTimeBasedSky.TabIndex = 4;
            this.chkTimeBasedSky.Text = "Time Based Sky";
            this.chkTimeBasedSky.UseVisualStyleBackColor = false;
            this.chkTimeBasedSky.CheckedChanged += new System.EventHandler(this.chkTimeBasedSky_CheckedChanged);
            // 
            // chkEnvColorsAllowed
            // 
            this.chkEnvColorsAllowed.AutoSize = true;
            this.chkEnvColorsAllowed.BackColor = System.Drawing.Color.Transparent;
            this.chkEnvColorsAllowed.Location = new System.Drawing.Point(6, 20);
            this.chkEnvColorsAllowed.Name = "chkEnvColorsAllowed";
            this.chkEnvColorsAllowed.Size = new System.Drawing.Size(59, 17);
            this.chkEnvColorsAllowed.TabIndex = 3;
            this.chkEnvColorsAllowed.Text = "Enable";
            this.chkEnvColorsAllowed.UseVisualStyleBackColor = false;
            this.chkEnvColorsAllowed.CheckedChanged += new System.EventHandler(this.chkEnvColorsAllowed_CheckedChanged);
            // 
            // gboMessageType
            // 
            this.gboMessageType.ActiveControl = null;
            this.gboMessageType.Controls.Add(this.btnSeeKeyWords);
            this.gboMessageType.Controls.Add(this.chkAnnouncementMT);
            this.gboMessageType.Controls.Add(this.chkBottomRight3);
            this.gboMessageType.Controls.Add(this.txtBottomRight3);
            this.gboMessageType.Controls.Add(this.chkBottomRight2);
            this.gboMessageType.Controls.Add(this.txtBottomRight2);
            this.gboMessageType.Controls.Add(this.chkBottomRight1);
            this.gboMessageType.Controls.Add(this.txtBottomRight1);
            this.gboMessageType.Controls.Add(this.chkStatus3);
            this.gboMessageType.Controls.Add(this.txtStatus3);
            this.gboMessageType.Controls.Add(this.chkStatus2);
            this.gboMessageType.Controls.Add(this.txtStatus2);
            this.gboMessageType.Controls.Add(this.chkStatus1);
            this.gboMessageType.Controls.Add(this.txtStatus1);
            this.gboMessageType.Controls.Add(this.chkMessageTypeAllowed);
            this.gboMessageType.Location = new System.Drawing.Point(242, 202);
            this.gboMessageType.Name = "gboMessageType";
            this.gboMessageType.Size = new System.Drawing.Size(322, 227);
            this.gboMessageType.TabIndex = 9;
            this.gboMessageType.TabStop = false;
            this.gboMessageType.Text = "Message Type";
            this.gboMessageType.UseSelectable = true;
            // 
            // btnSeeKeyWords
            // 
            this.btnSeeKeyWords.Location = new System.Drawing.Point(195, 194);
            this.btnSeeKeyWords.Name = "btnSeeKeyWords";
            this.btnSeeKeyWords.Size = new System.Drawing.Size(120, 23);
            this.btnSeeKeyWords.TabIndex = 15;
            this.btnSeeKeyWords.Text = "Key Words";
            this.btnSeeKeyWords.UseSelectable = true;
            this.btnSeeKeyWords.Click += new System.EventHandler(this.btnSeeKeyWords_Click);
            // 
            // chkAnnouncementMT
            // 
            this.chkAnnouncementMT.AutoSize = true;
            this.chkAnnouncementMT.BackColor = System.Drawing.Color.Transparent;
            this.chkAnnouncementMT.Location = new System.Drawing.Point(7, 43);
            this.chkAnnouncementMT.Name = "chkAnnouncementMT";
            this.chkAnnouncementMT.Size = new System.Drawing.Size(167, 17);
            this.chkAnnouncementMT.TabIndex = 14;
            this.chkAnnouncementMT.Text = "Show Announcements at Top";
            this.chkAnnouncementMT.UseVisualStyleBackColor = false;
            // 
            // chkBottomRight3
            // 
            this.chkBottomRight3.AutoSize = true;
            this.chkBottomRight3.BackColor = System.Drawing.Color.Transparent;
            this.chkBottomRight3.Location = new System.Drawing.Point(195, 112);
            this.chkBottomRight3.Name = "chkBottomRight3";
            this.chkBottomRight3.Size = new System.Drawing.Size(15, 14);
            this.chkBottomRight3.TabIndex = 12;
            this.chkBottomRight3.UseVisualStyleBackColor = false;
            this.chkBottomRight3.CheckedChanged += new System.EventHandler(this.chkBottomRight3_CheckedChanged);
            // 
            // txtBottomRight3
            // 
            // 
            // 
            // 
            this.txtBottomRight3.CustomButton.Image = null;
            this.txtBottomRight3.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtBottomRight3.CustomButton.Name = "";
            this.txtBottomRight3.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBottomRight3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBottomRight3.CustomButton.TabIndex = 1;
            this.txtBottomRight3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBottomRight3.CustomButton.UseSelectable = true;
            this.txtBottomRight3.CustomButton.Visible = false;
            this.txtBottomRight3.Lines = new string[0];
            this.txtBottomRight3.Location = new System.Drawing.Point(216, 112);
            this.txtBottomRight3.MaxLength = 32767;
            this.txtBottomRight3.Name = "txtBottomRight3";
            this.txtBottomRight3.PasswordChar = '\0';
            this.txtBottomRight3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBottomRight3.SelectedText = "";
            this.txtBottomRight3.SelectionLength = 0;
            this.txtBottomRight3.SelectionStart = 0;
            this.txtBottomRight3.ShortcutsEnabled = true;
            this.txtBottomRight3.Size = new System.Drawing.Size(100, 21);
            this.txtBottomRight3.TabIndex = 11;
            this.txtBottomRight3.UseSelectable = true;
            this.txtBottomRight3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBottomRight3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkBottomRight2
            // 
            this.chkBottomRight2.AutoSize = true;
            this.chkBottomRight2.BackColor = System.Drawing.Color.Transparent;
            this.chkBottomRight2.Location = new System.Drawing.Point(195, 139);
            this.chkBottomRight2.Name = "chkBottomRight2";
            this.chkBottomRight2.Size = new System.Drawing.Size(15, 14);
            this.chkBottomRight2.TabIndex = 10;
            this.chkBottomRight2.UseVisualStyleBackColor = false;
            this.chkBottomRight2.CheckedChanged += new System.EventHandler(this.chkBottomRight2_CheckedChanged);
            // 
            // txtBottomRight2
            // 
            // 
            // 
            // 
            this.txtBottomRight2.CustomButton.Image = null;
            this.txtBottomRight2.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtBottomRight2.CustomButton.Name = "";
            this.txtBottomRight2.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBottomRight2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBottomRight2.CustomButton.TabIndex = 1;
            this.txtBottomRight2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBottomRight2.CustomButton.UseSelectable = true;
            this.txtBottomRight2.CustomButton.Visible = false;
            this.txtBottomRight2.Lines = new string[0];
            this.txtBottomRight2.Location = new System.Drawing.Point(216, 139);
            this.txtBottomRight2.MaxLength = 32767;
            this.txtBottomRight2.Name = "txtBottomRight2";
            this.txtBottomRight2.PasswordChar = '\0';
            this.txtBottomRight2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBottomRight2.SelectedText = "";
            this.txtBottomRight2.SelectionLength = 0;
            this.txtBottomRight2.SelectionStart = 0;
            this.txtBottomRight2.ShortcutsEnabled = true;
            this.txtBottomRight2.Size = new System.Drawing.Size(100, 21);
            this.txtBottomRight2.TabIndex = 9;
            this.txtBottomRight2.UseSelectable = true;
            this.txtBottomRight2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBottomRight2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkBottomRight1
            // 
            this.chkBottomRight1.AutoSize = true;
            this.chkBottomRight1.BackColor = System.Drawing.Color.Transparent;
            this.chkBottomRight1.Location = new System.Drawing.Point(195, 166);
            this.chkBottomRight1.Name = "chkBottomRight1";
            this.chkBottomRight1.Size = new System.Drawing.Size(15, 14);
            this.chkBottomRight1.TabIndex = 8;
            this.chkBottomRight1.UseVisualStyleBackColor = false;
            this.chkBottomRight1.CheckedChanged += new System.EventHandler(this.chkBottomRight1_CheckedChanged);
            // 
            // txtBottomRight1
            // 
            // 
            // 
            // 
            this.txtBottomRight1.CustomButton.Image = null;
            this.txtBottomRight1.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtBottomRight1.CustomButton.Name = "";
            this.txtBottomRight1.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBottomRight1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBottomRight1.CustomButton.TabIndex = 1;
            this.txtBottomRight1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBottomRight1.CustomButton.UseSelectable = true;
            this.txtBottomRight1.CustomButton.Visible = false;
            this.txtBottomRight1.Lines = new string[0];
            this.txtBottomRight1.Location = new System.Drawing.Point(216, 166);
            this.txtBottomRight1.MaxLength = 32767;
            this.txtBottomRight1.Name = "txtBottomRight1";
            this.txtBottomRight1.PasswordChar = '\0';
            this.txtBottomRight1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBottomRight1.SelectedText = "";
            this.txtBottomRight1.SelectionLength = 0;
            this.txtBottomRight1.SelectionStart = 0;
            this.txtBottomRight1.ShortcutsEnabled = true;
            this.txtBottomRight1.Size = new System.Drawing.Size(100, 21);
            this.txtBottomRight1.TabIndex = 7;
            this.txtBottomRight1.UseSelectable = true;
            this.txtBottomRight1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBottomRight1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkStatus3
            // 
            this.chkStatus3.AutoSize = true;
            this.chkStatus3.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus3.Location = new System.Drawing.Point(195, 75);
            this.chkStatus3.Name = "chkStatus3";
            this.chkStatus3.Size = new System.Drawing.Size(15, 14);
            this.chkStatus3.TabIndex = 6;
            this.chkStatus3.UseVisualStyleBackColor = false;
            this.chkStatus3.CheckedChanged += new System.EventHandler(this.chkStatus3_CheckedChanged);
            // 
            // txtStatus3
            // 
            // 
            // 
            // 
            this.txtStatus3.CustomButton.Image = null;
            this.txtStatus3.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtStatus3.CustomButton.Name = "";
            this.txtStatus3.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtStatus3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus3.CustomButton.TabIndex = 1;
            this.txtStatus3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus3.CustomButton.UseSelectable = true;
            this.txtStatus3.CustomButton.Visible = false;
            this.txtStatus3.Lines = new string[0];
            this.txtStatus3.Location = new System.Drawing.Point(216, 75);
            this.txtStatus3.MaxLength = 32767;
            this.txtStatus3.Name = "txtStatus3";
            this.txtStatus3.PasswordChar = '\0';
            this.txtStatus3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus3.SelectedText = "";
            this.txtStatus3.SelectionLength = 0;
            this.txtStatus3.SelectionStart = 0;
            this.txtStatus3.ShortcutsEnabled = true;
            this.txtStatus3.Size = new System.Drawing.Size(100, 21);
            this.txtStatus3.TabIndex = 5;
            this.txtStatus3.UseSelectable = true;
            this.txtStatus3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkStatus2
            // 
            this.chkStatus2.AutoSize = true;
            this.chkStatus2.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus2.Location = new System.Drawing.Point(195, 48);
            this.chkStatus2.Name = "chkStatus2";
            this.chkStatus2.Size = new System.Drawing.Size(15, 14);
            this.chkStatus2.TabIndex = 4;
            this.chkStatus2.UseVisualStyleBackColor = false;
            this.chkStatus2.CheckedChanged += new System.EventHandler(this.chkStatus2_CheckedChanged);
            // 
            // txtStatus2
            // 
            // 
            // 
            // 
            this.txtStatus2.CustomButton.Image = null;
            this.txtStatus2.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtStatus2.CustomButton.Name = "";
            this.txtStatus2.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtStatus2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus2.CustomButton.TabIndex = 1;
            this.txtStatus2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus2.CustomButton.UseSelectable = true;
            this.txtStatus2.CustomButton.Visible = false;
            this.txtStatus2.Lines = new string[0];
            this.txtStatus2.Location = new System.Drawing.Point(216, 48);
            this.txtStatus2.MaxLength = 32767;
            this.txtStatus2.Name = "txtStatus2";
            this.txtStatus2.PasswordChar = '\0';
            this.txtStatus2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus2.SelectedText = "";
            this.txtStatus2.SelectionLength = 0;
            this.txtStatus2.SelectionStart = 0;
            this.txtStatus2.ShortcutsEnabled = true;
            this.txtStatus2.Size = new System.Drawing.Size(100, 21);
            this.txtStatus2.TabIndex = 3;
            this.txtStatus2.UseSelectable = true;
            this.txtStatus2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkStatus1
            // 
            this.chkStatus1.AutoSize = true;
            this.chkStatus1.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus1.Location = new System.Drawing.Point(195, 21);
            this.chkStatus1.Name = "chkStatus1";
            this.chkStatus1.Size = new System.Drawing.Size(15, 14);
            this.chkStatus1.TabIndex = 2;
            this.chkStatus1.UseVisualStyleBackColor = false;
            this.chkStatus1.CheckedChanged += new System.EventHandler(this.chkStatus1_CheckedChanged);
            // 
            // txtStatus1
            // 
            // 
            // 
            // 
            this.txtStatus1.CustomButton.Image = null;
            this.txtStatus1.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtStatus1.CustomButton.Name = "";
            this.txtStatus1.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtStatus1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus1.CustomButton.TabIndex = 1;
            this.txtStatus1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus1.CustomButton.UseSelectable = true;
            this.txtStatus1.CustomButton.Visible = false;
            this.txtStatus1.Lines = new string[0];
            this.txtStatus1.Location = new System.Drawing.Point(216, 21);
            this.txtStatus1.MaxLength = 32767;
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.PasswordChar = '\0';
            this.txtStatus1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus1.SelectedText = "";
            this.txtStatus1.SelectionLength = 0;
            this.txtStatus1.SelectionStart = 0;
            this.txtStatus1.ShortcutsEnabled = true;
            this.txtStatus1.Size = new System.Drawing.Size(100, 21);
            this.txtStatus1.TabIndex = 1;
            this.txtStatus1.UseSelectable = true;
            this.txtStatus1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkMessageTypeAllowed
            // 
            this.chkMessageTypeAllowed.AutoSize = true;
            this.chkMessageTypeAllowed.BackColor = System.Drawing.Color.Transparent;
            this.chkMessageTypeAllowed.Location = new System.Drawing.Point(7, 21);
            this.chkMessageTypeAllowed.Name = "chkMessageTypeAllowed";
            this.chkMessageTypeAllowed.Size = new System.Drawing.Size(65, 17);
            this.chkMessageTypeAllowed.TabIndex = 0;
            this.chkMessageTypeAllowed.Text = "Enabled";
            this.chkMessageTypeAllowed.UseVisualStyleBackColor = false;
            this.chkMessageTypeAllowed.CheckedChanged += new System.EventHandler(this.chkMessageTypeAllowed_CheckedChanged);
            // 
            // gboHeldBlock
            // 
            this.gboHeldBlock.ActiveControl = null;
            this.gboHeldBlock.Controls.Add(this.chkHeldBlockAllowed);
            this.gboHeldBlock.Location = new System.Drawing.Point(549, 127);
            this.gboHeldBlock.Name = "gboHeldBlock";
            this.gboHeldBlock.Size = new System.Drawing.Size(109, 69);
            this.gboHeldBlock.TabIndex = 7;
            this.gboHeldBlock.TabStop = false;
            this.gboHeldBlock.Text = "Held Block";
            this.gboHeldBlock.UseSelectable = true;
            // 
            // chkHeldBlockAllowed
            // 
            this.chkHeldBlockAllowed.AutoSize = true;
            this.chkHeldBlockAllowed.BackColor = System.Drawing.Color.Transparent;
            this.chkHeldBlockAllowed.Location = new System.Drawing.Point(7, 21);
            this.chkHeldBlockAllowed.Name = "chkHeldBlockAllowed";
            this.chkHeldBlockAllowed.Size = new System.Drawing.Size(59, 17);
            this.chkHeldBlockAllowed.TabIndex = 0;
            this.chkHeldBlockAllowed.Text = "Enable";
            this.chkHeldBlockAllowed.UseVisualStyleBackColor = false;
            this.chkHeldBlockAllowed.CheckedChanged += new System.EventHandler(this.chkHeldBlockAllowed_CheckedChanged);
            // 
            // gboCustomBlocks
            // 
            this.gboCustomBlocks.ActiveControl = null;
            this.gboCustomBlocks.Controls.Add(this.clbBlocks);
            this.gboCustomBlocks.Controls.Add(this.chkCustomBlocksAllowed);
            this.gboCustomBlocks.Location = new System.Drawing.Point(242, 60);
            this.gboCustomBlocks.Name = "gboCustomBlocks";
            this.gboCustomBlocks.Size = new System.Drawing.Size(109, 136);
            this.gboCustomBlocks.TabIndex = 8;
            this.gboCustomBlocks.TabStop = false;
            this.gboCustomBlocks.Text = "Custom Blocks";
            this.gboCustomBlocks.UseSelectable = true;
            // 
            // clbBlocks
            // 
            this.clbBlocks.FormattingEnabled = true;
            this.clbBlocks.Location = new System.Drawing.Point(6, 47);
            this.clbBlocks.Name = "clbBlocks";
            this.clbBlocks.Size = new System.Drawing.Size(94, 49);
            this.clbBlocks.TabIndex = 2;
            // 
            // chkCustomBlocksAllowed
            // 
            this.chkCustomBlocksAllowed.AutoSize = true;
            this.chkCustomBlocksAllowed.BackColor = System.Drawing.Color.Transparent;
            this.chkCustomBlocksAllowed.Location = new System.Drawing.Point(6, 21);
            this.chkCustomBlocksAllowed.Name = "chkCustomBlocksAllowed";
            this.chkCustomBlocksAllowed.Size = new System.Drawing.Size(59, 17);
            this.chkCustomBlocksAllowed.TabIndex = 1;
            this.chkCustomBlocksAllowed.Text = "Enable";
            this.chkCustomBlocksAllowed.UseVisualStyleBackColor = false;
            this.chkCustomBlocksAllowed.CheckedChanged += new System.EventHandler(this.chkCustomBlocksAllowed_CheckedChanged);
            // 
            // gboClickDistance
            // 
            this.gboClickDistance.ActiveControl = null;
            this.gboClickDistance.Controls.Add(this.chkClickDistanceAllowed);
            this.gboClickDistance.Location = new System.Drawing.Point(549, 60);
            this.gboClickDistance.Name = "gboClickDistance";
            this.gboClickDistance.Size = new System.Drawing.Size(109, 65);
            this.gboClickDistance.TabIndex = 6;
            this.gboClickDistance.TabStop = false;
            this.gboClickDistance.Text = "Click Distance";
            this.gboClickDistance.UseSelectable = true;
            // 
            // chkClickDistanceAllowed
            // 
            this.chkClickDistanceAllowed.AutoSize = true;
            this.chkClickDistanceAllowed.BackColor = System.Drawing.Color.Transparent;
            this.chkClickDistanceAllowed.Location = new System.Drawing.Point(7, 21);
            this.chkClickDistanceAllowed.Name = "chkClickDistanceAllowed";
            this.chkClickDistanceAllowed.Size = new System.Drawing.Size(59, 17);
            this.chkClickDistanceAllowed.TabIndex = 0;
            this.chkClickDistanceAllowed.Text = "Enable";
            this.chkClickDistanceAllowed.UseVisualStyleBackColor = false;
            this.chkClickDistanceAllowed.CheckedChanged += new System.EventHandler(this.chkClickDistanceAllowed_CheckedChanged);
            // 
            // lblAboutCPE
            // 
            this.lblAboutCPE.Location = new System.Drawing.Point(23, 60);
            this.lblAboutCPE.Name = "lblAboutCPE";
            this.lblAboutCPE.Size = new System.Drawing.Size(209, 179);
            this.lblAboutCPE.TabIndex = 5;
            this.lblAboutCPE.Text = resources.GetString("lblAboutCPE.Text");
            this.lblAboutCPE.WrapToLine = true;
            // 
            // Cpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 555);
            this.Controls.Add(this.gboEnvColors);
            this.Controls.Add(this.gboMessageType);
            this.Controls.Add(this.gboHeldBlock);
            this.Controls.Add(this.gboCustomBlocks);
            this.Controls.Add(this.gboClickDistance);
            this.Controls.Add(this.lblAboutCPE);
            this.Name = "Cpe";
            this.Text = "Cpe";
            this.gboEnvColors.ResumeLayout(false);
            this.gboEnvColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourLength)).EndInit();
            this.gboMessageType.ResumeLayout(false);
            this.gboMessageType.PerformLayout();
            this.gboHeldBlock.ResumeLayout(false);
            this.gboHeldBlock.PerformLayout();
            this.gboCustomBlocks.ResumeLayout(false);
            this.gboCustomBlocks.PerformLayout();
            this.gboClickDistance.ResumeLayout(false);
            this.gboClickDistance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTile gboEnvColors;
        internal System.Windows.Forms.NumericUpDown numHourLength;
        internal MetroFramework.Controls.MetroLabel lblHourLength;
        internal System.Windows.Forms.CheckBox chkTimeBasedSky;
        internal System.Windows.Forms.CheckBox chkEnvColorsAllowed;
        internal MetroFramework.Controls.MetroTile gboMessageType;
        internal MetroFramework.Controls.MetroButton btnSeeKeyWords;
        internal System.Windows.Forms.CheckBox chkAnnouncementMT;
        internal System.Windows.Forms.CheckBox chkBottomRight3;
        internal MetroFramework.Controls.MetroTextBox txtBottomRight3;
        internal System.Windows.Forms.CheckBox chkBottomRight2;
        internal MetroFramework.Controls.MetroTextBox txtBottomRight2;
        internal System.Windows.Forms.CheckBox chkBottomRight1;
        internal MetroFramework.Controls.MetroTextBox txtBottomRight1;
        internal System.Windows.Forms.CheckBox chkStatus3;
        internal MetroFramework.Controls.MetroTextBox txtStatus3;
        internal System.Windows.Forms.CheckBox chkStatus2;
        internal MetroFramework.Controls.MetroTextBox txtStatus2;
        internal System.Windows.Forms.CheckBox chkStatus1;
        internal MetroFramework.Controls.MetroTextBox txtStatus1;
        internal System.Windows.Forms.CheckBox chkMessageTypeAllowed;
        internal MetroFramework.Controls.MetroTile gboHeldBlock;
        internal System.Windows.Forms.CheckBox chkHeldBlockAllowed;
        internal MetroFramework.Controls.MetroTile gboCustomBlocks;
        internal System.Windows.Forms.CheckedListBox clbBlocks;
        internal System.Windows.Forms.CheckBox chkCustomBlocksAllowed;
        internal MetroFramework.Controls.MetroTile gboClickDistance;
        internal System.Windows.Forms.CheckBox chkClickDistanceAllowed;
        internal MetroFramework.Controls.MetroLabel lblAboutCPE;
    }
}