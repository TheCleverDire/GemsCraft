namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class General
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
            this.gBasic = new MetroFramework.Controls.MetroTile();
            this.nMaxPlayersPerWorld = new System.Windows.Forms.NumericUpDown();
            this.lMaxPlayersPerWorld = new MetroFramework.Controls.MetroLabel();
            this.lPort = new MetroFramework.Controls.MetroLabel();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.cDefaultRank = new MetroFramework.Controls.MetroComboBox();
            this.lDefaultRank = new MetroFramework.Controls.MetroLabel();
            this.lUploadBandwidth = new MetroFramework.Controls.MetroLabel();
            this.bMeasure = new MetroFramework.Controls.MetroButton();
            this.tServerName = new MetroFramework.Controls.MetroTextBox();
            this.lUploadBandwidthUnits = new MetroFramework.Controls.MetroLabel();
            this.lServerName = new MetroFramework.Controls.MetroLabel();
            this.nUploadBandwidth = new System.Windows.Forms.NumericUpDown();
            this.tMOTD = new MetroFramework.Controls.MetroTextBox();
            this.lMOTD = new MetroFramework.Controls.MetroLabel();
            this.cPublic = new MetroFramework.Controls.MetroComboBox();
            this.nMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.lPublic = new MetroFramework.Controls.MetroLabel();
            this.lMaxPlayers = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new MetroFramework.Controls.MetroTile();
            this.bWiki = new MetroFramework.Controls.MetroButton();
            this.bWeb = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new MetroFramework.Controls.MetroTile();
            this.bChangelog = new MetroFramework.Controls.MetroButton();
            this.bCredits = new MetroFramework.Controls.MetroButton();
            this.bReadme = new MetroFramework.Controls.MetroButton();
            this.gInformation = new MetroFramework.Controls.MetroTile();
            this.bGreeting = new MetroFramework.Controls.MetroButton();
            this.lAnnouncementsUnits = new MetroFramework.Controls.MetroLabel();
            this.nAnnouncements = new System.Windows.Forms.NumericUpDown();
            this.xAnnouncements = new MetroFramework.Controls.MetroCheckBox();
            this.bRules = new MetroFramework.Controls.MetroButton();
            this.bAnnouncements = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayersPerWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUploadBandwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayers)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAnnouncements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBasic
            // 
            this.gBasic.ActiveControl = null;
            this.gBasic.Controls.Add(this.nMaxPlayersPerWorld);
            this.gBasic.Controls.Add(this.lMaxPlayersPerWorld);
            this.gBasic.Controls.Add(this.lPort);
            this.gBasic.Controls.Add(this.nPort);
            this.gBasic.Controls.Add(this.cDefaultRank);
            this.gBasic.Controls.Add(this.lDefaultRank);
            this.gBasic.Controls.Add(this.lUploadBandwidth);
            this.gBasic.Controls.Add(this.bMeasure);
            this.gBasic.Controls.Add(this.tServerName);
            this.gBasic.Controls.Add(this.lUploadBandwidthUnits);
            this.gBasic.Controls.Add(this.lServerName);
            this.gBasic.Controls.Add(this.nUploadBandwidth);
            this.gBasic.Controls.Add(this.tMOTD);
            this.gBasic.Controls.Add(this.lMOTD);
            this.gBasic.Controls.Add(this.cPublic);
            this.gBasic.Controls.Add(this.nMaxPlayers);
            this.gBasic.Controls.Add(this.lPublic);
            this.gBasic.Controls.Add(this.lMaxPlayers);
            this.gBasic.Location = new System.Drawing.Point(23, 63);
            this.gBasic.Name = "gBasic";
            this.gBasic.Size = new System.Drawing.Size(636, 190);
            this.gBasic.TabIndex = 6;
            this.gBasic.TabStop = false;
            this.gBasic.Text = "Basic Settings";
            this.gBasic.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.gBasic.UseSelectable = true;
            // 
            // nMaxPlayersPerWorld
            // 
            this.nMaxPlayersPerWorld.Location = new System.Drawing.Point(440, 74);
            this.nMaxPlayersPerWorld.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nMaxPlayersPerWorld.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxPlayersPerWorld.Name = "nMaxPlayersPerWorld";
            this.nMaxPlayersPerWorld.Size = new System.Drawing.Size(75, 20);
            this.nMaxPlayersPerWorld.TabIndex = 12;
            this.nMaxPlayersPerWorld.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lMaxPlayersPerWorld
            // 
            this.lMaxPlayersPerWorld.AutoSize = true;
            this.lMaxPlayersPerWorld.Location = new System.Drawing.Point(288, 76);
            this.lMaxPlayersPerWorld.Name = "lMaxPlayersPerWorld";
            this.lMaxPlayersPerWorld.Size = new System.Drawing.Size(148, 19);
            this.lMaxPlayersPerWorld.TabIndex = 11;
            this.lMaxPlayersPerWorld.Text = "Max players (per world)";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(33, 103);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(84, 19);
            this.lPort.TabIndex = 6;
            this.lPort.Text = "Port number";
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(123, 101);
            this.nPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(75, 20);
            this.nPort.TabIndex = 7;
            this.nPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cDefaultRank
            // 
            this.cDefaultRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDefaultRank.FormattingEnabled = true;
            this.cDefaultRank.ItemHeight = 23;
            this.cDefaultRank.Location = new System.Drawing.Point(440, 128);
            this.cDefaultRank.Name = "cDefaultRank";
            this.cDefaultRank.Size = new System.Drawing.Size(170, 29);
            this.cDefaultRank.TabIndex = 18;
            this.cDefaultRank.UseSelectable = true;
            // 
            // lDefaultRank
            // 
            this.lDefaultRank.AutoSize = true;
            this.lDefaultRank.Location = new System.Drawing.Point(361, 131);
            this.lDefaultRank.Name = "lDefaultRank";
            this.lDefaultRank.Size = new System.Drawing.Size(79, 19);
            this.lDefaultRank.TabIndex = 17;
            this.lDefaultRank.Text = "Default rank";
            // 
            // lUploadBandwidth
            // 
            this.lUploadBandwidth.AutoSize = true;
            this.lUploadBandwidth.Location = new System.Drawing.Point(317, 103);
            this.lUploadBandwidth.Name = "lUploadBandwidth";
            this.lUploadBandwidth.Size = new System.Drawing.Size(117, 19);
            this.lUploadBandwidth.TabIndex = 13;
            this.lUploadBandwidth.Text = "Upload bandwidth";
            // 
            // bMeasure
            // 
            this.bMeasure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bMeasure.Location = new System.Drawing.Point(559, 99);
            this.bMeasure.Name = "bMeasure";
            this.bMeasure.Size = new System.Drawing.Size(71, 23);
            this.bMeasure.TabIndex = 16;
            this.bMeasure.Text = "Measure";
            this.bMeasure.UseSelectable = true;
            // 
            // tServerName
            // 
            this.tServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tServerName.CustomButton.Image = null;
            this.tServerName.CustomButton.Location = new System.Drawing.Point(487, 1);
            this.tServerName.CustomButton.Name = "";
            this.tServerName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tServerName.CustomButton.TabIndex = 1;
            this.tServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tServerName.CustomButton.UseSelectable = true;
            this.tServerName.CustomButton.Visible = false;
            this.tServerName.Lines = new string[0];
            this.tServerName.Location = new System.Drawing.Point(123, 20);
            this.tServerName.MaxLength = 64;
            this.tServerName.Name = "tServerName";
            this.tServerName.PasswordChar = '\0';
            this.tServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tServerName.SelectedText = "";
            this.tServerName.SelectionLength = 0;
            this.tServerName.SelectionStart = 0;
            this.tServerName.ShortcutsEnabled = true;
            this.tServerName.Size = new System.Drawing.Size(507, 21);
            this.tServerName.TabIndex = 1;
            this.tServerName.UseSelectable = true;
            this.tServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lUploadBandwidthUnits
            // 
            this.lUploadBandwidthUnits.AutoSize = true;
            this.lUploadBandwidthUnits.Location = new System.Drawing.Point(521, 103);
            this.lUploadBandwidthUnits.Name = "lUploadBandwidthUnits";
            this.lUploadBandwidthUnits.Size = new System.Drawing.Size(34, 19);
            this.lUploadBandwidthUnits.TabIndex = 15;
            this.lUploadBandwidthUnits.Text = "KB/s";
            // 
            // lServerName
            // 
            this.lServerName.AutoSize = true;
            this.lServerName.Location = new System.Drawing.Point(40, 23);
            this.lServerName.Name = "lServerName";
            this.lServerName.Size = new System.Drawing.Size(84, 19);
            this.lServerName.TabIndex = 0;
            this.lServerName.Text = "Server name";
            // 
            // nUploadBandwidth
            // 
            this.nUploadBandwidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUploadBandwidth.Location = new System.Drawing.Point(440, 101);
            this.nUploadBandwidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUploadBandwidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUploadBandwidth.Name = "nUploadBandwidth";
            this.nUploadBandwidth.Size = new System.Drawing.Size(75, 20);
            this.nUploadBandwidth.TabIndex = 14;
            this.nUploadBandwidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tMOTD
            // 
            this.tMOTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tMOTD.CustomButton.Image = null;
            this.tMOTD.CustomButton.Location = new System.Drawing.Point(487, 1);
            this.tMOTD.CustomButton.Name = "";
            this.tMOTD.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tMOTD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tMOTD.CustomButton.TabIndex = 1;
            this.tMOTD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tMOTD.CustomButton.UseSelectable = true;
            this.tMOTD.CustomButton.Visible = false;
            this.tMOTD.Lines = new string[0];
            this.tMOTD.Location = new System.Drawing.Point(123, 47);
            this.tMOTD.MaxLength = 64;
            this.tMOTD.Name = "tMOTD";
            this.tMOTD.PasswordChar = '\0';
            this.tMOTD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tMOTD.SelectedText = "";
            this.tMOTD.SelectionLength = 0;
            this.tMOTD.SelectionStart = 0;
            this.tMOTD.ShortcutsEnabled = true;
            this.tMOTD.Size = new System.Drawing.Size(507, 21);
            this.tMOTD.TabIndex = 3;
            this.tMOTD.UseSelectable = true;
            this.tMOTD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tMOTD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lMOTD
            // 
            this.lMOTD.AutoSize = true;
            this.lMOTD.Location = new System.Drawing.Point(70, 47);
            this.lMOTD.Name = "lMOTD";
            this.lMOTD.Size = new System.Drawing.Size(47, 19);
            this.lMOTD.TabIndex = 2;
            this.lMOTD.Text = "MOTD";
            // 
            // cPublic
            // 
            this.cPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPublic.FormattingEnabled = true;
            this.cPublic.ItemHeight = 23;
            this.cPublic.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cPublic.Location = new System.Drawing.Point(123, 128);
            this.cPublic.Name = "cPublic";
            this.cPublic.Size = new System.Drawing.Size(75, 29);
            this.cPublic.TabIndex = 10;
            this.cPublic.UseSelectable = true;
            // 
            // nMaxPlayers
            // 
            this.nMaxPlayers.Location = new System.Drawing.Point(123, 74);
            this.nMaxPlayers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxPlayers.Name = "nMaxPlayers";
            this.nMaxPlayers.Size = new System.Drawing.Size(75, 20);
            this.nMaxPlayers.TabIndex = 5;
            this.nMaxPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lPublic
            // 
            this.lPublic.AutoSize = true;
            this.lPublic.Location = new System.Drawing.Point(14, 131);
            this.lPublic.Name = "lPublic";
            this.lPublic.Size = new System.Drawing.Size(95, 19);
            this.lPublic.TabIndex = 9;
            this.lPublic.Text = "Server visibility";
            // 
            // lMaxPlayers
            // 
            this.lMaxPlayers.AutoSize = true;
            this.lMaxPlayers.Location = new System.Drawing.Point(3, 76);
            this.lMaxPlayers.Name = "lMaxPlayers";
            this.lMaxPlayers.Size = new System.Drawing.Size(117, 19);
            this.lMaxPlayers.TabIndex = 4;
            this.lMaxPlayers.Text = "Max players (total)";
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.groupBox4.ActiveControl = null;
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.bWiki);
            this.groupBox4.Controls.Add(this.bWeb);
            this.groupBox4.Location = new System.Drawing.Point(26, 473);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 94);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Us";
            this.groupBox4.UseSelectable = true;
            // 
            // bWiki
            // 
            this.bWiki.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bWiki.Location = new System.Drawing.Point(7, 60);
            this.bWiki.Name = "bWiki";
            this.bWiki.Size = new System.Drawing.Size(111, 23);
            this.bWiki.TabIndex = 1;
            this.bWiki.Text = "Wiki";
            this.bWiki.UseSelectable = true;
            // 
            // bWeb
            // 
            this.bWeb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bWeb.Location = new System.Drawing.Point(8, 31);
            this.bWeb.Name = "bWeb";
            this.bWeb.Size = new System.Drawing.Size(110, 23);
            this.bWeb.TabIndex = 1;
            this.bWeb.Text = "Website";
            this.bWeb.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.ActiveControl = null;
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.bChangelog);
            this.groupBox2.Controls.Add(this.bCredits);
            this.groupBox2.Controls.Add(this.bReadme);
            this.groupBox2.Location = new System.Drawing.Point(26, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 135);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            this.groupBox2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.groupBox2.UseSelectable = true;
            // 
            // bChangelog
            // 
            this.bChangelog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bChangelog.Location = new System.Drawing.Point(7, 89);
            this.bChangelog.Name = "bChangelog";
            this.bChangelog.Size = new System.Drawing.Size(110, 23);
            this.bChangelog.TabIndex = 2;
            this.bChangelog.Text = "Changelog";
            this.bChangelog.UseSelectable = true;
            // 
            // bCredits
            // 
            this.bCredits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCredits.Location = new System.Drawing.Point(6, 31);
            this.bCredits.Name = "bCredits";
            this.bCredits.Size = new System.Drawing.Size(111, 23);
            this.bCredits.TabIndex = 1;
            this.bCredits.Text = "Credits";
            this.bCredits.UseSelectable = true;
            // 
            // bReadme
            // 
            this.bReadme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReadme.Location = new System.Drawing.Point(7, 60);
            this.bReadme.Name = "bReadme";
            this.bReadme.Size = new System.Drawing.Size(110, 23);
            this.bReadme.TabIndex = 1;
            this.bReadme.Text = "Readme";
            this.bReadme.UseSelectable = true;
            // 
            // gInformation
            // 
            this.gInformation.ActiveControl = null;
            this.gInformation.Controls.Add(this.bGreeting);
            this.gInformation.Controls.Add(this.lAnnouncementsUnits);
            this.gInformation.Controls.Add(this.nAnnouncements);
            this.gInformation.Controls.Add(this.xAnnouncements);
            this.gInformation.Controls.Add(this.bRules);
            this.gInformation.Controls.Add(this.bAnnouncements);
            this.gInformation.Location = new System.Drawing.Point(23, 269);
            this.gInformation.Name = "gInformation";
            this.gInformation.Size = new System.Drawing.Size(636, 57);
            this.gInformation.TabIndex = 7;
            this.gInformation.TabStop = false;
            this.gInformation.Text = "Information";
            this.gInformation.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gInformation.UseSelectable = true;
            // 
            // bGreeting
            // 
            this.bGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGreeting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGreeting.Location = new System.Drawing.Point(538, 20);
            this.bGreeting.Name = "bGreeting";
            this.bGreeting.Size = new System.Drawing.Size(92, 28);
            this.bGreeting.TabIndex = 5;
            this.bGreeting.Text = "Edit Greeting";
            this.bGreeting.UseSelectable = true;
            // 
            // lAnnouncementsUnits
            // 
            this.lAnnouncementsUnits.AutoSize = true;
            this.lAnnouncementsUnits.Location = new System.Drawing.Point(266, 27);
            this.lAnnouncementsUnits.Name = "lAnnouncementsUnits";
            this.lAnnouncementsUnits.Size = new System.Drawing.Size(31, 19);
            this.lAnnouncementsUnits.TabIndex = 2;
            this.lAnnouncementsUnits.Text = "min";
            // 
            // nAnnouncements
            // 
            this.nAnnouncements.Enabled = false;
            this.nAnnouncements.Location = new System.Drawing.Point(210, 25);
            this.nAnnouncements.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nAnnouncements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAnnouncements.Name = "nAnnouncements";
            this.nAnnouncements.Size = new System.Drawing.Size(50, 20);
            this.nAnnouncements.TabIndex = 1;
            this.nAnnouncements.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xAnnouncements
            // 
            this.xAnnouncements.AutoSize = true;
            this.xAnnouncements.BackColor = System.Drawing.Color.Firebrick;
            this.xAnnouncements.Location = new System.Drawing.Point(24, 26);
            this.xAnnouncements.Name = "xAnnouncements";
            this.xAnnouncements.Size = new System.Drawing.Size(172, 15);
            this.xAnnouncements.TabIndex = 0;
            this.xAnnouncements.Text = "Show announcements every";
            this.xAnnouncements.UseSelectable = true;
            // 
            // bRules
            // 
            this.bRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRules.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bRules.Location = new System.Drawing.Point(445, 20);
            this.bRules.Name = "bRules";
            this.bRules.Size = new System.Drawing.Size(87, 28);
            this.bRules.TabIndex = 4;
            this.bRules.Text = "Edit Rules";
            this.bRules.UseSelectable = true;
            // 
            // bAnnouncements
            // 
            this.bAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAnnouncements.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAnnouncements.Enabled = false;
            this.bAnnouncements.Location = new System.Drawing.Point(301, 20);
            this.bAnnouncements.Name = "bAnnouncements";
            this.bAnnouncements.Size = new System.Drawing.Size(138, 28);
            this.bAnnouncements.TabIndex = 3;
            this.bAnnouncements.Text = "Edit Announcements";
            this.bAnnouncements.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GemsCraftGUI.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(155, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 576);
            this.Controls.Add(this.gBasic);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gInformation);
            this.Name = "General";
            this.Text = "General";
            this.gBasic.ResumeLayout(false);
            this.gBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayersPerWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUploadBandwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayers)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gInformation.ResumeLayout(false);
            this.gInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAnnouncements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTile gBasic;
        internal System.Windows.Forms.NumericUpDown nMaxPlayersPerWorld;
        internal MetroFramework.Controls.MetroLabel lMaxPlayersPerWorld;
        internal MetroFramework.Controls.MetroLabel lPort;
        internal System.Windows.Forms.NumericUpDown nPort;
        internal MetroFramework.Controls.MetroComboBox cDefaultRank;
        internal MetroFramework.Controls.MetroLabel lDefaultRank;
        internal MetroFramework.Controls.MetroLabel lUploadBandwidth;
        internal MetroFramework.Controls.MetroButton bMeasure;
        internal MetroFramework.Controls.MetroTextBox tServerName;
        internal MetroFramework.Controls.MetroLabel lUploadBandwidthUnits;
        internal MetroFramework.Controls.MetroLabel lServerName;
        internal System.Windows.Forms.NumericUpDown nUploadBandwidth;
        internal MetroFramework.Controls.MetroTextBox tMOTD;
        internal MetroFramework.Controls.MetroLabel lMOTD;
        internal MetroFramework.Controls.MetroComboBox cPublic;
        internal System.Windows.Forms.NumericUpDown nMaxPlayers;
        internal MetroFramework.Controls.MetroLabel lPublic;
        internal MetroFramework.Controls.MetroLabel lMaxPlayers;
        internal MetroFramework.Controls.MetroTile groupBox4;
        internal MetroFramework.Controls.MetroButton bWiki;
        internal MetroFramework.Controls.MetroButton bWeb;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal MetroFramework.Controls.MetroTile groupBox2;
        internal MetroFramework.Controls.MetroButton bChangelog;
        internal MetroFramework.Controls.MetroButton bCredits;
        internal MetroFramework.Controls.MetroButton bReadme;
        internal MetroFramework.Controls.MetroTile gInformation;
        internal MetroFramework.Controls.MetroButton bGreeting;
        internal MetroFramework.Controls.MetroLabel lAnnouncementsUnits;
        internal System.Windows.Forms.NumericUpDown nAnnouncements;
        internal MetroFramework.Controls.MetroCheckBox xAnnouncements;
        internal MetroFramework.Controls.MetroButton bRules;
        internal MetroFramework.Controls.MetroButton bAnnouncements;
    }
}