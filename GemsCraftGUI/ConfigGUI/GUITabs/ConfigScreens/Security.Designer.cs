namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class Security
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
            this.gBlockDB = new MetroFramework.Controls.MetroTile();
            this.cBlockDBAutoEnableRank = new MetroFramework.Controls.MetroComboBox();
            this.xBlockDBAutoEnable = new System.Windows.Forms.CheckBox();
            this.xBlockDBEnabled = new System.Windows.Forms.CheckBox();
            this.gSecurityMisc = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.xAnnounceRankChangeReasons = new System.Windows.Forms.CheckBox();
            this.xRequireKickReason = new System.Windows.Forms.CheckBox();
            this.lPatrolledRankAndBelow = new MetroFramework.Controls.MetroLabel();
            this.cPatrolledRank = new MetroFramework.Controls.MetroComboBox();
            this.lPatrolledRank = new MetroFramework.Controls.MetroLabel();
            this.xAnnounceRankChanges = new System.Windows.Forms.CheckBox();
            this.xAnnounceKickAndBanReasons = new System.Windows.Forms.CheckBox();
            this.xRequireRankChangeReason = new System.Windows.Forms.CheckBox();
            this.xRequireBanReason = new System.Windows.Forms.CheckBox();
            this.txtRemotePass = new MetroFramework.Controls.MetroTextBox();
            this.lblRemotePassword = new MetroFramework.Controls.MetroLabel();
            this.gSpamChat = new MetroFramework.Controls.MetroTile();
            this.lAntispamMaxWarnings = new MetroFramework.Controls.MetroLabel();
            this.nAntispamMaxWarnings = new System.Windows.Forms.NumericUpDown();
            this.xAntispamKicks = new System.Windows.Forms.CheckBox();
            this.lSpamMuteSeconds = new MetroFramework.Controls.MetroLabel();
            this.lAntispamInterval = new MetroFramework.Controls.MetroLabel();
            this.nSpamMute = new System.Windows.Forms.NumericUpDown();
            this.lSpamMute = new MetroFramework.Controls.MetroLabel();
            this.nAntispamInterval = new System.Windows.Forms.NumericUpDown();
            this.lAntispamMessageCount = new MetroFramework.Controls.MetroLabel();
            this.nAntispamMessageCount = new System.Windows.Forms.NumericUpDown();
            this.lSpamChat = new MetroFramework.Controls.MetroLabel();
            this.gVerify = new MetroFramework.Controls.MetroTile();
            this.nMaxConnectionsPerIP = new System.Windows.Forms.NumericUpDown();
            this.xAllowUnverifiedLAN = new System.Windows.Forms.CheckBox();
            this.xMaxConnectionsPerIP = new System.Windows.Forms.CheckBox();
            this.lVerifyNames = new MetroFramework.Controls.MetroLabel();
            this.cVerifyNames = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboSelectOnTheGoRank = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chkAllowEditingConfig = new System.Windows.Forms.CheckBox();
            this.chkOnTheGo = new System.Windows.Forms.CheckBox();
            this.lPort = new MetroFramework.Controls.MetroLabel();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gBlockDB.SuspendLayout();
            this.gSecurityMisc.SuspendLayout();
            this.gSpamChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamMaxWarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSpamMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamMessageCount)).BeginInit();
            this.gVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxConnectionsPerIP)).BeginInit();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.SuspendLayout();
            // 
            // gBlockDB
            // 
            this.gBlockDB.ActiveControl = null;
            this.gBlockDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gBlockDB.Controls.Add(this.cBlockDBAutoEnableRank);
            this.gBlockDB.Controls.Add(this.xBlockDBAutoEnable);
            this.gBlockDB.Controls.Add(this.xBlockDBEnabled);
            this.gBlockDB.Location = new System.Drawing.Point(23, 150);
            this.gBlockDB.Name = "gBlockDB";
            this.gBlockDB.Size = new System.Drawing.Size(636, 88);
            this.gBlockDB.TabIndex = 5;
            this.gBlockDB.TabStop = false;
            this.gBlockDB.Text = "BlockDB";
            this.gBlockDB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.gBlockDB.UseSelectable = true;
            // 
            // cBlockDBAutoEnableRank
            // 
            this.cBlockDBAutoEnableRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBlockDBAutoEnableRank.FormattingEnabled = true;
            this.cBlockDBAutoEnableRank.ItemHeight = 23;
            this.cBlockDBAutoEnableRank.Location = new System.Drawing.Point(408, 55);
            this.cBlockDBAutoEnableRank.Name = "cBlockDBAutoEnableRank";
            this.cBlockDBAutoEnableRank.Size = new System.Drawing.Size(121, 29);
            this.cBlockDBAutoEnableRank.TabIndex = 2;
            this.cBlockDBAutoEnableRank.TabStop = false;
            this.cBlockDBAutoEnableRank.UseSelectable = true;
            // 
            // xBlockDBAutoEnable
            // 
            this.xBlockDBAutoEnable.AutoSize = true;
            this.xBlockDBAutoEnable.BackColor = System.Drawing.Color.Transparent;
            this.xBlockDBAutoEnable.Enabled = false;
            this.xBlockDBAutoEnable.Location = new System.Drawing.Point(42, 55);
            this.xBlockDBAutoEnable.Name = "xBlockDBAutoEnable";
            this.xBlockDBAutoEnable.Size = new System.Drawing.Size(319, 17);
            this.xBlockDBAutoEnable.TabIndex = 1;
            this.xBlockDBAutoEnable.TabStop = false;
            this.xBlockDBAutoEnable.Text = "Automatically enable BlockDB on worlds that can be edited by";
            this.xBlockDBAutoEnable.UseVisualStyleBackColor = false;
            // 
            // xBlockDBEnabled
            // 
            this.xBlockDBEnabled.AutoSize = true;
            this.xBlockDBEnabled.BackColor = System.Drawing.Color.Transparent;
            this.xBlockDBEnabled.Location = new System.Drawing.Point(42, 30);
            this.xBlockDBEnabled.Name = "xBlockDBEnabled";
            this.xBlockDBEnabled.Size = new System.Drawing.Size(221, 17);
            this.xBlockDBEnabled.TabIndex = 0;
            this.xBlockDBEnabled.Text = "Enable BlockDB (per-block edit tracking).";
            this.xBlockDBEnabled.UseVisualStyleBackColor = false;
            // 
            // gSecurityMisc
            // 
            this.gSecurityMisc.ActiveControl = null;
            this.gSecurityMisc.Controls.Add(this.metroLabel1);
            this.gSecurityMisc.Controls.Add(this.xAnnounceRankChangeReasons);
            this.gSecurityMisc.Controls.Add(this.xRequireKickReason);
            this.gSecurityMisc.Controls.Add(this.lPatrolledRankAndBelow);
            this.gSecurityMisc.Controls.Add(this.cPatrolledRank);
            this.gSecurityMisc.Controls.Add(this.lPatrolledRank);
            this.gSecurityMisc.Controls.Add(this.xAnnounceRankChanges);
            this.gSecurityMisc.Controls.Add(this.xAnnounceKickAndBanReasons);
            this.gSecurityMisc.Controls.Add(this.xRequireRankChangeReason);
            this.gSecurityMisc.Controls.Add(this.xRequireBanReason);
            this.gSecurityMisc.Location = new System.Drawing.Point(23, 344);
            this.gSecurityMisc.Name = "gSecurityMisc";
            this.gSecurityMisc.Size = new System.Drawing.Size(332, 227);
            this.gSecurityMisc.TabIndex = 7;
            this.gSecurityMisc.Text = "Misc";
            this.gSecurityMisc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gSecurityMisc.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(434, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 12;
            // 
            // xAnnounceRankChangeReasons
            // 
            this.xAnnounceRankChangeReasons.AutoSize = true;
            this.xAnnounceRankChangeReasons.BackColor = System.Drawing.Color.Transparent;
            this.xAnnounceRankChangeReasons.Location = new System.Drawing.Point(8, 133);
            this.xAnnounceRankChangeReasons.Name = "xAnnounceRankChangeReasons";
            this.xAnnounceRankChangeReasons.Size = new System.Drawing.Size(219, 17);
            this.xAnnounceRankChangeReasons.TabIndex = 6;
            this.xAnnounceRankChangeReasons.Text = "Announce promotion && demotion reasons";
            this.xAnnounceRankChangeReasons.UseVisualStyleBackColor = false;
            // 
            // xRequireKickReason
            // 
            this.xRequireKickReason.AutoSize = true;
            this.xRequireKickReason.BackColor = System.Drawing.Color.Transparent;
            this.xRequireKickReason.Location = new System.Drawing.Point(8, 10);
            this.xRequireKickReason.Name = "xRequireKickReason";
            this.xRequireKickReason.Size = new System.Drawing.Size(121, 17);
            this.xRequireKickReason.TabIndex = 1;
            this.xRequireKickReason.Text = "Require kick reason";
            this.xRequireKickReason.UseVisualStyleBackColor = false;
            // 
            // lPatrolledRankAndBelow
            // 
            this.lPatrolledRankAndBelow.AutoSize = true;
            this.lPatrolledRankAndBelow.Location = new System.Drawing.Point(233, 153);
            this.lPatrolledRankAndBelow.Name = "lPatrolledRankAndBelow";
            this.lPatrolledRankAndBelow.Size = new System.Drawing.Size(78, 19);
            this.lPatrolledRankAndBelow.TabIndex = 9;
            this.lPatrolledRankAndBelow.Text = "(and below)";
            // 
            // cPatrolledRank
            // 
            this.cPatrolledRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cPatrolledRank.FormattingEnabled = true;
            this.cPatrolledRank.ItemHeight = 23;
            this.cPatrolledRank.Location = new System.Drawing.Point(104, 153);
            this.cPatrolledRank.Name = "cPatrolledRank";
            this.cPatrolledRank.Size = new System.Drawing.Size(123, 29);
            this.cPatrolledRank.TabIndex = 8;
            this.cPatrolledRank.UseSelectable = true;
            this.cPatrolledRank.SelectedIndexChanged += new System.EventHandler(this.cPatrolledRank_SelectedIndexChanged);
            // 
            // lPatrolledRank
            // 
            this.lPatrolledRank.AutoSize = true;
            this.lPatrolledRank.Location = new System.Drawing.Point(8, 153);
            this.lPatrolledRank.Name = "lPatrolledRank";
            this.lPatrolledRank.Size = new System.Drawing.Size(90, 19);
            this.lPatrolledRank.TabIndex = 7;
            this.lPatrolledRank.Text = "Patrolled rank";
            this.lPatrolledRank.Click += new System.EventHandler(this.lPatrolledRank_Click);
            // 
            // xAnnounceRankChanges
            // 
            this.xAnnounceRankChanges.AutoSize = true;
            this.xAnnounceRankChanges.BackColor = System.Drawing.Color.Transparent;
            this.xAnnounceRankChanges.Location = new System.Drawing.Point(8, 108);
            this.xAnnounceRankChanges.Name = "xAnnounceRankChanges";
            this.xAnnounceRankChanges.Size = new System.Drawing.Size(201, 17);
            this.xAnnounceRankChanges.TabIndex = 5;
            this.xAnnounceRankChanges.Text = "Announce promotions and demotions";
            this.xAnnounceRankChanges.UseVisualStyleBackColor = false;
            // 
            // xAnnounceKickAndBanReasons
            // 
            this.xAnnounceKickAndBanReasons.AutoSize = true;
            this.xAnnounceKickAndBanReasons.BackColor = System.Drawing.Color.Transparent;
            this.xAnnounceKickAndBanReasons.Location = new System.Drawing.Point(8, 83);
            this.xAnnounceKickAndBanReasons.Name = "xAnnounceKickAndBanReasons";
            this.xAnnounceKickAndBanReasons.Size = new System.Drawing.Size(219, 17);
            this.xAnnounceKickAndBanReasons.TabIndex = 4;
            this.xAnnounceKickAndBanReasons.Text = "Announce kick, ban, and unban reasons";
            this.xAnnounceKickAndBanReasons.UseVisualStyleBackColor = false;
            // 
            // xRequireRankChangeReason
            // 
            this.xRequireRankChangeReason.AutoSize = true;
            this.xRequireRankChangeReason.BackColor = System.Drawing.Color.Transparent;
            this.xRequireRankChangeReason.Location = new System.Drawing.Point(8, 60);
            this.xRequireRankChangeReason.Name = "xRequireRankChangeReason";
            this.xRequireRankChangeReason.Size = new System.Drawing.Size(202, 17);
            this.xRequireRankChangeReason.TabIndex = 3;
            this.xRequireRankChangeReason.Text = "Require promotion && demotion reason";
            this.xRequireRankChangeReason.UseVisualStyleBackColor = false;
            // 
            // xRequireBanReason
            // 
            this.xRequireBanReason.AutoSize = true;
            this.xRequireBanReason.BackColor = System.Drawing.Color.Transparent;
            this.xRequireBanReason.Location = new System.Drawing.Point(8, 35);
            this.xRequireBanReason.Name = "xRequireBanReason";
            this.xRequireBanReason.Size = new System.Drawing.Size(161, 17);
            this.xRequireBanReason.TabIndex = 2;
            this.xRequireBanReason.Text = "Require ban && unban reason";
            this.xRequireBanReason.UseVisualStyleBackColor = false;
            // 
            // txtRemotePass
            // 
            // 
            // 
            // 
            this.txtRemotePass.CustomButton.Image = null;
            this.txtRemotePass.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtRemotePass.CustomButton.Name = "";
            this.txtRemotePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRemotePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemotePass.CustomButton.TabIndex = 1;
            this.txtRemotePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemotePass.CustomButton.UseSelectable = true;
            this.txtRemotePass.CustomButton.Visible = false;
            this.txtRemotePass.Lines = new string[] {
        "Password"};
            this.txtRemotePass.Location = new System.Drawing.Point(83, 36);
            this.txtRemotePass.MaxLength = 32767;
            this.txtRemotePass.Name = "txtRemotePass";
            this.txtRemotePass.PasswordChar = '*';
            this.txtRemotePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemotePass.SelectedText = "";
            this.txtRemotePass.SelectionLength = 0;
            this.txtRemotePass.SelectionStart = 0;
            this.txtRemotePass.ShortcutsEnabled = true;
            this.txtRemotePass.Size = new System.Drawing.Size(201, 23);
            this.txtRemotePass.TabIndex = 11;
            this.txtRemotePass.Text = "Password";
            this.txtRemotePass.UseSelectable = true;
            this.txtRemotePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemotePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRemotePass.Click += new System.EventHandler(this.txtRemotePass_Click);
            // 
            // lblRemotePassword
            // 
            this.lblRemotePassword.AutoSize = true;
            this.lblRemotePassword.Location = new System.Drawing.Point(14, 33);
            this.lblRemotePassword.Name = "lblRemotePassword";
            this.lblRemotePassword.Size = new System.Drawing.Size(63, 19);
            this.lblRemotePassword.TabIndex = 10;
            this.lblRemotePassword.Text = "Password";
            // 
            // gSpamChat
            // 
            this.gSpamChat.ActiveControl = null;
            this.gSpamChat.Controls.Add(this.lAntispamMaxWarnings);
            this.gSpamChat.Controls.Add(this.nAntispamMaxWarnings);
            this.gSpamChat.Controls.Add(this.xAntispamKicks);
            this.gSpamChat.Controls.Add(this.lSpamMuteSeconds);
            this.gSpamChat.Controls.Add(this.lAntispamInterval);
            this.gSpamChat.Controls.Add(this.nSpamMute);
            this.gSpamChat.Controls.Add(this.lSpamMute);
            this.gSpamChat.Controls.Add(this.nAntispamInterval);
            this.gSpamChat.Controls.Add(this.lAntispamMessageCount);
            this.gSpamChat.Controls.Add(this.nAntispamMessageCount);
            this.gSpamChat.Controls.Add(this.lSpamChat);
            this.gSpamChat.Location = new System.Drawing.Point(23, 244);
            this.gSpamChat.Name = "gSpamChat";
            this.gSpamChat.Size = new System.Drawing.Size(636, 94);
            this.gSpamChat.TabIndex = 6;
            this.gSpamChat.TabStop = false;
            this.gSpamChat.Text = "Chat Spam Prevention";
            this.gSpamChat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gSpamChat.UseSelectable = true;
            // 
            // lAntispamMaxWarnings
            // 
            this.lAntispamMaxWarnings.AutoSize = true;
            this.lAntispamMaxWarnings.Location = new System.Drawing.Point(454, 62);
            this.lAntispamMaxWarnings.Name = "lAntispamMaxWarnings";
            this.lAntispamMaxWarnings.Size = new System.Drawing.Size(60, 19);
            this.lAntispamMaxWarnings.TabIndex = 10;
            this.lAntispamMaxWarnings.Text = "warnings";
            // 
            // nAntispamMaxWarnings
            // 
            this.nAntispamMaxWarnings.Location = new System.Drawing.Point(386, 60);
            this.nAntispamMaxWarnings.Name = "nAntispamMaxWarnings";
            this.nAntispamMaxWarnings.Size = new System.Drawing.Size(62, 20);
            this.nAntispamMaxWarnings.TabIndex = 9;
            // 
            // xAntispamKicks
            // 
            this.xAntispamKicks.AutoSize = true;
            this.xAntispamKicks.BackColor = System.Drawing.Color.Transparent;
            this.xAntispamKicks.Location = new System.Drawing.Point(304, 61);
            this.xAntispamKicks.Name = "xAntispamKicks";
            this.xAntispamKicks.Size = new System.Drawing.Size(71, 17);
            this.xAntispamKicks.TabIndex = 8;
            this.xAntispamKicks.Text = "Kick after";
            this.xAntispamKicks.UseVisualStyleBackColor = false;
            // 
            // lSpamMuteSeconds
            // 
            this.lSpamMuteSeconds.AutoSize = true;
            this.lSpamMuteSeconds.Location = new System.Drawing.Point(221, 62);
            this.lSpamMuteSeconds.Name = "lSpamMuteSeconds";
            this.lSpamMuteSeconds.Size = new System.Drawing.Size(55, 19);
            this.lSpamMuteSeconds.TabIndex = 7;
            this.lSpamMuteSeconds.Text = "seconds";
            // 
            // lAntispamInterval
            // 
            this.lAntispamInterval.AutoSize = true;
            this.lAntispamInterval.Location = new System.Drawing.Point(372, 27);
            this.lAntispamInterval.Name = "lAntispamInterval";
            this.lAntispamInterval.Size = new System.Drawing.Size(55, 19);
            this.lAntispamInterval.TabIndex = 4;
            this.lAntispamInterval.Text = "seconds";
            // 
            // nSpamMute
            // 
            this.nSpamMute.Location = new System.Drawing.Point(153, 59);
            this.nSpamMute.Name = "nSpamMute";
            this.nSpamMute.Size = new System.Drawing.Size(62, 20);
            this.nSpamMute.TabIndex = 6;
            // 
            // lSpamMute
            // 
            this.lSpamMute.AutoSize = true;
            this.lSpamMute.Location = new System.Drawing.Point(27, 62);
            this.lSpamMute.Name = "lSpamMute";
            this.lSpamMute.Size = new System.Drawing.Size(120, 19);
            this.lSpamMute.TabIndex = 5;
            this.lSpamMute.Text = "Mute spammer for";
            // 
            // nAntispamInterval
            // 
            this.nAntispamInterval.Location = new System.Drawing.Point(304, 25);
            this.nAntispamInterval.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nAntispamInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAntispamInterval.Name = "nAntispamInterval";
            this.nAntispamInterval.Size = new System.Drawing.Size(62, 20);
            this.nAntispamInterval.TabIndex = 3;
            this.nAntispamInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lAntispamMessageCount
            // 
            this.lAntispamMessageCount.AutoSize = true;
            this.lAntispamMessageCount.Location = new System.Drawing.Point(219, 27);
            this.lAntispamMessageCount.Name = "lAntispamMessageCount";
            this.lAntispamMessageCount.Size = new System.Drawing.Size(79, 19);
            this.lAntispamMessageCount.TabIndex = 2;
            this.lAntispamMessageCount.Text = "messages in";
            // 
            // nAntispamMessageCount
            // 
            this.nAntispamMessageCount.Location = new System.Drawing.Point(153, 25);
            this.nAntispamMessageCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nAntispamMessageCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nAntispamMessageCount.Name = "nAntispamMessageCount";
            this.nAntispamMessageCount.Size = new System.Drawing.Size(62, 20);
            this.nAntispamMessageCount.TabIndex = 1;
            this.nAntispamMessageCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lSpamChat
            // 
            this.lSpamChat.AutoSize = true;
            this.lSpamChat.Location = new System.Drawing.Point(42, 25);
            this.lSpamChat.Name = "lSpamChat";
            this.lSpamChat.Size = new System.Drawing.Size(108, 19);
            this.lSpamChat.TabIndex = 0;
            this.lSpamChat.Text = "Limit chat rate to";
            // 
            // gVerify
            // 
            this.gVerify.ActiveControl = null;
            this.gVerify.BackColor = System.Drawing.Color.Gray;
            this.gVerify.Controls.Add(this.nMaxConnectionsPerIP);
            this.gVerify.Controls.Add(this.xAllowUnverifiedLAN);
            this.gVerify.Controls.Add(this.xMaxConnectionsPerIP);
            this.gVerify.Controls.Add(this.lVerifyNames);
            this.gVerify.Controls.Add(this.cVerifyNames);
            this.gVerify.Location = new System.Drawing.Point(23, 63);
            this.gVerify.Name = "gVerify";
            this.gVerify.Size = new System.Drawing.Size(636, 81);
            this.gVerify.TabIndex = 4;
            this.gVerify.TabStop = false;
            this.gVerify.Text = "Connection";
            this.gVerify.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.gVerify.UseSelectable = true;
            // 
            // nMaxConnectionsPerIP
            // 
            this.nMaxConnectionsPerIP.Location = new System.Drawing.Point(539, 21);
            this.nMaxConnectionsPerIP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxConnectionsPerIP.Name = "nMaxConnectionsPerIP";
            this.nMaxConnectionsPerIP.Size = new System.Drawing.Size(47, 20);
            this.nMaxConnectionsPerIP.TabIndex = 4;
            this.nMaxConnectionsPerIP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xAllowUnverifiedLAN
            // 
            this.xAllowUnverifiedLAN.AutoSize = true;
            this.xAllowUnverifiedLAN.BackColor = System.Drawing.Color.Transparent;
            this.xAllowUnverifiedLAN.Location = new System.Drawing.Point(42, 49);
            this.xAllowUnverifiedLAN.Name = "xAllowUnverifiedLAN";
            this.xAllowUnverifiedLAN.Size = new System.Drawing.Size(436, 17);
            this.xAllowUnverifiedLAN.TabIndex = 2;
            this.xAllowUnverifiedLAN.Text = "Allow connections from LAN without name verification (192.168.0.0/16 and 10.0.0.0" +
    "/8)";
            this.xAllowUnverifiedLAN.UseVisualStyleBackColor = false;
            // 
            // xMaxConnectionsPerIP
            // 
            this.xMaxConnectionsPerIP.AutoSize = true;
            this.xMaxConnectionsPerIP.BackColor = System.Drawing.Color.Transparent;
            this.xMaxConnectionsPerIP.Location = new System.Drawing.Point(304, 22);
            this.xMaxConnectionsPerIP.Name = "xMaxConnectionsPerIP";
            this.xMaxConnectionsPerIP.Size = new System.Drawing.Size(201, 17);
            this.xMaxConnectionsPerIP.TabIndex = 3;
            this.xMaxConnectionsPerIP.Text = "Limit number of connections per IP to";
            this.xMaxConnectionsPerIP.UseVisualStyleBackColor = false;
            // 
            // lVerifyNames
            // 
            this.lVerifyNames.AutoSize = true;
            this.lVerifyNames.Location = new System.Drawing.Point(35, 20);
            this.lVerifyNames.Name = "lVerifyNames";
            this.lVerifyNames.Size = new System.Drawing.Size(112, 19);
            this.lVerifyNames.TabIndex = 0;
            this.lVerifyNames.Text = "Name verification";
            // 
            // cVerifyNames
            // 
            this.cVerifyNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cVerifyNames.FormattingEnabled = true;
            this.cVerifyNames.ItemHeight = 23;
            this.cVerifyNames.Items.AddRange(new object[] {
            "None (Unsafe)",
            "Normal",
            "Strict"});
            this.cVerifyNames.Location = new System.Drawing.Point(153, 20);
            this.cVerifyNames.Name = "cVerifyNames";
            this.cVerifyNames.Size = new System.Drawing.Size(120, 29);
            this.cVerifyNames.TabIndex = 1;
            this.cVerifyNames.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.metroLabel3);
            this.metroTile1.Controls.Add(this.cboSelectOnTheGoRank);
            this.metroTile1.Controls.Add(this.metroLabel4);
            this.metroTile1.Controls.Add(this.chkAllowEditingConfig);
            this.metroTile1.Controls.Add(this.chkOnTheGo);
            this.metroTile1.Controls.Add(this.lPort);
            this.metroTile1.Controls.Add(this.nPort);
            this.metroTile1.Controls.Add(this.metroLabel2);
            this.metroTile1.Controls.Add(this.lblRemotePassword);
            this.metroTile1.Controls.Add(this.txtRemotePass);
            this.metroTile1.Location = new System.Drawing.Point(361, 344);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(298, 227);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "GemsCraft On the Go";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(147, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "(and above)";
            // 
            // cboSelectOnTheGoRank
            // 
            this.cboSelectOnTheGoRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSelectOnTheGoRank.FormattingEnabled = true;
            this.cboSelectOnTheGoRank.ItemHeight = 23;
            this.cboSelectOnTheGoRank.Location = new System.Drawing.Point(18, 130);
            this.cboSelectOnTheGoRank.Name = "cboSelectOnTheGoRank";
            this.cboSelectOnTheGoRank.Size = new System.Drawing.Size(123, 29);
            this.cboSelectOnTheGoRank.TabIndex = 18;
            this.cboSelectOnTheGoRank.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Min. Rank";
            // 
            // chkAllowEditingConfig
            // 
            this.chkAllowEditingConfig.AutoSize = true;
            this.chkAllowEditingConfig.BackColor = System.Drawing.Color.Transparent;
            this.chkAllowEditingConfig.Location = new System.Drawing.Point(18, 88);
            this.chkAllowEditingConfig.Name = "chkAllowEditingConfig";
            this.chkAllowEditingConfig.Size = new System.Drawing.Size(145, 17);
            this.chkAllowEditingConfig.TabIndex = 16;
            this.chkAllowEditingConfig.Text = "Allow Config to Be Edited";
            this.chkAllowEditingConfig.UseVisualStyleBackColor = false;
            // 
            // chkOnTheGo
            // 
            this.chkOnTheGo.AutoSize = true;
            this.chkOnTheGo.BackColor = System.Drawing.Color.Transparent;
            this.chkOnTheGo.Location = new System.Drawing.Point(18, 10);
            this.chkOnTheGo.Name = "chkOnTheGo";
            this.chkOnTheGo.Size = new System.Drawing.Size(145, 17);
            this.chkOnTheGo.TabIndex = 15;
            this.chkOnTheGo.Text = "Enable On the Go Usage";
            this.chkOnTheGo.UseVisualStyleBackColor = false;
            this.chkOnTheGo.CheckedChanged += new System.EventHandler(this.chkOnTheGo_CheckedChanged);
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(14, 66);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(84, 19);
            this.lPort.TabIndex = 13;
            this.lPort.Text = "Port number";
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(104, 65);
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
            this.nPort.TabIndex = 14;
            this.nPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(434, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 12;
            // 
            // Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 582);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.gBlockDB);
            this.Controls.Add(this.gSecurityMisc);
            this.Controls.Add(this.gSpamChat);
            this.Controls.Add(this.gVerify);
            this.Name = "Security";
            this.Text = "Security";
            this.gBlockDB.ResumeLayout(false);
            this.gBlockDB.PerformLayout();
            this.gSecurityMisc.ResumeLayout(false);
            this.gSecurityMisc.PerformLayout();
            this.gSpamChat.ResumeLayout(false);
            this.gSpamChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamMaxWarnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSpamMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamMessageCount)).EndInit();
            this.gVerify.ResumeLayout(false);
            this.gVerify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxConnectionsPerIP)).EndInit();
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTile gBlockDB;
        internal MetroFramework.Controls.MetroComboBox cBlockDBAutoEnableRank;
        internal System.Windows.Forms.CheckBox xBlockDBAutoEnable;
        internal System.Windows.Forms.CheckBox xBlockDBEnabled;
        internal MetroFramework.Controls.MetroTile gSecurityMisc;
        internal System.Windows.Forms.CheckBox xAnnounceRankChangeReasons;
        internal System.Windows.Forms.CheckBox xRequireKickReason;
        internal MetroFramework.Controls.MetroLabel lPatrolledRankAndBelow;
        internal MetroFramework.Controls.MetroComboBox cPatrolledRank;
        internal MetroFramework.Controls.MetroLabel lPatrolledRank;
        internal System.Windows.Forms.CheckBox xAnnounceRankChanges;
        internal System.Windows.Forms.CheckBox xAnnounceKickAndBanReasons;
        internal System.Windows.Forms.CheckBox xRequireRankChangeReason;
        internal System.Windows.Forms.CheckBox xRequireBanReason;
        internal MetroFramework.Controls.MetroTile gSpamChat;
        internal MetroFramework.Controls.MetroLabel lAntispamMaxWarnings;
        internal System.Windows.Forms.NumericUpDown nAntispamMaxWarnings;
        internal System.Windows.Forms.CheckBox xAntispamKicks;
        internal MetroFramework.Controls.MetroLabel lSpamMuteSeconds;
        internal MetroFramework.Controls.MetroLabel lAntispamInterval;
        internal System.Windows.Forms.NumericUpDown nSpamMute;
        internal MetroFramework.Controls.MetroLabel lSpamMute;
        internal System.Windows.Forms.NumericUpDown nAntispamInterval;
        internal MetroFramework.Controls.MetroLabel lAntispamMessageCount;
        internal System.Windows.Forms.NumericUpDown nAntispamMessageCount;
        internal MetroFramework.Controls.MetroLabel lSpamChat;
        internal MetroFramework.Controls.MetroTile gVerify;
        internal System.Windows.Forms.NumericUpDown nMaxConnectionsPerIP;
        internal System.Windows.Forms.CheckBox xAllowUnverifiedLAN;
        internal System.Windows.Forms.CheckBox xMaxConnectionsPerIP;
        internal MetroFramework.Controls.MetroLabel lVerifyNames;
        internal MetroFramework.Controls.MetroComboBox cVerifyNames;
        internal MetroFramework.Controls.MetroLabel lblRemotePassword;
        internal MetroFramework.Controls.MetroTextBox txtRemotePass;
        internal MetroFramework.Controls.MetroLabel metroLabel1;
        internal MetroFramework.Controls.MetroTile metroTile1;
        internal MetroFramework.Controls.MetroLabel metroLabel2;
        internal System.Windows.Forms.CheckBox chkOnTheGo;
        internal MetroFramework.Controls.MetroLabel lPort;
        internal System.Windows.Forms.NumericUpDown nPort;
        internal System.Windows.Forms.CheckBox chkAllowEditingConfig;
        internal MetroFramework.Controls.MetroLabel metroLabel3;
        internal MetroFramework.Controls.MetroComboBox cboSelectOnTheGoRank;
        internal MetroFramework.Controls.MetroLabel metroLabel4;
    }
}