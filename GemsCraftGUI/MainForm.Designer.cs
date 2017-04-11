using GemsCraftGUI.ConfigGUI;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace GemsCraftGUI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.bApply = new MetroFramework.Controls.MetroButton();
            this.bResetAll = new MetroFramework.Controls.MetroButton();
            this.bResetTab = new MetroFramework.Controls.MetroButton();
            this.bCancel = new MetroFramework.Controls.MetroButton();
            this.bOK = new MetroFramework.Controls.MetroButton();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabRanks = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gPermissionLimits = new MetroFramework.Controls.MetroTile();
            this.permissionLimitBoxContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lRankList = new MetroFramework.Controls.MetroLabel();
            this.bLowerRank = new MetroFramework.Controls.MetroButton();
            this.bRaiseRank = new MetroFramework.Controls.MetroButton();
            this.gRankOptions = new MetroFramework.Controls.MetroTile();
            this.lFillLimitUnits = new MetroFramework.Controls.MetroLabel();
            this.nFillLimit = new System.Windows.Forms.NumericUpDown();
            this.lFillLimit = new MetroFramework.Controls.MetroLabel();
            this.nCopyPasteSlots = new System.Windows.Forms.NumericUpDown();
            this.lCopyPasteSlots = new MetroFramework.Controls.MetroLabel();
            this.xAllowSecurityCircumvention = new MetroFramework.Controls.MetroCheckBox();
            this.lAntiGrief1 = new MetroFramework.Controls.MetroLabel();
            this.lAntiGrief3 = new MetroFramework.Controls.MetroLabel();
            this.nAntiGriefSeconds = new System.Windows.Forms.NumericUpDown();
            this.bColorRank = new MetroFramework.Controls.MetroButton();
            this.xDrawLimit = new MetroFramework.Controls.MetroCheckBox();
            this.lDrawLimitUnits = new MetroFramework.Controls.MetroLabel();
            this.lKickIdleUnits = new MetroFramework.Controls.MetroLabel();
            this.nDrawLimit = new System.Windows.Forms.NumericUpDown();
            this.nKickIdle = new System.Windows.Forms.NumericUpDown();
            this.xAntiGrief = new MetroFramework.Controls.MetroCheckBox();
            this.lAntiGrief2 = new MetroFramework.Controls.MetroLabel();
            this.xKickIdle = new MetroFramework.Controls.MetroCheckBox();
            this.nAntiGriefBlocks = new System.Windows.Forms.NumericUpDown();
            this.xReserveSlot = new MetroFramework.Controls.MetroCheckBox();
            this.tPrefix = new MetroFramework.Controls.MetroTextBox();
            this.lPrefix = new MetroFramework.Controls.MetroLabel();
            this.lRankColor = new MetroFramework.Controls.MetroLabel();
            this.tRankName = new MetroFramework.Controls.MetroTextBox();
            this.lRankName = new MetroFramework.Controls.MetroLabel();
            this.bDeleteRank = new MetroFramework.Controls.MetroButton();
            this.vPermissions = new MetroFramework.Controls.MetroListView();
            this.chPermissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bAddRank = new MetroFramework.Controls.MetroButton();
            this.lPermissions = new MetroFramework.Controls.MetroLabel();
            this.vRanks = new System.Windows.Forms.ListBox();
            this.tabGeneral = new MetroFramework.Controls.MetroTabPage();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.tabChat = new MetroFramework.Controls.MetroTabPage();
            this.chatPreview1 = new fCraft.ConfigGUI.ChatPreview();
            this.gAppearence = new MetroFramework.Controls.MetroTile();
            this.xShowConnectionMessages = new MetroFramework.Controls.MetroCheckBox();
            this.xShowJoinedWorldMessages = new MetroFramework.Controls.MetroCheckBox();
            this.xRankColorsInWorldNames = new MetroFramework.Controls.MetroCheckBox();
            this.xRankPrefixesInList = new MetroFramework.Controls.MetroCheckBox();
            this.xRankPrefixesInChat = new MetroFramework.Controls.MetroCheckBox();
            this.xRankColorsInChat = new MetroFramework.Controls.MetroCheckBox();
            this.gChatColors = new MetroFramework.Controls.MetroTile();
            this.lColorMe = new MetroFramework.Controls.MetroLabel();
            this.bColorGlobal = new MetroFramework.Controls.MetroButton();
            this.bColorMe = new MetroFramework.Controls.MetroButton();
            this.lColorWarning = new MetroFramework.Controls.MetroLabel();
            this.bColorWarning = new MetroFramework.Controls.MetroButton();
            this.bColorSys = new MetroFramework.Controls.MetroButton();
            this.lColorSys = new MetroFramework.Controls.MetroLabel();
            this.bColorPM = new MetroFramework.Controls.MetroButton();
            this.lColorHelp = new MetroFramework.Controls.MetroLabel();
            this.lColorPM = new MetroFramework.Controls.MetroLabel();
            this.IColorGlobal = new MetroFramework.Controls.MetroLabel();
            this.lColorSay = new MetroFramework.Controls.MetroLabel();
            this.bColorAnnouncement = new MetroFramework.Controls.MetroButton();
            this.lColorAnnouncement = new MetroFramework.Controls.MetroLabel();
            this.bColorHelp = new MetroFramework.Controls.MetroButton();
            this.bColorSay = new MetroFramework.Controls.MetroButton();
            this.tabWorlds = new MetroFramework.Controls.MetroTabPage();
            this.mcbPrison = new MetroFramework.Controls.MetroCheckBox();
            this.cboPrison = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.xWoMEnableEnvExtensions = new MetroFramework.Controls.MetroCheckBox();
            this.bMapPath = new MetroFramework.Controls.MetroButton();
            this.xMapPath = new MetroFramework.Controls.MetroCheckBox();
            this.tMapPath = new MetroFramework.Controls.MetroTextBox();
            this.lDefaultBuildRank = new MetroFramework.Controls.MetroLabel();
            this.cDefaultBuildRank = new MetroFramework.Controls.MetroComboBox();
            this.cMainWorld = new MetroFramework.Controls.MetroComboBox();
            this.lMainWorld = new MetroFramework.Controls.MetroLabel();
            this.bWorldEdit = new MetroFramework.Controls.MetroButton();
            this.bAddWorld = new MetroFramework.Controls.MetroButton();
            this.bWorldDelete = new MetroFramework.Controls.MetroButton();
            this.dgvWorlds = new System.Windows.Forms.DataGridView();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAccess = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcBuild = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcBackup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcHidden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcBlockDB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSecurity = new MetroFramework.Controls.MetroTabPage();
            this.gBlockDB = new MetroFramework.Controls.MetroTile();
            this.cBlockDBAutoEnableRank = new MetroFramework.Controls.MetroComboBox();
            this.xBlockDBAutoEnable = new MetroFramework.Controls.MetroCheckBox();
            this.xBlockDBEnabled = new MetroFramework.Controls.MetroCheckBox();
            this.gSecurityMisc = new MetroFramework.Controls.MetroTile();
            this.xAnnounceRankChangeReasons = new MetroFramework.Controls.MetroCheckBox();
            this.xRequireKickReason = new MetroFramework.Controls.MetroCheckBox();
            this.lPatrolledRankAndBelow = new MetroFramework.Controls.MetroLabel();
            this.cPatrolledRank = new MetroFramework.Controls.MetroComboBox();
            this.lPatrolledRank = new MetroFramework.Controls.MetroLabel();
            this.xAnnounceRankChanges = new MetroFramework.Controls.MetroCheckBox();
            this.xAnnounceKickAndBanReasons = new MetroFramework.Controls.MetroCheckBox();
            this.xRequireRankChangeReason = new MetroFramework.Controls.MetroCheckBox();
            this.xRequireBanReason = new MetroFramework.Controls.MetroCheckBox();
            this.gSpamChat = new MetroFramework.Controls.MetroTile();
            this.lAntispamMaxWarnings = new MetroFramework.Controls.MetroLabel();
            this.nAntispamMaxWarnings = new System.Windows.Forms.NumericUpDown();
            this.xAntispamKicks = new MetroFramework.Controls.MetroCheckBox();
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
            this.xAllowUnverifiedLAN = new MetroFramework.Controls.MetroCheckBox();
            this.xMaxConnectionsPerIP = new MetroFramework.Controls.MetroCheckBox();
            this.lVerifyNames = new MetroFramework.Controls.MetroLabel();
            this.cVerifyNames = new MetroFramework.Controls.MetroComboBox();
            this.gUpdate = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new MetroFramework.Controls.MetroTile();
            this.bUpdate = new MetroFramework.Controls.MetroButton();
            this.checkUpdate = new MetroFramework.Controls.MetroCheckBox();
            this.gDataBackup = new MetroFramework.Controls.MetroTile();
            this.xBackupDataOnStartup = new MetroFramework.Controls.MetroCheckBox();
            this.gSaving = new MetroFramework.Controls.MetroTile();
            this.nSaveInterval = new System.Windows.Forms.NumericUpDown();
            this.lSaveIntervalUnits = new MetroFramework.Controls.MetroLabel();
            this.xSaveInterval = new MetroFramework.Controls.MetroCheckBox();
            this.gBackups = new MetroFramework.Controls.MetroTile();
            this.xBackupOnlyWhenChanged = new MetroFramework.Controls.MetroCheckBox();
            this.lMaxBackupSize = new MetroFramework.Controls.MetroLabel();
            this.xMaxBackupSize = new MetroFramework.Controls.MetroCheckBox();
            this.nMaxBackupSize = new System.Windows.Forms.NumericUpDown();
            this.xMaxBackups = new MetroFramework.Controls.MetroCheckBox();
            this.xBackupOnStartup = new MetroFramework.Controls.MetroCheckBox();
            this.lMaxBackups = new MetroFramework.Controls.MetroLabel();
            this.nMaxBackups = new System.Windows.Forms.NumericUpDown();
            this.nBackupInterval = new System.Windows.Forms.NumericUpDown();
            this.lBackupIntervalUnits = new MetroFramework.Controls.MetroLabel();
            this.xBackupInterval = new MetroFramework.Controls.MetroCheckBox();
            this.xBackupOnJoin = new MetroFramework.Controls.MetroCheckBox();
            this.tabLogging = new MetroFramework.Controls.MetroTabPage();
            this.gLogFile = new MetroFramework.Controls.MetroTile();
            this.lLogFileOptionsDescription = new MetroFramework.Controls.MetroLabel();
            this.xLogLimit = new MetroFramework.Controls.MetroCheckBox();
            this.vLogFileOptions = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lLogLimitUnits = new MetroFramework.Controls.MetroLabel();
            this.nLogLimit = new System.Windows.Forms.NumericUpDown();
            this.cLogMode = new MetroFramework.Controls.MetroComboBox();
            this.lLogMode = new MetroFramework.Controls.MetroLabel();
            this.gConsole = new MetroFramework.Controls.MetroTile();
            this.lLogConsoleOptionsDescription = new MetroFramework.Controls.MetroLabel();
            this.vConsoleOptions = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabIRC = new MetroFramework.Controls.MetroTabPage();
            this.gIRCAdv = new MetroFramework.Controls.MetroTile();
            this.tServPass = new MetroFramework.Controls.MetroTextBox();
            this.xServPass = new MetroFramework.Controls.MetroCheckBox();
            this.tChanPass = new MetroFramework.Controls.MetroTextBox();
            this.xChanPass = new MetroFramework.Controls.MetroCheckBox();
            this.xIRCListShowNonEnglish = new MetroFramework.Controls.MetroCheckBox();
            this.gIRCOptions = new MetroFramework.Controls.MetroTile();
            this.xIRCBotAnnounceServerEvents = new MetroFramework.Controls.MetroCheckBox();
            this.xIRCUseColor = new MetroFramework.Controls.MetroCheckBox();
            this.lIRCNoForwardingMessage = new MetroFramework.Controls.MetroLabel();
            this.xIRCBotAnnounceIRCJoins = new MetroFramework.Controls.MetroCheckBox();
            this.bColorIRC = new MetroFramework.Controls.MetroButton();
            this.lColorIRC = new MetroFramework.Controls.MetroLabel();
            this.xIRCBotForwardFromIRC = new MetroFramework.Controls.MetroCheckBox();
            this.xIRCBotAnnounceServerJoins = new MetroFramework.Controls.MetroCheckBox();
            this.xIRCBotForwardFromServer = new MetroFramework.Controls.MetroCheckBox();
            this.gIRCNetwork = new MetroFramework.Controls.MetroTile();
            this.lIRCDelayUnits = new MetroFramework.Controls.MetroLabel();
            this.xIRCRegisteredNick = new MetroFramework.Controls.MetroCheckBox();
            this.tIRCNickServMessage = new MetroFramework.Controls.MetroTextBox();
            this.lIRCNickServMessage = new MetroFramework.Controls.MetroLabel();
            this.tIRCNickServ = new MetroFramework.Controls.MetroTextBox();
            this.lIRCNickServ = new MetroFramework.Controls.MetroLabel();
            this.nIRCDelay = new System.Windows.Forms.NumericUpDown();
            this.lIRCDelay = new MetroFramework.Controls.MetroLabel();
            this.lIRCBotChannels2 = new MetroFramework.Controls.MetroLabel();
            this.lIRCBotChannels3 = new MetroFramework.Controls.MetroLabel();
            this.tIRCBotChannels = new MetroFramework.Controls.MetroTextBox();
            this.lIRCBotChannels = new MetroFramework.Controls.MetroLabel();
            this.nIRCBotPort = new System.Windows.Forms.NumericUpDown();
            this.lIRCBotPort = new MetroFramework.Controls.MetroLabel();
            this.tIRCBotNetwork = new MetroFramework.Controls.MetroTextBox();
            this.lIRCBotNetwork = new MetroFramework.Controls.MetroLabel();
            this.lIRCBotNick = new MetroFramework.Controls.MetroLabel();
            this.tIRCBotNick = new MetroFramework.Controls.MetroTextBox();
            this.lIRCList = new MetroFramework.Controls.MetroLabel();
            this.xIRCBotEnabled = new MetroFramework.Controls.MetroCheckBox();
            this.cIRCList = new MetroFramework.Controls.MetroComboBox();
            this.tabAdvanced = new MetroFramework.Controls.MetroTabPage();
            this.gPerformance = new MetroFramework.Controls.MetroTile();
            this.lAdvancedWarning = new MetroFramework.Controls.MetroLabel();
            this.xLowLatencyMode = new MetroFramework.Controls.MetroCheckBox();
            this.lProcessPriority = new MetroFramework.Controls.MetroLabel();
            this.cProcessPriority = new MetroFramework.Controls.MetroComboBox();
            this.nTickInterval = new System.Windows.Forms.NumericUpDown();
            this.lTickIntervalUnits = new MetroFramework.Controls.MetroLabel();
            this.lTickInterval = new MetroFramework.Controls.MetroLabel();
            this.nThrottling = new System.Windows.Forms.NumericUpDown();
            this.lThrottling = new MetroFramework.Controls.MetroLabel();
            this.lThrottlingUnits = new MetroFramework.Controls.MetroLabel();
            this.gAdvancedMisc = new MetroFramework.Controls.MetroTile();
            this.xAutoRank = new MetroFramework.Controls.MetroCheckBox();
            this.nMaxUndoStates = new System.Windows.Forms.NumericUpDown();
            this.lMaxUndoStates = new MetroFramework.Controls.MetroLabel();
            this.lIPWarning = new MetroFramework.Controls.MetroLabel();
            this.tIP = new MetroFramework.Controls.MetroTextBox();
            this.xIP = new MetroFramework.Controls.MetroCheckBox();
            this.lConsoleName = new MetroFramework.Controls.MetroLabel();
            this.tConsoleName = new MetroFramework.Controls.MetroTextBox();
            this.nMaxUndo = new System.Windows.Forms.NumericUpDown();
            this.lMaxUndoUnits = new MetroFramework.Controls.MetroLabel();
            this.xMaxUndo = new MetroFramework.Controls.MetroCheckBox();
            this.xRelayAllBlockUpdates = new MetroFramework.Controls.MetroCheckBox();
            this.xNoPartialPositionUpdates = new MetroFramework.Controls.MetroCheckBox();
            this.gCrashReport = new MetroFramework.Controls.MetroTile();
            this.xCrash = new MetroFramework.Controls.MetroCheckBox();
            this.lCrashReportDisclaimer = new MetroFramework.Controls.MetroLabel();
            this.Misc = new MetroFramework.Controls.MetroTabPage();
            this.gboDragon = new MetroFramework.Controls.MetroTile();
            this.clbDragonPermits = new System.Windows.Forms.CheckedListBox();
            this.cboDragonDefault = new MetroFramework.Controls.MetroComboBox();
            this.lblDefaultBlock = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new MetroFramework.Controls.MetroTile();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.websiteURL = new MetroFramework.Controls.MetroTextBox();
            this.ReqsEditor = new MetroFramework.Controls.MetroButton();
            this.SwearEditor = new MetroFramework.Controls.MetroButton();
            this.MaxCapsValue = new System.Windows.Forms.NumericUpDown();
            this.MaxCaps = new MetroFramework.Controls.MetroLabel();
            this.SwearBox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new MetroFramework.Controls.MetroTile();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.CustomColor = new MetroFramework.Controls.MetroButton();
            this.CustomText = new MetroFramework.Controls.MetroLabel();
            this.CustomName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.CustomAliases = new MetroFramework.Controls.MetroTextBox();
            this.CPETab = new MetroFramework.Controls.MetroTabPage();
            this.gboEnvColors = new MetroFramework.Controls.MetroTile();
            this.numHourLength = new System.Windows.Forms.NumericUpDown();
            this.lblHourLength = new MetroFramework.Controls.MetroLabel();
            this.chkTimeBasedSky = new MetroFramework.Controls.MetroCheckBox();
            this.chkEnvColorsAllowed = new MetroFramework.Controls.MetroCheckBox();
            this.gboMessageType = new MetroFramework.Controls.MetroTile();
            this.btnSeeKeyWords = new MetroFramework.Controls.MetroButton();
            this.chkAnnouncementMT = new MetroFramework.Controls.MetroCheckBox();
            this.chkBottomRight3 = new MetroFramework.Controls.MetroCheckBox();
            this.txtBottomRight3 = new MetroFramework.Controls.MetroTextBox();
            this.chkBottomRight2 = new MetroFramework.Controls.MetroCheckBox();
            this.txtBottomRight2 = new MetroFramework.Controls.MetroTextBox();
            this.chkBottomRight1 = new MetroFramework.Controls.MetroCheckBox();
            this.txtBottomRight1 = new MetroFramework.Controls.MetroTextBox();
            this.chkStatus3 = new MetroFramework.Controls.MetroCheckBox();
            this.txtStatus3 = new MetroFramework.Controls.MetroTextBox();
            this.chkStatus2 = new MetroFramework.Controls.MetroCheckBox();
            this.txtStatus2 = new MetroFramework.Controls.MetroTextBox();
            this.chkStatus1 = new MetroFramework.Controls.MetroCheckBox();
            this.txtStatus1 = new MetroFramework.Controls.MetroTextBox();
            this.chkMessageTypeAllowed = new MetroFramework.Controls.MetroCheckBox();
            this.gboHeldBlock = new MetroFramework.Controls.MetroTile();
            this.chkHeldBlockAllowed = new MetroFramework.Controls.MetroCheckBox();
            this.gboCustomBlocks = new MetroFramework.Controls.MetroTile();
            this.clbBlocks = new System.Windows.Forms.CheckedListBox();
            this.chkCustomBlocksAllowed = new MetroFramework.Controls.MetroCheckBox();
            this.gboClickDistance = new MetroFramework.Controls.MetroTile();
            this.chkClickDistanceAllowed = new MetroFramework.Controls.MetroCheckBox();
            this.lblAboutCPE = new MetroFramework.Controls.MetroLabel();
            this.ServerTab = new MetroFramework.Controls.MetroTabPage();
            this.picServerStatus = new System.Windows.Forms.PictureBox();
            this.btnRestart = new MetroFramework.Controls.MetroButton();
            this.pStop = new MetroFramework.Controls.MetroButton();
            this.bStart = new MetroFramework.Controls.MetroButton();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.playerListLabel = new MetroFramework.Controls.MetroLabel();
            this.bVoice = new MetroFramework.Controls.MetroButton();
            this.console = new fCraft.ServerGUI.ConsoleBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.URLLabel = new MetroFramework.Controls.MetroLabel();
            this.bPlay = new MetroFramework.Controls.MetroButton();
            this.uriDisplay = new MetroFramework.Controls.MetroTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ThemeBox = new MetroFramework.Controls.MetroComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabRanks.SuspendLayout();
            this.gPermissionLimits.SuspendLayout();
            this.gRankOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFillLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCopyPasteSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKickIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefBlocks)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.gBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayersPerWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUploadBandwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayers)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAnnouncements)).BeginInit();
            this.tabChat.SuspendLayout();
            this.gAppearence.SuspendLayout();
            this.gChatColors.SuspendLayout();
            this.tabWorlds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorlds)).BeginInit();
            this.tabSecurity.SuspendLayout();
            this.gBlockDB.SuspendLayout();
            this.gSecurityMisc.SuspendLayout();
            this.gSpamChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamMaxWarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSpamMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntispamMessageCount)).BeginInit();
            this.gVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxConnectionsPerIP)).BeginInit();
            this.gUpdate.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gDataBackup.SuspendLayout();
            this.gSaving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSaveInterval)).BeginInit();
            this.gBackups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackupSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackupInterval)).BeginInit();
            this.tabLogging.SuspendLayout();
            this.gLogFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLogLimit)).BeginInit();
            this.gConsole.SuspendLayout();
            this.tabIRC.SuspendLayout();
            this.gIRCAdv.SuspendLayout();
            this.gIRCOptions.SuspendLayout();
            this.gIRCNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIRCDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRCBotPort)).BeginInit();
            this.tabAdvanced.SuspendLayout();
            this.gPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTickInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nThrottling)).BeginInit();
            this.gAdvancedMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndoStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndo)).BeginInit();
            this.gCrashReport.SuspendLayout();
            this.Misc.SuspendLayout();
            this.gboDragon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCapsValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CPETab.SuspendLayout();
            this.gboEnvColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourLength)).BeginInit();
            this.gboMessageType.SuspendLayout();
            this.gboHeldBlock.SuspendLayout();
            this.gboCustomBlocks.SuspendLayout();
            this.gboClickDistance.SuspendLayout();
            this.ServerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ServerTab);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(700, 608);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.bApply);
            this.tabPage1.Controls.Add(this.bResetAll);
            this.tabPage1.Controls.Add(this.bResetTab);
            this.tabPage1.Controls.Add(this.bCancel);
            this.tabPage1.Controls.Add(this.bOK);
            this.tabPage1.Controls.Add(this.tabs);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.BackColor = System.Drawing.Color.Silver;
            this.bApply.Location = new System.Drawing.Point(572, 532);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(100, 28);
            this.bApply.TabIndex = 9;
            this.bApply.Text = "Apply";
            this.bApply.UseSelectable = true;
            // 
            // bResetAll
            // 
            this.bResetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bResetAll.BackColor = System.Drawing.Color.Gainsboro;
            this.bResetAll.Location = new System.Drawing.Point(16, 532);
            this.bResetAll.Name = "bResetAll";
            this.bResetAll.Size = new System.Drawing.Size(114, 28);
            this.bResetAll.TabIndex = 10;
            this.bResetAll.Text = "Reset All Defaults";
            this.bResetAll.UseSelectable = true;
            // 
            // bResetTab
            // 
            this.bResetTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bResetTab.BackColor = System.Drawing.Color.Gainsboro;
            this.bResetTab.Location = new System.Drawing.Point(136, 532);
            this.bResetTab.Name = "bResetTab";
            this.bResetTab.Size = new System.Drawing.Size(100, 28);
            this.bResetTab.TabIndex = 11;
            this.bResetTab.Text = "Reset Tab";
            this.bResetTab.UseSelectable = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Silver;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(466, 532);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 28);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseSelectable = true;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.BackColor = System.Drawing.Color.Silver;
            this.bOK.Location = new System.Drawing.Point(360, 532);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(100, 28);
            this.bOK.TabIndex = 7;
            this.bOK.Text = "OK";
            this.bOK.UseSelectable = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabGeneral);
            this.tabs.Controls.Add(this.tabRanks);
            this.tabs.Controls.Add(this.tabChat);
            this.tabs.Controls.Add(this.tabWorlds);
            this.tabs.Controls.Add(this.tabSecurity);
            this.tabs.Controls.Add(this.gUpdate);
            this.tabs.Controls.Add(this.tabLogging);
            this.tabs.Controls.Add(this.tabIRC);
            this.tabs.Controls.Add(this.tabAdvanced);
            this.tabs.Controls.Add(this.Misc);
            this.tabs.Controls.Add(this.CPETab);
            this.tabs.Location = new System.Drawing.Point(16, 14);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(660, 526);
            this.tabs.TabIndex = 6;
            this.tabs.UseSelectable = true;
            // 
            // tabRanks
            // 
            this.tabRanks.BackColor = System.Drawing.Color.Gray;
            this.tabRanks.Controls.Add(this.metroButton1);
            this.tabRanks.Controls.Add(this.gPermissionLimits);
            this.tabRanks.Controls.Add(this.lRankList);
            this.tabRanks.Controls.Add(this.bLowerRank);
            this.tabRanks.Controls.Add(this.bRaiseRank);
            this.tabRanks.Controls.Add(this.gRankOptions);
            this.tabRanks.Controls.Add(this.bDeleteRank);
            this.tabRanks.Controls.Add(this.vPermissions);
            this.tabRanks.Controls.Add(this.bAddRank);
            this.tabRanks.Controls.Add(this.lPermissions);
            this.tabRanks.Controls.Add(this.vRanks);
            this.tabRanks.HorizontalScrollbarBarColor = true;
            this.tabRanks.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRanks.HorizontalScrollbarSize = 10;
            this.tabRanks.Location = new System.Drawing.Point(4, 38);
            this.tabRanks.Name = "tabRanks";
            this.tabRanks.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabRanks.Size = new System.Drawing.Size(652, 484);
            this.tabRanks.TabIndex = 2;
            this.tabRanks.Text = "Ranks";
            this.tabRanks.VerticalScrollbarBarColor = true;
            this.tabRanks.VerticalScrollbarHighlightOnWheel = false;
            this.tabRanks.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(473, 450);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(171, 21);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Select All";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // gPermissionLimits
            // 
            this.gPermissionLimits.ActiveControl = null;
            this.gPermissionLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPermissionLimits.Controls.Add(this.permissionLimitBoxContainer);
            this.gPermissionLimits.Location = new System.Drawing.Point(160, 281);
            this.gPermissionLimits.Name = "gPermissionLimits";
            this.gPermissionLimits.Size = new System.Drawing.Size(307, 190);
            this.gPermissionLimits.TabIndex = 7;
            this.gPermissionLimits.TabStop = false;
            this.gPermissionLimits.Text = "Permission Limits";
            this.gPermissionLimits.UseSelectable = true;
            // 
            // permissionLimitBoxContainer
            // 
            this.permissionLimitBoxContainer.AutoScroll = true;
            this.permissionLimitBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionLimitBoxContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.permissionLimitBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.permissionLimitBoxContainer.Margin = new System.Windows.Forms.Padding(0);
            this.permissionLimitBoxContainer.Name = "permissionLimitBoxContainer";
            this.permissionLimitBoxContainer.Size = new System.Drawing.Size(307, 190);
            this.permissionLimitBoxContainer.TabIndex = 0;
            this.permissionLimitBoxContainer.WrapContents = false;
            // 
            // lRankList
            // 
            this.lRankList.AutoSize = true;
            this.lRankList.Location = new System.Drawing.Point(8, 10);
            this.lRankList.Name = "lRankList";
            this.lRankList.Size = new System.Drawing.Size(59, 19);
            this.lRankList.TabIndex = 0;
            this.lRankList.Text = "Rank List";
            // 
            // bLowerRank
            // 
            this.bLowerRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLowerRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bLowerRank.Location = new System.Drawing.Point(84, 420);
            this.bLowerRank.Name = "bLowerRank";
            this.bLowerRank.Size = new System.Drawing.Size(70, 23);
            this.bLowerRank.TabIndex = 5;
            this.bLowerRank.Text = "▼ Lower";
            this.bLowerRank.UseSelectable = true;
            // 
            // bRaiseRank
            // 
            this.bRaiseRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRaiseRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bRaiseRank.Location = new System.Drawing.Point(8, 420);
            this.bRaiseRank.Name = "bRaiseRank";
            this.bRaiseRank.Size = new System.Drawing.Size(70, 23);
            this.bRaiseRank.TabIndex = 4;
            this.bRaiseRank.Text = "▲ Raise";
            this.bRaiseRank.UseSelectable = true;
            // 
            // gRankOptions
            // 
            this.gRankOptions.ActiveControl = null;
            this.gRankOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gRankOptions.Controls.Add(this.lFillLimitUnits);
            this.gRankOptions.Controls.Add(this.nFillLimit);
            this.gRankOptions.Controls.Add(this.lFillLimit);
            this.gRankOptions.Controls.Add(this.nCopyPasteSlots);
            this.gRankOptions.Controls.Add(this.lCopyPasteSlots);
            this.gRankOptions.Controls.Add(this.xAllowSecurityCircumvention);
            this.gRankOptions.Controls.Add(this.lAntiGrief1);
            this.gRankOptions.Controls.Add(this.lAntiGrief3);
            this.gRankOptions.Controls.Add(this.nAntiGriefSeconds);
            this.gRankOptions.Controls.Add(this.bColorRank);
            this.gRankOptions.Controls.Add(this.xDrawLimit);
            this.gRankOptions.Controls.Add(this.lDrawLimitUnits);
            this.gRankOptions.Controls.Add(this.lKickIdleUnits);
            this.gRankOptions.Controls.Add(this.nDrawLimit);
            this.gRankOptions.Controls.Add(this.nKickIdle);
            this.gRankOptions.Controls.Add(this.xAntiGrief);
            this.gRankOptions.Controls.Add(this.lAntiGrief2);
            this.gRankOptions.Controls.Add(this.xKickIdle);
            this.gRankOptions.Controls.Add(this.nAntiGriefBlocks);
            this.gRankOptions.Controls.Add(this.xReserveSlot);
            this.gRankOptions.Controls.Add(this.tPrefix);
            this.gRankOptions.Controls.Add(this.lPrefix);
            this.gRankOptions.Controls.Add(this.lRankColor);
            this.gRankOptions.Controls.Add(this.tRankName);
            this.gRankOptions.Controls.Add(this.lRankName);
            this.gRankOptions.Location = new System.Drawing.Point(160, 3);
            this.gRankOptions.Name = "gRankOptions";
            this.gRankOptions.Size = new System.Drawing.Size(307, 273);
            this.gRankOptions.TabIndex = 6;
            this.gRankOptions.TabStop = false;
            this.gRankOptions.Text = "Rank Options";
            this.gRankOptions.UseSelectable = true;
            // 
            // lFillLimitUnits
            // 
            this.lFillLimitUnits.AutoSize = true;
            this.lFillLimitUnits.Location = new System.Drawing.Point(239, 245);
            this.lFillLimitUnits.Name = "lFillLimitUnits";
            this.lFillLimitUnits.Size = new System.Drawing.Size(45, 19);
            this.lFillLimitUnits.TabIndex = 24;
            this.lFillLimitUnits.Text = "blocks";
            // 
            // nFillLimit
            // 
            this.nFillLimit.Location = new System.Drawing.Point(174, 243);
            this.nFillLimit.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nFillLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFillLimit.Name = "nFillLimit";
            this.nFillLimit.Size = new System.Drawing.Size(59, 20);
            this.nFillLimit.TabIndex = 23;
            this.nFillLimit.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lFillLimit
            // 
            this.lFillLimit.AutoSize = true;
            this.lFillLimit.Location = new System.Drawing.Point(85, 245);
            this.lFillLimit.Name = "lFillLimit";
            this.lFillLimit.Size = new System.Drawing.Size(94, 19);
            this.lFillLimit.TabIndex = 22;
            this.lFillLimit.Text = "Flood-fill limit:";
            // 
            // nCopyPasteSlots
            // 
            this.nCopyPasteSlots.Location = new System.Drawing.Point(174, 216);
            this.nCopyPasteSlots.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nCopyPasteSlots.Name = "nCopyPasteSlots";
            this.nCopyPasteSlots.Size = new System.Drawing.Size(59, 20);
            this.nCopyPasteSlots.TabIndex = 21;
            // 
            // lCopyPasteSlots
            // 
            this.lCopyPasteSlots.AutoSize = true;
            this.lCopyPasteSlots.Location = new System.Drawing.Point(50, 218);
            this.lCopyPasteSlots.Name = "lCopyPasteSlots";
            this.lCopyPasteSlots.Size = new System.Drawing.Size(132, 19);
            this.lCopyPasteSlots.TabIndex = 20;
            this.lCopyPasteSlots.Text = "Copy/paste slot limit:";
            // 
            // xAllowSecurityCircumvention
            // 
            this.xAllowSecurityCircumvention.AutoSize = true;
            this.xAllowSecurityCircumvention.Location = new System.Drawing.Point(12, 165);
            this.xAllowSecurityCircumvention.Name = "xAllowSecurityCircumvention";
            this.xAllowSecurityCircumvention.Size = new System.Drawing.Size(266, 15);
            this.xAllowSecurityCircumvention.TabIndex = 16;
            this.xAllowSecurityCircumvention.Text = "Allow removing own access/build restrictions.";
            this.xAllowSecurityCircumvention.UseSelectable = true;
            // 
            // lAntiGrief1
            // 
            this.lAntiGrief1.AutoSize = true;
            this.lAntiGrief1.Location = new System.Drawing.Point(50, 135);
            this.lAntiGrief1.Name = "lAntiGrief1";
            this.lAntiGrief1.Size = new System.Drawing.Size(50, 19);
            this.lAntiGrief1.TabIndex = 11;
            this.lAntiGrief1.Text = "Kick on";
            // 
            // lAntiGrief3
            // 
            this.lAntiGrief3.AutoSize = true;
            this.lAntiGrief3.Location = new System.Drawing.Point(275, 135);
            this.lAntiGrief3.Name = "lAntiGrief3";
            this.lAntiGrief3.Size = new System.Drawing.Size(27, 19);
            this.lAntiGrief3.TabIndex = 15;
            this.lAntiGrief3.Text = "sec";
            // 
            // nAntiGriefSeconds
            // 
            this.nAntiGriefSeconds.Location = new System.Drawing.Point(229, 133);
            this.nAntiGriefSeconds.Name = "nAntiGriefSeconds";
            this.nAntiGriefSeconds.Size = new System.Drawing.Size(40, 20);
            this.nAntiGriefSeconds.TabIndex = 14;
            // 
            // bColorRank
            // 
            this.bColorRank.BackColor = System.Drawing.Color.White;
            this.bColorRank.Location = new System.Drawing.Point(201, 47);
            this.bColorRank.Name = "bColorRank";
            this.bColorRank.Size = new System.Drawing.Size(100, 24);
            this.bColorRank.TabIndex = 6;
            this.bColorRank.UseSelectable = true;
            // 
            // xDrawLimit
            // 
            this.xDrawLimit.AutoSize = true;
            this.xDrawLimit.Location = new System.Drawing.Point(12, 190);
            this.xDrawLimit.Name = "xDrawLimit";
            this.xDrawLimit.Size = new System.Drawing.Size(77, 15);
            this.xDrawLimit.TabIndex = 17;
            this.xDrawLimit.Text = "Draw limit";
            this.xDrawLimit.UseSelectable = true;
            // 
            // lDrawLimitUnits
            // 
            this.lDrawLimitUnits.AutoSize = true;
            this.lDrawLimitUnits.Location = new System.Drawing.Point(172, 191);
            this.lDrawLimitUnits.Name = "lDrawLimitUnits";
            this.lDrawLimitUnits.Size = new System.Drawing.Size(45, 19);
            this.lDrawLimitUnits.TabIndex = 19;
            this.lDrawLimitUnits.Text = "blocks";
            // 
            // lKickIdleUnits
            // 
            this.lKickIdleUnits.AutoSize = true;
            this.lKickIdleUnits.Location = new System.Drawing.Point(181, 79);
            this.lKickIdleUnits.Name = "lKickIdleUnits";
            this.lKickIdleUnits.Size = new System.Drawing.Size(54, 19);
            this.lKickIdleUnits.TabIndex = 9;
            this.lKickIdleUnits.Text = "minutes";
            // 
            // nDrawLimit
            // 
            this.nDrawLimit.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nDrawLimit.Location = new System.Drawing.Point(99, 189);
            this.nDrawLimit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nDrawLimit.Name = "nDrawLimit";
            this.nDrawLimit.Size = new System.Drawing.Size(67, 20);
            this.nDrawLimit.TabIndex = 18;
            // 
            // nKickIdle
            // 
            this.nKickIdle.Location = new System.Drawing.Point(116, 77);
            this.nKickIdle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nKickIdle.Name = "nKickIdle";
            this.nKickIdle.Size = new System.Drawing.Size(59, 20);
            this.nKickIdle.TabIndex = 8;
            // 
            // xAntiGrief
            // 
            this.xAntiGrief.AutoSize = true;
            this.xAntiGrief.Location = new System.Drawing.Point(12, 108);
            this.xAntiGrief.Name = "xAntiGrief";
            this.xAntiGrief.Size = new System.Drawing.Size(207, 15);
            this.xAntiGrief.TabIndex = 10;
            this.xAntiGrief.Text = "Enable grief / autoclicker detection";
            this.xAntiGrief.UseSelectable = true;
            // 
            // lAntiGrief2
            // 
            this.lAntiGrief2.AutoSize = true;
            this.lAntiGrief2.Location = new System.Drawing.Point(168, 135);
            this.lAntiGrief2.Name = "lAntiGrief2";
            this.lAntiGrief2.Size = new System.Drawing.Size(59, 19);
            this.lAntiGrief2.TabIndex = 13;
            this.lAntiGrief2.Text = "blocks in";
            // 
            // xKickIdle
            // 
            this.xKickIdle.AutoSize = true;
            this.xKickIdle.Location = new System.Drawing.Point(12, 78);
            this.xKickIdle.Name = "xKickIdle";
            this.xKickIdle.Size = new System.Drawing.Size(95, 15);
            this.xKickIdle.TabIndex = 7;
            this.xKickIdle.Text = "Kick if idle for";
            this.xKickIdle.UseSelectable = true;
            // 
            // nAntiGriefBlocks
            // 
            this.nAntiGriefBlocks.Location = new System.Drawing.Point(103, 133);
            this.nAntiGriefBlocks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nAntiGriefBlocks.Name = "nAntiGriefBlocks";
            this.nAntiGriefBlocks.Size = new System.Drawing.Size(59, 20);
            this.nAntiGriefBlocks.TabIndex = 12;
            // 
            // xReserveSlot
            // 
            this.xReserveSlot.AutoSize = true;
            this.xReserveSlot.Location = new System.Drawing.Point(12, 51);
            this.xReserveSlot.Name = "xReserveSlot";
            this.xReserveSlot.Size = new System.Drawing.Size(120, 15);
            this.xReserveSlot.TabIndex = 4;
            this.xReserveSlot.Text = "Reserve player slot";
            this.xReserveSlot.UseSelectable = true;
            // 
            // tPrefix
            // 
            // 
            // 
            // 
            this.tPrefix.CustomButton.Image = null;
            this.tPrefix.CustomButton.Location = new System.Drawing.Point(2, 1);
            this.tPrefix.CustomButton.Name = "";
            this.tPrefix.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tPrefix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tPrefix.CustomButton.TabIndex = 1;
            this.tPrefix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tPrefix.CustomButton.UseSelectable = true;
            this.tPrefix.CustomButton.Visible = false;
            this.tPrefix.Enabled = false;
            this.tPrefix.Lines = new string[0];
            this.tPrefix.Location = new System.Drawing.Point(279, 20);
            this.tPrefix.MaxLength = 1;
            this.tPrefix.Name = "tPrefix";
            this.tPrefix.PasswordChar = '\0';
            this.tPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tPrefix.SelectedText = "";
            this.tPrefix.SelectionLength = 0;
            this.tPrefix.SelectionStart = 0;
            this.tPrefix.ShortcutsEnabled = true;
            this.tPrefix.Size = new System.Drawing.Size(22, 21);
            this.tPrefix.TabIndex = 3;
            this.tPrefix.UseSelectable = true;
            this.tPrefix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tPrefix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lPrefix
            // 
            this.lPrefix.AutoSize = true;
            this.lPrefix.Enabled = false;
            this.lPrefix.Location = new System.Drawing.Point(235, 23);
            this.lPrefix.Name = "lPrefix";
            this.lPrefix.Size = new System.Drawing.Size(42, 19);
            this.lPrefix.TabIndex = 2;
            this.lPrefix.Text = "Prefix";
            // 
            // lRankColor
            // 
            this.lRankColor.AutoSize = true;
            this.lRankColor.Location = new System.Drawing.Point(159, 52);
            this.lRankColor.Name = "lRankColor";
            this.lRankColor.Size = new System.Drawing.Size(42, 19);
            this.lRankColor.TabIndex = 5;
            this.lRankColor.Text = "Color";
            // 
            // tRankName
            // 
            // 
            // 
            // 
            this.tRankName.CustomButton.Image = null;
            this.tRankName.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tRankName.CustomButton.Name = "";
            this.tRankName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tRankName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tRankName.CustomButton.TabIndex = 1;
            this.tRankName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tRankName.CustomButton.UseSelectable = true;
            this.tRankName.CustomButton.Visible = false;
            this.tRankName.Lines = new string[0];
            this.tRankName.Location = new System.Drawing.Point(62, 20);
            this.tRankName.MaxLength = 16;
            this.tRankName.Name = "tRankName";
            this.tRankName.PasswordChar = '\0';
            this.tRankName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tRankName.SelectedText = "";
            this.tRankName.SelectionLength = 0;
            this.tRankName.SelectionStart = 0;
            this.tRankName.ShortcutsEnabled = true;
            this.tRankName.Size = new System.Drawing.Size(143, 21);
            this.tRankName.TabIndex = 1;
            this.tRankName.UseSelectable = true;
            this.tRankName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tRankName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lRankName
            // 
            this.lRankName.AutoSize = true;
            this.lRankName.Location = new System.Drawing.Point(15, 23);
            this.lRankName.Name = "lRankName";
            this.lRankName.Size = new System.Drawing.Size(45, 19);
            this.lRankName.TabIndex = 0;
            this.lRankName.Text = "Name";
            // 
            // bDeleteRank
            // 
            this.bDeleteRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bDeleteRank.Location = new System.Drawing.Point(84, 28);
            this.bDeleteRank.Name = "bDeleteRank";
            this.bDeleteRank.Size = new System.Drawing.Size(70, 23);
            this.bDeleteRank.TabIndex = 3;
            this.bDeleteRank.Text = "Delete";
            this.bDeleteRank.UseSelectable = true;
            // 
            // vPermissions
            // 
            this.vPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vPermissions.CheckBoxes = true;
            this.vPermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPermissions});
            this.vPermissions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vPermissions.FullRowSelect = true;
            this.vPermissions.GridLines = true;
            this.vPermissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vPermissions.Location = new System.Drawing.Point(473, 32);
            this.vPermissions.MultiSelect = false;
            this.vPermissions.Name = "vPermissions";
            this.vPermissions.OwnerDraw = true;
            this.vPermissions.ShowGroups = false;
            this.vPermissions.ShowItemToolTips = true;
            this.vPermissions.Size = new System.Drawing.Size(171, 406);
            this.vPermissions.TabIndex = 9;
            this.vPermissions.UseCompatibleStateImageBehavior = false;
            this.vPermissions.UseSelectable = true;
            this.vPermissions.View = System.Windows.Forms.View.Details;
            // 
            // chPermissions
            // 
            this.chPermissions.Width = 150;
            // 
            // bAddRank
            // 
            this.bAddRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAddRank.Location = new System.Drawing.Point(8, 28);
            this.bAddRank.Name = "bAddRank";
            this.bAddRank.Size = new System.Drawing.Size(70, 23);
            this.bAddRank.TabIndex = 2;
            this.bAddRank.Text = "Add Rank";
            this.bAddRank.UseSelectable = true;
            // 
            // lPermissions
            // 
            this.lPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPermissions.AutoSize = true;
            this.lPermissions.Location = new System.Drawing.Point(473, 10);
            this.lPermissions.Name = "lPermissions";
            this.lPermissions.Size = new System.Drawing.Size(108, 19);
            this.lPermissions.TabIndex = 8;
            this.lPermissions.Text = "Rank Permissions";
            // 
            // vRanks
            // 
            this.vRanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vRanks.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vRanks.FormattingEnabled = true;
            this.vRanks.IntegralHeight = false;
            this.vRanks.ItemHeight = 15;
            this.vRanks.Location = new System.Drawing.Point(8, 57);
            this.vRanks.Name = "vRanks";
            this.vRanks.Size = new System.Drawing.Size(146, 357);
            this.vRanks.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.Gray;
            this.tabGeneral.Controls.Add(this.gBasic);
            this.tabGeneral.Controls.Add(this.groupBox4);
            this.tabGeneral.Controls.Add(this.pictureBox1);
            this.tabGeneral.Controls.Add(this.groupBox2);
            this.tabGeneral.Controls.Add(this.gInformation);
            this.tabGeneral.HorizontalScrollbarBarColor = true;
            this.tabGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabGeneral.HorizontalScrollbarSize = 10;
            this.tabGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabGeneral.Size = new System.Drawing.Size(652, 484);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.VerticalScrollbarBarColor = true;
            this.tabGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabGeneral.VerticalScrollbarSize = 10;
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
            this.gBasic.Location = new System.Drawing.Point(8, 13);
            this.gBasic.Name = "gBasic";
            this.gBasic.Size = new System.Drawing.Size(636, 190);
            this.gBasic.TabIndex = 0;
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
            this.groupBox4.Location = new System.Drawing.Point(422, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 94);
            this.groupBox4.TabIndex = 5;
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
            this.bWeb.Click += new System.EventHandler(this.bWeb_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GemsCraftGUI.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(236, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.ActiveControl = null;
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.bChangelog);
            this.groupBox2.Controls.Add(this.bCredits);
            this.groupBox2.Controls.Add(this.bReadme);
            this.groupBox2.Location = new System.Drawing.Point(107, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 135);
            this.groupBox2.TabIndex = 4;
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
            this.gInformation.Location = new System.Drawing.Point(8, 219);
            this.gInformation.Name = "gInformation";
            this.gInformation.Size = new System.Drawing.Size(636, 57);
            this.gInformation.TabIndex = 1;
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
            // tabChat
            // 
            this.tabChat.BackColor = System.Drawing.Color.Gray;
            this.tabChat.Controls.Add(this.chatPreview1);
            this.tabChat.Controls.Add(this.gAppearence);
            this.tabChat.Controls.Add(this.gChatColors);
            this.tabChat.HorizontalScrollbarBarColor = true;
            this.tabChat.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChat.HorizontalScrollbarSize = 10;
            this.tabChat.Location = new System.Drawing.Point(4, 38);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.tabChat.Size = new System.Drawing.Size(652, 484);
            this.tabChat.TabIndex = 10;
            this.tabChat.Text = "Chat";
            this.tabChat.VerticalScrollbarBarColor = true;
            this.tabChat.VerticalScrollbarHighlightOnWheel = false;
            this.tabChat.VerticalScrollbarSize = 10;
            // 
            // chatPreview1
            // 
            this.chatPreview1.AutoScroll = true;
            this.chatPreview1.Location = new System.Drawing.Point(7, 281);
            this.chatPreview1.Name = "chatPreview1";
            this.chatPreview1.Size = new System.Drawing.Size(637, 190);
            this.chatPreview1.TabIndex = 2;
            // 
            // gAppearence
            // 
            this.gAppearence.ActiveControl = null;
            this.gAppearence.Controls.Add(this.xShowConnectionMessages);
            this.gAppearence.Controls.Add(this.xShowJoinedWorldMessages);
            this.gAppearence.Controls.Add(this.xRankColorsInWorldNames);
            this.gAppearence.Controls.Add(this.xRankPrefixesInList);
            this.gAppearence.Controls.Add(this.xRankPrefixesInChat);
            this.gAppearence.Controls.Add(this.xRankColorsInChat);
            this.gAppearence.Location = new System.Drawing.Point(7, 153);
            this.gAppearence.Name = "gAppearence";
            this.gAppearence.Size = new System.Drawing.Size(637, 122);
            this.gAppearence.TabIndex = 1;
            this.gAppearence.TabStop = false;
            this.gAppearence.Text = "Appearence Tweaks";
            this.gAppearence.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.gAppearence.UseSelectable = true;
            // 
            // xShowConnectionMessages
            // 
            this.xShowConnectionMessages.AutoSize = true;
            this.xShowConnectionMessages.Location = new System.Drawing.Point(325, 45);
            this.xShowConnectionMessages.Name = "xShowConnectionMessages";
            this.xShowConnectionMessages.Size = new System.Drawing.Size(282, 15);
            this.xShowConnectionMessages.TabIndex = 4;
            this.xShowConnectionMessages.Text = "Show a message when players join/leave SERVER.";
            this.xShowConnectionMessages.UseSelectable = true;
            // 
            // xShowJoinedWorldMessages
            // 
            this.xShowJoinedWorldMessages.AutoSize = true;
            this.xShowJoinedWorldMessages.Location = new System.Drawing.Point(325, 20);
            this.xShowJoinedWorldMessages.Name = "xShowJoinedWorldMessages";
            this.xShowJoinedWorldMessages.Size = new System.Drawing.Size(246, 15);
            this.xShowJoinedWorldMessages.TabIndex = 3;
            this.xShowJoinedWorldMessages.Text = "Show a message when players join worlds.";
            this.xShowJoinedWorldMessages.UseSelectable = true;
            // 
            // xRankColorsInWorldNames
            // 
            this.xRankColorsInWorldNames.AutoSize = true;
            this.xRankColorsInWorldNames.Location = new System.Drawing.Point(325, 70);
            this.xRankColorsInWorldNames.Name = "xRankColorsInWorldNames";
            this.xRankColorsInWorldNames.Size = new System.Drawing.Size(233, 15);
            this.xRankColorsInWorldNames.TabIndex = 5;
            this.xRankColorsInWorldNames.Text = "Color world names based on build rank.";
            this.xRankColorsInWorldNames.UseSelectable = true;
            // 
            // xRankPrefixesInList
            // 
            this.xRankPrefixesInList.AutoSize = true;
            this.xRankPrefixesInList.Location = new System.Drawing.Point(44, 70);
            this.xRankPrefixesInList.Name = "xRankPrefixesInList";
            this.xRankPrefixesInList.Size = new System.Drawing.Size(206, 15);
            this.xRankPrefixesInList.TabIndex = 2;
            this.xRankPrefixesInList.Text = "Prefixes in player list (breaks skins).";
            this.xRankPrefixesInList.UseSelectable = true;
            // 
            // xRankPrefixesInChat
            // 
            this.xRankPrefixesInChat.AutoSize = true;
            this.xRankPrefixesInChat.Location = new System.Drawing.Point(25, 45);
            this.xRankPrefixesInChat.Name = "xRankPrefixesInChat";
            this.xRankPrefixesInChat.Size = new System.Drawing.Size(124, 15);
            this.xRankPrefixesInChat.TabIndex = 1;
            this.xRankPrefixesInChat.Text = "Show rank prefixes.";
            this.xRankPrefixesInChat.UseSelectable = true;
            // 
            // xRankColorsInChat
            // 
            this.xRankColorsInChat.AutoSize = true;
            this.xRankColorsInChat.Location = new System.Drawing.Point(25, 20);
            this.xRankColorsInChat.Name = "xRankColorsInChat";
            this.xRankColorsInChat.Size = new System.Drawing.Size(116, 15);
            this.xRankColorsInChat.TabIndex = 0;
            this.xRankColorsInChat.Text = "Show rank colors.";
            this.xRankColorsInChat.UseSelectable = true;
            // 
            // gChatColors
            // 
            this.gChatColors.ActiveControl = null;
            this.gChatColors.BackColor = System.Drawing.Color.Gray;
            this.gChatColors.Controls.Add(this.lColorMe);
            this.gChatColors.Controls.Add(this.bColorGlobal);
            this.gChatColors.Controls.Add(this.bColorMe);
            this.gChatColors.Controls.Add(this.lColorWarning);
            this.gChatColors.Controls.Add(this.bColorWarning);
            this.gChatColors.Controls.Add(this.bColorSys);
            this.gChatColors.Controls.Add(this.lColorSys);
            this.gChatColors.Controls.Add(this.bColorPM);
            this.gChatColors.Controls.Add(this.lColorHelp);
            this.gChatColors.Controls.Add(this.lColorPM);
            this.gChatColors.Controls.Add(this.IColorGlobal);
            this.gChatColors.Controls.Add(this.lColorSay);
            this.gChatColors.Controls.Add(this.bColorAnnouncement);
            this.gChatColors.Controls.Add(this.lColorAnnouncement);
            this.gChatColors.Controls.Add(this.bColorHelp);
            this.gChatColors.Controls.Add(this.bColorSay);
            this.gChatColors.Location = new System.Drawing.Point(8, 8);
            this.gChatColors.Name = "gChatColors";
            this.gChatColors.Size = new System.Drawing.Size(636, 139);
            this.gChatColors.TabIndex = 0;
            this.gChatColors.TabStop = false;
            this.gChatColors.Text = "Colors";
            this.gChatColors.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gChatColors.UseSelectable = true;
            // 
            // lColorMe
            // 
            this.lColorMe.AutoSize = true;
            this.lColorMe.Location = new System.Drawing.Point(388, 78);
            this.lColorMe.Name = "lColorMe";
            this.lColorMe.Size = new System.Drawing.Size(131, 19);
            this.lColorMe.TabIndex = 12;
            this.lColorMe.Text = "/Me command color";
            // 
            // bColorGlobal
            // 
            this.bColorGlobal.BackColor = System.Drawing.Color.White;
            this.bColorGlobal.Location = new System.Drawing.Point(525, 111);
            this.bColorGlobal.Name = "bColorGlobal";
            this.bColorGlobal.Size = new System.Drawing.Size(100, 23);
            this.bColorGlobal.TabIndex = 13;
            this.bColorGlobal.UseSelectable = true;
            // 
            // bColorMe
            // 
            this.bColorMe.BackColor = System.Drawing.Color.White;
            this.bColorMe.Location = new System.Drawing.Point(525, 78);
            this.bColorMe.Name = "bColorMe";
            this.bColorMe.Size = new System.Drawing.Size(100, 23);
            this.bColorMe.TabIndex = 13;
            this.bColorMe.UseSelectable = true;
            // 
            // lColorWarning
            // 
            this.lColorWarning.AutoSize = true;
            this.lColorWarning.Location = new System.Drawing.Point(52, 49);
            this.lColorWarning.Name = "lColorWarning";
            this.lColorWarning.Size = new System.Drawing.Size(135, 19);
            this.lColorWarning.TabIndex = 2;
            this.lColorWarning.Text = "Warning / error color";
            // 
            // bColorWarning
            // 
            this.bColorWarning.BackColor = System.Drawing.Color.White;
            this.bColorWarning.Location = new System.Drawing.Point(193, 49);
            this.bColorWarning.Name = "bColorWarning";
            this.bColorWarning.Size = new System.Drawing.Size(100, 23);
            this.bColorWarning.TabIndex = 3;
            this.bColorWarning.UseSelectable = true;
            // 
            // bColorSys
            // 
            this.bColorSys.BackColor = System.Drawing.Color.White;
            this.bColorSys.Location = new System.Drawing.Point(193, 20);
            this.bColorSys.Name = "bColorSys";
            this.bColorSys.Size = new System.Drawing.Size(100, 23);
            this.bColorSys.TabIndex = 1;
            this.bColorSys.UseSelectable = true;
            // 
            // lColorSys
            // 
            this.lColorSys.AutoSize = true;
            this.lColorSys.Location = new System.Drawing.Point(48, 20);
            this.lColorSys.Name = "lColorSys";
            this.lColorSys.Size = new System.Drawing.Size(139, 19);
            this.lColorSys.TabIndex = 0;
            this.lColorSys.Text = "System message color";
            // 
            // bColorPM
            // 
            this.bColorPM.BackColor = System.Drawing.Color.White;
            this.bColorPM.Location = new System.Drawing.Point(193, 78);
            this.bColorPM.Name = "bColorPM";
            this.bColorPM.Size = new System.Drawing.Size(100, 23);
            this.bColorPM.TabIndex = 5;
            this.bColorPM.UseSelectable = true;
            // 
            // lColorHelp
            // 
            this.lColorHelp.AutoSize = true;
            this.lColorHelp.Location = new System.Drawing.Point(62, 107);
            this.lColorHelp.Name = "lColorHelp";
            this.lColorHelp.Size = new System.Drawing.Size(125, 19);
            this.lColorHelp.TabIndex = 6;
            this.lColorHelp.Text = "Help message color";
            // 
            // lColorPM
            // 
            this.lColorPM.AutoSize = true;
            this.lColorPM.Location = new System.Drawing.Point(11, 78);
            this.lColorPM.Name = "lColorPM";
            this.lColorPM.Size = new System.Drawing.Size(176, 19);
            this.lColorPM.TabIndex = 4;
            this.lColorPM.Text = "Private / rank message color";
            // 
            // IColorGlobal
            // 
            this.IColorGlobal.AutoSize = true;
            this.IColorGlobal.Location = new System.Drawing.Point(404, 111);
            this.IColorGlobal.Name = "IColorGlobal";
            this.IColorGlobal.Size = new System.Drawing.Size(115, 19);
            this.IColorGlobal.TabIndex = 10;
            this.IColorGlobal.Text = "Global Chat Color";
            // 
            // lColorSay
            // 
            this.lColorSay.AutoSize = true;
            this.lColorSay.Location = new System.Drawing.Point(396, 49);
            this.lColorSay.Name = "lColorSay";
            this.lColorSay.Size = new System.Drawing.Size(123, 19);
            this.lColorSay.TabIndex = 10;
            this.lColorSay.Text = "/Say message color";
            // 
            // bColorAnnouncement
            // 
            this.bColorAnnouncement.BackColor = System.Drawing.Color.White;
            this.bColorAnnouncement.Location = new System.Drawing.Point(525, 20);
            this.bColorAnnouncement.Name = "bColorAnnouncement";
            this.bColorAnnouncement.Size = new System.Drawing.Size(100, 23);
            this.bColorAnnouncement.TabIndex = 9;
            this.bColorAnnouncement.UseSelectable = true;
            // 
            // lColorAnnouncement
            // 
            this.lColorAnnouncement.AutoSize = true;
            this.lColorAnnouncement.Location = new System.Drawing.Point(323, 20);
            this.lColorAnnouncement.Name = "lColorAnnouncement";
            this.lColorAnnouncement.Size = new System.Drawing.Size(196, 19);
            this.lColorAnnouncement.TabIndex = 8;
            this.lColorAnnouncement.Text = "Announcement and /Rules color";
            // 
            // bColorHelp
            // 
            this.bColorHelp.BackColor = System.Drawing.Color.White;
            this.bColorHelp.Location = new System.Drawing.Point(193, 107);
            this.bColorHelp.Name = "bColorHelp";
            this.bColorHelp.Size = new System.Drawing.Size(100, 23);
            this.bColorHelp.TabIndex = 7;
            this.bColorHelp.UseSelectable = true;
            // 
            // bColorSay
            // 
            this.bColorSay.BackColor = System.Drawing.Color.White;
            this.bColorSay.Location = new System.Drawing.Point(525, 49);
            this.bColorSay.Name = "bColorSay";
            this.bColorSay.Size = new System.Drawing.Size(100, 23);
            this.bColorSay.TabIndex = 11;
            this.bColorSay.UseSelectable = true;
            // 
            // tabWorlds
            // 
            this.tabWorlds.BackColor = System.Drawing.Color.Gray;
            this.tabWorlds.Controls.Add(this.mcbPrison);
            this.tabWorlds.Controls.Add(this.cboPrison);
            this.tabWorlds.Controls.Add(this.label6);
            this.tabWorlds.Controls.Add(this.xWoMEnableEnvExtensions);
            this.tabWorlds.Controls.Add(this.bMapPath);
            this.tabWorlds.Controls.Add(this.xMapPath);
            this.tabWorlds.Controls.Add(this.tMapPath);
            this.tabWorlds.Controls.Add(this.lDefaultBuildRank);
            this.tabWorlds.Controls.Add(this.cDefaultBuildRank);
            this.tabWorlds.Controls.Add(this.cMainWorld);
            this.tabWorlds.Controls.Add(this.lMainWorld);
            this.tabWorlds.Controls.Add(this.bWorldEdit);
            this.tabWorlds.Controls.Add(this.bAddWorld);
            this.tabWorlds.Controls.Add(this.bWorldDelete);
            this.tabWorlds.Controls.Add(this.dgvWorlds);
            this.tabWorlds.HorizontalScrollbarBarColor = true;
            this.tabWorlds.HorizontalScrollbarHighlightOnWheel = false;
            this.tabWorlds.HorizontalScrollbarSize = 10;
            this.tabWorlds.Location = new System.Drawing.Point(4, 38);
            this.tabWorlds.Name = "tabWorlds";
            this.tabWorlds.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabWorlds.Size = new System.Drawing.Size(652, 484);
            this.tabWorlds.TabIndex = 9;
            this.tabWorlds.Text = "Worlds";
            this.tabWorlds.VerticalScrollbarBarColor = true;
            this.tabWorlds.VerticalScrollbarHighlightOnWheel = false;
            this.tabWorlds.VerticalScrollbarSize = 10;
            // 
            // mcbPrison
            // 
            this.mcbPrison.AutoSize = true;
            this.mcbPrison.Location = new System.Drawing.Point(339, 56);
            this.mcbPrison.Name = "mcbPrison";
            this.mcbPrison.Size = new System.Drawing.Size(101, 15);
            this.mcbPrison.TabIndex = 25;
            this.mcbPrison.Text = "Prison Enabled";
            this.mcbPrison.UseSelectable = true;
            this.mcbPrison.CheckedChanged += new System.EventHandler(this.mcbPrison_CheckedChanged);
            // 
            // cboPrison
            // 
            this.cboPrison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPrison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPrison.ItemHeight = 23;
            this.cboPrison.Location = new System.Drawing.Point(542, 46);
            this.cboPrison.Name = "cboPrison";
            this.cboPrison.Size = new System.Drawing.Size(102, 29);
            this.cboPrison.TabIndex = 24;
            this.cboPrison.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prison World:";
            // 
            // xWoMEnableEnvExtensions
            // 
            this.xWoMEnableEnvExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xWoMEnableEnvExtensions.AutoSize = true;
            this.xWoMEnableEnvExtensions.Location = new System.Drawing.Point(8, 454);
            this.xWoMEnableEnvExtensions.Name = "xWoMEnableEnvExtensions";
            this.xWoMEnableEnvExtensions.Size = new System.Drawing.Size(239, 15);
            this.xWoMEnableEnvExtensions.TabIndex = 22;
            this.xWoMEnableEnvExtensions.Text = "Enable Env Extensions (/MapEdit or /Env)";
            this.xWoMEnableEnvExtensions.UseSelectable = true;
            // 
            // bMapPath
            // 
            this.bMapPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMapPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bMapPath.Enabled = false;
            this.bMapPath.Location = new System.Drawing.Point(587, 423);
            this.bMapPath.Name = "bMapPath";
            this.bMapPath.Size = new System.Drawing.Size(62, 23);
            this.bMapPath.TabIndex = 10;
            this.bMapPath.Text = "Browse";
            this.bMapPath.UseSelectable = true;
            // 
            // xMapPath
            // 
            this.xMapPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xMapPath.AutoSize = true;
            this.xMapPath.Location = new System.Drawing.Point(8, 427);
            this.xMapPath.Name = "xMapPath";
            this.xMapPath.Size = new System.Drawing.Size(185, 15);
            this.xMapPath.TabIndex = 8;
            this.xMapPath.Text = "Custom path for storing maps:";
            this.xMapPath.UseSelectable = true;
            // 
            // tMapPath
            // 
            this.tMapPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tMapPath.CustomButton.Image = null;
            this.tMapPath.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.tMapPath.CustomButton.Name = "";
            this.tMapPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tMapPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tMapPath.CustomButton.TabIndex = 1;
            this.tMapPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tMapPath.CustomButton.UseSelectable = true;
            this.tMapPath.CustomButton.Visible = false;
            this.tMapPath.Enabled = false;
            this.tMapPath.Lines = new string[0];
            this.tMapPath.Location = new System.Drawing.Point(203, 425);
            this.tMapPath.MaxLength = 32767;
            this.tMapPath.Name = "tMapPath";
            this.tMapPath.PasswordChar = '\0';
            this.tMapPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tMapPath.SelectedText = "";
            this.tMapPath.SelectionLength = 0;
            this.tMapPath.SelectionStart = 0;
            this.tMapPath.ShortcutsEnabled = true;
            this.tMapPath.Size = new System.Drawing.Size(378, 19);
            this.tMapPath.TabIndex = 9;
            this.tMapPath.UseSelectable = true;
            this.tMapPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tMapPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lDefaultBuildRank
            // 
            this.lDefaultBuildRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDefaultBuildRank.AutoSize = true;
            this.lDefaultBuildRank.Location = new System.Drawing.Point(-4, 392);
            this.lDefaultBuildRank.Name = "lDefaultBuildRank";
            this.lDefaultBuildRank.Size = new System.Drawing.Size(374, 19);
            this.lDefaultBuildRank.TabIndex = 6;
            this.lDefaultBuildRank.Text = "Default rank requirement for building on newly-loaded worlds:";
            // 
            // cDefaultBuildRank
            // 
            this.cDefaultBuildRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cDefaultBuildRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDefaultBuildRank.FormattingEnabled = true;
            this.cDefaultBuildRank.ItemHeight = 23;
            this.cDefaultBuildRank.Location = new System.Drawing.Point(372, 392);
            this.cDefaultBuildRank.Name = "cDefaultBuildRank";
            this.cDefaultBuildRank.Size = new System.Drawing.Size(121, 29);
            this.cDefaultBuildRank.TabIndex = 7;
            this.cDefaultBuildRank.UseSelectable = true;
            // 
            // cMainWorld
            // 
            this.cMainWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cMainWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cMainWorld.ItemHeight = 23;
            this.cMainWorld.Location = new System.Drawing.Point(542, 17);
            this.cMainWorld.Name = "cMainWorld";
            this.cMainWorld.Size = new System.Drawing.Size(102, 29);
            this.cMainWorld.TabIndex = 5;
            this.cMainWorld.UseSelectable = true;
            // 
            // lMainWorld
            // 
            this.lMainWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lMainWorld.AutoSize = true;
            this.lMainWorld.Location = new System.Drawing.Point(458, 27);
            this.lMainWorld.Name = "lMainWorld";
            this.lMainWorld.Size = new System.Drawing.Size(78, 19);
            this.lMainWorld.TabIndex = 4;
            this.lMainWorld.Text = "Main world:";
            // 
            // bWorldEdit
            // 
            this.bWorldEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bWorldEdit.Enabled = false;
            this.bWorldEdit.Location = new System.Drawing.Point(114, 36);
            this.bWorldEdit.Name = "bWorldEdit";
            this.bWorldEdit.Size = new System.Drawing.Size(100, 28);
            this.bWorldEdit.TabIndex = 2;
            this.bWorldEdit.Text = "Edit";
            this.bWorldEdit.UseSelectable = true;
            // 
            // bAddWorld
            // 
            this.bAddWorld.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAddWorld.Location = new System.Drawing.Point(8, 36);
            this.bAddWorld.Name = "bAddWorld";
            this.bAddWorld.Size = new System.Drawing.Size(100, 28);
            this.bAddWorld.TabIndex = 1;
            this.bAddWorld.Text = "Add World";
            this.bAddWorld.UseSelectable = true;
            // 
            // bWorldDelete
            // 
            this.bWorldDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bWorldDelete.Enabled = false;
            this.bWorldDelete.Location = new System.Drawing.Point(220, 36);
            this.bWorldDelete.Name = "bWorldDelete";
            this.bWorldDelete.Size = new System.Drawing.Size(100, 28);
            this.bWorldDelete.TabIndex = 3;
            this.bWorldDelete.Text = "Delete World";
            this.bWorldDelete.UseSelectable = true;
            // 
            // dgvWorlds
            // 
            this.dgvWorlds.AllowUserToAddRows = false;
            this.dgvWorlds.AllowUserToDeleteRows = false;
            this.dgvWorlds.AllowUserToOrderColumns = true;
            this.dgvWorlds.AllowUserToResizeRows = false;
            this.dgvWorlds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorlds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorlds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcName,
            this.dgvcDescription,
            this.dgvcAccess,
            this.dgvcBuild,
            this.dgvcBackup,
            this.dgvcHidden,
            this.dgvcBlockDB});
            this.dgvWorlds.Location = new System.Drawing.Point(8, 75);
            this.dgvWorlds.MultiSelect = false;
            this.dgvWorlds.Name = "dgvWorlds";
            this.dgvWorlds.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.dgvWorlds.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorlds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorlds.Size = new System.Drawing.Size(636, 311);
            this.dgvWorlds.TabIndex = 0;
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "World Name";
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.Width = 110;
            // 
            // dgvcDescription
            // 
            this.dgvcDescription.DataPropertyName = "Description";
            this.dgvcDescription.HeaderText = "";
            this.dgvcDescription.Name = "dgvcDescription";
            this.dgvcDescription.ReadOnly = true;
            this.dgvcDescription.Width = 130;
            // 
            // dgvcAccess
            // 
            this.dgvcAccess.DataPropertyName = "AccessPermission";
            this.dgvcAccess.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcAccess.HeaderText = "Access";
            this.dgvcAccess.Name = "dgvcAccess";
            this.dgvcAccess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcBuild
            // 
            this.dgvcBuild.DataPropertyName = "BuildPermission";
            this.dgvcBuild.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcBuild.HeaderText = "Build";
            this.dgvcBuild.Name = "dgvcBuild";
            this.dgvcBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcBackup
            // 
            this.dgvcBackup.DataPropertyName = "Backup";
            this.dgvcBackup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcBackup.HeaderText = "Backup";
            this.dgvcBackup.Name = "dgvcBackup";
            this.dgvcBackup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcBackup.Width = 90;
            // 
            // dgvcHidden
            // 
            this.dgvcHidden.DataPropertyName = "Hidden";
            this.dgvcHidden.HeaderText = "Hide";
            this.dgvcHidden.Name = "dgvcHidden";
            this.dgvcHidden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcHidden.Width = 40;
            // 
            // dgvcBlockDB
            // 
            this.dgvcBlockDB.DataPropertyName = "BlockDBEnabled";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvcBlockDB.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcBlockDB.HeaderText = "BlockDB";
            this.dgvcBlockDB.Name = "dgvcBlockDB";
            this.dgvcBlockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcBlockDB.ThreeState = true;
            this.dgvcBlockDB.Width = 60;
            // 
            // tabSecurity
            // 
            this.tabSecurity.BackColor = System.Drawing.Color.Gray;
            this.tabSecurity.Controls.Add(this.gBlockDB);
            this.tabSecurity.Controls.Add(this.gSecurityMisc);
            this.tabSecurity.Controls.Add(this.gSpamChat);
            this.tabSecurity.Controls.Add(this.gVerify);
            this.tabSecurity.HorizontalScrollbarBarColor = true;
            this.tabSecurity.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSecurity.HorizontalScrollbarSize = 10;
            this.tabSecurity.Location = new System.Drawing.Point(4, 38);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabSecurity.Size = new System.Drawing.Size(652, 484);
            this.tabSecurity.TabIndex = 7;
            this.tabSecurity.Text = "Security";
            this.tabSecurity.VerticalScrollbarBarColor = true;
            this.tabSecurity.VerticalScrollbarHighlightOnWheel = false;
            this.tabSecurity.VerticalScrollbarSize = 10;
            // 
            // gBlockDB
            // 
            this.gBlockDB.ActiveControl = null;
            this.gBlockDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gBlockDB.Controls.Add(this.cBlockDBAutoEnableRank);
            this.gBlockDB.Controls.Add(this.xBlockDBAutoEnable);
            this.gBlockDB.Controls.Add(this.xBlockDBEnabled);
            this.gBlockDB.Location = new System.Drawing.Point(8, 100);
            this.gBlockDB.Name = "gBlockDB";
            this.gBlockDB.Size = new System.Drawing.Size(636, 88);
            this.gBlockDB.TabIndex = 1;
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
            this.xBlockDBAutoEnable.Enabled = false;
            this.xBlockDBAutoEnable.Location = new System.Drawing.Point(42, 55);
            this.xBlockDBAutoEnable.Name = "xBlockDBAutoEnable";
            this.xBlockDBAutoEnable.Size = new System.Drawing.Size(351, 15);
            this.xBlockDBAutoEnable.TabIndex = 1;
            this.xBlockDBAutoEnable.TabStop = false;
            this.xBlockDBAutoEnable.Text = "Automatically enable BlockDB on worlds that can be edited by";
            this.xBlockDBAutoEnable.UseSelectable = true;
            // 
            // xBlockDBEnabled
            // 
            this.xBlockDBEnabled.AutoSize = true;
            this.xBlockDBEnabled.Location = new System.Drawing.Point(42, 30);
            this.xBlockDBEnabled.Name = "xBlockDBEnabled";
            this.xBlockDBEnabled.Size = new System.Drawing.Size(239, 15);
            this.xBlockDBEnabled.TabIndex = 0;
            this.xBlockDBEnabled.Text = "Enable BlockDB (per-block edit tracking).";
            this.xBlockDBEnabled.UseSelectable = true;
            // 
            // gSecurityMisc
            // 
            this.gSecurityMisc.ActiveControl = null;
            this.gSecurityMisc.Controls.Add(this.xAnnounceRankChangeReasons);
            this.gSecurityMisc.Controls.Add(this.xRequireKickReason);
            this.gSecurityMisc.Controls.Add(this.lPatrolledRankAndBelow);
            this.gSecurityMisc.Controls.Add(this.cPatrolledRank);
            this.gSecurityMisc.Controls.Add(this.lPatrolledRank);
            this.gSecurityMisc.Controls.Add(this.xAnnounceRankChanges);
            this.gSecurityMisc.Controls.Add(this.xAnnounceKickAndBanReasons);
            this.gSecurityMisc.Controls.Add(this.xRequireRankChangeReason);
            this.gSecurityMisc.Controls.Add(this.xRequireBanReason);
            this.gSecurityMisc.Location = new System.Drawing.Point(8, 294);
            this.gSecurityMisc.Name = "gSecurityMisc";
            this.gSecurityMisc.Size = new System.Drawing.Size(636, 178);
            this.gSecurityMisc.TabIndex = 3;
            this.gSecurityMisc.TabStop = false;
            this.gSecurityMisc.Text = "Misc";
            this.gSecurityMisc.UseSelectable = true;
            // 
            // xAnnounceRankChangeReasons
            // 
            this.xAnnounceRankChangeReasons.AutoSize = true;
            this.xAnnounceRankChangeReasons.Location = new System.Drawing.Point(304, 109);
            this.xAnnounceRankChangeReasons.Name = "xAnnounceRankChangeReasons";
            this.xAnnounceRankChangeReasons.Size = new System.Drawing.Size(249, 15);
            this.xAnnounceRankChangeReasons.TabIndex = 6;
            this.xAnnounceRankChangeReasons.Text = "Announce promotion && demotion reasons";
            this.xAnnounceRankChangeReasons.UseSelectable = true;
            // 
            // xRequireKickReason
            // 
            this.xRequireKickReason.AutoSize = true;
            this.xRequireKickReason.Location = new System.Drawing.Point(42, 59);
            this.xRequireKickReason.Name = "xRequireKickReason";
            this.xRequireKickReason.Size = new System.Drawing.Size(125, 15);
            this.xRequireKickReason.TabIndex = 1;
            this.xRequireKickReason.Text = "Require kick reason";
            this.xRequireKickReason.UseSelectable = true;
            // 
            // lPatrolledRankAndBelow
            // 
            this.lPatrolledRankAndBelow.AutoSize = true;
            this.lPatrolledRankAndBelow.Location = new System.Drawing.Point(257, 143);
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
            this.cPatrolledRank.Location = new System.Drawing.Point(128, 140);
            this.cPatrolledRank.Name = "cPatrolledRank";
            this.cPatrolledRank.Size = new System.Drawing.Size(123, 29);
            this.cPatrolledRank.TabIndex = 8;
            this.cPatrolledRank.UseSelectable = true;
            // 
            // lPatrolledRank
            // 
            this.lPatrolledRank.AutoSize = true;
            this.lPatrolledRank.Location = new System.Drawing.Point(39, 143);
            this.lPatrolledRank.Name = "lPatrolledRank";
            this.lPatrolledRank.Size = new System.Drawing.Size(90, 19);
            this.lPatrolledRank.TabIndex = 7;
            this.lPatrolledRank.Text = "Patrolled rank";
            // 
            // xAnnounceRankChanges
            // 
            this.xAnnounceRankChanges.AutoSize = true;
            this.xAnnounceRankChanges.Location = new System.Drawing.Point(304, 84);
            this.xAnnounceRankChanges.Name = "xAnnounceRankChanges";
            this.xAnnounceRankChanges.Size = new System.Drawing.Size(226, 15);
            this.xAnnounceRankChanges.TabIndex = 5;
            this.xAnnounceRankChanges.Text = "Announce promotions and demotions";
            this.xAnnounceRankChanges.UseSelectable = true;
            // 
            // xAnnounceKickAndBanReasons
            // 
            this.xAnnounceKickAndBanReasons.AutoSize = true;
            this.xAnnounceKickAndBanReasons.Location = new System.Drawing.Point(304, 59);
            this.xAnnounceKickAndBanReasons.Name = "xAnnounceKickAndBanReasons";
            this.xAnnounceKickAndBanReasons.Size = new System.Drawing.Size(234, 15);
            this.xAnnounceKickAndBanReasons.TabIndex = 4;
            this.xAnnounceKickAndBanReasons.Text = "Announce kick, ban, and unban reasons";
            this.xAnnounceKickAndBanReasons.UseSelectable = true;
            // 
            // xRequireRankChangeReason
            // 
            this.xRequireRankChangeReason.AutoSize = true;
            this.xRequireRankChangeReason.Location = new System.Drawing.Point(42, 109);
            this.xRequireRankChangeReason.Name = "xRequireRankChangeReason";
            this.xRequireRankChangeReason.Size = new System.Drawing.Size(229, 15);
            this.xRequireRankChangeReason.TabIndex = 3;
            this.xRequireRankChangeReason.Text = "Require promotion && demotion reason";
            this.xRequireRankChangeReason.UseSelectable = true;
            // 
            // xRequireBanReason
            // 
            this.xRequireBanReason.AutoSize = true;
            this.xRequireBanReason.Location = new System.Drawing.Point(42, 84);
            this.xRequireBanReason.Name = "xRequireBanReason";
            this.xRequireBanReason.Size = new System.Drawing.Size(174, 15);
            this.xRequireBanReason.TabIndex = 2;
            this.xRequireBanReason.Text = "Require ban && unban reason";
            this.xRequireBanReason.UseSelectable = true;
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
            this.gSpamChat.Location = new System.Drawing.Point(8, 194);
            this.gSpamChat.Name = "gSpamChat";
            this.gSpamChat.Size = new System.Drawing.Size(636, 94);
            this.gSpamChat.TabIndex = 2;
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
            this.xAntispamKicks.Location = new System.Drawing.Point(304, 61);
            this.xAntispamKicks.Name = "xAntispamKicks";
            this.xAntispamKicks.Size = new System.Drawing.Size(72, 15);
            this.xAntispamKicks.TabIndex = 8;
            this.xAntispamKicks.Text = "Kick after";
            this.xAntispamKicks.UseSelectable = true;
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
            this.gVerify.Location = new System.Drawing.Point(8, 13);
            this.gVerify.Name = "gVerify";
            this.gVerify.Size = new System.Drawing.Size(636, 81);
            this.gVerify.TabIndex = 0;
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
            this.xAllowUnverifiedLAN.Location = new System.Drawing.Point(42, 49);
            this.xAllowUnverifiedLAN.Name = "xAllowUnverifiedLAN";
            this.xAllowUnverifiedLAN.Size = new System.Drawing.Size(476, 15);
            this.xAllowUnverifiedLAN.TabIndex = 2;
            this.xAllowUnverifiedLAN.Text = "Allow connections from LAN without name verification (192.168.0.0/16 and 10.0.0.0" +
    "/8)";
            this.xAllowUnverifiedLAN.UseSelectable = true;
            // 
            // xMaxConnectionsPerIP
            // 
            this.xMaxConnectionsPerIP.AutoSize = true;
            this.xMaxConnectionsPerIP.Location = new System.Drawing.Point(304, 22);
            this.xMaxConnectionsPerIP.Name = "xMaxConnectionsPerIP";
            this.xMaxConnectionsPerIP.Size = new System.Drawing.Size(224, 15);
            this.xMaxConnectionsPerIP.TabIndex = 3;
            this.xMaxConnectionsPerIP.Text = "Limit number of connections per IP to";
            this.xMaxConnectionsPerIP.UseSelectable = true;
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
            // gUpdate
            // 
            this.gUpdate.BackColor = System.Drawing.Color.Gray;
            this.gUpdate.Controls.Add(this.groupBox5);
            this.gUpdate.Controls.Add(this.gDataBackup);
            this.gUpdate.Controls.Add(this.gSaving);
            this.gUpdate.Controls.Add(this.gBackups);
            this.gUpdate.HorizontalScrollbarBarColor = true;
            this.gUpdate.HorizontalScrollbarHighlightOnWheel = false;
            this.gUpdate.HorizontalScrollbarSize = 10;
            this.gUpdate.Location = new System.Drawing.Point(4, 38);
            this.gUpdate.Name = "gUpdate";
            this.gUpdate.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.gUpdate.Size = new System.Drawing.Size(652, 484);
            this.gUpdate.TabIndex = 4;
            this.gUpdate.Text = "Saving and Backup";
            this.gUpdate.VerticalScrollbarBarColor = true;
            this.gUpdate.VerticalScrollbarHighlightOnWheel = false;
            this.gUpdate.VerticalScrollbarSize = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.ActiveControl = null;
            this.groupBox5.Controls.Add(this.bUpdate);
            this.groupBox5.Controls.Add(this.checkUpdate);
            this.groupBox5.Location = new System.Drawing.Point(8, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(635, 54);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update";
            this.groupBox5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.groupBox5.UseSelectable = true;
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bUpdate.Location = new System.Drawing.Point(221, 14);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(205, 28);
            this.bUpdate.TabIndex = 23;
            this.bUpdate.Text = "Manual Update Check";
            this.bUpdate.UseSelectable = true;
            // 
            // checkUpdate
            // 
            this.checkUpdate.AutoSize = true;
            this.checkUpdate.Location = new System.Drawing.Point(11, 20);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(197, 15);
            this.checkUpdate.TabIndex = 22;
            this.checkUpdate.Text = "Automatically Check for Updates";
            this.checkUpdate.UseSelectable = true;
            // 
            // gDataBackup
            // 
            this.gDataBackup.ActiveControl = null;
            this.gDataBackup.Controls.Add(this.xBackupDataOnStartup);
            this.gDataBackup.Location = new System.Drawing.Point(8, 235);
            this.gDataBackup.Name = "gDataBackup";
            this.gDataBackup.Size = new System.Drawing.Size(636, 52);
            this.gDataBackup.TabIndex = 2;
            this.gDataBackup.TabStop = false;
            this.gDataBackup.Text = "Data Backup";
            this.gDataBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gDataBackup.UseSelectable = true;
            // 
            // xBackupDataOnStartup
            // 
            this.xBackupDataOnStartup.AutoSize = true;
            this.xBackupDataOnStartup.Location = new System.Drawing.Point(16, 20);
            this.xBackupDataOnStartup.Name = "xBackupDataOnStartup";
            this.xBackupDataOnStartup.Size = new System.Drawing.Size(249, 15);
            this.xBackupDataOnStartup.TabIndex = 0;
            this.xBackupDataOnStartup.Text = "Backup PlayerDB and IP ban list on startup.";
            this.xBackupDataOnStartup.UseSelectable = true;
            // 
            // gSaving
            // 
            this.gSaving.ActiveControl = null;
            this.gSaving.Controls.Add(this.nSaveInterval);
            this.gSaving.Controls.Add(this.lSaveIntervalUnits);
            this.gSaving.Controls.Add(this.xSaveInterval);
            this.gSaving.Location = new System.Drawing.Point(8, 13);
            this.gSaving.Name = "gSaving";
            this.gSaving.Size = new System.Drawing.Size(636, 52);
            this.gSaving.TabIndex = 0;
            this.gSaving.TabStop = false;
            this.gSaving.Text = "Map Saving";
            this.gSaving.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gSaving.UseSelectable = true;
            // 
            // nSaveInterval
            // 
            this.nSaveInterval.Location = new System.Drawing.Point(136, 20);
            this.nSaveInterval.Name = "nSaveInterval";
            this.nSaveInterval.Size = new System.Drawing.Size(48, 20);
            this.nSaveInterval.TabIndex = 1;
            // 
            // lSaveIntervalUnits
            // 
            this.lSaveIntervalUnits.AutoSize = true;
            this.lSaveIntervalUnits.Location = new System.Drawing.Point(190, 22);
            this.lSaveIntervalUnits.Name = "lSaveIntervalUnits";
            this.lSaveIntervalUnits.Size = new System.Drawing.Size(55, 19);
            this.lSaveIntervalUnits.TabIndex = 2;
            this.lSaveIntervalUnits.Text = "seconds";
            // 
            // xSaveInterval
            // 
            this.xSaveInterval.AutoSize = true;
            this.xSaveInterval.Location = new System.Drawing.Point(12, 21);
            this.xSaveInterval.Name = "xSaveInterval";
            this.xSaveInterval.Size = new System.Drawing.Size(110, 15);
            this.xSaveInterval.TabIndex = 0;
            this.xSaveInterval.Text = "Save maps every";
            this.xSaveInterval.UseSelectable = true;
            // 
            // gBackups
            // 
            this.gBackups.ActiveControl = null;
            this.gBackups.Controls.Add(this.xBackupOnlyWhenChanged);
            this.gBackups.Controls.Add(this.lMaxBackupSize);
            this.gBackups.Controls.Add(this.xMaxBackupSize);
            this.gBackups.Controls.Add(this.nMaxBackupSize);
            this.gBackups.Controls.Add(this.xMaxBackups);
            this.gBackups.Controls.Add(this.xBackupOnStartup);
            this.gBackups.Controls.Add(this.lMaxBackups);
            this.gBackups.Controls.Add(this.nMaxBackups);
            this.gBackups.Controls.Add(this.nBackupInterval);
            this.gBackups.Controls.Add(this.lBackupIntervalUnits);
            this.gBackups.Controls.Add(this.xBackupInterval);
            this.gBackups.Controls.Add(this.xBackupOnJoin);
            this.gBackups.Location = new System.Drawing.Point(8, 71);
            this.gBackups.Name = "gBackups";
            this.gBackups.Size = new System.Drawing.Size(636, 158);
            this.gBackups.TabIndex = 1;
            this.gBackups.TabStop = false;
            this.gBackups.Text = "Map Backups";
            this.gBackups.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gBackups.UseSelectable = true;
            // 
            // xBackupOnlyWhenChanged
            // 
            this.xBackupOnlyWhenChanged.AutoSize = true;
            this.xBackupOnlyWhenChanged.Location = new System.Drawing.Point(369, 46);
            this.xBackupOnlyWhenChanged.Name = "xBackupOnlyWhenChanged";
            this.xBackupOnlyWhenChanged.Size = new System.Drawing.Size(250, 15);
            this.xBackupOnlyWhenChanged.TabIndex = 4;
            this.xBackupOnlyWhenChanged.Text = "Skip timed backups if map hasn\'t changed.";
            this.xBackupOnlyWhenChanged.UseSelectable = true;
            // 
            // lMaxBackupSize
            // 
            this.lMaxBackupSize.AutoSize = true;
            this.lMaxBackupSize.Location = new System.Drawing.Point(418, 124);
            this.lMaxBackupSize.Name = "lMaxBackupSize";
            this.lMaxBackupSize.Size = new System.Drawing.Size(111, 19);
            this.lMaxBackupSize.TabIndex = 11;
            this.lMaxBackupSize.Text = "MB of disk space.";
            // 
            // xMaxBackupSize
            // 
            this.xMaxBackupSize.AutoSize = true;
            this.xMaxBackupSize.Location = new System.Drawing.Point(16, 123);
            this.xMaxBackupSize.Name = "xMaxBackupSize";
            this.xMaxBackupSize.Size = new System.Drawing.Size(308, 15);
            this.xMaxBackupSize.TabIndex = 9;
            this.xMaxBackupSize.Text = "Delete old backups if the directory takes up more than";
            this.xMaxBackupSize.UseSelectable = true;
            // 
            // nMaxBackupSize
            // 
            this.nMaxBackupSize.Location = new System.Drawing.Point(339, 122);
            this.nMaxBackupSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nMaxBackupSize.Name = "nMaxBackupSize";
            this.nMaxBackupSize.Size = new System.Drawing.Size(73, 20);
            this.nMaxBackupSize.TabIndex = 10;
            // 
            // xMaxBackups
            // 
            this.xMaxBackups.AutoSize = true;
            this.xMaxBackups.Location = new System.Drawing.Point(16, 98);
            this.xMaxBackups.Name = "xMaxBackups";
            this.xMaxBackups.Size = new System.Drawing.Size(240, 15);
            this.xMaxBackups.TabIndex = 6;
            this.xMaxBackups.Text = "Delete old backups if there are more than";
            this.xMaxBackups.UseSelectable = true;
            // 
            // xBackupOnStartup
            // 
            this.xBackupOnStartup.AutoSize = true;
            this.xBackupOnStartup.Enabled = false;
            this.xBackupOnStartup.Location = new System.Drawing.Point(16, 20);
            this.xBackupOnStartup.Name = "xBackupOnStartup";
            this.xBackupOnStartup.Size = new System.Drawing.Size(161, 15);
            this.xBackupOnStartup.TabIndex = 0;
            this.xBackupOnStartup.Text = "Create backups on startup";
            this.xBackupOnStartup.UseSelectable = true;
            // 
            // lMaxBackups
            // 
            this.lMaxBackups.AutoSize = true;
            this.lMaxBackups.Location = new System.Drawing.Point(336, 99);
            this.lMaxBackups.Name = "lMaxBackups";
            this.lMaxBackups.Size = new System.Drawing.Size(172, 19);
            this.lMaxBackups.TabIndex = 8;
            this.lMaxBackups.Text = "files in the backup directory.";
            // 
            // nMaxBackups
            // 
            this.nMaxBackups.Location = new System.Drawing.Point(273, 97);
            this.nMaxBackups.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nMaxBackups.Name = "nMaxBackups";
            this.nMaxBackups.Size = new System.Drawing.Size(57, 20);
            this.nMaxBackups.TabIndex = 7;
            // 
            // nBackupInterval
            // 
            this.nBackupInterval.Location = new System.Drawing.Point(164, 45);
            this.nBackupInterval.Name = "nBackupInterval";
            this.nBackupInterval.Size = new System.Drawing.Size(48, 20);
            this.nBackupInterval.TabIndex = 2;
            // 
            // lBackupIntervalUnits
            // 
            this.lBackupIntervalUnits.AutoSize = true;
            this.lBackupIntervalUnits.Location = new System.Drawing.Point(218, 47);
            this.lBackupIntervalUnits.Name = "lBackupIntervalUnits";
            this.lBackupIntervalUnits.Size = new System.Drawing.Size(54, 19);
            this.lBackupIntervalUnits.TabIndex = 3;
            this.lBackupIntervalUnits.Text = "minutes";
            // 
            // xBackupInterval
            // 
            this.xBackupInterval.AutoSize = true;
            this.xBackupInterval.Location = new System.Drawing.Point(16, 46);
            this.xBackupInterval.Name = "xBackupInterval";
            this.xBackupInterval.Size = new System.Drawing.Size(135, 15);
            this.xBackupInterval.TabIndex = 1;
            this.xBackupInterval.Text = "Create backups every";
            this.xBackupInterval.UseSelectable = true;
            // 
            // xBackupOnJoin
            // 
            this.xBackupOnJoin.AutoSize = true;
            this.xBackupOnJoin.Location = new System.Drawing.Point(16, 72);
            this.xBackupOnJoin.Name = "xBackupOnJoin";
            this.xBackupOnJoin.Size = new System.Drawing.Size(267, 15);
            this.xBackupOnJoin.TabIndex = 5;
            this.xBackupOnJoin.Text = "Create backup whenever a player joins a world";
            this.xBackupOnJoin.UseSelectable = true;
            // 
            // tabLogging
            // 
            this.tabLogging.BackColor = System.Drawing.Color.Gray;
            this.tabLogging.Controls.Add(this.gLogFile);
            this.tabLogging.Controls.Add(this.gConsole);
            this.tabLogging.HorizontalScrollbarBarColor = true;
            this.tabLogging.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLogging.HorizontalScrollbarSize = 10;
            this.tabLogging.Location = new System.Drawing.Point(4, 38);
            this.tabLogging.Name = "tabLogging";
            this.tabLogging.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabLogging.Size = new System.Drawing.Size(652, 484);
            this.tabLogging.TabIndex = 5;
            this.tabLogging.Text = "Logging";
            this.tabLogging.VerticalScrollbarBarColor = true;
            this.tabLogging.VerticalScrollbarHighlightOnWheel = false;
            this.tabLogging.VerticalScrollbarSize = 10;
            // 
            // gLogFile
            // 
            this.gLogFile.ActiveControl = null;
            this.gLogFile.BackColor = System.Drawing.Color.Gray;
            this.gLogFile.Controls.Add(this.lLogFileOptionsDescription);
            this.gLogFile.Controls.Add(this.xLogLimit);
            this.gLogFile.Controls.Add(this.vLogFileOptions);
            this.gLogFile.Controls.Add(this.lLogLimitUnits);
            this.gLogFile.Controls.Add(this.nLogLimit);
            this.gLogFile.Controls.Add(this.cLogMode);
            this.gLogFile.Controls.Add(this.lLogMode);
            this.gLogFile.Location = new System.Drawing.Point(329, 13);
            this.gLogFile.Name = "gLogFile";
            this.gLogFile.Size = new System.Drawing.Size(315, 423);
            this.gLogFile.TabIndex = 1;
            this.gLogFile.TabStop = false;
            this.gLogFile.Text = "Log File";
            this.gLogFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.gLogFile.UseSelectable = true;
            // 
            // lLogFileOptionsDescription
            // 
            this.lLogFileOptionsDescription.AutoSize = true;
            this.lLogFileOptionsDescription.Location = new System.Drawing.Point(27, 22);
            this.lLogFileOptionsDescription.Name = "lLogFileOptionsDescription";
            this.lLogFileOptionsDescription.Size = new System.Drawing.Size(227, 38);
            this.lLogFileOptionsDescription.TabIndex = 0;
            this.lLogFileOptionsDescription.Text = "Types of messages that will be written\r\nto the log file on disk.";
            // 
            // xLogLimit
            // 
            this.xLogLimit.AutoSize = true;
            this.xLogLimit.Enabled = false;
            this.xLogLimit.Location = new System.Drawing.Point(18, 390);
            this.xLogLimit.Name = "xLogLimit";
            this.xLogLimit.Size = new System.Drawing.Size(76, 15);
            this.xLogLimit.TabIndex = 4;
            this.xLogLimit.Text = "Only keep";
            this.xLogLimit.UseSelectable = true;
            // 
            // vLogFileOptions
            // 
            this.vLogFileOptions.CheckBoxes = true;
            this.vLogFileOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.vLogFileOptions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vLogFileOptions.FullRowSelect = true;
            this.vLogFileOptions.GridLines = true;
            this.vLogFileOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vLogFileOptions.Location = new System.Drawing.Point(78, 59);
            this.vLogFileOptions.Name = "vLogFileOptions";
            this.vLogFileOptions.OwnerDraw = true;
            this.vLogFileOptions.ShowItemToolTips = true;
            this.vLogFileOptions.Size = new System.Drawing.Size(161, 294);
            this.vLogFileOptions.TabIndex = 1;
            this.vLogFileOptions.UseCompatibleStateImageBehavior = false;
            this.vLogFileOptions.UseSelectable = true;
            this.vLogFileOptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 157;
            // 
            // lLogLimitUnits
            // 
            this.lLogLimitUnits.AutoSize = true;
            this.lLogLimitUnits.Location = new System.Drawing.Point(166, 391);
            this.lLogLimitUnits.Name = "lLogLimitUnits";
            this.lLogLimitUnits.Size = new System.Drawing.Size(143, 19);
            this.lLogLimitUnits.TabIndex = 6;
            this.lLogLimitUnits.Text = "of most recent log files";
            // 
            // nLogLimit
            // 
            this.nLogLimit.Enabled = false;
            this.nLogLimit.Location = new System.Drawing.Point(104, 389);
            this.nLogLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nLogLimit.Name = "nLogLimit";
            this.nLogLimit.Size = new System.Drawing.Size(56, 20);
            this.nLogLimit.TabIndex = 5;
            // 
            // cLogMode
            // 
            this.cLogMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cLogMode.FormattingEnabled = true;
            this.cLogMode.ItemHeight = 23;
            this.cLogMode.Items.AddRange(new object[] {
            "One long file",
            "Multiple files, split by session",
            "Multiple files, split by day"});
            this.cLogMode.Location = new System.Drawing.Point(104, 360);
            this.cLogMode.Name = "cLogMode";
            this.cLogMode.Size = new System.Drawing.Size(185, 29);
            this.cLogMode.TabIndex = 3;
            this.cLogMode.UseSelectable = true;
            // 
            // lLogMode
            // 
            this.lLogMode.AutoSize = true;
            this.lLogMode.Location = new System.Drawing.Point(35, 363);
            this.lLogMode.Name = "lLogMode";
            this.lLogMode.Size = new System.Drawing.Size(70, 19);
            this.lLogMode.TabIndex = 2;
            this.lLogMode.Text = "Log mode";
            // 
            // gConsole
            // 
            this.gConsole.ActiveControl = null;
            this.gConsole.Controls.Add(this.lLogConsoleOptionsDescription);
            this.gConsole.Controls.Add(this.vConsoleOptions);
            this.gConsole.Location = new System.Drawing.Point(8, 13);
            this.gConsole.Name = "gConsole";
            this.gConsole.Size = new System.Drawing.Size(315, 423);
            this.gConsole.TabIndex = 0;
            this.gConsole.TabStop = false;
            this.gConsole.Text = "Console";
            this.gConsole.UseSelectable = true;
            // 
            // lLogConsoleOptionsDescription
            // 
            this.lLogConsoleOptionsDescription.AutoSize = true;
            this.lLogConsoleOptionsDescription.Location = new System.Drawing.Point(9, 21);
            this.lLogConsoleOptionsDescription.Name = "lLogConsoleOptionsDescription";
            this.lLogConsoleOptionsDescription.Size = new System.Drawing.Size(227, 38);
            this.lLogConsoleOptionsDescription.TabIndex = 0;
            this.lLogConsoleOptionsDescription.Text = "Types of messages that will be written\r\ndirectly to console.";
            // 
            // vConsoleOptions
            // 
            this.vConsoleOptions.CheckBoxes = true;
            this.vConsoleOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.vConsoleOptions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vConsoleOptions.FullRowSelect = true;
            this.vConsoleOptions.GridLines = true;
            this.vConsoleOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vConsoleOptions.Location = new System.Drawing.Point(76, 59);
            this.vConsoleOptions.Name = "vConsoleOptions";
            this.vConsoleOptions.OwnerDraw = true;
            this.vConsoleOptions.ShowItemToolTips = true;
            this.vConsoleOptions.Size = new System.Drawing.Size(161, 294);
            this.vConsoleOptions.TabIndex = 1;
            this.vConsoleOptions.UseCompatibleStateImageBehavior = false;
            this.vConsoleOptions.UseSelectable = true;
            this.vConsoleOptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 157;
            // 
            // tabIRC
            // 
            this.tabIRC.BackColor = System.Drawing.Color.Gray;
            this.tabIRC.Controls.Add(this.gIRCAdv);
            this.tabIRC.Controls.Add(this.xIRCListShowNonEnglish);
            this.tabIRC.Controls.Add(this.gIRCOptions);
            this.tabIRC.Controls.Add(this.gIRCNetwork);
            this.tabIRC.Controls.Add(this.lIRCList);
            this.tabIRC.Controls.Add(this.xIRCBotEnabled);
            this.tabIRC.Controls.Add(this.cIRCList);
            this.tabIRC.HorizontalScrollbarBarColor = true;
            this.tabIRC.HorizontalScrollbarHighlightOnWheel = false;
            this.tabIRC.HorizontalScrollbarSize = 10;
            this.tabIRC.Location = new System.Drawing.Point(4, 38);
            this.tabIRC.Name = "tabIRC";
            this.tabIRC.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabIRC.Size = new System.Drawing.Size(652, 484);
            this.tabIRC.TabIndex = 8;
            this.tabIRC.Text = "IRC";
            this.tabIRC.VerticalScrollbarBarColor = true;
            this.tabIRC.VerticalScrollbarHighlightOnWheel = false;
            this.tabIRC.VerticalScrollbarSize = 10;
            // 
            // gIRCAdv
            // 
            this.gIRCAdv.ActiveControl = null;
            this.gIRCAdv.Controls.Add(this.tServPass);
            this.gIRCAdv.Controls.Add(this.xServPass);
            this.gIRCAdv.Controls.Add(this.tChanPass);
            this.gIRCAdv.Controls.Add(this.xChanPass);
            this.gIRCAdv.Location = new System.Drawing.Point(10, 374);
            this.gIRCAdv.Name = "gIRCAdv";
            this.gIRCAdv.Size = new System.Drawing.Size(419, 95);
            this.gIRCAdv.TabIndex = 6;
            this.gIRCAdv.TabStop = false;
            this.gIRCAdv.Text = "Advanced";
            this.gIRCAdv.UseSelectable = true;
            // 
            // tServPass
            // 
            // 
            // 
            // 
            this.tServPass.CustomButton.Image = null;
            this.tServPass.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.tServPass.CustomButton.Name = "";
            this.tServPass.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tServPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tServPass.CustomButton.TabIndex = 1;
            this.tServPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tServPass.CustomButton.UseSelectable = true;
            this.tServPass.CustomButton.Visible = false;
            this.tServPass.Enabled = false;
            this.tServPass.Lines = new string[0];
            this.tServPass.Location = new System.Drawing.Point(219, 48);
            this.tServPass.MaxLength = 32767;
            this.tServPass.Name = "tServPass";
            this.tServPass.PasswordChar = '\0';
            this.tServPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tServPass.SelectedText = "";
            this.tServPass.SelectionLength = 0;
            this.tServPass.SelectionStart = 0;
            this.tServPass.ShortcutsEnabled = true;
            this.tServPass.Size = new System.Drawing.Size(154, 21);
            this.tServPass.TabIndex = 3;
            this.tServPass.UseSelectable = true;
            this.tServPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tServPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xServPass
            // 
            this.xServPass.AutoSize = true;
            this.xServPass.Location = new System.Drawing.Point(219, 23);
            this.xServPass.Name = "xServPass";
            this.xServPass.Size = new System.Drawing.Size(130, 15);
            this.xServPass.TabIndex = 2;
            this.xServPass.Text = "Use Server Password";
            this.xServPass.UseSelectable = true;
            // 
            // tChanPass
            // 
            // 
            // 
            // 
            this.tChanPass.CustomButton.Image = null;
            this.tChanPass.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.tChanPass.CustomButton.Name = "";
            this.tChanPass.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tChanPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tChanPass.CustomButton.TabIndex = 1;
            this.tChanPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tChanPass.CustomButton.UseSelectable = true;
            this.tChanPass.CustomButton.Visible = false;
            this.tChanPass.Enabled = false;
            this.tChanPass.Lines = new string[0];
            this.tChanPass.Location = new System.Drawing.Point(16, 48);
            this.tChanPass.MaxLength = 32767;
            this.tChanPass.Name = "tChanPass";
            this.tChanPass.PasswordChar = '\0';
            this.tChanPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tChanPass.SelectedText = "";
            this.tChanPass.SelectionLength = 0;
            this.tChanPass.SelectionStart = 0;
            this.tChanPass.ShortcutsEnabled = true;
            this.tChanPass.Size = new System.Drawing.Size(154, 21);
            this.tChanPass.TabIndex = 1;
            this.tChanPass.UseSelectable = true;
            this.tChanPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tChanPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xChanPass
            // 
            this.xChanPass.AutoSize = true;
            this.xChanPass.Location = new System.Drawing.Point(16, 23);
            this.xChanPass.Name = "xChanPass";
            this.xChanPass.Size = new System.Drawing.Size(142, 15);
            this.xChanPass.TabIndex = 0;
            this.xChanPass.Text = "Use Channel Password";
            this.xChanPass.UseSelectable = true;
            // 
            // xIRCListShowNonEnglish
            // 
            this.xIRCListShowNonEnglish.AutoSize = true;
            this.xIRCListShowNonEnglish.Enabled = false;
            this.xIRCListShowNonEnglish.Location = new System.Drawing.Point(465, 13);
            this.xIRCListShowNonEnglish.Name = "xIRCListShowNonEnglish";
            this.xIRCListShowNonEnglish.Size = new System.Drawing.Size(170, 15);
            this.xIRCListShowNonEnglish.TabIndex = 3;
            this.xIRCListShowNonEnglish.Text = "Show non-English networks";
            this.xIRCListShowNonEnglish.UseSelectable = true;
            // 
            // gIRCOptions
            // 
            this.gIRCOptions.ActiveControl = null;
            this.gIRCOptions.Controls.Add(this.xIRCBotAnnounceServerEvents);
            this.gIRCOptions.Controls.Add(this.xIRCUseColor);
            this.gIRCOptions.Controls.Add(this.lIRCNoForwardingMessage);
            this.gIRCOptions.Controls.Add(this.xIRCBotAnnounceIRCJoins);
            this.gIRCOptions.Controls.Add(this.bColorIRC);
            this.gIRCOptions.Controls.Add(this.lColorIRC);
            this.gIRCOptions.Controls.Add(this.xIRCBotForwardFromIRC);
            this.gIRCOptions.Controls.Add(this.xIRCBotAnnounceServerJoins);
            this.gIRCOptions.Controls.Add(this.xIRCBotForwardFromServer);
            this.gIRCOptions.Location = new System.Drawing.Point(8, 206);
            this.gIRCOptions.Name = "gIRCOptions";
            this.gIRCOptions.Size = new System.Drawing.Size(636, 162);
            this.gIRCOptions.TabIndex = 5;
            this.gIRCOptions.TabStop = false;
            this.gIRCOptions.Text = "Options";
            this.gIRCOptions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.gIRCOptions.UseSelectable = true;
            // 
            // xIRCBotAnnounceServerEvents
            // 
            this.xIRCBotAnnounceServerEvents.AutoSize = true;
            this.xIRCBotAnnounceServerEvents.Location = new System.Drawing.Point(38, 109);
            this.xIRCBotAnnounceServerEvents.Name = "xIRCBotAnnounceServerEvents";
            this.xIRCBotAnnounceServerEvents.Size = new System.Drawing.Size(397, 15);
            this.xIRCBotAnnounceServerEvents.TabIndex = 7;
            this.xIRCBotAnnounceServerEvents.Text = "Announce SERVER events (kicks, bans, promotions, demotions) on IRC.";
            this.xIRCBotAnnounceServerEvents.UseSelectable = true;
            // 
            // xIRCUseColor
            // 
            this.xIRCUseColor.AutoSize = true;
            this.xIRCUseColor.Location = new System.Drawing.Point(325, 34);
            this.xIRCUseColor.Name = "xIRCUseColor";
            this.xIRCUseColor.Size = new System.Drawing.Size(140, 15);
            this.xIRCUseColor.TabIndex = 2;
            this.xIRCUseColor.Text = "Use text colors on IRC.";
            this.xIRCUseColor.UseSelectable = true;
            // 
            // lIRCNoForwardingMessage
            // 
            this.lIRCNoForwardingMessage.AutoSize = true;
            this.lIRCNoForwardingMessage.Location = new System.Drawing.Point(35, 137);
            this.lIRCNoForwardingMessage.Name = "lIRCNoForwardingMessage";
            this.lIRCNoForwardingMessage.Size = new System.Drawing.Size(607, 19);
            this.lIRCNoForwardingMessage.TabIndex = 8;
            this.lIRCNoForwardingMessage.Text = "NOTE: If forwarding all messages is not enabled, only messages starting with a ha" +
    "sh (#) will be relayed.";
            // 
            // xIRCBotAnnounceIRCJoins
            // 
            this.xIRCBotAnnounceIRCJoins.AutoSize = true;
            this.xIRCBotAnnounceIRCJoins.Location = new System.Drawing.Point(325, 84);
            this.xIRCBotAnnounceIRCJoins.Name = "xIRCBotAnnounceIRCJoins";
            this.xIRCBotAnnounceIRCJoins.Size = new System.Drawing.Size(294, 15);
            this.xIRCBotAnnounceIRCJoins.TabIndex = 6;
            this.xIRCBotAnnounceIRCJoins.Text = "Announce people joining/leaving the IRC channels.";
            this.xIRCBotAnnounceIRCJoins.UseSelectable = true;
            // 
            // bColorIRC
            // 
            this.bColorIRC.BackColor = System.Drawing.Color.White;
            this.bColorIRC.Location = new System.Drawing.Point(152, 20);
            this.bColorIRC.Name = "bColorIRC";
            this.bColorIRC.Size = new System.Drawing.Size(100, 23);
            this.bColorIRC.TabIndex = 1;
            this.bColorIRC.UseSelectable = true;
            // 
            // lColorIRC
            // 
            this.lColorIRC.AutoSize = true;
            this.lColorIRC.Location = new System.Drawing.Point(35, 24);
            this.lColorIRC.Name = "lColorIRC";
            this.lColorIRC.Size = new System.Drawing.Size(118, 19);
            this.lColorIRC.TabIndex = 0;
            this.lColorIRC.Text = "IRC message color";
            // 
            // xIRCBotForwardFromIRC
            // 
            this.xIRCBotForwardFromIRC.AutoSize = true;
            this.xIRCBotForwardFromIRC.Location = new System.Drawing.Point(38, 84);
            this.xIRCBotForwardFromIRC.Name = "xIRCBotForwardFromIRC";
            this.xIRCBotForwardFromIRC.Size = new System.Drawing.Size(224, 15);
            this.xIRCBotForwardFromIRC.TabIndex = 4;
            this.xIRCBotForwardFromIRC.Text = "Forward ALL chat from IRC to SERVER.";
            this.xIRCBotForwardFromIRC.UseSelectable = true;
            // 
            // xIRCBotAnnounceServerJoins
            // 
            this.xIRCBotAnnounceServerJoins.AutoSize = true;
            this.xIRCBotAnnounceServerJoins.Location = new System.Drawing.Point(325, 59);
            this.xIRCBotAnnounceServerJoins.Name = "xIRCBotAnnounceServerJoins";
            this.xIRCBotAnnounceServerJoins.Size = new System.Drawing.Size(265, 15);
            this.xIRCBotAnnounceServerJoins.TabIndex = 5;
            this.xIRCBotAnnounceServerJoins.Text = "Announce people joining/leaving the SERVER.";
            this.xIRCBotAnnounceServerJoins.UseSelectable = true;
            // 
            // xIRCBotForwardFromServer
            // 
            this.xIRCBotForwardFromServer.AutoSize = true;
            this.xIRCBotForwardFromServer.Location = new System.Drawing.Point(38, 59);
            this.xIRCBotForwardFromServer.Name = "xIRCBotForwardFromServer";
            this.xIRCBotForwardFromServer.Size = new System.Drawing.Size(224, 15);
            this.xIRCBotForwardFromServer.TabIndex = 3;
            this.xIRCBotForwardFromServer.Text = "Forward ALL chat from SERVER to IRC.";
            this.xIRCBotForwardFromServer.UseSelectable = true;
            // 
            // gIRCNetwork
            // 
            this.gIRCNetwork.ActiveControl = null;
            this.gIRCNetwork.Controls.Add(this.lIRCDelayUnits);
            this.gIRCNetwork.Controls.Add(this.xIRCRegisteredNick);
            this.gIRCNetwork.Controls.Add(this.tIRCNickServMessage);
            this.gIRCNetwork.Controls.Add(this.lIRCNickServMessage);
            this.gIRCNetwork.Controls.Add(this.tIRCNickServ);
            this.gIRCNetwork.Controls.Add(this.lIRCNickServ);
            this.gIRCNetwork.Controls.Add(this.nIRCDelay);
            this.gIRCNetwork.Controls.Add(this.lIRCDelay);
            this.gIRCNetwork.Controls.Add(this.lIRCBotChannels2);
            this.gIRCNetwork.Controls.Add(this.lIRCBotChannels3);
            this.gIRCNetwork.Controls.Add(this.tIRCBotChannels);
            this.gIRCNetwork.Controls.Add(this.lIRCBotChannels);
            this.gIRCNetwork.Controls.Add(this.nIRCBotPort);
            this.gIRCNetwork.Controls.Add(this.lIRCBotPort);
            this.gIRCNetwork.Controls.Add(this.tIRCBotNetwork);
            this.gIRCNetwork.Controls.Add(this.lIRCBotNetwork);
            this.gIRCNetwork.Controls.Add(this.lIRCBotNick);
            this.gIRCNetwork.Controls.Add(this.tIRCBotNick);
            this.gIRCNetwork.Location = new System.Drawing.Point(8, 40);
            this.gIRCNetwork.Name = "gIRCNetwork";
            this.gIRCNetwork.Size = new System.Drawing.Size(636, 160);
            this.gIRCNetwork.TabIndex = 4;
            this.gIRCNetwork.TabStop = false;
            this.gIRCNetwork.Text = "Network";
            this.gIRCNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gIRCNetwork.UseSelectable = true;
            // 
            // lIRCDelayUnits
            // 
            this.lIRCDelayUnits.AutoSize = true;
            this.lIRCDelayUnits.Location = new System.Drawing.Point(598, 22);
            this.lIRCDelayUnits.Name = "lIRCDelayUnits";
            this.lIRCDelayUnits.Size = new System.Drawing.Size(26, 19);
            this.lIRCDelayUnits.TabIndex = 6;
            this.lIRCDelayUnits.Text = "ms";
            // 
            // xIRCRegisteredNick
            // 
            this.xIRCRegisteredNick.AutoSize = true;
            this.xIRCRegisteredNick.Location = new System.Drawing.Point(265, 101);
            this.xIRCRegisteredNick.Name = "xIRCRegisteredNick";
            this.xIRCRegisteredNick.Size = new System.Drawing.Size(78, 15);
            this.xIRCRegisteredNick.TabIndex = 13;
            this.xIRCRegisteredNick.Text = "Registered";
            this.xIRCRegisteredNick.UseSelectable = true;
            // 
            // tIRCNickServMessage
            // 
            // 
            // 
            // 
            this.tIRCNickServMessage.CustomButton.Image = null;
            this.tIRCNickServMessage.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tIRCNickServMessage.CustomButton.Name = "";
            this.tIRCNickServMessage.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIRCNickServMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIRCNickServMessage.CustomButton.TabIndex = 1;
            this.tIRCNickServMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIRCNickServMessage.CustomButton.UseSelectable = true;
            this.tIRCNickServMessage.CustomButton.Visible = false;
            this.tIRCNickServMessage.Enabled = false;
            this.tIRCNickServMessage.Lines = new string[0];
            this.tIRCNickServMessage.Location = new System.Drawing.Point(399, 126);
            this.tIRCNickServMessage.MaxLength = 32767;
            this.tIRCNickServMessage.Name = "tIRCNickServMessage";
            this.tIRCNickServMessage.PasswordChar = '\0';
            this.tIRCNickServMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIRCNickServMessage.SelectedText = "";
            this.tIRCNickServMessage.SelectionLength = 0;
            this.tIRCNickServMessage.SelectionStart = 0;
            this.tIRCNickServMessage.ShortcutsEnabled = true;
            this.tIRCNickServMessage.Size = new System.Drawing.Size(223, 21);
            this.tIRCNickServMessage.TabIndex = 17;
            this.tIRCNickServMessage.UseSelectable = true;
            this.tIRCNickServMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIRCNickServMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lIRCNickServMessage
            // 
            this.lIRCNickServMessage.AutoSize = true;
            this.lIRCNickServMessage.Enabled = false;
            this.lIRCNickServMessage.Location = new System.Drawing.Point(265, 126);
            this.lIRCNickServMessage.Name = "lIRCNickServMessage";
            this.lIRCNickServMessage.Size = new System.Drawing.Size(128, 19);
            this.lIRCNickServMessage.TabIndex = 16;
            this.lIRCNickServMessage.Text = "Authentication string";
            // 
            // tIRCNickServ
            // 
            // 
            // 
            // 
            this.tIRCNickServ.CustomButton.Image = null;
            this.tIRCNickServ.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tIRCNickServ.CustomButton.Name = "";
            this.tIRCNickServ.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIRCNickServ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIRCNickServ.CustomButton.TabIndex = 1;
            this.tIRCNickServ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIRCNickServ.CustomButton.UseSelectable = true;
            this.tIRCNickServ.CustomButton.Visible = false;
            this.tIRCNickServ.Enabled = false;
            this.tIRCNickServ.Lines = new string[0];
            this.tIRCNickServ.Location = new System.Drawing.Point(121, 126);
            this.tIRCNickServ.MaxLength = 32;
            this.tIRCNickServ.Name = "tIRCNickServ";
            this.tIRCNickServ.PasswordChar = '\0';
            this.tIRCNickServ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIRCNickServ.SelectedText = "";
            this.tIRCNickServ.SelectionLength = 0;
            this.tIRCNickServ.SelectionStart = 0;
            this.tIRCNickServ.ShortcutsEnabled = true;
            this.tIRCNickServ.Size = new System.Drawing.Size(138, 21);
            this.tIRCNickServ.TabIndex = 15;
            this.tIRCNickServ.UseSelectable = true;
            this.tIRCNickServ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIRCNickServ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lIRCNickServ
            // 
            this.lIRCNickServ.AutoSize = true;
            this.lIRCNickServ.Enabled = false;
            this.lIRCNickServ.Location = new System.Drawing.Point(35, 129);
            this.lIRCNickServ.Name = "lIRCNickServ";
            this.lIRCNickServ.Size = new System.Drawing.Size(86, 19);
            this.lIRCNickServ.TabIndex = 14;
            this.lIRCNickServ.Text = "NickServ nick";
            // 
            // nIRCDelay
            // 
            this.nIRCDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nIRCDelay.Location = new System.Drawing.Point(536, 20);
            this.nIRCDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nIRCDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIRCDelay.Name = "nIRCDelay";
            this.nIRCDelay.Size = new System.Drawing.Size(56, 20);
            this.nIRCDelay.TabIndex = 5;
            this.nIRCDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lIRCDelay
            // 
            this.lIRCDelay.AutoSize = true;
            this.lIRCDelay.Location = new System.Drawing.Point(416, 22);
            this.lIRCDelay.Name = "lIRCDelay";
            this.lIRCDelay.Size = new System.Drawing.Size(121, 19);
            this.lIRCDelay.TabIndex = 4;
            this.lIRCDelay.Text = "Min message delay";
            // 
            // lIRCBotChannels2
            // 
            this.lIRCBotChannels2.AutoSize = true;
            this.lIRCBotChannels2.Location = new System.Drawing.Point(0, 68);
            this.lIRCBotChannels2.Name = "lIRCBotChannels2";
            this.lIRCBotChannels2.Size = new System.Drawing.Size(124, 19);
            this.lIRCBotChannels2.TabIndex = 9;
            this.lIRCBotChannels2.Text = "(comma seperated)";
            // 
            // lIRCBotChannels3
            // 
            this.lIRCBotChannels3.AutoSize = true;
            this.lIRCBotChannels3.Location = new System.Drawing.Point(130, 68);
            this.lIRCBotChannels3.Name = "lIRCBotChannels3";
            this.lIRCBotChannels3.Size = new System.Drawing.Size(358, 19);
            this.lIRCBotChannels3.TabIndex = 10;
            this.lIRCBotChannels3.Text = "NOTE: Channel names are case-sensitive on some networks!";
            // 
            // tIRCBotChannels
            // 
            // 
            // 
            // 
            this.tIRCBotChannels.CustomButton.Image = null;
            this.tIRCBotChannels.CustomButton.Location = new System.Drawing.Point(481, 1);
            this.tIRCBotChannels.CustomButton.Name = "";
            this.tIRCBotChannels.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIRCBotChannels.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIRCBotChannels.CustomButton.TabIndex = 1;
            this.tIRCBotChannels.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIRCBotChannels.CustomButton.UseSelectable = true;
            this.tIRCBotChannels.CustomButton.Visible = false;
            this.tIRCBotChannels.Lines = new string[0];
            this.tIRCBotChannels.Location = new System.Drawing.Point(121, 47);
            this.tIRCBotChannels.MaxLength = 1000;
            this.tIRCBotChannels.Name = "tIRCBotChannels";
            this.tIRCBotChannels.PasswordChar = '\0';
            this.tIRCBotChannels.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIRCBotChannels.SelectedText = "";
            this.tIRCBotChannels.SelectionLength = 0;
            this.tIRCBotChannels.SelectionStart = 0;
            this.tIRCBotChannels.ShortcutsEnabled = true;
            this.tIRCBotChannels.Size = new System.Drawing.Size(501, 21);
            this.tIRCBotChannels.TabIndex = 8;
            this.tIRCBotChannels.UseSelectable = true;
            this.tIRCBotChannels.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIRCBotChannels.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lIRCBotChannels
            // 
            this.lIRCBotChannels.AutoSize = true;
            this.lIRCBotChannels.Location = new System.Drawing.Point(13, 49);
            this.lIRCBotChannels.Name = "lIRCBotChannels";
            this.lIRCBotChannels.Size = new System.Drawing.Size(102, 19);
            this.lIRCBotChannels.TabIndex = 7;
            this.lIRCBotChannels.Text = "Channels to join";
            // 
            // nIRCBotPort
            // 
            this.nIRCBotPort.Location = new System.Drawing.Point(300, 20);
            this.nIRCBotPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nIRCBotPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIRCBotPort.Name = "nIRCBotPort";
            this.nIRCBotPort.Size = new System.Drawing.Size(64, 20);
            this.nIRCBotPort.TabIndex = 3;
            this.nIRCBotPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lIRCBotPort
            // 
            this.lIRCBotPort.AutoSize = true;
            this.lIRCBotPort.Location = new System.Drawing.Point(265, 22);
            this.lIRCBotPort.Name = "lIRCBotPort";
            this.lIRCBotPort.Size = new System.Drawing.Size(34, 19);
            this.lIRCBotPort.TabIndex = 2;
            this.lIRCBotPort.Text = "Port";
            // 
            // tIRCBotNetwork
            // 
            // 
            // 
            // 
            this.tIRCBotNetwork.CustomButton.Image = null;
            this.tIRCBotNetwork.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tIRCBotNetwork.CustomButton.Name = "";
            this.tIRCBotNetwork.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIRCBotNetwork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIRCBotNetwork.CustomButton.TabIndex = 1;
            this.tIRCBotNetwork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIRCBotNetwork.CustomButton.UseSelectable = true;
            this.tIRCBotNetwork.CustomButton.Visible = false;
            this.tIRCBotNetwork.Lines = new string[0];
            this.tIRCBotNetwork.Location = new System.Drawing.Point(121, 19);
            this.tIRCBotNetwork.MaxLength = 512;
            this.tIRCBotNetwork.Name = "tIRCBotNetwork";
            this.tIRCBotNetwork.PasswordChar = '\0';
            this.tIRCBotNetwork.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIRCBotNetwork.SelectedText = "";
            this.tIRCBotNetwork.SelectionLength = 0;
            this.tIRCBotNetwork.SelectionStart = 0;
            this.tIRCBotNetwork.ShortcutsEnabled = true;
            this.tIRCBotNetwork.Size = new System.Drawing.Size(138, 21);
            this.tIRCBotNetwork.TabIndex = 1;
            this.tIRCBotNetwork.UseSelectable = true;
            this.tIRCBotNetwork.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIRCBotNetwork.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lIRCBotNetwork
            // 
            this.lIRCBotNetwork.AutoSize = true;
            this.lIRCBotNetwork.Location = new System.Drawing.Point(26, 22);
            this.lIRCBotNetwork.Name = "lIRCBotNetwork";
            this.lIRCBotNetwork.Size = new System.Drawing.Size(101, 19);
            this.lIRCBotNetwork.TabIndex = 0;
            this.lIRCBotNetwork.Text = "IRC Server Host";
            // 
            // lIRCBotNick
            // 
            this.lIRCBotNick.AutoSize = true;
            this.lIRCBotNick.Location = new System.Drawing.Point(65, 102);
            this.lIRCBotNick.Name = "lIRCBotNick";
            this.lIRCBotNick.Size = new System.Drawing.Size(55, 19);
            this.lIRCBotNick.TabIndex = 11;
            this.lIRCBotNick.Text = "Bot nick";
            // 
            // tIRCBotNick
            // 
            // 
            // 
            // 
            this.tIRCBotNick.CustomButton.Image = null;
            this.tIRCBotNick.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tIRCBotNick.CustomButton.Name = "";
            this.tIRCBotNick.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIRCBotNick.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIRCBotNick.CustomButton.TabIndex = 1;
            this.tIRCBotNick.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIRCBotNick.CustomButton.UseSelectable = true;
            this.tIRCBotNick.CustomButton.Visible = false;
            this.tIRCBotNick.Lines = new string[0];
            this.tIRCBotNick.Location = new System.Drawing.Point(121, 99);
            this.tIRCBotNick.MaxLength = 32;
            this.tIRCBotNick.Name = "tIRCBotNick";
            this.tIRCBotNick.PasswordChar = '\0';
            this.tIRCBotNick.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIRCBotNick.SelectedText = "";
            this.tIRCBotNick.SelectionLength = 0;
            this.tIRCBotNick.SelectionStart = 0;
            this.tIRCBotNick.ShortcutsEnabled = true;
            this.tIRCBotNick.Size = new System.Drawing.Size(138, 21);
            this.tIRCBotNick.TabIndex = 12;
            this.tIRCBotNick.UseSelectable = true;
            this.tIRCBotNick.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIRCBotNick.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lIRCList
            // 
            this.lIRCList.AutoSize = true;
            this.lIRCList.Enabled = false;
            this.lIRCList.Location = new System.Drawing.Point(203, 13);
            this.lIRCList.Name = "lIRCList";
            this.lIRCList.Size = new System.Drawing.Size(112, 19);
            this.lIRCList.TabIndex = 1;
            this.lIRCList.Text = "Popular networks:";
            // 
            // xIRCBotEnabled
            // 
            this.xIRCBotEnabled.AutoSize = true;
            this.xIRCBotEnabled.Location = new System.Drawing.Point(14, 13);
            this.xIRCBotEnabled.Name = "xIRCBotEnabled";
            this.xIRCBotEnabled.Size = new System.Drawing.Size(140, 15);
            this.xIRCBotEnabled.TabIndex = 0;
            this.xIRCBotEnabled.Text = "Enable IRC integration";
            this.xIRCBotEnabled.UseSelectable = true;
            // 
            // cIRCList
            // 
            this.cIRCList.Enabled = false;
            this.cIRCList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cIRCList.FormattingEnabled = true;
            this.cIRCList.ItemHeight = 23;
            this.cIRCList.Location = new System.Drawing.Point(321, 11);
            this.cIRCList.Name = "cIRCList";
            this.cIRCList.Size = new System.Drawing.Size(138, 29);
            this.cIRCList.TabIndex = 2;
            this.cIRCList.UseSelectable = true;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.Color.Gray;
            this.tabAdvanced.Controls.Add(this.gPerformance);
            this.tabAdvanced.Controls.Add(this.gAdvancedMisc);
            this.tabAdvanced.Controls.Add(this.gCrashReport);
            this.tabAdvanced.HorizontalScrollbarBarColor = true;
            this.tabAdvanced.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdvanced.HorizontalScrollbarSize = 10;
            this.tabAdvanced.Location = new System.Drawing.Point(4, 38);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tabAdvanced.Size = new System.Drawing.Size(652, 484);
            this.tabAdvanced.TabIndex = 6;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.VerticalScrollbarBarColor = true;
            this.tabAdvanced.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdvanced.VerticalScrollbarSize = 10;
            // 
            // gPerformance
            // 
            this.gPerformance.ActiveControl = null;
            this.gPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPerformance.Controls.Add(this.lAdvancedWarning);
            this.gPerformance.Controls.Add(this.xLowLatencyMode);
            this.gPerformance.Controls.Add(this.lProcessPriority);
            this.gPerformance.Controls.Add(this.cProcessPriority);
            this.gPerformance.Controls.Add(this.nTickInterval);
            this.gPerformance.Controls.Add(this.lTickIntervalUnits);
            this.gPerformance.Controls.Add(this.lTickInterval);
            this.gPerformance.Controls.Add(this.nThrottling);
            this.gPerformance.Controls.Add(this.lThrottling);
            this.gPerformance.Controls.Add(this.lThrottlingUnits);
            this.gPerformance.Location = new System.Drawing.Point(8, 318);
            this.gPerformance.Name = "gPerformance";
            this.gPerformance.Size = new System.Drawing.Size(636, 165);
            this.gPerformance.TabIndex = 2;
            this.gPerformance.TabStop = false;
            this.gPerformance.Text = "Performance";
            this.gPerformance.UseSelectable = true;
            // 
            // lAdvancedWarning
            // 
            this.lAdvancedWarning.AutoSize = true;
            this.lAdvancedWarning.Location = new System.Drawing.Point(15, 21);
            this.lAdvancedWarning.Name = "lAdvancedWarning";
            this.lAdvancedWarning.Size = new System.Drawing.Size(510, 38);
            this.lAdvancedWarning.TabIndex = 0;
            this.lAdvancedWarning.Text = "Warning: Altering these settings may decrease your server\'s stability and perform" +
    "ance.\r\nIf you\'re not sure what these settings do, you probably shouldn\'t change " +
    "them...";
            // 
            // xLowLatencyMode
            // 
            this.xLowLatencyMode.AutoSize = true;
            this.xLowLatencyMode.Location = new System.Drawing.Point(6, 64);
            this.xLowLatencyMode.Name = "xLowLatencyMode";
            this.xLowLatencyMode.Size = new System.Drawing.Size(528, 15);
            this.xLowLatencyMode.TabIndex = 3;
            this.xLowLatencyMode.Text = "Low-latency mode (disables Nagle\'s algorithm, reducing latency but increasing ban" +
    "dwidth use).";
            this.xLowLatencyMode.UseSelectable = true;
            // 
            // lProcessPriority
            // 
            this.lProcessPriority.AutoSize = true;
            this.lProcessPriority.Location = new System.Drawing.Point(19, 94);
            this.lProcessPriority.Name = "lProcessPriority";
            this.lProcessPriority.Size = new System.Drawing.Size(99, 19);
            this.lProcessPriority.TabIndex = 10;
            this.lProcessPriority.Text = "Process priority";
            // 
            // cProcessPriority
            // 
            this.cProcessPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cProcessPriority.ItemHeight = 23;
            this.cProcessPriority.Items.AddRange(new object[] {
            "(system default)",
            "High",
            "Above Normal",
            "Normal",
            "Below Normal",
            "Low"});
            this.cProcessPriority.Location = new System.Drawing.Point(115, 91);
            this.cProcessPriority.Name = "cProcessPriority";
            this.cProcessPriority.Size = new System.Drawing.Size(109, 29);
            this.cProcessPriority.TabIndex = 11;
            this.cProcessPriority.UseSelectable = true;
            // 
            // nTickInterval
            // 
            this.nTickInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nTickInterval.Location = new System.Drawing.Point(429, 92);
            this.nTickInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nTickInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nTickInterval.Name = "nTickInterval";
            this.nTickInterval.Size = new System.Drawing.Size(70, 20);
            this.nTickInterval.TabIndex = 13;
            this.nTickInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lTickIntervalUnits
            // 
            this.lTickIntervalUnits.AutoSize = true;
            this.lTickIntervalUnits.Location = new System.Drawing.Point(505, 94);
            this.lTickIntervalUnits.Name = "lTickIntervalUnits";
            this.lTickIntervalUnits.Size = new System.Drawing.Size(26, 19);
            this.lTickIntervalUnits.TabIndex = 14;
            this.lTickIntervalUnits.Text = "ms";
            // 
            // lTickInterval
            // 
            this.lTickInterval.AutoSize = true;
            this.lTickInterval.Location = new System.Drawing.Point(352, 94);
            this.lTickInterval.Name = "lTickInterval";
            this.lTickInterval.Size = new System.Drawing.Size(78, 19);
            this.lTickInterval.TabIndex = 12;
            this.lTickInterval.Text = "Tick interval";
            // 
            // nThrottling
            // 
            this.nThrottling.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nThrottling.Location = new System.Drawing.Point(115, 120);
            this.nThrottling.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nThrottling.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nThrottling.Name = "nThrottling";
            this.nThrottling.Size = new System.Drawing.Size(70, 20);
            this.nThrottling.TabIndex = 16;
            this.nThrottling.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // lThrottling
            // 
            this.lThrottling.AutoSize = true;
            this.lThrottling.Location = new System.Drawing.Point(22, 122);
            this.lThrottling.Name = "lThrottling";
            this.lThrottling.Size = new System.Drawing.Size(97, 19);
            this.lThrottling.TabIndex = 15;
            this.lThrottling.Text = "Block throttling";
            // 
            // lThrottlingUnits
            // 
            this.lThrottlingUnits.AutoSize = true;
            this.lThrottlingUnits.Location = new System.Drawing.Point(191, 122);
            this.lThrottlingUnits.Name = "lThrottlingUnits";
            this.lThrottlingUnits.Size = new System.Drawing.Size(142, 19);
            this.lThrottlingUnits.TabIndex = 17;
            this.lThrottlingUnits.Text = "blocks / second / client";
            // 
            // gAdvancedMisc
            // 
            this.gAdvancedMisc.ActiveControl = null;
            this.gAdvancedMisc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gAdvancedMisc.Controls.Add(this.xAutoRank);
            this.gAdvancedMisc.Controls.Add(this.nMaxUndoStates);
            this.gAdvancedMisc.Controls.Add(this.lMaxUndoStates);
            this.gAdvancedMisc.Controls.Add(this.lIPWarning);
            this.gAdvancedMisc.Controls.Add(this.tIP);
            this.gAdvancedMisc.Controls.Add(this.xIP);
            this.gAdvancedMisc.Controls.Add(this.lConsoleName);
            this.gAdvancedMisc.Controls.Add(this.tConsoleName);
            this.gAdvancedMisc.Controls.Add(this.nMaxUndo);
            this.gAdvancedMisc.Controls.Add(this.lMaxUndoUnits);
            this.gAdvancedMisc.Controls.Add(this.xMaxUndo);
            this.gAdvancedMisc.Controls.Add(this.xRelayAllBlockUpdates);
            this.gAdvancedMisc.Controls.Add(this.xNoPartialPositionUpdates);
            this.gAdvancedMisc.Location = new System.Drawing.Point(8, 99);
            this.gAdvancedMisc.Name = "gAdvancedMisc";
            this.gAdvancedMisc.Size = new System.Drawing.Size(636, 213);
            this.gAdvancedMisc.TabIndex = 1;
            this.gAdvancedMisc.TabStop = false;
            this.gAdvancedMisc.Text = "Miscellaneous";
            this.gAdvancedMisc.UseSelectable = true;
            // 
            // xAutoRank
            // 
            this.xAutoRank.AutoSize = true;
            this.xAutoRank.Location = new System.Drawing.Point(9, 188);
            this.xAutoRank.Name = "xAutoRank";
            this.xAutoRank.Size = new System.Drawing.Size(113, 15);
            this.xAutoRank.TabIndex = 24;
            this.xAutoRank.Text = "Enable AutoRank";
            this.xAutoRank.UseSelectable = true;
            // 
            // nMaxUndoStates
            // 
            this.nMaxUndoStates.Location = new System.Drawing.Point(115, 71);
            this.nMaxUndoStates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxUndoStates.Name = "nMaxUndoStates";
            this.nMaxUndoStates.Size = new System.Drawing.Size(58, 20);
            this.nMaxUndoStates.TabIndex = 23;
            this.nMaxUndoStates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lMaxUndoStates
            // 
            this.lMaxUndoStates.AutoSize = true;
            this.lMaxUndoStates.Location = new System.Drawing.Point(179, 73);
            this.lMaxUndoStates.Name = "lMaxUndoStates";
            this.lMaxUndoStates.Size = new System.Drawing.Size(79, 19);
            this.lMaxUndoStates.TabIndex = 22;
            this.lMaxUndoStates.Text = "states, up to";
            // 
            // lIPWarning
            // 
            this.lIPWarning.AutoSize = true;
            this.lIPWarning.Location = new System.Drawing.Point(112, 131);
            this.lIPWarning.Name = "lIPWarning";
            this.lIPWarning.Size = new System.Drawing.Size(500, 19);
            this.lIPWarning.TabIndex = 20;
            this.lIPWarning.Text = "Note: You do not need to specify an IP address unless you have multiple NICs or I" +
    "Ps.";
            // 
            // tIP
            // 
            // 
            // 
            // 
            this.tIP.CustomButton.Image = null;
            this.tIP.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.tIP.CustomButton.Name = "";
            this.tIP.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIP.CustomButton.TabIndex = 1;
            this.tIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIP.CustomButton.UseSelectable = true;
            this.tIP.CustomButton.Visible = false;
            this.tIP.Lines = new string[0];
            this.tIP.Location = new System.Drawing.Point(115, 107);
            this.tIP.MaxLength = 15;
            this.tIP.Name = "tIP";
            this.tIP.PasswordChar = '\0';
            this.tIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIP.SelectedText = "";
            this.tIP.SelectionLength = 0;
            this.tIP.SelectionStart = 0;
            this.tIP.ShortcutsEnabled = true;
            this.tIP.Size = new System.Drawing.Size(97, 21);
            this.tIP.TabIndex = 19;
            this.tIP.UseSelectable = true;
            this.tIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xIP
            // 
            this.xIP.AutoSize = true;
            this.xIP.Location = new System.Drawing.Point(6, 109);
            this.xIP.Name = "xIP";
            this.xIP.Size = new System.Drawing.Size(95, 15);
            this.xIP.TabIndex = 18;
            this.xIP.Text = "Designated IP";
            this.xIP.UseSelectable = true;
            // 
            // lConsoleName
            // 
            this.lConsoleName.AutoSize = true;
            this.lConsoleName.Location = new System.Drawing.Point(6, 161);
            this.lConsoleName.Name = "lConsoleName";
            this.lConsoleName.Size = new System.Drawing.Size(93, 19);
            this.lConsoleName.TabIndex = 7;
            this.lConsoleName.Text = "Console name";
            // 
            // tConsoleName
            // 
            // 
            // 
            // 
            this.tConsoleName.CustomButton.Image = null;
            this.tConsoleName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.tConsoleName.CustomButton.Name = "";
            this.tConsoleName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tConsoleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tConsoleName.CustomButton.TabIndex = 1;
            this.tConsoleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tConsoleName.CustomButton.UseSelectable = true;
            this.tConsoleName.CustomButton.Visible = false;
            this.tConsoleName.Lines = new string[0];
            this.tConsoleName.Location = new System.Drawing.Point(115, 158);
            this.tConsoleName.MaxLength = 32767;
            this.tConsoleName.Name = "tConsoleName";
            this.tConsoleName.PasswordChar = '\0';
            this.tConsoleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tConsoleName.SelectedText = "";
            this.tConsoleName.SelectionLength = 0;
            this.tConsoleName.SelectionStart = 0;
            this.tConsoleName.ShortcutsEnabled = true;
            this.tConsoleName.Size = new System.Drawing.Size(167, 21);
            this.tConsoleName.TabIndex = 8;
            this.tConsoleName.UseSelectable = true;
            this.tConsoleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tConsoleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nMaxUndo
            // 
            this.nMaxUndo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxUndo.Location = new System.Drawing.Point(257, 71);
            this.nMaxUndo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nMaxUndo.Name = "nMaxUndo";
            this.nMaxUndo.Size = new System.Drawing.Size(86, 20);
            this.nMaxUndo.TabIndex = 5;
            this.nMaxUndo.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // lMaxUndoUnits
            // 
            this.lMaxUndoUnits.AutoSize = true;
            this.lMaxUndoUnits.Location = new System.Drawing.Point(349, 73);
            this.lMaxUndoUnits.Name = "lMaxUndoUnits";
            this.lMaxUndoUnits.Size = new System.Drawing.Size(282, 19);
            this.lMaxUndoUnits.TabIndex = 6;
            this.lMaxUndoUnits.Text = "blocks each (up to 16.0 MB of RAM per player)";
            // 
            // xMaxUndo
            // 
            this.xMaxUndo.AutoSize = true;
            this.xMaxUndo.Checked = true;
            this.xMaxUndo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xMaxUndo.Location = new System.Drawing.Point(6, 72);
            this.xMaxUndo.Name = "xMaxUndo";
            this.xMaxUndo.Size = new System.Drawing.Size(100, 15);
            this.xMaxUndo.TabIndex = 4;
            this.xMaxUndo.Text = "Limit /undo to";
            this.xMaxUndo.UseSelectable = true;
            // 
            // xRelayAllBlockUpdates
            // 
            this.xRelayAllBlockUpdates.AutoSize = true;
            this.xRelayAllBlockUpdates.Location = new System.Drawing.Point(6, 21);
            this.xRelayAllBlockUpdates.Name = "xRelayAllBlockUpdates";
            this.xRelayAllBlockUpdates.Size = new System.Drawing.Size(543, 15);
            this.xRelayAllBlockUpdates.TabIndex = 1;
            this.xRelayAllBlockUpdates.Text = "When a player changes a block, send him the redundant update packet anyway (origi" +
    "nal behavior).";
            this.xRelayAllBlockUpdates.UseSelectable = true;
            // 
            // xNoPartialPositionUpdates
            // 
            this.xNoPartialPositionUpdates.AutoSize = true;
            this.xNoPartialPositionUpdates.Location = new System.Drawing.Point(6, 46);
            this.xNoPartialPositionUpdates.Name = "xNoPartialPositionUpdates";
            this.xNoPartialPositionUpdates.Size = new System.Drawing.Size(311, 15);
            this.xNoPartialPositionUpdates.TabIndex = 2;
            this.xNoPartialPositionUpdates.Text = "Do not use partial position updates (opcodes 9, 10, 11).";
            this.xNoPartialPositionUpdates.UseSelectable = true;
            // 
            // gCrashReport
            // 
            this.gCrashReport.ActiveControl = null;
            this.gCrashReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCrashReport.Controls.Add(this.xCrash);
            this.gCrashReport.Controls.Add(this.lCrashReportDisclaimer);
            this.gCrashReport.Location = new System.Drawing.Point(8, 13);
            this.gCrashReport.Name = "gCrashReport";
            this.gCrashReport.Size = new System.Drawing.Size(636, 80);
            this.gCrashReport.TabIndex = 0;
            this.gCrashReport.TabStop = false;
            this.gCrashReport.Text = "Crash Reporting";
            this.gCrashReport.UseSelectable = true;
            // 
            // xCrash
            // 
            this.xCrash.AutoSize = true;
            this.xCrash.Location = new System.Drawing.Point(25, 25);
            this.xCrash.Name = "xCrash";
            this.xCrash.Size = new System.Drawing.Size(16, 0);
            this.xCrash.TabIndex = 2;
            this.xCrash.UseSelectable = true;
            // 
            // lCrashReportDisclaimer
            // 
            this.lCrashReportDisclaimer.AutoSize = true;
            this.lCrashReportDisclaimer.Location = new System.Drawing.Point(45, 26);
            this.lCrashReportDisclaimer.Name = "lCrashReportDisclaimer";
            this.lCrashReportDisclaimer.Size = new System.Drawing.Size(579, 57);
            this.lCrashReportDisclaimer.TabIndex = 1;
            this.lCrashReportDisclaimer.Text = "Send all Crash Reports To The GemsCraft Dev Team\r\nCrash reports are when serious " +
    "unexpected errors occur. Being able to receive crash reports helps\r\nidentify bug" +
    "s and improve GemsCraft! ";
            // 
            // Misc
            // 
            this.Misc.BackColor = System.Drawing.Color.Gray;
            this.Misc.Controls.Add(this.gboDragon);
            this.Misc.Controls.Add(this.groupBox3);
            this.Misc.Controls.Add(this.groupBox1);
            this.Misc.HorizontalScrollbarBarColor = true;
            this.Misc.HorizontalScrollbarHighlightOnWheel = false;
            this.Misc.HorizontalScrollbarSize = 10;
            this.Misc.Location = new System.Drawing.Point(4, 38);
            this.Misc.Name = "Misc";
            this.Misc.Padding = new System.Windows.Forms.Padding(3);
            this.Misc.Size = new System.Drawing.Size(652, 484);
            this.Misc.TabIndex = 11;
            this.Misc.Text = "Misc";
            this.Misc.VerticalScrollbarBarColor = true;
            this.Misc.VerticalScrollbarHighlightOnWheel = false;
            this.Misc.VerticalScrollbarSize = 10;
            // 
            // gboDragon
            // 
            this.gboDragon.ActiveControl = null;
            this.gboDragon.Controls.Add(this.clbDragonPermits);
            this.gboDragon.Controls.Add(this.cboDragonDefault);
            this.gboDragon.Controls.Add(this.lblDefaultBlock);
            this.gboDragon.Location = new System.Drawing.Point(31, 327);
            this.gboDragon.Name = "gboDragon";
            this.gboDragon.Size = new System.Drawing.Size(200, 138);
            this.gboDragon.TabIndex = 28;
            this.gboDragon.TabStop = false;
            this.gboDragon.Text = "Dragon";
            this.gboDragon.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.gboDragon.UseSelectable = true;
            // 
            // clbDragonPermits
            // 
            this.clbDragonPermits.FormattingEnabled = true;
            this.clbDragonPermits.Items.AddRange(new object[] {
            "Fire",
            "Magma",
            "Lava",
            "Red"});
            this.clbDragonPermits.Location = new System.Drawing.Point(13, 51);
            this.clbDragonPermits.Name = "clbDragonPermits";
            this.clbDragonPermits.Size = new System.Drawing.Size(76, 64);
            this.clbDragonPermits.TabIndex = 2;
            // 
            // cboDragonDefault
            // 
            this.cboDragonDefault.FormattingEnabled = true;
            this.cboDragonDefault.ItemHeight = 23;
            this.cboDragonDefault.Items.AddRange(new object[] {
            "Fire",
            "Magma",
            "Lava",
            "Red"});
            this.cboDragonDefault.Location = new System.Drawing.Point(99, 18);
            this.cboDragonDefault.Name = "cboDragonDefault";
            this.cboDragonDefault.Size = new System.Drawing.Size(86, 29);
            this.cboDragonDefault.TabIndex = 1;
            this.cboDragonDefault.UseSelectable = true;
            // 
            // lblDefaultBlock
            // 
            this.lblDefaultBlock.AutoSize = true;
            this.lblDefaultBlock.Location = new System.Drawing.Point(13, 21);
            this.lblDefaultBlock.Name = "lblDefaultBlock";
            this.lblDefaultBlock.Size = new System.Drawing.Size(85, 19);
            this.lblDefaultBlock.TabIndex = 0;
            this.lblDefaultBlock.Text = "Default Block";
            // 
            // groupBox3
            // 
            this.groupBox3.ActiveControl = null;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.websiteURL);
            this.groupBox3.Controls.Add(this.ReqsEditor);
            this.groupBox3.Controls.Add(this.SwearEditor);
            this.groupBox3.Controls.Add(this.MaxCapsValue);
            this.groupBox3.Controls.Add(this.MaxCaps);
            this.groupBox3.Controls.Add(this.SwearBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(31, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 142);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Configurations";
            this.groupBox3.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "WebsiteURL";
            // 
            // websiteURL
            // 
            // 
            // 
            // 
            this.websiteURL.CustomButton.Image = null;
            this.websiteURL.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.websiteURL.CustomButton.Name = "";
            this.websiteURL.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.websiteURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.websiteURL.CustomButton.TabIndex = 1;
            this.websiteURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.websiteURL.CustomButton.UseSelectable = true;
            this.websiteURL.CustomButton.Visible = false;
            this.websiteURL.Lines = new string[0];
            this.websiteURL.Location = new System.Drawing.Point(110, 67);
            this.websiteURL.MaxLength = 32767;
            this.websiteURL.Name = "websiteURL";
            this.websiteURL.PasswordChar = '\0';
            this.websiteURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.websiteURL.SelectedText = "";
            this.websiteURL.SelectionLength = 0;
            this.websiteURL.SelectionStart = 0;
            this.websiteURL.ShortcutsEnabled = true;
            this.websiteURL.Size = new System.Drawing.Size(212, 21);
            this.websiteURL.TabIndex = 28;
            this.websiteURL.UseSelectable = true;
            this.websiteURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.websiteURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ReqsEditor
            // 
            this.ReqsEditor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReqsEditor.Location = new System.Drawing.Point(442, 94);
            this.ReqsEditor.Name = "ReqsEditor";
            this.ReqsEditor.Size = new System.Drawing.Size(125, 23);
            this.ReqsEditor.TabIndex = 26;
            this.ReqsEditor.Text = "Edit Requirements";
            this.ReqsEditor.UseSelectable = true;
            // 
            // SwearEditor
            // 
            this.SwearEditor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SwearEditor.Location = new System.Drawing.Point(442, 65);
            this.SwearEditor.Name = "SwearEditor";
            this.SwearEditor.Size = new System.Drawing.Size(125, 23);
            this.SwearEditor.TabIndex = 25;
            this.SwearEditor.Text = "Edit Profanity List";
            this.SwearEditor.UseSelectable = true;
            // 
            // MaxCapsValue
            // 
            this.MaxCapsValue.Location = new System.Drawing.Point(110, 32);
            this.MaxCapsValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaxCapsValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxCapsValue.Name = "MaxCapsValue";
            this.MaxCapsValue.Size = new System.Drawing.Size(75, 20);
            this.MaxCapsValue.TabIndex = 21;
            this.MaxCapsValue.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // MaxCaps
            // 
            this.MaxCaps.AutoSize = true;
            this.MaxCaps.Location = new System.Drawing.Point(10, 34);
            this.MaxCaps.Name = "MaxCaps";
            this.MaxCaps.Size = new System.Drawing.Size(101, 19);
            this.MaxCaps.TabIndex = 20;
            this.MaxCaps.Text = "Maximum Caps";
            // 
            // SwearBox
            // 
            this.SwearBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SwearBox.CustomButton.Image = null;
            this.SwearBox.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.SwearBox.CustomButton.Name = "";
            this.SwearBox.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SwearBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SwearBox.CustomButton.TabIndex = 1;
            this.SwearBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SwearBox.CustomButton.UseSelectable = true;
            this.SwearBox.CustomButton.Visible = false;
            this.SwearBox.Lines = new string[0];
            this.SwearBox.Location = new System.Drawing.Point(442, 34);
            this.SwearBox.MaxLength = 64;
            this.SwearBox.Name = "SwearBox";
            this.SwearBox.PasswordChar = '\0';
            this.SwearBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SwearBox.SelectedText = "";
            this.SwearBox.SelectionLength = 0;
            this.SwearBox.SelectionStart = 0;
            this.SwearBox.ShortcutsEnabled = true;
            this.SwearBox.Size = new System.Drawing.Size(125, 21);
            this.SwearBox.TabIndex = 22;
            this.SwearBox.UseSelectable = true;
            this.SwearBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SwearBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Word for swears to be replaced with: ";
            // 
            // groupBox1
            // 
            this.groupBox1.ActiveControl = null;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CustomColor);
            this.groupBox1.Controls.Add(this.CustomText);
            this.groupBox1.Controls.Add(this.CustomName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CustomAliases);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 146);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Chat Channel";
            this.groupBox1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.groupBox1.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Custom Chat Channel Command Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(450, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 76);
            this.label4.TabIndex = 25;
            this.label4.Text = "The name should be \r\nin this format: \r\n\'staffchat\'. No spaces or \r\nsymbols (inclu" +
    "ding \"/\")";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomColor
            // 
            this.CustomColor.BackColor = System.Drawing.Color.White;
            this.CustomColor.Location = new System.Drawing.Point(244, 62);
            this.CustomColor.Name = "CustomColor";
            this.CustomColor.Size = new System.Drawing.Size(100, 23);
            this.CustomColor.TabIndex = 15;
            this.CustomColor.UseSelectable = true;
            // 
            // CustomText
            // 
            this.CustomText.AutoSize = true;
            this.CustomText.Location = new System.Drawing.Point(65, 62);
            this.CustomText.Name = "CustomText";
            this.CustomText.Size = new System.Drawing.Size(173, 19);
            this.CustomText.TabIndex = 14;
            this.CustomText.Text = "Custom Chat Channel Color";
            // 
            // CustomName
            // 
            this.CustomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CustomName.CustomButton.Image = null;
            this.CustomName.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.CustomName.CustomButton.Name = "";
            this.CustomName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.CustomName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomName.CustomButton.TabIndex = 1;
            this.CustomName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomName.CustomButton.UseSelectable = true;
            this.CustomName.CustomButton.Visible = false;
            this.CustomName.Lines = new string[0];
            this.CustomName.Location = new System.Drawing.Point(246, 20);
            this.CustomName.MaxLength = 64;
            this.CustomName.Name = "CustomName";
            this.CustomName.PasswordChar = '\0';
            this.CustomName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomName.SelectedText = "";
            this.CustomName.SelectionLength = 0;
            this.CustomName.SelectionStart = 0;
            this.CustomName.ShortcutsEnabled = true;
            this.CustomName.Size = new System.Drawing.Size(169, 21);
            this.CustomName.TabIndex = 17;
            this.CustomName.UseSelectable = true;
            this.CustomName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Custom Chat Channel Aliases";
            // 
            // CustomAliases
            // 
            this.CustomAliases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CustomAliases.CustomButton.Image = null;
            this.CustomAliases.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.CustomAliases.CustomButton.Name = "";
            this.CustomAliases.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.CustomAliases.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomAliases.CustomButton.TabIndex = 1;
            this.CustomAliases.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomAliases.CustomButton.UseSelectable = true;
            this.CustomAliases.CustomButton.Visible = false;
            this.CustomAliases.Lines = new string[0];
            this.CustomAliases.Location = new System.Drawing.Point(244, 109);
            this.CustomAliases.MaxLength = 64;
            this.CustomAliases.Name = "CustomAliases";
            this.CustomAliases.PasswordChar = '\0';
            this.CustomAliases.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomAliases.SelectedText = "";
            this.CustomAliases.SelectionLength = 0;
            this.CustomAliases.SelectionStart = 0;
            this.CustomAliases.ShortcutsEnabled = true;
            this.CustomAliases.Size = new System.Drawing.Size(169, 21);
            this.CustomAliases.TabIndex = 19;
            this.CustomAliases.UseSelectable = true;
            this.CustomAliases.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomAliases.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CPETab
            // 
            this.CPETab.BackColor = System.Drawing.Color.Gray;
            this.CPETab.Controls.Add(this.gboEnvColors);
            this.CPETab.Controls.Add(this.gboMessageType);
            this.CPETab.Controls.Add(this.gboHeldBlock);
            this.CPETab.Controls.Add(this.gboCustomBlocks);
            this.CPETab.Controls.Add(this.gboClickDistance);
            this.CPETab.Controls.Add(this.lblAboutCPE);
            this.CPETab.HorizontalScrollbarBarColor = true;
            this.CPETab.HorizontalScrollbarHighlightOnWheel = false;
            this.CPETab.HorizontalScrollbarSize = 10;
            this.CPETab.Location = new System.Drawing.Point(4, 38);
            this.CPETab.Name = "CPETab";
            this.CPETab.Padding = new System.Windows.Forms.Padding(3);
            this.CPETab.Size = new System.Drawing.Size(652, 484);
            this.CPETab.TabIndex = 12;
            this.CPETab.Text = "CPE";
            this.CPETab.VerticalScrollbarBarColor = true;
            this.CPETab.VerticalScrollbarHighlightOnWheel = false;
            this.CPETab.VerticalScrollbarSize = 10;
            // 
            // gboEnvColors
            // 
            this.gboEnvColors.ActiveControl = null;
            this.gboEnvColors.Controls.Add(this.numHourLength);
            this.gboEnvColors.Controls.Add(this.lblHourLength);
            this.gboEnvColors.Controls.Add(this.chkTimeBasedSky);
            this.gboEnvColors.Controls.Add(this.chkEnvColorsAllowed);
            this.gboEnvColors.Location = new System.Drawing.Point(340, 7);
            this.gboEnvColors.Name = "gboEnvColors";
            this.gboEnvColors.Size = new System.Drawing.Size(187, 136);
            this.gboEnvColors.TabIndex = 4;
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
            this.chkTimeBasedSky.Location = new System.Drawing.Point(6, 45);
            this.chkTimeBasedSky.Name = "chkTimeBasedSky";
            this.chkTimeBasedSky.Size = new System.Drawing.Size(105, 15);
            this.chkTimeBasedSky.TabIndex = 4;
            this.chkTimeBasedSky.Text = "Time Based Sky";
            this.chkTimeBasedSky.UseSelectable = true;
            this.chkTimeBasedSky.CheckedChanged += new System.EventHandler(this.chkTimeBasedSky_CheckedChanged);
            // 
            // chkEnvColorsAllowed
            // 
            this.chkEnvColorsAllowed.AutoSize = true;
            this.chkEnvColorsAllowed.Location = new System.Drawing.Point(6, 20);
            this.chkEnvColorsAllowed.Name = "chkEnvColorsAllowed";
            this.chkEnvColorsAllowed.Size = new System.Drawing.Size(58, 15);
            this.chkEnvColorsAllowed.TabIndex = 3;
            this.chkEnvColorsAllowed.Text = "Enable";
            this.chkEnvColorsAllowed.UseSelectable = true;
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
            this.gboMessageType.Location = new System.Drawing.Point(226, 149);
            this.gboMessageType.Name = "gboMessageType";
            this.gboMessageType.Size = new System.Drawing.Size(322, 227);
            this.gboMessageType.TabIndex = 3;
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
            this.chkAnnouncementMT.Location = new System.Drawing.Point(7, 43);
            this.chkAnnouncementMT.Name = "chkAnnouncementMT";
            this.chkAnnouncementMT.Size = new System.Drawing.Size(179, 15);
            this.chkAnnouncementMT.TabIndex = 14;
            this.chkAnnouncementMT.Text = "Show Announcements at Top";
            this.chkAnnouncementMT.UseSelectable = true;
            // 
            // chkBottomRight3
            // 
            this.chkBottomRight3.AutoSize = true;
            this.chkBottomRight3.Location = new System.Drawing.Point(195, 112);
            this.chkBottomRight3.Name = "chkBottomRight3";
            this.chkBottomRight3.Size = new System.Drawing.Size(16, 0);
            this.chkBottomRight3.TabIndex = 12;
            this.chkBottomRight3.UseSelectable = true;
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
            this.chkBottomRight2.Location = new System.Drawing.Point(195, 139);
            this.chkBottomRight2.Name = "chkBottomRight2";
            this.chkBottomRight2.Size = new System.Drawing.Size(16, 0);
            this.chkBottomRight2.TabIndex = 10;
            this.chkBottomRight2.UseSelectable = true;
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
            this.chkBottomRight1.Location = new System.Drawing.Point(195, 166);
            this.chkBottomRight1.Name = "chkBottomRight1";
            this.chkBottomRight1.Size = new System.Drawing.Size(16, 0);
            this.chkBottomRight1.TabIndex = 8;
            this.chkBottomRight1.UseSelectable = true;
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
            this.chkStatus3.Location = new System.Drawing.Point(195, 75);
            this.chkStatus3.Name = "chkStatus3";
            this.chkStatus3.Size = new System.Drawing.Size(16, 0);
            this.chkStatus3.TabIndex = 6;
            this.chkStatus3.UseSelectable = true;
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
            this.chkStatus2.Location = new System.Drawing.Point(195, 48);
            this.chkStatus2.Name = "chkStatus2";
            this.chkStatus2.Size = new System.Drawing.Size(16, 0);
            this.chkStatus2.TabIndex = 4;
            this.chkStatus2.UseSelectable = true;
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
            this.chkStatus1.Location = new System.Drawing.Point(195, 21);
            this.chkStatus1.Name = "chkStatus1";
            this.chkStatus1.Size = new System.Drawing.Size(16, 0);
            this.chkStatus1.TabIndex = 2;
            this.chkStatus1.UseSelectable = true;
            this.chkStatus1.CheckedChanged += new System.EventHandler(this.chStatus1_CheckedChanged);
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
            this.chkMessageTypeAllowed.Location = new System.Drawing.Point(7, 21);
            this.chkMessageTypeAllowed.Name = "chkMessageTypeAllowed";
            this.chkMessageTypeAllowed.Size = new System.Drawing.Size(65, 15);
            this.chkMessageTypeAllowed.TabIndex = 0;
            this.chkMessageTypeAllowed.Text = "Enabled";
            this.chkMessageTypeAllowed.UseSelectable = true;
            this.chkMessageTypeAllowed.CheckedChanged += new System.EventHandler(this.chkMessageTypeAllowed_CheckedChanged);
            // 
            // gboHeldBlock
            // 
            this.gboHeldBlock.ActiveControl = null;
            this.gboHeldBlock.Controls.Add(this.chkHeldBlockAllowed);
            this.gboHeldBlock.Location = new System.Drawing.Point(533, 74);
            this.gboHeldBlock.Name = "gboHeldBlock";
            this.gboHeldBlock.Size = new System.Drawing.Size(109, 69);
            this.gboHeldBlock.TabIndex = 2;
            this.gboHeldBlock.TabStop = false;
            this.gboHeldBlock.Text = "Held Block";
            this.gboHeldBlock.UseSelectable = true;
            // 
            // chkHeldBlockAllowed
            // 
            this.chkHeldBlockAllowed.AutoSize = true;
            this.chkHeldBlockAllowed.Location = new System.Drawing.Point(7, 21);
            this.chkHeldBlockAllowed.Name = "chkHeldBlockAllowed";
            this.chkHeldBlockAllowed.Size = new System.Drawing.Size(58, 15);
            this.chkHeldBlockAllowed.TabIndex = 0;
            this.chkHeldBlockAllowed.Text = "Enable";
            this.chkHeldBlockAllowed.UseSelectable = true;
            // 
            // gboCustomBlocks
            // 
            this.gboCustomBlocks.ActiveControl = null;
            this.gboCustomBlocks.Controls.Add(this.clbBlocks);
            this.gboCustomBlocks.Controls.Add(this.chkCustomBlocksAllowed);
            this.gboCustomBlocks.Location = new System.Drawing.Point(226, 7);
            this.gboCustomBlocks.Name = "gboCustomBlocks";
            this.gboCustomBlocks.Size = new System.Drawing.Size(109, 136);
            this.gboCustomBlocks.TabIndex = 2;
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
            this.chkCustomBlocksAllowed.Location = new System.Drawing.Point(6, 21);
            this.chkCustomBlocksAllowed.Name = "chkCustomBlocksAllowed";
            this.chkCustomBlocksAllowed.Size = new System.Drawing.Size(58, 15);
            this.chkCustomBlocksAllowed.TabIndex = 1;
            this.chkCustomBlocksAllowed.Text = "Enable";
            this.chkCustomBlocksAllowed.UseSelectable = true;
            this.chkCustomBlocksAllowed.CheckedChanged += new System.EventHandler(this.chkCustomBlocksAllowed_CheckedChanged);
            // 
            // gboClickDistance
            // 
            this.gboClickDistance.ActiveControl = null;
            this.gboClickDistance.Controls.Add(this.chkClickDistanceAllowed);
            this.gboClickDistance.Location = new System.Drawing.Point(533, 7);
            this.gboClickDistance.Name = "gboClickDistance";
            this.gboClickDistance.Size = new System.Drawing.Size(109, 65);
            this.gboClickDistance.TabIndex = 1;
            this.gboClickDistance.TabStop = false;
            this.gboClickDistance.Text = "Click Distance";
            this.gboClickDistance.UseSelectable = true;
            // 
            // chkClickDistanceAllowed
            // 
            this.chkClickDistanceAllowed.AutoSize = true;
            this.chkClickDistanceAllowed.Location = new System.Drawing.Point(7, 21);
            this.chkClickDistanceAllowed.Name = "chkClickDistanceAllowed";
            this.chkClickDistanceAllowed.Size = new System.Drawing.Size(58, 15);
            this.chkClickDistanceAllowed.TabIndex = 0;
            this.chkClickDistanceAllowed.Text = "Enable";
            this.chkClickDistanceAllowed.UseSelectable = true;
            // 
            // lblAboutCPE
            // 
            this.lblAboutCPE.Location = new System.Drawing.Point(7, 7);
            this.lblAboutCPE.Name = "lblAboutCPE";
            this.lblAboutCPE.Size = new System.Drawing.Size(209, 179);
            this.lblAboutCPE.TabIndex = 0;
            this.lblAboutCPE.Text = resources.GetString("lblAboutCPE.Text");
            this.lblAboutCPE.WrapToLine = true;
            // 
            // ServerTab
            // 
            this.ServerTab.BackColor = System.Drawing.Color.Gray;
            this.ServerTab.Controls.Add(this.ThemeBox);
            this.ServerTab.Controls.Add(this.picServerStatus);
            this.ServerTab.Controls.Add(this.btnRestart);
            this.ServerTab.Controls.Add(this.pStop);
            this.ServerTab.Controls.Add(this.bStart);
            this.ServerTab.Controls.Add(this.logBox);
            this.ServerTab.Controls.Add(this.playerListLabel);
            this.ServerTab.Controls.Add(this.bVoice);
            this.ServerTab.Controls.Add(this.console);
            this.ServerTab.Controls.Add(this.playerList);
            this.ServerTab.Controls.Add(this.URLLabel);
            this.ServerTab.Controls.Add(this.bPlay);
            this.ServerTab.Controls.Add(this.uriDisplay);
            this.ServerTab.HorizontalScrollbarBarColor = true;
            this.ServerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ServerTab.HorizontalScrollbarSize = 10;
            this.ServerTab.Location = new System.Drawing.Point(4, 38);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTab.Size = new System.Drawing.Size(692, 566);
            this.ServerTab.TabIndex = 1;
            this.ServerTab.Text = "Server";
            this.ServerTab.VerticalScrollbarBarColor = true;
            this.ServerTab.VerticalScrollbarHighlightOnWheel = false;
            this.ServerTab.VerticalScrollbarSize = 10;
            this.ServerTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // picServerStatus
            // 
            this.picServerStatus.Image = global::GemsCraftGUI.Properties.Resources.server_off;
            this.picServerStatus.Location = new System.Drawing.Point(546, 91);
            this.picServerStatus.Name = "picServerStatus";
            this.picServerStatus.Size = new System.Drawing.Size(143, 143);
            this.picServerStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServerStatus.TabIndex = 19;
            this.picServerStatus.TabStop = false;
            this.picServerStatus.Click += new System.EventHandler(this.picServerStatus_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(542, 62);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(143, 23);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseSelectable = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pStop
            // 
            this.pStop.Enabled = false;
            this.pStop.Location = new System.Drawing.Point(542, 33);
            this.pStop.Name = "pStop";
            this.pStop.Size = new System.Drawing.Size(143, 23);
            this.pStop.TabIndex = 17;
            this.pStop.Text = "Stop";
            this.pStop.UseSelectable = true;
            this.pStop.Click += new System.EventHandler(this.pStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(541, 6);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(144, 23);
            this.bStart.TabIndex = 16;
            this.bStart.Text = "Start";
            this.bStart.UseSelectable = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.Enabled = false;
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.HideSelection = false;
            this.logBox.Location = new System.Drawing.Point(3, 32);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(533, 508);
            this.logBox.TabIndex = 14;
            this.logBox.Text = "";
            // 
            // playerListLabel
            // 
            this.playerListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerListLabel.AutoSize = true;
            this.playerListLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerListLabel.ForeColor = System.Drawing.Color.Black;
            this.playerListLabel.Location = new System.Drawing.Point(541, 259);
            this.playerListLabel.Name = "playerListLabel";
            this.playerListLabel.Size = new System.Drawing.Size(64, 19);
            this.playerListLabel.TabIndex = 12;
            this.playerListLabel.Text = "Player list";
            this.playerListLabel.Click += new System.EventHandler(this.playerListLabel_Click);
            // 
            // bVoice
            // 
            this.bVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVoice.Enabled = false;
            this.bVoice.Location = new System.Drawing.Point(648, 546);
            this.bVoice.Name = "bVoice";
            this.bVoice.Size = new System.Drawing.Size(37, 20);
            this.bVoice.TabIndex = 13;
            this.bVoice.Text = "V";
            this.bVoice.UseSelectable = true;
            // 
            // console
            // 
            this.console.Enabled = false;
            this.console.Location = new System.Drawing.Point(6, 546);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(636, 20);
            this.console.TabIndex = 15;
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.BackColor = System.Drawing.Color.Silver;
            this.playerList.Enabled = false;
            this.playerList.FormattingEnabled = true;
            this.playerList.IntegralHeight = false;
            this.playerList.Location = new System.Drawing.Point(542, 281);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(144, 259);
            this.playerList.TabIndex = 11;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.ForeColor = System.Drawing.Color.Black;
            this.URLLabel.Location = new System.Drawing.Point(11, 10);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(35, 19);
            this.URLLabel.TabIndex = 9;
            this.URLLabel.Text = "URL:";
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bPlay.Enabled = false;
            this.bPlay.Location = new System.Drawing.Point(488, 4);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(48, 23);
            this.bPlay.TabIndex = 8;
            this.bPlay.Text = "Play";
            this.bPlay.UseSelectable = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // uriDisplay
            // 
            // 
            // 
            // 
            this.uriDisplay.CustomButton.Image = null;
            this.uriDisplay.CustomButton.Location = new System.Drawing.Point(416, 2);
            this.uriDisplay.CustomButton.Name = "";
            this.uriDisplay.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.uriDisplay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uriDisplay.CustomButton.TabIndex = 1;
            this.uriDisplay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uriDisplay.CustomButton.UseSelectable = true;
            this.uriDisplay.CustomButton.Visible = false;
            this.uriDisplay.Enabled = false;
            this.uriDisplay.Lines = new string[0];
            this.uriDisplay.Location = new System.Drawing.Point(48, 6);
            this.uriDisplay.MaxLength = 32767;
            this.uriDisplay.Name = "uriDisplay";
            this.uriDisplay.PasswordChar = '\0';
            this.uriDisplay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uriDisplay.SelectedText = "";
            this.uriDisplay.SelectionLength = 0;
            this.uriDisplay.SelectionStart = 0;
            this.uriDisplay.ShortcutsEnabled = true;
            this.uriDisplay.Size = new System.Drawing.Size(434, 20);
            this.uriDisplay.TabIndex = 10;
            this.uriDisplay.UseSelectable = true;
            this.uriDisplay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uriDisplay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 11111;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // ThemeBox
            // 
            this.ThemeBox.FormattingEnabled = true;
            this.ThemeBox.ItemHeight = 23;
            this.ThemeBox.Location = new System.Drawing.Point(542, 240);
            this.ThemeBox.Name = "ThemeBox";
            this.ThemeBox.Size = new System.Drawing.Size(121, 29);
            this.ThemeBox.TabIndex = 20;
            this.ThemeBox.UseSelectable = true;
            this.ThemeBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 671);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GemsCraft";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabRanks.ResumeLayout(false);
            this.tabRanks.PerformLayout();
            this.gPermissionLimits.ResumeLayout(false);
            this.gRankOptions.ResumeLayout(false);
            this.gRankOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFillLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCopyPasteSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKickIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefBlocks)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.gBasic.ResumeLayout(false);
            this.gBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayersPerWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUploadBandwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxPlayers)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gInformation.ResumeLayout(false);
            this.gInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAnnouncements)).EndInit();
            this.tabChat.ResumeLayout(false);
            this.gAppearence.ResumeLayout(false);
            this.gAppearence.PerformLayout();
            this.gChatColors.ResumeLayout(false);
            this.gChatColors.PerformLayout();
            this.tabWorlds.ResumeLayout(false);
            this.tabWorlds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorlds)).EndInit();
            this.tabSecurity.ResumeLayout(false);
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
            this.gUpdate.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gDataBackup.ResumeLayout(false);
            this.gDataBackup.PerformLayout();
            this.gSaving.ResumeLayout(false);
            this.gSaving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSaveInterval)).EndInit();
            this.gBackups.ResumeLayout(false);
            this.gBackups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackupSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackupInterval)).EndInit();
            this.tabLogging.ResumeLayout(false);
            this.gLogFile.ResumeLayout(false);
            this.gLogFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLogLimit)).EndInit();
            this.gConsole.ResumeLayout(false);
            this.gConsole.PerformLayout();
            this.tabIRC.ResumeLayout(false);
            this.tabIRC.PerformLayout();
            this.gIRCAdv.ResumeLayout(false);
            this.gIRCAdv.PerformLayout();
            this.gIRCOptions.ResumeLayout(false);
            this.gIRCOptions.PerformLayout();
            this.gIRCNetwork.ResumeLayout(false);
            this.gIRCNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIRCDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRCBotPort)).EndInit();
            this.tabAdvanced.ResumeLayout(false);
            this.gPerformance.ResumeLayout(false);
            this.gPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTickInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nThrottling)).EndInit();
            this.gAdvancedMisc.ResumeLayout(false);
            this.gAdvancedMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndoStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndo)).EndInit();
            this.gCrashReport.ResumeLayout(false);
            this.gCrashReport.PerformLayout();
            this.Misc.ResumeLayout(false);
            this.gboDragon.ResumeLayout(false);
            this.gboDragon.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCapsValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CPETab.ResumeLayout(false);
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
            this.ServerTab.ResumeLayout(false);
            this.ServerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroTabControl tabControl1;
        private MetroTabPage tabPage1;
        private MetroTabPage ServerTab;
        private MetroButton bApply;
        private MetroButton bResetAll;
        private MetroButton bResetTab;
        private MetroButton bCancel;
        private MetroButton bOK;
        private MetroTabControl tabs;
        private MetroTabPage tabGeneral;
        private MetroTile gBasic;
        private NumericUpDown nMaxPlayersPerWorld;
        private MetroLabel lMaxPlayersPerWorld;
        private MetroLabel lPort;
        private NumericUpDown nPort;
        private MetroComboBox cDefaultRank;
        private MetroLabel lDefaultRank;
        private MetroLabel lUploadBandwidth;
        private MetroButton bMeasure;
        private MetroTextBox tServerName;
        private MetroLabel lUploadBandwidthUnits;
        private MetroLabel lServerName;
        private NumericUpDown nUploadBandwidth;
        private MetroTextBox tMOTD;
        private MetroLabel lMOTD;
        private MetroComboBox cPublic;
        private NumericUpDown nMaxPlayers;
        private MetroLabel lMaxPlayers;
        private MetroTile groupBox4;
        private MetroButton bWiki;
        private MetroButton bWeb;
        private PictureBox pictureBox1;
        private MetroTile groupBox2;
        private MetroButton bChangelog;
        private MetroButton bCredits;
        private MetroButton bReadme;
        private MetroTile gInformation;
        private MetroButton bGreeting;
        private MetroLabel lAnnouncementsUnits;
        private NumericUpDown nAnnouncements;
        private MetroCheckBox xAnnouncements;
        private MetroButton bRules;
        private MetroButton bAnnouncements;
        private MetroTabPage tabChat;
        private MetroTile gAppearence;
        private MetroCheckBox xShowConnectionMessages;
        private MetroCheckBox xShowJoinedWorldMessages;
        private MetroCheckBox xRankColorsInWorldNames;
        private MetroCheckBox xRankPrefixesInList;
        private MetroCheckBox xRankPrefixesInChat;
        private MetroCheckBox xRankColorsInChat;
        private MetroTile gChatColors;
        private MetroLabel lColorMe;
        private MetroButton bColorGlobal;
        private MetroButton bColorMe;
        private MetroLabel lColorWarning;
        private MetroButton bColorWarning;
        private MetroButton bColorSys;
        private MetroLabel lColorSys;
        private MetroButton bColorPM;
        private MetroLabel lColorHelp;
        private MetroLabel lColorPM;
        private MetroLabel IColorGlobal;
        private MetroLabel lColorSay;
        private MetroButton bColorAnnouncement;
        private MetroLabel lColorAnnouncement;
        private MetroButton bColorHelp;
        private MetroButton bColorSay;
        private MetroTabPage tabWorlds;
        private MetroCheckBox xWoMEnableEnvExtensions;
        private MetroButton bMapPath;
        private MetroCheckBox xMapPath;
        private MetroTextBox tMapPath;
        private MetroLabel lDefaultBuildRank;
        private MetroComboBox cDefaultBuildRank;
        private MetroComboBox cMainWorld;
        private MetroLabel lMainWorld;
        private MetroButton bWorldEdit;
        private MetroButton bAddWorld;
        private MetroButton bWorldDelete;
        private DataGridView dgvWorlds;
        private DataGridViewTextBoxColumn dgvcName;
        private DataGridViewTextBoxColumn dgvcDescription;
        private DataGridViewComboBoxColumn dgvcAccess;
        private DataGridViewComboBoxColumn dgvcBuild;
        private DataGridViewComboBoxColumn dgvcBackup;
        private DataGridViewCheckBoxColumn dgvcHidden;
        private DataGridViewCheckBoxColumn dgvcBlockDB;
        private MetroTabPage tabRanks;
        private MetroTile gPermissionLimits;
        private FlowLayoutPanel permissionLimitBoxContainer;
        private MetroLabel lRankList;
        private MetroButton bLowerRank;
        private MetroButton bRaiseRank;
        private MetroTile gRankOptions;
        private MetroLabel lFillLimitUnits;
        private NumericUpDown nFillLimit;
        private MetroLabel lFillLimit;
        private NumericUpDown nCopyPasteSlots;
        private MetroLabel lCopyPasteSlots;
        private MetroCheckBox xAllowSecurityCircumvention;
        private MetroLabel lAntiGrief1;
        private MetroLabel lAntiGrief3;
        private NumericUpDown nAntiGriefSeconds;
        private MetroButton bColorRank;
        private MetroCheckBox xDrawLimit;
        private MetroLabel lDrawLimitUnits;
        private MetroLabel lKickIdleUnits;
        private NumericUpDown nDrawLimit;
        private NumericUpDown nKickIdle;
        private MetroCheckBox xAntiGrief;
        private MetroLabel lAntiGrief2;
        private MetroCheckBox xKickIdle;
        private NumericUpDown nAntiGriefBlocks;
        private MetroCheckBox xReserveSlot;
        private MetroTextBox tPrefix;
        private MetroLabel lPrefix;
        private MetroLabel lRankColor;
        private MetroTextBox tRankName;
        private MetroLabel lRankName;
        private MetroButton bDeleteRank;
        private MetroListView vPermissions;
        private ColumnHeader chPermissions;
        private MetroButton bAddRank;
        private MetroLabel lPermissions;
        private ListBox vRanks;
        private MetroTabPage tabSecurity;
        private MetroTile gBlockDB;
        private MetroComboBox cBlockDBAutoEnableRank;
        private MetroCheckBox xBlockDBAutoEnable;
        private MetroCheckBox xBlockDBEnabled;
        private MetroTile gSecurityMisc;
        private MetroCheckBox xAnnounceRankChangeReasons;
        private MetroCheckBox xRequireKickReason;
        private MetroLabel lPatrolledRankAndBelow;
        private MetroComboBox cPatrolledRank;
        private MetroLabel lPatrolledRank;
        private MetroCheckBox xAnnounceRankChanges;
        private MetroCheckBox xAnnounceKickAndBanReasons;
        private MetroCheckBox xRequireRankChangeReason;
        private MetroCheckBox xRequireBanReason;
        private MetroTile gSpamChat;
        private MetroLabel lAntispamMaxWarnings;
        private NumericUpDown nAntispamMaxWarnings;
        private MetroCheckBox xAntispamKicks;
        private MetroLabel lSpamMuteSeconds;
        private MetroLabel lAntispamInterval;
        private NumericUpDown nSpamMute;
        private MetroLabel lSpamMute;
        private NumericUpDown nAntispamInterval;
        private MetroLabel lAntispamMessageCount;
        private NumericUpDown nAntispamMessageCount;
        private MetroLabel lSpamChat;
        private MetroTile gVerify;
        private NumericUpDown nMaxConnectionsPerIP;
        private MetroCheckBox xAllowUnverifiedLAN;
        private MetroCheckBox xMaxConnectionsPerIP;
        private MetroLabel lVerifyNames;
        private MetroComboBox cVerifyNames;
        private MetroTabPage gUpdate;
        private MetroTile groupBox5;
        private MetroButton bUpdate;
        private MetroCheckBox checkUpdate;
        private MetroTile gDataBackup;
        private MetroCheckBox xBackupDataOnStartup;
        private MetroTile gSaving;
        private NumericUpDown nSaveInterval;
        private MetroLabel lSaveIntervalUnits;
        private MetroCheckBox xSaveInterval;
        private MetroTile gBackups;
        private MetroCheckBox xBackupOnlyWhenChanged;
        private MetroLabel lMaxBackupSize;
        private MetroCheckBox xMaxBackupSize;
        private NumericUpDown nMaxBackupSize;
        private MetroCheckBox xMaxBackups;
        private MetroCheckBox xBackupOnStartup;
        private MetroLabel lMaxBackups;
        private NumericUpDown nMaxBackups;
        private NumericUpDown nBackupInterval;
        private MetroLabel lBackupIntervalUnits;
        private MetroCheckBox xBackupInterval;
        private MetroCheckBox xBackupOnJoin;
        private MetroTabPage tabLogging;
        private MetroTile gLogFile;
        private MetroLabel lLogFileOptionsDescription;
        private MetroCheckBox xLogLimit;
        private MetroListView vLogFileOptions;
        private ColumnHeader columnHeader2;
        private MetroLabel lLogLimitUnits;
        private NumericUpDown nLogLimit;
        private MetroComboBox cLogMode;
        private MetroLabel lLogMode;
        private MetroTile gConsole;
        private MetroLabel lLogConsoleOptionsDescription;
        private MetroListView vConsoleOptions;
        private ColumnHeader columnHeader3;
        private MetroTabPage tabIRC;
        private MetroTile gIRCAdv;
        private MetroTextBox tServPass;
        private MetroCheckBox xServPass;
        private MetroTextBox tChanPass;
        private MetroCheckBox xChanPass;
        private MetroCheckBox xIRCListShowNonEnglish;
        private MetroTile gIRCOptions;
        private MetroCheckBox xIRCBotAnnounceServerEvents;
        private MetroCheckBox xIRCUseColor;
        private MetroLabel lIRCNoForwardingMessage;
        private MetroCheckBox xIRCBotAnnounceIRCJoins;
        private MetroButton bColorIRC;
        private MetroLabel lColorIRC;
        private MetroCheckBox xIRCBotForwardFromIRC;
        private MetroCheckBox xIRCBotAnnounceServerJoins;
        private MetroCheckBox xIRCBotForwardFromServer;
        private MetroTile gIRCNetwork;
        private MetroLabel lIRCDelayUnits;
        private MetroCheckBox xIRCRegisteredNick;
        private MetroTextBox tIRCNickServMessage;
        private MetroLabel lIRCNickServMessage;
        private MetroTextBox tIRCNickServ;
        private MetroLabel lIRCNickServ;
        private NumericUpDown nIRCDelay;
        private MetroLabel lIRCDelay;
        private MetroLabel lIRCBotChannels2;
        private MetroLabel lIRCBotChannels3;
        private MetroTextBox tIRCBotChannels;
        private MetroLabel lIRCBotChannels;
        private NumericUpDown nIRCBotPort;
        private MetroLabel lIRCBotPort;
        private MetroTextBox tIRCBotNetwork;
        private MetroLabel lIRCBotNetwork;
        private MetroLabel lIRCBotNick;
        private MetroTextBox tIRCBotNick;
        private MetroLabel lIRCList;
        private MetroCheckBox xIRCBotEnabled;
        private MetroComboBox cIRCList;
        private MetroTabPage tabAdvanced;
        private MetroTile gPerformance;
        private MetroLabel lAdvancedWarning;
        private MetroCheckBox xLowLatencyMode;
        private MetroLabel lProcessPriority;
        private MetroComboBox cProcessPriority;
        private NumericUpDown nTickInterval;
        private MetroLabel lTickIntervalUnits;
        private MetroLabel lTickInterval;
        private NumericUpDown nThrottling;
        private MetroLabel lThrottling;
        private MetroLabel lThrottlingUnits;
        private MetroTile gAdvancedMisc;
        private MetroCheckBox xAutoRank;
        private NumericUpDown nMaxUndoStates;
        private MetroLabel lMaxUndoStates;
        private MetroLabel lIPWarning;
        private MetroTextBox tIP;
        private MetroCheckBox xIP;
        private MetroLabel lConsoleName;
        private MetroTextBox tConsoleName;
        private NumericUpDown nMaxUndo;
        private MetroLabel lMaxUndoUnits;
        private MetroCheckBox xMaxUndo;
        private MetroCheckBox xRelayAllBlockUpdates;
        private MetroCheckBox xNoPartialPositionUpdates;
        private MetroTile gCrashReport;
        private MetroCheckBox xCrash;
        private MetroLabel lCrashReportDisclaimer;
        private MetroTabPage Misc;
        private MetroTile groupBox3;
        private MetroLabel label5;
        private MetroTextBox websiteURL;
        private MetroButton ReqsEditor;
        private MetroButton SwearEditor;
        private NumericUpDown MaxCapsValue;
        private MetroLabel MaxCaps;
        private MetroTextBox SwearBox;
        private MetroLabel label3;
        private MetroTile groupBox1;
        private MetroLabel label1;
        private MetroLabel label4;
        private MetroButton CustomColor;
        private MetroLabel CustomText;
        private MetroTextBox CustomName;
        private MetroLabel label2;
        private MetroTextBox CustomAliases;
        private ToolTip toolTip;
        private ToolTip toolTip1;
        private fCraft.ConfigGUI.ChatPreview chatPreview1;
        private MetroLabel URLLabel;
        private MetroButton bPlay;
        private MetroTextBox uriDisplay;
        private MetroLabel playerListLabel;
        private ListBox playerList;
        private MetroButton bVoice;
        private RichTextBox logBox;
        private fCraft.ServerGUI.ConsoleBox console;
        private MetroButton bStart;
        private MetroButton pStop;
        private MetroTile gboDragon;
        private MetroLabel lblDefaultBlock;
        private MetroComboBox cboDragonDefault;
        private CheckedListBox clbDragonPermits;
        private MetroButton btnRestart;
        private PictureBox picServerStatus;
        //DO NOT MODIFY THE HANDLERS REGION!
        //YOU COULD POTENTIALLY MESS UP THE PROGRAM IF MODIFED AND NOT NOTICED
        #region Handlers
        //Fixes all event handlers that were lost on the GUI switch
        void ConfigEventHandlers()
        {
            //All the Config Handlers
            //this.HeartBeatUrlComboBox.SelectedIndexChanged += new System.EventHandler(this.HeartBeatUrlComboBox_SelectedIndexChanged);
            this.nMaxPlayersPerWorld.Validating += new System.ComponentModel.CancelEventHandler(this.nMaxPlayerPerWorld_Validating);
            this.cDefaultRank.SelectedIndexChanged += new System.EventHandler(this.cDefaultRank_SelectedIndexChanged);
            this.bMeasure.Click += new System.EventHandler(this.bMeasure_Click);
            this.nMaxPlayers.ValueChanged += new System.EventHandler(this.nMaxPlayers_ValueChanged);
            this.bChangelog.Click += new System.EventHandler(this.bChangelog_Click);
            this.bCredits.Click += new System.EventHandler(this.bCredits_Click);
            this.bReadme.Click += new System.EventHandler(this.bReadme_Click);
            this.bGreeting.Click += new System.EventHandler(this.bGreeting_Click);
            this.xAnnouncements.CheckedChanged += new System.EventHandler(this.xAnnouncements_CheckedChanged);
            this.bRules.Click += new System.EventHandler(this.bRules_Click);
            this.bAnnouncements.Click += new System.EventHandler(this.bAnnouncements_Click);
            this.xRankPrefixesInChat.CheckedChanged += new System.EventHandler(this.xRankPrefixesInChat_CheckedChanged);
            this.bColorMe.Click += new System.EventHandler(this.bColorMe_Click);
            this.bColorWarning.Click += new System.EventHandler(this.bColorWarning_Click);
            this.bColorSys.Click += new System.EventHandler(this.bColorSys_Click);
            this.bColorPM.Click += new System.EventHandler(this.bColorPM_Click);
            this.bColorAnnouncement.Click += new System.EventHandler(this.bColorAnnouncement_Click);
            this.bColorHelp.Click += new System.EventHandler(this.bColorHelp_Click);
            this.bColorSay.Click += new System.EventHandler(this.bColorSay_Click);
            this.bMapPath.Click += new System.EventHandler(this.bMapPath_Click);
            this.xMapPath.CheckedChanged += new System.EventHandler(this.xMapPath_CheckedChanged);
            this.cDefaultBuildRank.SelectedIndexChanged += new System.EventHandler(this.cDefaultBuildRank_SelectedIndexChanged);
            this.bWorldEdit.Click += new System.EventHandler(this.bWorldEdit_Click);
            this.bAddWorld.Click += new System.EventHandler(this.bAddWorld_Click);
            this.bWorldDelete.Click += new System.EventHandler(this.bWorldDel_Click);
            this.dgvWorlds.SelectionChanged += new System.EventHandler(this.dgvWorlds_Click);
            this.dgvWorlds.Click += new System.EventHandler(this.dgvWorlds_Click);
            this.bLowerRank.Click += new System.EventHandler(this.bLowerRank_Click);
            this.bRaiseRank.Click += new System.EventHandler(this.bRaiseRank_Click);
            this.nFillLimit.ValueChanged += new System.EventHandler(this.nFillLimit_ValueChanged);
            this.nCopyPasteSlots.ValueChanged += new System.EventHandler(this.nCopyPasteSlots_ValueChanged);
            this.xAllowSecurityCircumvention.CheckedChanged += new System.EventHandler(this.xAllowSecurityCircumvention_CheckedChanged);
            this.nAntiGriefSeconds.ValueChanged += new System.EventHandler(this.nAntiGriefSeconds_ValueChanged);
            this.bColorRank.Click += new System.EventHandler(this.bColorRank_Click);
            this.xDrawLimit.CheckedChanged += new System.EventHandler(this.xDrawLimit_CheckedChanged);
            this.nDrawLimit.ValueChanged += new System.EventHandler(this.nDrawLimit_ValueChanged);
            this.nKickIdle.ValueChanged += new System.EventHandler(this.nKickIdle_ValueChanged);
            this.xAntiGrief.CheckedChanged += new System.EventHandler(this.xAntiGrief_CheckedChanged);
            this.xKickIdle.CheckedChanged += new System.EventHandler(this.xKickIdle_CheckedChanged);
            this.nAntiGriefBlocks.ValueChanged += new System.EventHandler(this.nAntiGriefBlocks_ValueChanged);
            this.xReserveSlot.CheckedChanged += new System.EventHandler(this.xReserveSlot_CheckedChanged);
            this.tPrefix.Validating += new System.ComponentModel.CancelEventHandler(this.tPrefix_Validating);
            this.tRankName.Validating += new System.ComponentModel.CancelEventHandler(this.tRankName_Validating);
            this.bDeleteRank.Click += new System.EventHandler(this.bDeleteRank_Click);
            this.vPermissions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.vPermissions_ItemChecked);
            this.bAddRank.Click += new System.EventHandler(this.bAddRank_Click);
            this.vRanks.SelectedIndexChanged += new System.EventHandler(this.vRanks_SelectedIndexChanged);
            this.cBlockDBAutoEnableRank.SelectedIndexChanged += new System.EventHandler(this.cBlockDBAutoEnableRank_SelectedIndexChanged);
            this.xBlockDBAutoEnable.CheckedChanged += new System.EventHandler(this.xBlockDBAutoEnable_CheckedChanged);
            this.xBlockDBEnabled.CheckedChanged += new System.EventHandler(this.xBlockDBEnabled_CheckedChanged);
            this.cPatrolledRank.SelectedIndexChanged += new System.EventHandler(this.cPatrolledRank_SelectedIndexChanged);
            this.xAnnounceRankChanges.CheckedChanged += new System.EventHandler(this.xAnnounceRankChanges_CheckedChanged);
            this.xAntispamKicks.CheckedChanged += new System.EventHandler(this.xSpamChatKick_CheckedChanged);
            this.xMaxConnectionsPerIP.CheckedChanged += new System.EventHandler(this.xMaxConnectionsPerIP_CheckedChanged);
            this.cVerifyNames.SelectedIndexChanged += new System.EventHandler(this.cVerifyNames_SelectedIndexChanged);
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            this.xSaveInterval.CheckedChanged += new System.EventHandler(this.xSaveAtInterval_CheckedChanged);
            this.xMaxBackupSize.CheckedChanged += new System.EventHandler(this.xMaxBackupSize_CheckedChanged);
            this.xMaxBackups.CheckedChanged += new System.EventHandler(this.xMaxBackups_CheckedChanged);
            this.xBackupInterval.CheckedChanged += new System.EventHandler(this.xBackupAtInterval_CheckedChanged);
            this.xLogLimit.CheckedChanged += new System.EventHandler(this.xLogLimit_CheckedChanged);
            this.vLogFileOptions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.vLogFileOptions_ItemChecked);
            this.vConsoleOptions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.vConsoleOptions_ItemChecked);
            this.xServPass.CheckedChanged += new System.EventHandler(this.xServPass_CheckedChanged);
            this.xChanPass.CheckedChanged += new System.EventHandler(this.xChanPass_CheckedChanged);
            this.xIRCListShowNonEnglish.CheckedChanged += new System.EventHandler(this.xIRCListShowNonEnglish_CheckedChanged);
            this.bColorIRC.Click += new System.EventHandler(this.bColorIRC_Click);
            this.xIRCRegisteredNick.CheckedChanged += new System.EventHandler(this.xIRCRegisteredNick_CheckedChanged);
            this.xIRCBotEnabled.CheckedChanged += new System.EventHandler(this.xIRC_CheckedChanged);
            this.cIRCList.SelectedIndexChanged += new System.EventHandler(this.cIRCList_SelectedIndexChanged);
            this.nMaxUndoStates.ValueChanged += new System.EventHandler(this.nMaxUndo_ValueChanged);
            this.tIP.Validating += new System.ComponentModel.CancelEventHandler(this.tIP_Validating);
            this.xIP.CheckedChanged += new System.EventHandler(this.xIP_CheckedChanged);
            this.nMaxUndo.ValueChanged += new System.EventHandler(this.nMaxUndo_ValueChanged);
            this.xMaxUndo.CheckedChanged += new System.EventHandler(this.xMaxUndo_CheckedChanged);
            this.websiteURL.TextChanged += new System.EventHandler(this.websiteURL_TextChanged);
            this.ReqsEditor.Click += new System.EventHandler(this.ReqsEditor_Click);
            this.SwearEditor.Click += new System.EventHandler(this.SwearEditor_Click);
            this.CustomColor.Click += new System.EventHandler(this.button1_Click);
            this.CustomText.Click += new System.EventHandler(this.label1_Click);
            this.bOK.Click += new System.EventHandler(this.bSave_Click);
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            this.bResetTab.Click += new System.EventHandler(this.bResetTab_Click);
            this.bResetAll.Click += new System.EventHandler(this.bResetAll_Click);
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            this.bColorGlobal.Click += new System.EventHandler(this.bColorGlobal_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigUI_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
        }

        void StartServerHandlers()
        {
            //Server Handlers
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            this.bVoice.Click += new System.EventHandler(this.bVoice_Click);
        }
        #endregion

        private MetroTabPage CPETab;
        private MetroLabel lblAboutCPE;
        private MetroTile gboClickDistance;
        private MetroCheckBox chkClickDistanceAllowed;
        private MetroTile gboCustomBlocks;
        private MetroCheckBox chkCustomBlocksAllowed;
        private CheckedListBox clbBlocks;
        private MetroTile gboHeldBlock;
        private MetroCheckBox chkHeldBlockAllowed;
        private MetroTile gboMessageType;
        private MetroCheckBox chkMessageTypeAllowed;
        private MetroCheckBox chkAnnouncementMT;
        private MetroCheckBox chkBottomRight3;
        private MetroTextBox txtBottomRight3;
        private MetroCheckBox chkBottomRight2;
        private MetroTextBox txtBottomRight2;
        private MetroCheckBox chkBottomRight1;
        private MetroTextBox txtBottomRight1;
        private MetroCheckBox chkStatus3;
        private MetroTextBox txtStatus3;
        private MetroCheckBox chkStatus2;
        private MetroTextBox txtStatus2;
        private MetroCheckBox chkStatus1;
        private MetroTextBox txtStatus1;
        private MetroButton btnSeeKeyWords;
        private MetroTile gboEnvColors;
        private MetroCheckBox chkTimeBasedSky;
        private MetroCheckBox chkEnvColorsAllowed;
        private MetroLabel lblHourLength;
        private NumericUpDown numHourLength;
        private MetroComboBox cboPrison;
        private MetroLabel label6;
        private MetroLabel lPublic;
        private MetroCheckBox mcbPrison;
        private MetroButton metroButton1;
        private MetroComboBox ThemeBox;
    }


}