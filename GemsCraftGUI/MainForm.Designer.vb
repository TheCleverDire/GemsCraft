<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabConfig = New System.Windows.Forms.TabPage()
        Me.tabServer = New System.Windows.Forms.TabPage()
        Me.tIRCNickServMessage = New System.Windows.Forms.TextBox()
        Me.xLogLimit = New System.Windows.Forms.CheckBox()
        Me.vLogFileOptions = New System.Windows.Forms.ListView()
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lLogLimitUnits = New System.Windows.Forms.Label()
        Me.nLogLimit = New System.Windows.Forms.NumericUpDown()
        Me.cLogMode = New System.Windows.Forms.ComboBox()
        Me.lLogMode = New System.Windows.Forms.Label()
        Me.lLogConsoleOptionsDescription = New System.Windows.Forms.Label()
        Me.vConsoleOptions = New System.Windows.Forms.ListView()
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabIRC = New System.Windows.Forms.TabPage()
        Me.gIRCAdv = New System.Windows.Forms.GroupBox()
        Me.tServPass = New System.Windows.Forms.TextBox()
        Me.xServPass = New System.Windows.Forms.CheckBox()
        Me.tChanPass = New System.Windows.Forms.TextBox()
        Me.xChanPass = New System.Windows.Forms.CheckBox()
        Me.xIRCListShowNonEnglish = New System.Windows.Forms.CheckBox()
        Me.gIRCOptions = New System.Windows.Forms.GroupBox()
        Me.xIRCBotAnnounceServerEvents = New System.Windows.Forms.CheckBox()
        Me.xIRCUseColor = New System.Windows.Forms.CheckBox()
        Me.lIRCNoForwardingMessage = New System.Windows.Forms.Label()
        Me.xIRCBotAnnounceIRCJoins = New System.Windows.Forms.CheckBox()
        Me.bColorIRC = New System.Windows.Forms.Button()
        Me.lColorIRC = New System.Windows.Forms.Label()
        Me.xIRCBotForwardFromIRC = New System.Windows.Forms.CheckBox()
        Me.xIRCBotAnnounceServerJoins = New System.Windows.Forms.CheckBox()
        Me.xIRCBotForwardFromServer = New System.Windows.Forms.CheckBox()
        Me.gIRCNetwork = New System.Windows.Forms.GroupBox()
        Me.lIRCDelayUnits = New System.Windows.Forms.Label()
        Me.xIRCRegisteredNick = New System.Windows.Forms.CheckBox()
        Me.lIRCNickServMessage = New System.Windows.Forms.Label()
        Me.tIRCNickServ = New System.Windows.Forms.TextBox()
        Me.lIRCNickServ = New System.Windows.Forms.Label()
        Me.nIRCDelay = New System.Windows.Forms.NumericUpDown()
        Me.lIRCDelay = New System.Windows.Forms.Label()
        Me.lIRCBotChannels2 = New System.Windows.Forms.Label()
        Me.lIRCBotChannels3 = New System.Windows.Forms.Label()
        Me.tIRCBotChannels = New System.Windows.Forms.TextBox()
        Me.lIRCBotChannels = New System.Windows.Forms.Label()
        Me.nIRCBotPort = New System.Windows.Forms.NumericUpDown()
        Me.lIRCBotPort = New System.Windows.Forms.Label()
        Me.tIRCBotNetwork = New System.Windows.Forms.TextBox()
        Me.lIRCBotNetwork = New System.Windows.Forms.Label()
        Me.lIRCBotNick = New System.Windows.Forms.Label()
        Me.tIRCBotNick = New System.Windows.Forms.TextBox()
        Me.lIRCList = New System.Windows.Forms.Label()
        Me.xIRCBotEnabled = New System.Windows.Forms.CheckBox()
        Me.cIRCList = New System.Windows.Forms.ComboBox()
        Me.lLogFileOptionsDescription = New System.Windows.Forms.Label()
        Me.gLogFile = New System.Windows.Forms.GroupBox()
        Me.tabLogging = New System.Windows.Forms.TabPage()
        Me.gConsole = New System.Windows.Forms.GroupBox()
        Me.gDataBackup = New System.Windows.Forms.GroupBox()
        Me.xBackupDataOnStartup = New System.Windows.Forms.CheckBox()
        Me.bUpdate = New System.Windows.Forms.Button()
        Me.checkUpdate = New System.Windows.Forms.CheckBox()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.nMaxConnectionsPerIP = New System.Windows.Forms.NumericUpDown()
        Me.xAllowUnverifiedLAN = New System.Windows.Forms.CheckBox()
        Me.xMaxConnectionsPerIP = New System.Windows.Forms.CheckBox()
        Me.gUpdate = New System.Windows.Forms.TabPage()
        Me.gSaving = New System.Windows.Forms.GroupBox()
        Me.nSaveInterval = New System.Windows.Forms.NumericUpDown()
        Me.lSaveIntervalUnits = New System.Windows.Forms.Label()
        Me.xSaveInterval = New System.Windows.Forms.CheckBox()
        Me.gBackups = New System.Windows.Forms.GroupBox()
        Me.xBackupOnlyWhenChanged = New System.Windows.Forms.CheckBox()
        Me.lMaxBackupSize = New System.Windows.Forms.Label()
        Me.xMaxBackupSize = New System.Windows.Forms.CheckBox()
        Me.nMaxBackupSize = New System.Windows.Forms.NumericUpDown()
        Me.xMaxBackups = New System.Windows.Forms.CheckBox()
        Me.xBackupOnStartup = New System.Windows.Forms.CheckBox()
        Me.lMaxBackups = New System.Windows.Forms.Label()
        Me.nMaxBackups = New System.Windows.Forms.NumericUpDown()
        Me.nBackupInterval = New System.Windows.Forms.NumericUpDown()
        Me.lBackupIntervalUnits = New System.Windows.Forms.Label()
        Me.xBackupInterval = New System.Windows.Forms.CheckBox()
        Me.xBackupOnJoin = New System.Windows.Forms.CheckBox()
        Me.lVerifyNames = New System.Windows.Forms.Label()
        Me.gVerify = New System.Windows.Forms.GroupBox()
        Me.cVerifyNames = New System.Windows.Forms.ComboBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.xAntispamKicks = New System.Windows.Forms.CheckBox()
        Me.lSpamMuteSeconds = New System.Windows.Forms.Label()
        Me.nAntispamMaxWarnings = New System.Windows.Forms.NumericUpDown()
        Me.xAutoRank = New System.Windows.Forms.CheckBox()
        Me.nMaxUndoStates = New System.Windows.Forms.NumericUpDown()
        Me.lIPWarning = New System.Windows.Forms.Label()
        Me.tIP = New System.Windows.Forms.TextBox()
        Me.lAntispamMaxWarnings = New System.Windows.Forms.Label()
        Me.gCrashReport = New System.Windows.Forms.GroupBox()
        Me.xCrash = New System.Windows.Forms.CheckBox()
        Me.lCrashReportDisclaimer = New System.Windows.Forms.Label()
        Me.Misc = New System.Windows.Forms.TabPage()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.websiteURL = New System.Windows.Forms.TextBox()
        Me.ReqsEditor = New System.Windows.Forms.Button()
        Me.SwearEditor = New System.Windows.Forms.Button()
        Me.MaxCapsValue = New System.Windows.Forms.NumericUpDown()
        Me.MaxCaps = New System.Windows.Forms.Label()
        Me.SwearBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.CustomColor = New System.Windows.Forms.Button()
        Me.CustomText = New System.Windows.Forms.Label()
        Me.CustomName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.CustomAliases = New System.Windows.Forms.TextBox()
        Me.lMaxUndoStates = New System.Windows.Forms.Label()
        Me.bApply = New System.Windows.Forms.Button()
        Me.bResetAll = New System.Windows.Forms.Button()
        Me.bResetTab = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.xIP = New System.Windows.Forms.CheckBox()
        Me.tabAdvanced = New System.Windows.Forms.TabPage()
        Me.gPerformance = New System.Windows.Forms.GroupBox()
        Me.lAdvancedWarning = New System.Windows.Forms.Label()
        Me.xLowLatencyMode = New System.Windows.Forms.CheckBox()
        Me.lProcessPriority = New System.Windows.Forms.Label()
        Me.cProcessPriority = New System.Windows.Forms.ComboBox()
        Me.nTickInterval = New System.Windows.Forms.NumericUpDown()
        Me.lTickIntervalUnits = New System.Windows.Forms.Label()
        Me.lTickInterval = New System.Windows.Forms.Label()
        Me.nThrottling = New System.Windows.Forms.NumericUpDown()
        Me.lThrottling = New System.Windows.Forms.Label()
        Me.lThrottlingUnits = New System.Windows.Forms.Label()
        Me.gAdvancedMisc = New System.Windows.Forms.GroupBox()
        Me.lConsoleName = New System.Windows.Forms.Label()
        Me.tConsoleName = New System.Windows.Forms.TextBox()
        Me.nMaxUndo = New System.Windows.Forms.NumericUpDown()
        Me.lMaxUndoUnits = New System.Windows.Forms.Label()
        Me.xMaxUndo = New System.Windows.Forms.CheckBox()
        Me.xRelayAllBlockUpdates = New System.Windows.Forms.CheckBox()
        Me.xNoPartialPositionUpdates = New System.Windows.Forms.CheckBox()
        Me.lAntispamInterval = New System.Windows.Forms.Label()
        Me.lAnnouncementsUnits = New System.Windows.Forms.Label()
        Me.lColorMe = New System.Windows.Forms.Label()
        Me.bColorGlobal = New System.Windows.Forms.Button()
        Me.bColorMe = New System.Windows.Forms.Button()
        Me.gChatColors = New System.Windows.Forms.GroupBox()
        Me.lColorWarning = New System.Windows.Forms.Label()
        Me.bColorWarning = New System.Windows.Forms.Button()
        Me.bColorSys = New System.Windows.Forms.Button()
        Me.lColorSys = New System.Windows.Forms.Label()
        Me.bColorPM = New System.Windows.Forms.Button()
        Me.lColorHelp = New System.Windows.Forms.Label()
        Me.lColorPM = New System.Windows.Forms.Label()
        Me.IColorGlobal = New System.Windows.Forms.Label()
        Me.lColorSay = New System.Windows.Forms.Label()
        Me.bColorAnnouncement = New System.Windows.Forms.Button()
        Me.lColorAnnouncement = New System.Windows.Forms.Label()
        Me.bColorHelp = New System.Windows.Forms.Button()
        Me.bColorSay = New System.Windows.Forms.Button()
        Me.xShowConnectionMessages = New System.Windows.Forms.CheckBox()
        Me.xShowJoinedWorldMessages = New System.Windows.Forms.CheckBox()
        Me.xRankColorsInWorldNames = New System.Windows.Forms.CheckBox()
        Me.xRankPrefixesInList = New System.Windows.Forms.CheckBox()
        Me.xRankPrefixesInChat = New System.Windows.Forms.CheckBox()
        Me.xRankColorsInChat = New System.Windows.Forms.CheckBox()
        Me.gAppearence = New System.Windows.Forms.GroupBox()
        Me.tabChat = New System.Windows.Forms.TabPage()
        Me.bGreeting = New System.Windows.Forms.Button()
        Me.nAnnouncements = New System.Windows.Forms.NumericUpDown()
        Me.xWoMEnableEnvExtensions = New System.Windows.Forms.CheckBox()
        Me.bMapPath = New System.Windows.Forms.Button()
        Me.xMapPath = New System.Windows.Forms.CheckBox()
        Me.tMapPath = New System.Windows.Forms.TextBox()
        Me.cDefaultBuildRank = New System.Windows.Forms.ComboBox()
        Me.tabWorlds = New System.Windows.Forms.TabPage()
        Me.lDefaultBuildRank = New System.Windows.Forms.Label()
        Me.cMainWorld = New System.Windows.Forms.ComboBox()
        Me.lMainWorld = New System.Windows.Forms.Label()
        Me.bWorldEdit = New System.Windows.Forms.Button()
        Me.bAddWorld = New System.Windows.Forms.Button()
        Me.bWorldDelete = New System.Windows.Forms.Button()
        Me.dgvWorlds = New System.Windows.Forms.DataGridView()
        Me.dgvcName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAccess = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvcBuild = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvcBackup = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvcHidden = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvcBlockDB = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.xAnnouncements = New System.Windows.Forms.CheckBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.HeartBeatUrlComboBox = New System.Windows.Forms.ComboBox()
        Me.nMaxPlayersPerWorld = New System.Windows.Forms.NumericUpDown()
        Me.lMaxPlayersPerWorld = New System.Windows.Forms.Label()
        Me.lPort = New System.Windows.Forms.Label()
        Me.nPort = New System.Windows.Forms.NumericUpDown()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.gBasic = New System.Windows.Forms.GroupBox()
        Me.cDefaultRank = New System.Windows.Forms.ComboBox()
        Me.lDefaultRank = New System.Windows.Forms.Label()
        Me.lUploadBandwidth = New System.Windows.Forms.Label()
        Me.bMeasure = New System.Windows.Forms.Button()
        Me.tServerName = New System.Windows.Forms.TextBox()
        Me.lUploadBandwidthUnits = New System.Windows.Forms.Label()
        Me.lServerName = New System.Windows.Forms.Label()
        Me.nUploadBandwidth = New System.Windows.Forms.NumericUpDown()
        Me.tMOTD = New System.Windows.Forms.TextBox()
        Me.lMOTD = New System.Windows.Forms.Label()
        Me.cPublic = New System.Windows.Forms.ComboBox()
        Me.nMaxPlayers = New System.Windows.Forms.NumericUpDown()
        Me.lPublic = New System.Windows.Forms.Label()
        Me.lMaxPlayers = New System.Windows.Forms.Label()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.bWiki = New System.Windows.Forms.Button()
        Me.bWeb = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.bChangelog = New System.Windows.Forms.Button()
        Me.bCredits = New System.Windows.Forms.Button()
        Me.bReadme = New System.Windows.Forms.Button()
        Me.gInformation = New System.Windows.Forms.GroupBox()
        Me.bRules = New System.Windows.Forms.Button()
        Me.bAnnouncements = New System.Windows.Forms.Button()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabRanks = New System.Windows.Forms.TabPage()
        Me.gPermissionLimits = New System.Windows.Forms.GroupBox()
        Me.permissionLimitBoxContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.lRankList = New System.Windows.Forms.Label()
        Me.bLowerRank = New System.Windows.Forms.Button()
        Me.bRaiseRank = New System.Windows.Forms.Button()
        Me.gRankOptions = New System.Windows.Forms.GroupBox()
        Me.lFillLimitUnits = New System.Windows.Forms.Label()
        Me.nFillLimit = New System.Windows.Forms.NumericUpDown()
        Me.lFillLimit = New System.Windows.Forms.Label()
        Me.nCopyPasteSlots = New System.Windows.Forms.NumericUpDown()
        Me.lCopyPasteSlots = New System.Windows.Forms.Label()
        Me.xAllowSecurityCircumvention = New System.Windows.Forms.CheckBox()
        Me.lAntiGrief1 = New System.Windows.Forms.Label()
        Me.lAntiGrief3 = New System.Windows.Forms.Label()
        Me.nAntiGriefSeconds = New System.Windows.Forms.NumericUpDown()
        Me.bColorRank = New System.Windows.Forms.Button()
        Me.xDrawLimit = New System.Windows.Forms.CheckBox()
        Me.lDrawLimitUnits = New System.Windows.Forms.Label()
        Me.lKickIdleUnits = New System.Windows.Forms.Label()
        Me.nDrawLimit = New System.Windows.Forms.NumericUpDown()
        Me.nKickIdle = New System.Windows.Forms.NumericUpDown()
        Me.xAntiGrief = New System.Windows.Forms.CheckBox()
        Me.lAntiGrief2 = New System.Windows.Forms.Label()
        Me.xKickIdle = New System.Windows.Forms.CheckBox()
        Me.nAntiGriefBlocks = New System.Windows.Forms.NumericUpDown()
        Me.xReserveSlot = New System.Windows.Forms.CheckBox()
        Me.tPrefix = New System.Windows.Forms.TextBox()
        Me.lPrefix = New System.Windows.Forms.Label()
        Me.lRankColor = New System.Windows.Forms.Label()
        Me.tRankName = New System.Windows.Forms.TextBox()
        Me.lRankName = New System.Windows.Forms.Label()
        Me.bDeleteRank = New System.Windows.Forms.Button()
        Me.vPermissions = New System.Windows.Forms.ListView()
        Me.chPermissions = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bAddRank = New System.Windows.Forms.Button()
        Me.lPermissions = New System.Windows.Forms.Label()
        Me.vRanks = New System.Windows.Forms.ListBox()
        Me.tabSecurity = New System.Windows.Forms.TabPage()
        Me.gBlockDB = New System.Windows.Forms.GroupBox()
        Me.cBlockDBAutoEnableRank = New System.Windows.Forms.ComboBox()
        Me.xBlockDBAutoEnable = New System.Windows.Forms.CheckBox()
        Me.xBlockDBEnabled = New System.Windows.Forms.CheckBox()
        Me.gSecurityMisc = New System.Windows.Forms.GroupBox()
        Me.xAnnounceRankChangeReasons = New System.Windows.Forms.CheckBox()
        Me.xRequireKickReason = New System.Windows.Forms.CheckBox()
        Me.lPatrolledRankAndBelow = New System.Windows.Forms.Label()
        Me.cPatrolledRank = New System.Windows.Forms.ComboBox()
        Me.lPatrolledRank = New System.Windows.Forms.Label()
        Me.xAnnounceRankChanges = New System.Windows.Forms.CheckBox()
        Me.xAnnounceKickAndBanReasons = New System.Windows.Forms.CheckBox()
        Me.xRequireRankChangeReason = New System.Windows.Forms.CheckBox()
        Me.xRequireBanReason = New System.Windows.Forms.CheckBox()
        Me.gSpamChat = New System.Windows.Forms.GroupBox()
        Me.nSpamMute = New System.Windows.Forms.NumericUpDown()
        Me.lSpamMute = New System.Windows.Forms.Label()
        Me.nAntispamInterval = New System.Windows.Forms.NumericUpDown()
        Me.lAntispamMessageCount = New System.Windows.Forms.Label()
        Me.nAntispamMessageCount = New System.Windows.Forms.NumericUpDown()
        Me.lSpamChat = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.URLLabel = New System.Windows.Forms.Label()
        Me.bPlay = New System.Windows.Forms.Button()
        Me.uriDisplay = New System.Windows.Forms.TextBox()
        Me.logBox = New System.Windows.Forms.RichTextBox()
        Me.playerListLabel = New System.Windows.Forms.Label()
        Me.playerList = New System.Windows.Forms.ListBox()
        Me.bVoice = New System.Windows.Forms.Button()
        Me.console = New GemsCraftGUI.ConsoleBox()
        Me.TabControl1.SuspendLayout()
        Me.tabConfig.SuspendLayout()
        Me.tabServer.SuspendLayout()
        CType(Me.nLogLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabIRC.SuspendLayout()
        Me.gIRCAdv.SuspendLayout()
        Me.gIRCOptions.SuspendLayout()
        Me.gIRCNetwork.SuspendLayout()
        CType(Me.nIRCDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nIRCBotPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gLogFile.SuspendLayout()
        Me.tabLogging.SuspendLayout()
        Me.gConsole.SuspendLayout()
        Me.gDataBackup.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        CType(Me.nMaxConnectionsPerIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gUpdate.SuspendLayout()
        Me.gSaving.SuspendLayout()
        CType(Me.nSaveInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBackups.SuspendLayout()
        CType(Me.nMaxBackupSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxBackups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nBackupInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gVerify.SuspendLayout()
        CType(Me.nAntispamMaxWarnings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxUndoStates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gCrashReport.SuspendLayout()
        Me.Misc.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.MaxCapsValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.tabAdvanced.SuspendLayout()
        Me.gPerformance.SuspendLayout()
        CType(Me.nTickInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nThrottling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gAdvancedMisc.SuspendLayout()
        CType(Me.nMaxUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gChatColors.SuspendLayout()
        Me.gAppearence.SuspendLayout()
        Me.tabChat.SuspendLayout()
        CType(Me.nAnnouncements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWorlds.SuspendLayout()
        CType(Me.dgvWorlds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxPlayersPerWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGeneral.SuspendLayout()
        Me.gBasic.SuspendLayout()
        CType(Me.nUploadBandwidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.gInformation.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.tabRanks.SuspendLayout()
        Me.gPermissionLimits.SuspendLayout()
        Me.gRankOptions.SuspendLayout()
        CType(Me.nFillLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCopyPasteSlots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAntiGriefSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDrawLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nKickIdle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAntiGriefBlocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSecurity.SuspendLayout()
        Me.gBlockDB.SuspendLayout()
        Me.gSecurityMisc.SuspendLayout()
        Me.gSpamChat.SuspendLayout()
        CType(Me.nSpamMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAntispamInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nAntispamMessageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabConfig)
        Me.TabControl1.Controls.Add(Me.tabServer)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(700, 598)
        Me.TabControl1.TabIndex = 0
        '
        'tabConfig
        '
        Me.tabConfig.BackColor = System.Drawing.Color.Gray
        Me.tabConfig.Controls.Add(Me.bApply)
        Me.tabConfig.Controls.Add(Me.bResetAll)
        Me.tabConfig.Controls.Add(Me.bResetTab)
        Me.tabConfig.Controls.Add(Me.bCancel)
        Me.tabConfig.Controls.Add(Me.bOK)
        Me.tabConfig.Controls.Add(Me.tabs)
        Me.tabConfig.Location = New System.Drawing.Point(4, 22)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfig.Size = New System.Drawing.Size(692, 572)
        Me.tabConfig.TabIndex = 0
        Me.tabConfig.Text = "Configuration"
        '
        'tabServer
        '
        Me.tabServer.BackColor = System.Drawing.Color.Gray
        Me.tabServer.Controls.Add(Me.console)
        Me.tabServer.Controls.Add(Me.bVoice)
        Me.tabServer.Controls.Add(Me.playerListLabel)
        Me.tabServer.Controls.Add(Me.playerList)
        Me.tabServer.Controls.Add(Me.logBox)
        Me.tabServer.Controls.Add(Me.URLLabel)
        Me.tabServer.Controls.Add(Me.bPlay)
        Me.tabServer.Controls.Add(Me.uriDisplay)
        Me.tabServer.Location = New System.Drawing.Point(4, 22)
        Me.tabServer.Name = "tabServer"
        Me.tabServer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServer.Size = New System.Drawing.Size(692, 572)
        Me.tabServer.TabIndex = 1
        Me.tabServer.Text = "Server"
        '
        'tIRCNickServMessage
        '
        Me.tIRCNickServMessage.Enabled = False
        Me.tIRCNickServMessage.Location = New System.Drawing.Point(388, 126)
        Me.tIRCNickServMessage.Name = "tIRCNickServMessage"
        Me.tIRCNickServMessage.Size = New System.Drawing.Size(234, 21)
        Me.tIRCNickServMessage.TabIndex = 17
        '
        'xLogLimit
        '
        Me.xLogLimit.AutoSize = True
        Me.xLogLimit.Enabled = False
        Me.xLogLimit.Location = New System.Drawing.Point(18, 390)
        Me.xLogLimit.Name = "xLogLimit"
        Me.xLogLimit.Size = New System.Drawing.Size(80, 19)
        Me.xLogLimit.TabIndex = 4
        Me.xLogLimit.Text = "Only keep"
        Me.xLogLimit.UseVisualStyleBackColor = True
        '
        'vLogFileOptions
        '
        Me.vLogFileOptions.CheckBoxes = True
        Me.vLogFileOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader2})
        Me.vLogFileOptions.GridLines = True
        Me.vLogFileOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.vLogFileOptions.Location = New System.Drawing.Point(78, 59)
        Me.vLogFileOptions.Name = "vLogFileOptions"
        Me.vLogFileOptions.ShowItemToolTips = True
        Me.vLogFileOptions.Size = New System.Drawing.Size(161, 294)
        Me.vLogFileOptions.TabIndex = 1
        Me.vLogFileOptions.UseCompatibleStateImageBehavior = False
        Me.vLogFileOptions.View = System.Windows.Forms.View.Details
        '
        'columnHeader2
        '
        Me.columnHeader2.Width = 157
        '
        'lLogLimitUnits
        '
        Me.lLogLimitUnits.AutoSize = True
        Me.lLogLimitUnits.Location = New System.Drawing.Point(166, 391)
        Me.lLogLimitUnits.Name = "lLogLimitUnits"
        Me.lLogLimitUnits.Size = New System.Drawing.Size(129, 15)
        Me.lLogLimitUnits.TabIndex = 6
        Me.lLogLimitUnits.Text = "of most recent log files"
        '
        'nLogLimit
        '
        Me.nLogLimit.Enabled = False
        Me.nLogLimit.Location = New System.Drawing.Point(104, 389)
        Me.nLogLimit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nLogLimit.Name = "nLogLimit"
        Me.nLogLimit.Size = New System.Drawing.Size(56, 21)
        Me.nLogLimit.TabIndex = 5
        '
        'cLogMode
        '
        Me.cLogMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLogMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cLogMode.FormattingEnabled = True
        Me.cLogMode.Items.AddRange(New Object() {"One long file", "Multiple files, split by session", "Multiple files, split by day"})
        Me.cLogMode.Location = New System.Drawing.Point(104, 360)
        Me.cLogMode.Name = "cLogMode"
        Me.cLogMode.Size = New System.Drawing.Size(185, 23)
        Me.cLogMode.TabIndex = 3
        '
        'lLogMode
        '
        Me.lLogMode.AutoSize = True
        Me.lLogMode.Location = New System.Drawing.Point(35, 363)
        Me.lLogMode.Name = "lLogMode"
        Me.lLogMode.Size = New System.Drawing.Size(63, 15)
        Me.lLogMode.TabIndex = 2
        Me.lLogMode.Text = "Log mode"
        '
        'lLogConsoleOptionsDescription
        '
        Me.lLogConsoleOptionsDescription.AutoSize = True
        Me.lLogConsoleOptionsDescription.Location = New System.Drawing.Point(9, 21)
        Me.lLogConsoleOptionsDescription.Name = "lLogConsoleOptionsDescription"
        Me.lLogConsoleOptionsDescription.Size = New System.Drawing.Size(212, 30)
        Me.lLogConsoleOptionsDescription.TabIndex = 0
        Me.lLogConsoleOptionsDescription.Text = "Types of messages that will be written" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "directly to console."
        '
        'vConsoleOptions
        '
        Me.vConsoleOptions.CheckBoxes = True
        Me.vConsoleOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader3})
        Me.vConsoleOptions.GridLines = True
        Me.vConsoleOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.vConsoleOptions.Location = New System.Drawing.Point(76, 59)
        Me.vConsoleOptions.Name = "vConsoleOptions"
        Me.vConsoleOptions.ShowItemToolTips = True
        Me.vConsoleOptions.Size = New System.Drawing.Size(161, 294)
        Me.vConsoleOptions.TabIndex = 1
        Me.vConsoleOptions.UseCompatibleStateImageBehavior = False
        Me.vConsoleOptions.View = System.Windows.Forms.View.Details
        '
        'columnHeader3
        '
        Me.columnHeader3.Width = 157
        '
        'tabIRC
        '
        Me.tabIRC.BackColor = System.Drawing.Color.Silver
        Me.tabIRC.Controls.Add(Me.gIRCAdv)
        Me.tabIRC.Controls.Add(Me.xIRCListShowNonEnglish)
        Me.tabIRC.Controls.Add(Me.gIRCOptions)
        Me.tabIRC.Controls.Add(Me.gIRCNetwork)
        Me.tabIRC.Controls.Add(Me.lIRCList)
        Me.tabIRC.Controls.Add(Me.xIRCBotEnabled)
        Me.tabIRC.Controls.Add(Me.cIRCList)
        Me.tabIRC.Location = New System.Drawing.Point(4, 22)
        Me.tabIRC.Name = "tabIRC"
        Me.tabIRC.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabIRC.Size = New System.Drawing.Size(652, 484)
        Me.tabIRC.TabIndex = 8
        Me.tabIRC.Text = "IRC"
        '
        'gIRCAdv
        '
        Me.gIRCAdv.Controls.Add(Me.tServPass)
        Me.gIRCAdv.Controls.Add(Me.xServPass)
        Me.gIRCAdv.Controls.Add(Me.tChanPass)
        Me.gIRCAdv.Controls.Add(Me.xChanPass)
        Me.gIRCAdv.Location = New System.Drawing.Point(10, 374)
        Me.gIRCAdv.Name = "gIRCAdv"
        Me.gIRCAdv.Size = New System.Drawing.Size(419, 95)
        Me.gIRCAdv.TabIndex = 6
        Me.gIRCAdv.TabStop = False
        Me.gIRCAdv.Text = "Advanced"
        '
        'tServPass
        '
        Me.tServPass.Enabled = False
        Me.tServPass.Location = New System.Drawing.Point(219, 48)
        Me.tServPass.Name = "tServPass"
        Me.tServPass.Size = New System.Drawing.Size(154, 21)
        Me.tServPass.TabIndex = 3
        '
        'xServPass
        '
        Me.xServPass.AutoSize = True
        Me.xServPass.Location = New System.Drawing.Point(219, 23)
        Me.xServPass.Name = "xServPass"
        Me.xServPass.Size = New System.Drawing.Size(143, 19)
        Me.xServPass.TabIndex = 2
        Me.xServPass.Text = "Use Server Password"
        Me.xServPass.UseVisualStyleBackColor = True
        '
        'tChanPass
        '
        Me.tChanPass.Enabled = False
        Me.tChanPass.Location = New System.Drawing.Point(16, 48)
        Me.tChanPass.Name = "tChanPass"
        Me.tChanPass.Size = New System.Drawing.Size(154, 21)
        Me.tChanPass.TabIndex = 1
        '
        'xChanPass
        '
        Me.xChanPass.AutoSize = True
        Me.xChanPass.Location = New System.Drawing.Point(16, 23)
        Me.xChanPass.Name = "xChanPass"
        Me.xChanPass.Size = New System.Drawing.Size(154, 19)
        Me.xChanPass.TabIndex = 0
        Me.xChanPass.Text = "Use Channel Password"
        Me.xChanPass.UseVisualStyleBackColor = True
        '
        'xIRCListShowNonEnglish
        '
        Me.xIRCListShowNonEnglish.AutoSize = True
        Me.xIRCListShowNonEnglish.Enabled = False
        Me.xIRCListShowNonEnglish.Location = New System.Drawing.Point(465, 13)
        Me.xIRCListShowNonEnglish.Name = "xIRCListShowNonEnglish"
        Me.xIRCListShowNonEnglish.Size = New System.Drawing.Size(178, 19)
        Me.xIRCListShowNonEnglish.TabIndex = 3
        Me.xIRCListShowNonEnglish.Text = "Show non-English networks"
        Me.xIRCListShowNonEnglish.UseVisualStyleBackColor = True
        '
        'gIRCOptions
        '
        Me.gIRCOptions.Controls.Add(Me.xIRCBotAnnounceServerEvents)
        Me.gIRCOptions.Controls.Add(Me.xIRCUseColor)
        Me.gIRCOptions.Controls.Add(Me.lIRCNoForwardingMessage)
        Me.gIRCOptions.Controls.Add(Me.xIRCBotAnnounceIRCJoins)
        Me.gIRCOptions.Controls.Add(Me.bColorIRC)
        Me.gIRCOptions.Controls.Add(Me.lColorIRC)
        Me.gIRCOptions.Controls.Add(Me.xIRCBotForwardFromIRC)
        Me.gIRCOptions.Controls.Add(Me.xIRCBotAnnounceServerJoins)
        Me.gIRCOptions.Controls.Add(Me.xIRCBotForwardFromServer)
        Me.gIRCOptions.Location = New System.Drawing.Point(8, 206)
        Me.gIRCOptions.Name = "gIRCOptions"
        Me.gIRCOptions.Size = New System.Drawing.Size(636, 162)
        Me.gIRCOptions.TabIndex = 5
        Me.gIRCOptions.TabStop = False
        Me.gIRCOptions.Text = "Options"
        '
        'xIRCBotAnnounceServerEvents
        '
        Me.xIRCBotAnnounceServerEvents.AutoSize = True
        Me.xIRCBotAnnounceServerEvents.Location = New System.Drawing.Point(38, 109)
        Me.xIRCBotAnnounceServerEvents.Name = "xIRCBotAnnounceServerEvents"
        Me.xIRCBotAnnounceServerEvents.Size = New System.Drawing.Size(417, 19)
        Me.xIRCBotAnnounceServerEvents.TabIndex = 7
        Me.xIRCBotAnnounceServerEvents.Text = "Announce SERVER events (kicks, bans, promotions, demotions) on IRC."
        Me.xIRCBotAnnounceServerEvents.UseVisualStyleBackColor = True
        '
        'xIRCUseColor
        '
        Me.xIRCUseColor.AutoSize = True
        Me.xIRCUseColor.Location = New System.Drawing.Point(325, 34)
        Me.xIRCUseColor.Name = "xIRCUseColor"
        Me.xIRCUseColor.Size = New System.Drawing.Size(149, 19)
        Me.xIRCUseColor.TabIndex = 2
        Me.xIRCUseColor.Text = "Use text colors on IRC."
        Me.xIRCUseColor.UseVisualStyleBackColor = True
        '
        'lIRCNoForwardingMessage
        '
        Me.lIRCNoForwardingMessage.AutoSize = True
        Me.lIRCNoForwardingMessage.Location = New System.Drawing.Point(35, 137)
        Me.lIRCNoForwardingMessage.Name = "lIRCNoForwardingMessage"
        Me.lIRCNoForwardingMessage.Size = New System.Drawing.Size(567, 15)
        Me.lIRCNoForwardingMessage.TabIndex = 8
        Me.lIRCNoForwardingMessage.Text = "NOTE: If forwarding all messages is not enabled, only messages starting with a ha" & _
    "sh (#) will be relayed."
        '
        'xIRCBotAnnounceIRCJoins
        '
        Me.xIRCBotAnnounceIRCJoins.AutoSize = True
        Me.xIRCBotAnnounceIRCJoins.Location = New System.Drawing.Point(325, 84)
        Me.xIRCBotAnnounceIRCJoins.Name = "xIRCBotAnnounceIRCJoins"
        Me.xIRCBotAnnounceIRCJoins.Size = New System.Drawing.Size(303, 19)
        Me.xIRCBotAnnounceIRCJoins.TabIndex = 6
        Me.xIRCBotAnnounceIRCJoins.Text = "Announce people joining/leaving the IRC channels."
        Me.xIRCBotAnnounceIRCJoins.UseVisualStyleBackColor = True
        '
        'bColorIRC
        '
        Me.bColorIRC.BackColor = System.Drawing.Color.White
        Me.bColorIRC.Location = New System.Drawing.Point(152, 20)
        Me.bColorIRC.Name = "bColorIRC"
        Me.bColorIRC.Size = New System.Drawing.Size(100, 23)
        Me.bColorIRC.TabIndex = 1
        Me.bColorIRC.UseVisualStyleBackColor = False
        '
        'lColorIRC
        '
        Me.lColorIRC.AutoSize = True
        Me.lColorIRC.Location = New System.Drawing.Point(35, 24)
        Me.lColorIRC.Name = "lColorIRC"
        Me.lColorIRC.Size = New System.Drawing.Size(111, 15)
        Me.lColorIRC.TabIndex = 0
        Me.lColorIRC.Text = "IRC message color"
        '
        'xIRCBotForwardFromIRC
        '
        Me.xIRCBotForwardFromIRC.AutoSize = True
        Me.xIRCBotForwardFromIRC.Location = New System.Drawing.Point(38, 84)
        Me.xIRCBotForwardFromIRC.Name = "xIRCBotForwardFromIRC"
        Me.xIRCBotForwardFromIRC.Size = New System.Drawing.Size(240, 19)
        Me.xIRCBotForwardFromIRC.TabIndex = 4
        Me.xIRCBotForwardFromIRC.Text = "Forward ALL chat from IRC to SERVER."
        Me.xIRCBotForwardFromIRC.UseVisualStyleBackColor = True
        '
        'xIRCBotAnnounceServerJoins
        '
        Me.xIRCBotAnnounceServerJoins.AutoSize = True
        Me.xIRCBotAnnounceServerJoins.Location = New System.Drawing.Point(325, 59)
        Me.xIRCBotAnnounceServerJoins.Name = "xIRCBotAnnounceServerJoins"
        Me.xIRCBotAnnounceServerJoins.Size = New System.Drawing.Size(279, 19)
        Me.xIRCBotAnnounceServerJoins.TabIndex = 5
        Me.xIRCBotAnnounceServerJoins.Text = "Announce people joining/leaving the SERVER."
        Me.xIRCBotAnnounceServerJoins.UseVisualStyleBackColor = True
        '
        'xIRCBotForwardFromServer
        '
        Me.xIRCBotForwardFromServer.AutoSize = True
        Me.xIRCBotForwardFromServer.Location = New System.Drawing.Point(38, 59)
        Me.xIRCBotForwardFromServer.Name = "xIRCBotForwardFromServer"
        Me.xIRCBotForwardFromServer.Size = New System.Drawing.Size(240, 19)
        Me.xIRCBotForwardFromServer.TabIndex = 3
        Me.xIRCBotForwardFromServer.Text = "Forward ALL chat from SERVER to IRC."
        Me.xIRCBotForwardFromServer.UseVisualStyleBackColor = True
        '
        'gIRCNetwork
        '
        Me.gIRCNetwork.Controls.Add(Me.lIRCDelayUnits)
        Me.gIRCNetwork.Controls.Add(Me.xIRCRegisteredNick)
        Me.gIRCNetwork.Controls.Add(Me.tIRCNickServMessage)
        Me.gIRCNetwork.Controls.Add(Me.lIRCNickServMessage)
        Me.gIRCNetwork.Controls.Add(Me.tIRCNickServ)
        Me.gIRCNetwork.Controls.Add(Me.lIRCNickServ)
        Me.gIRCNetwork.Controls.Add(Me.nIRCDelay)
        Me.gIRCNetwork.Controls.Add(Me.lIRCDelay)
        Me.gIRCNetwork.Controls.Add(Me.lIRCBotChannels2)
        Me.gIRCNetwork.Controls.Add(Me.lIRCBotChannels3)
        Me.gIRCNetwork.Controls.Add(Me.tIRCBotChannels)
        Me.gIRCNetwork.Controls.Add(Me.lIRCBotChannels)
        Me.gIRCNetwork.Controls.Add(Me.nIRCBotPort)
        Me.gIRCNetwork.Controls.Add(Me.lIRCBotPort)
        Me.gIRCNetwork.Controls.Add(Me.tIRCBotNetwork)
        Me.gIRCNetwork.Controls.Add(Me.lIRCBotNetwork)
        Me.gIRCNetwork.Controls.Add(Me.lIRCBotNick)
        Me.gIRCNetwork.Controls.Add(Me.tIRCBotNick)
        Me.gIRCNetwork.Location = New System.Drawing.Point(8, 40)
        Me.gIRCNetwork.Name = "gIRCNetwork"
        Me.gIRCNetwork.Size = New System.Drawing.Size(636, 160)
        Me.gIRCNetwork.TabIndex = 4
        Me.gIRCNetwork.TabStop = False
        Me.gIRCNetwork.Text = "Network"
        '
        'lIRCDelayUnits
        '
        Me.lIRCDelayUnits.AutoSize = True
        Me.lIRCDelayUnits.Location = New System.Drawing.Point(598, 22)
        Me.lIRCDelayUnits.Name = "lIRCDelayUnits"
        Me.lIRCDelayUnits.Size = New System.Drawing.Size(24, 15)
        Me.lIRCDelayUnits.TabIndex = 6
        Me.lIRCDelayUnits.Text = "ms"
        '
        'xIRCRegisteredNick
        '
        Me.xIRCRegisteredNick.AutoSize = True
        Me.xIRCRegisteredNick.Location = New System.Drawing.Point(265, 101)
        Me.xIRCRegisteredNick.Name = "xIRCRegisteredNick"
        Me.xIRCRegisteredNick.Size = New System.Drawing.Size(86, 19)
        Me.xIRCRegisteredNick.TabIndex = 13
        Me.xIRCRegisteredNick.Text = "Registered"
        Me.xIRCRegisteredNick.UseVisualStyleBackColor = True
        '
        'lIRCNickServMessage
        '
        Me.lIRCNickServMessage.AutoSize = True
        Me.lIRCNickServMessage.Enabled = False
        Me.lIRCNickServMessage.Location = New System.Drawing.Point(265, 129)
        Me.lIRCNickServMessage.Name = "lIRCNickServMessage"
        Me.lIRCNickServMessage.Size = New System.Drawing.Size(117, 15)
        Me.lIRCNickServMessage.TabIndex = 16
        Me.lIRCNickServMessage.Text = "Authentication string"
        '
        'tIRCNickServ
        '
        Me.tIRCNickServ.Enabled = False
        Me.tIRCNickServ.Location = New System.Drawing.Point(121, 126)
        Me.tIRCNickServ.MaxLength = 32
        Me.tIRCNickServ.Name = "tIRCNickServ"
        Me.tIRCNickServ.Size = New System.Drawing.Size(138, 21)
        Me.tIRCNickServ.TabIndex = 15
        '
        'lIRCNickServ
        '
        Me.lIRCNickServ.AutoSize = True
        Me.lIRCNickServ.Enabled = False
        Me.lIRCNickServ.Location = New System.Drawing.Point(35, 129)
        Me.lIRCNickServ.Name = "lIRCNickServ"
        Me.lIRCNickServ.Size = New System.Drawing.Size(80, 15)
        Me.lIRCNickServ.TabIndex = 14
        Me.lIRCNickServ.Text = "NickServ nick"
        '
        'nIRCDelay
        '
        Me.nIRCDelay.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nIRCDelay.Location = New System.Drawing.Point(536, 20)
        Me.nIRCDelay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nIRCDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nIRCDelay.Name = "nIRCDelay"
        Me.nIRCDelay.Size = New System.Drawing.Size(56, 21)
        Me.nIRCDelay.TabIndex = 5
        Me.nIRCDelay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lIRCDelay
        '
        Me.lIRCDelay.AutoSize = True
        Me.lIRCDelay.Location = New System.Drawing.Point(416, 22)
        Me.lIRCDelay.Name = "lIRCDelay"
        Me.lIRCDelay.Size = New System.Drawing.Size(114, 15)
        Me.lIRCDelay.TabIndex = 4
        Me.lIRCDelay.Text = "Min message delay"
        '
        'lIRCBotChannels2
        '
        Me.lIRCBotChannels2.AutoSize = True
        Me.lIRCBotChannels2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lIRCBotChannels2.Location = New System.Drawing.Point(15, 65)
        Me.lIRCBotChannels2.Name = "lIRCBotChannels2"
        Me.lIRCBotChannels2.Size = New System.Drawing.Size(97, 13)
        Me.lIRCBotChannels2.TabIndex = 9
        Me.lIRCBotChannels2.Text = "(comma seperated)"
        '
        'lIRCBotChannels3
        '
        Me.lIRCBotChannels3.AutoSize = True
        Me.lIRCBotChannels3.Location = New System.Drawing.Point(118, 71)
        Me.lIRCBotChannels3.Name = "lIRCBotChannels3"
        Me.lIRCBotChannels3.Size = New System.Drawing.Size(340, 15)
        Me.lIRCBotChannels3.TabIndex = 10
        Me.lIRCBotChannels3.Text = "NOTE: Channel names are case-sensitive on some networks!"
        '
        'tIRCBotChannels
        '
        Me.tIRCBotChannels.Location = New System.Drawing.Point(121, 47)
        Me.tIRCBotChannels.MaxLength = 1000
        Me.tIRCBotChannels.Name = "tIRCBotChannels"
        Me.tIRCBotChannels.Size = New System.Drawing.Size(501, 21)
        Me.tIRCBotChannels.TabIndex = 8
        '
        'lIRCBotChannels
        '
        Me.lIRCBotChannels.AutoSize = True
        Me.lIRCBotChannels.Location = New System.Drawing.Point(20, 50)
        Me.lIRCBotChannels.Name = "lIRCBotChannels"
        Me.lIRCBotChannels.Size = New System.Drawing.Size(95, 15)
        Me.lIRCBotChannels.TabIndex = 7
        Me.lIRCBotChannels.Text = "Channels to join"
        '
        'nIRCBotPort
        '
        Me.nIRCBotPort.Location = New System.Drawing.Point(300, 20)
        Me.nIRCBotPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nIRCBotPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nIRCBotPort.Name = "nIRCBotPort"
        Me.nIRCBotPort.Size = New System.Drawing.Size(64, 21)
        Me.nIRCBotPort.TabIndex = 3
        Me.nIRCBotPort.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lIRCBotPort
        '
        Me.lIRCBotPort.AutoSize = True
        Me.lIRCBotPort.Location = New System.Drawing.Point(265, 22)
        Me.lIRCBotPort.Name = "lIRCBotPort"
        Me.lIRCBotPort.Size = New System.Drawing.Size(29, 15)
        Me.lIRCBotPort.TabIndex = 2
        Me.lIRCBotPort.Text = "Port"
        '
        'tIRCBotNetwork
        '
        Me.tIRCBotNetwork.Location = New System.Drawing.Point(121, 19)
        Me.tIRCBotNetwork.MaxLength = 512
        Me.tIRCBotNetwork.Name = "tIRCBotNetwork"
        Me.tIRCBotNetwork.Size = New System.Drawing.Size(138, 21)
        Me.tIRCBotNetwork.TabIndex = 1
        '
        'lIRCBotNetwork
        '
        Me.lIRCBotNetwork.AutoSize = True
        Me.lIRCBotNetwork.Location = New System.Drawing.Point(26, 22)
        Me.lIRCBotNetwork.Name = "lIRCBotNetwork"
        Me.lIRCBotNetwork.Size = New System.Drawing.Size(93, 15)
        Me.lIRCBotNetwork.TabIndex = 0
        Me.lIRCBotNetwork.Text = "IRC Server Host"
        '
        'lIRCBotNick
        '
        Me.lIRCBotNick.AutoSize = True
        Me.lIRCBotNick.Location = New System.Drawing.Point(65, 102)
        Me.lIRCBotNick.Name = "lIRCBotNick"
        Me.lIRCBotNick.Size = New System.Drawing.Size(50, 15)
        Me.lIRCBotNick.TabIndex = 11
        Me.lIRCBotNick.Text = "Bot nick"
        '
        'tIRCBotNick
        '
        Me.tIRCBotNick.Location = New System.Drawing.Point(121, 99)
        Me.tIRCBotNick.MaxLength = 32
        Me.tIRCBotNick.Name = "tIRCBotNick"
        Me.tIRCBotNick.Size = New System.Drawing.Size(138, 21)
        Me.tIRCBotNick.TabIndex = 12
        '
        'lIRCList
        '
        Me.lIRCList.AutoSize = True
        Me.lIRCList.Enabled = False
        Me.lIRCList.Location = New System.Drawing.Point(213, 14)
        Me.lIRCList.Name = "lIRCList"
        Me.lIRCList.Size = New System.Drawing.Size(105, 15)
        Me.lIRCList.TabIndex = 1
        Me.lIRCList.Text = "Popular networks:"
        '
        'xIRCBotEnabled
        '
        Me.xIRCBotEnabled.AutoSize = True
        Me.xIRCBotEnabled.Location = New System.Drawing.Point(14, 13)
        Me.xIRCBotEnabled.Name = "xIRCBotEnabled"
        Me.xIRCBotEnabled.Size = New System.Drawing.Size(149, 19)
        Me.xIRCBotEnabled.TabIndex = 0
        Me.xIRCBotEnabled.Text = "Enable IRC integration"
        Me.xIRCBotEnabled.UseVisualStyleBackColor = True
        '
        'cIRCList
        '
        Me.cIRCList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cIRCList.Enabled = False
        Me.cIRCList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cIRCList.FormattingEnabled = True
        Me.cIRCList.Location = New System.Drawing.Point(321, 11)
        Me.cIRCList.Name = "cIRCList"
        Me.cIRCList.Size = New System.Drawing.Size(138, 23)
        Me.cIRCList.TabIndex = 2
        '
        'lLogFileOptionsDescription
        '
        Me.lLogFileOptionsDescription.AutoSize = True
        Me.lLogFileOptionsDescription.Location = New System.Drawing.Point(27, 22)
        Me.lLogFileOptionsDescription.Name = "lLogFileOptionsDescription"
        Me.lLogFileOptionsDescription.Size = New System.Drawing.Size(212, 30)
        Me.lLogFileOptionsDescription.TabIndex = 0
        Me.lLogFileOptionsDescription.Text = "Types of messages that will be written" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the log file on disk."
        '
        'gLogFile
        '
        Me.gLogFile.BackColor = System.Drawing.Color.Silver
        Me.gLogFile.Controls.Add(Me.lLogFileOptionsDescription)
        Me.gLogFile.Controls.Add(Me.xLogLimit)
        Me.gLogFile.Controls.Add(Me.vLogFileOptions)
        Me.gLogFile.Controls.Add(Me.lLogLimitUnits)
        Me.gLogFile.Controls.Add(Me.nLogLimit)
        Me.gLogFile.Controls.Add(Me.cLogMode)
        Me.gLogFile.Controls.Add(Me.lLogMode)
        Me.gLogFile.Location = New System.Drawing.Point(329, 13)
        Me.gLogFile.Name = "gLogFile"
        Me.gLogFile.Size = New System.Drawing.Size(315, 423)
        Me.gLogFile.TabIndex = 1
        Me.gLogFile.TabStop = False
        Me.gLogFile.Text = "Log File"
        '
        'tabLogging
        '
        Me.tabLogging.BackColor = System.Drawing.Color.Silver
        Me.tabLogging.Controls.Add(Me.gLogFile)
        Me.tabLogging.Controls.Add(Me.gConsole)
        Me.tabLogging.Location = New System.Drawing.Point(4, 22)
        Me.tabLogging.Name = "tabLogging"
        Me.tabLogging.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabLogging.Size = New System.Drawing.Size(652, 484)
        Me.tabLogging.TabIndex = 5
        Me.tabLogging.Text = "Logging"
        '
        'gConsole
        '
        Me.gConsole.Controls.Add(Me.lLogConsoleOptionsDescription)
        Me.gConsole.Controls.Add(Me.vConsoleOptions)
        Me.gConsole.Location = New System.Drawing.Point(8, 13)
        Me.gConsole.Name = "gConsole"
        Me.gConsole.Size = New System.Drawing.Size(315, 423)
        Me.gConsole.TabIndex = 0
        Me.gConsole.TabStop = False
        Me.gConsole.Text = "Console"
        '
        'gDataBackup
        '
        Me.gDataBackup.Controls.Add(Me.xBackupDataOnStartup)
        Me.gDataBackup.Location = New System.Drawing.Point(8, 235)
        Me.gDataBackup.Name = "gDataBackup"
        Me.gDataBackup.Size = New System.Drawing.Size(636, 52)
        Me.gDataBackup.TabIndex = 2
        Me.gDataBackup.TabStop = False
        Me.gDataBackup.Text = "Data Backup"
        '
        'xBackupDataOnStartup
        '
        Me.xBackupDataOnStartup.AutoSize = True
        Me.xBackupDataOnStartup.Location = New System.Drawing.Point(16, 20)
        Me.xBackupDataOnStartup.Name = "xBackupDataOnStartup"
        Me.xBackupDataOnStartup.Size = New System.Drawing.Size(261, 19)
        Me.xBackupDataOnStartup.TabIndex = 0
        Me.xBackupDataOnStartup.Text = "Backup PlayerDB and IP ban list on startup."
        Me.xBackupDataOnStartup.UseVisualStyleBackColor = True
        '
        'bUpdate
        '
        Me.bUpdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUpdate.Location = New System.Drawing.Point(221, 14)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(205, 28)
        Me.bUpdate.TabIndex = 23
        Me.bUpdate.Text = "Manual Update Check"
        Me.bUpdate.UseVisualStyleBackColor = False
        '
        'checkUpdate
        '
        Me.checkUpdate.AutoSize = True
        Me.checkUpdate.Location = New System.Drawing.Point(11, 20)
        Me.checkUpdate.Name = "checkUpdate"
        Me.checkUpdate.Size = New System.Drawing.Size(201, 19)
        Me.checkUpdate.TabIndex = 22
        Me.checkUpdate.Text = "Automatically Check for Updates"
        Me.checkUpdate.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.bUpdate)
        Me.groupBox5.Controls.Add(Me.checkUpdate)
        Me.groupBox5.Location = New System.Drawing.Point(8, 293)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(635, 54)
        Me.groupBox5.TabIndex = 3
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Update"
        '
        'nMaxConnectionsPerIP
        '
        Me.nMaxConnectionsPerIP.Location = New System.Drawing.Point(539, 21)
        Me.nMaxConnectionsPerIP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nMaxConnectionsPerIP.Name = "nMaxConnectionsPerIP"
        Me.nMaxConnectionsPerIP.Size = New System.Drawing.Size(47, 21)
        Me.nMaxConnectionsPerIP.TabIndex = 4
        Me.nMaxConnectionsPerIP.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'xAllowUnverifiedLAN
        '
        Me.xAllowUnverifiedLAN.AutoSize = True
        Me.xAllowUnverifiedLAN.Location = New System.Drawing.Point(42, 49)
        Me.xAllowUnverifiedLAN.Name = "xAllowUnverifiedLAN"
        Me.xAllowUnverifiedLAN.Size = New System.Drawing.Size(490, 19)
        Me.xAllowUnverifiedLAN.TabIndex = 2
        Me.xAllowUnverifiedLAN.Text = "Allow connections from LAN without name verification (192.168.0.0/16 and 10.0.0.0" & _
    "/8)"
        Me.xAllowUnverifiedLAN.UseVisualStyleBackColor = True
        '
        'xMaxConnectionsPerIP
        '
        Me.xMaxConnectionsPerIP.AutoSize = True
        Me.xMaxConnectionsPerIP.Location = New System.Drawing.Point(304, 22)
        Me.xMaxConnectionsPerIP.Name = "xMaxConnectionsPerIP"
        Me.xMaxConnectionsPerIP.Size = New System.Drawing.Size(229, 19)
        Me.xMaxConnectionsPerIP.TabIndex = 3
        Me.xMaxConnectionsPerIP.Text = "Limit number of connections per IP to"
        Me.xMaxConnectionsPerIP.UseVisualStyleBackColor = True
        '
        'gUpdate
        '
        Me.gUpdate.BackColor = System.Drawing.Color.Silver
        Me.gUpdate.Controls.Add(Me.groupBox5)
        Me.gUpdate.Controls.Add(Me.gDataBackup)
        Me.gUpdate.Controls.Add(Me.gSaving)
        Me.gUpdate.Controls.Add(Me.gBackups)
        Me.gUpdate.Location = New System.Drawing.Point(4, 22)
        Me.gUpdate.Name = "gUpdate"
        Me.gUpdate.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.gUpdate.Size = New System.Drawing.Size(652, 484)
        Me.gUpdate.TabIndex = 4
        Me.gUpdate.Text = "Saving and Backup"
        '
        'gSaving
        '
        Me.gSaving.Controls.Add(Me.nSaveInterval)
        Me.gSaving.Controls.Add(Me.lSaveIntervalUnits)
        Me.gSaving.Controls.Add(Me.xSaveInterval)
        Me.gSaving.Location = New System.Drawing.Point(8, 13)
        Me.gSaving.Name = "gSaving"
        Me.gSaving.Size = New System.Drawing.Size(636, 52)
        Me.gSaving.TabIndex = 0
        Me.gSaving.TabStop = False
        Me.gSaving.Text = "Map Saving"
        '
        'nSaveInterval
        '
        Me.nSaveInterval.Location = New System.Drawing.Point(136, 20)
        Me.nSaveInterval.Name = "nSaveInterval"
        Me.nSaveInterval.Size = New System.Drawing.Size(48, 21)
        Me.nSaveInterval.TabIndex = 1
        '
        'lSaveIntervalUnits
        '
        Me.lSaveIntervalUnits.AutoSize = True
        Me.lSaveIntervalUnits.Location = New System.Drawing.Point(190, 22)
        Me.lSaveIntervalUnits.Name = "lSaveIntervalUnits"
        Me.lSaveIntervalUnits.Size = New System.Drawing.Size(53, 15)
        Me.lSaveIntervalUnits.TabIndex = 2
        Me.lSaveIntervalUnits.Text = "seconds"
        '
        'xSaveInterval
        '
        Me.xSaveInterval.AutoSize = True
        Me.xSaveInterval.Location = New System.Drawing.Point(12, 21)
        Me.xSaveInterval.Name = "xSaveInterval"
        Me.xSaveInterval.Size = New System.Drawing.Size(118, 19)
        Me.xSaveInterval.TabIndex = 0
        Me.xSaveInterval.Text = "Save maps every"
        Me.xSaveInterval.UseVisualStyleBackColor = True
        '
        'gBackups
        '
        Me.gBackups.Controls.Add(Me.xBackupOnlyWhenChanged)
        Me.gBackups.Controls.Add(Me.lMaxBackupSize)
        Me.gBackups.Controls.Add(Me.xMaxBackupSize)
        Me.gBackups.Controls.Add(Me.nMaxBackupSize)
        Me.gBackups.Controls.Add(Me.xMaxBackups)
        Me.gBackups.Controls.Add(Me.xBackupOnStartup)
        Me.gBackups.Controls.Add(Me.lMaxBackups)
        Me.gBackups.Controls.Add(Me.nMaxBackups)
        Me.gBackups.Controls.Add(Me.nBackupInterval)
        Me.gBackups.Controls.Add(Me.lBackupIntervalUnits)
        Me.gBackups.Controls.Add(Me.xBackupInterval)
        Me.gBackups.Controls.Add(Me.xBackupOnJoin)
        Me.gBackups.Location = New System.Drawing.Point(8, 71)
        Me.gBackups.Name = "gBackups"
        Me.gBackups.Size = New System.Drawing.Size(636, 158)
        Me.gBackups.TabIndex = 1
        Me.gBackups.TabStop = False
        Me.gBackups.Text = "Map Backups"
        '
        'xBackupOnlyWhenChanged
        '
        Me.xBackupOnlyWhenChanged.AutoSize = True
        Me.xBackupOnlyWhenChanged.Location = New System.Drawing.Point(369, 46)
        Me.xBackupOnlyWhenChanged.Name = "xBackupOnlyWhenChanged"
        Me.xBackupOnlyWhenChanged.Size = New System.Drawing.Size(260, 19)
        Me.xBackupOnlyWhenChanged.TabIndex = 4
        Me.xBackupOnlyWhenChanged.Text = "Skip timed backups if map hasn't changed."
        Me.xBackupOnlyWhenChanged.UseVisualStyleBackColor = True
        '
        'lMaxBackupSize
        '
        Me.lMaxBackupSize.AutoSize = True
        Me.lMaxBackupSize.Location = New System.Drawing.Point(418, 124)
        Me.lMaxBackupSize.Name = "lMaxBackupSize"
        Me.lMaxBackupSize.Size = New System.Drawing.Size(103, 15)
        Me.lMaxBackupSize.TabIndex = 11
        Me.lMaxBackupSize.Text = "MB of disk space."
        '
        'xMaxBackupSize
        '
        Me.xMaxBackupSize.AutoSize = True
        Me.xMaxBackupSize.Location = New System.Drawing.Point(16, 123)
        Me.xMaxBackupSize.Name = "xMaxBackupSize"
        Me.xMaxBackupSize.Size = New System.Drawing.Size(317, 19)
        Me.xMaxBackupSize.TabIndex = 9
        Me.xMaxBackupSize.Text = "Delete old backups if the directory takes up more than"
        Me.xMaxBackupSize.UseVisualStyleBackColor = True
        '
        'nMaxBackupSize
        '
        Me.nMaxBackupSize.Location = New System.Drawing.Point(339, 122)
        Me.nMaxBackupSize.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nMaxBackupSize.Name = "nMaxBackupSize"
        Me.nMaxBackupSize.Size = New System.Drawing.Size(73, 21)
        Me.nMaxBackupSize.TabIndex = 10
        '
        'xMaxBackups
        '
        Me.xMaxBackups.AutoSize = True
        Me.xMaxBackups.Location = New System.Drawing.Point(16, 98)
        Me.xMaxBackups.Name = "xMaxBackups"
        Me.xMaxBackups.Size = New System.Drawing.Size(251, 19)
        Me.xMaxBackups.TabIndex = 6
        Me.xMaxBackups.Text = "Delete old backups if there are more than"
        Me.xMaxBackups.UseVisualStyleBackColor = True
        '
        'xBackupOnStartup
        '
        Me.xBackupOnStartup.AutoSize = True
        Me.xBackupOnStartup.Enabled = False
        Me.xBackupOnStartup.Location = New System.Drawing.Point(16, 20)
        Me.xBackupOnStartup.Name = "xBackupOnStartup"
        Me.xBackupOnStartup.Size = New System.Drawing.Size(168, 19)
        Me.xBackupOnStartup.TabIndex = 0
        Me.xBackupOnStartup.Text = "Create backups on startup"
        Me.xBackupOnStartup.UseVisualStyleBackColor = True
        '
        'lMaxBackups
        '
        Me.lMaxBackups.AutoSize = True
        Me.lMaxBackups.Location = New System.Drawing.Point(336, 99)
        Me.lMaxBackups.Name = "lMaxBackups"
        Me.lMaxBackups.Size = New System.Drawing.Size(157, 15)
        Me.lMaxBackups.TabIndex = 8
        Me.lMaxBackups.Text = "files in the backup directory."
        '
        'nMaxBackups
        '
        Me.nMaxBackups.Location = New System.Drawing.Point(273, 97)
        Me.nMaxBackups.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nMaxBackups.Name = "nMaxBackups"
        Me.nMaxBackups.Size = New System.Drawing.Size(57, 21)
        Me.nMaxBackups.TabIndex = 7
        '
        'nBackupInterval
        '
        Me.nBackupInterval.Location = New System.Drawing.Point(164, 45)
        Me.nBackupInterval.Name = "nBackupInterval"
        Me.nBackupInterval.Size = New System.Drawing.Size(48, 21)
        Me.nBackupInterval.TabIndex = 2
        '
        'lBackupIntervalUnits
        '
        Me.lBackupIntervalUnits.AutoSize = True
        Me.lBackupIntervalUnits.Location = New System.Drawing.Point(218, 47)
        Me.lBackupIntervalUnits.Name = "lBackupIntervalUnits"
        Me.lBackupIntervalUnits.Size = New System.Drawing.Size(51, 15)
        Me.lBackupIntervalUnits.TabIndex = 3
        Me.lBackupIntervalUnits.Text = "minutes"
        '
        'xBackupInterval
        '
        Me.xBackupInterval.AutoSize = True
        Me.xBackupInterval.Location = New System.Drawing.Point(16, 46)
        Me.xBackupInterval.Name = "xBackupInterval"
        Me.xBackupInterval.Size = New System.Drawing.Size(142, 19)
        Me.xBackupInterval.TabIndex = 1
        Me.xBackupInterval.Text = "Create backups every"
        Me.xBackupInterval.UseVisualStyleBackColor = True
        '
        'xBackupOnJoin
        '
        Me.xBackupOnJoin.AutoSize = True
        Me.xBackupOnJoin.Location = New System.Drawing.Point(16, 72)
        Me.xBackupOnJoin.Name = "xBackupOnJoin"
        Me.xBackupOnJoin.Size = New System.Drawing.Size(279, 19)
        Me.xBackupOnJoin.TabIndex = 5
        Me.xBackupOnJoin.Text = "Create backup whenever a player joins a world"
        Me.xBackupOnJoin.UseVisualStyleBackColor = True
        '
        'lVerifyNames
        '
        Me.lVerifyNames.AutoSize = True
        Me.lVerifyNames.Location = New System.Drawing.Point(45, 23)
        Me.lVerifyNames.Name = "lVerifyNames"
        Me.lVerifyNames.Size = New System.Drawing.Size(102, 15)
        Me.lVerifyNames.TabIndex = 0
        Me.lVerifyNames.Text = "Name verification"
        '
        'gVerify
        '
        Me.gVerify.BackColor = System.Drawing.Color.Silver
        Me.gVerify.Controls.Add(Me.nMaxConnectionsPerIP)
        Me.gVerify.Controls.Add(Me.xAllowUnverifiedLAN)
        Me.gVerify.Controls.Add(Me.xMaxConnectionsPerIP)
        Me.gVerify.Controls.Add(Me.lVerifyNames)
        Me.gVerify.Controls.Add(Me.cVerifyNames)
        Me.gVerify.Location = New System.Drawing.Point(8, 13)
        Me.gVerify.Name = "gVerify"
        Me.gVerify.Size = New System.Drawing.Size(636, 81)
        Me.gVerify.TabIndex = 0
        Me.gVerify.TabStop = False
        Me.gVerify.Text = "Connection"
        '
        'cVerifyNames
        '
        Me.cVerifyNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cVerifyNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cVerifyNames.FormattingEnabled = True
        Me.cVerifyNames.Items.AddRange(New Object() {"None (Unsafe)", "Normal", "Strict"})
        Me.cVerifyNames.Location = New System.Drawing.Point(153, 20)
        Me.cVerifyNames.Name = "cVerifyNames"
        Me.cVerifyNames.Size = New System.Drawing.Size(120, 23)
        Me.cVerifyNames.TabIndex = 1
        '
        'toolTip
        '
        Me.toolTip.AutoPopDelay = 11111
        Me.toolTip.InitialDelay = 500
        Me.toolTip.IsBalloon = True
        Me.toolTip.ReshowDelay = 100
        '
        'xAntispamKicks
        '
        Me.xAntispamKicks.AutoSize = True
        Me.xAntispamKicks.Location = New System.Drawing.Point(304, 61)
        Me.xAntispamKicks.Name = "xAntispamKicks"
        Me.xAntispamKicks.Size = New System.Drawing.Size(76, 19)
        Me.xAntispamKicks.TabIndex = 8
        Me.xAntispamKicks.Text = "Kick after"
        Me.xAntispamKicks.UseVisualStyleBackColor = True
        '
        'lSpamMuteSeconds
        '
        Me.lSpamMuteSeconds.AutoSize = True
        Me.lSpamMuteSeconds.Location = New System.Drawing.Point(221, 62)
        Me.lSpamMuteSeconds.Name = "lSpamMuteSeconds"
        Me.lSpamMuteSeconds.Size = New System.Drawing.Size(53, 15)
        Me.lSpamMuteSeconds.TabIndex = 7
        Me.lSpamMuteSeconds.Text = "seconds"
        '
        'nAntispamMaxWarnings
        '
        Me.nAntispamMaxWarnings.Location = New System.Drawing.Point(386, 60)
        Me.nAntispamMaxWarnings.Name = "nAntispamMaxWarnings"
        Me.nAntispamMaxWarnings.Size = New System.Drawing.Size(62, 21)
        Me.nAntispamMaxWarnings.TabIndex = 9
        '
        'xAutoRank
        '
        Me.xAutoRank.AutoSize = True
        Me.xAutoRank.Location = New System.Drawing.Point(9, 188)
        Me.xAutoRank.Name = "xAutoRank"
        Me.xAutoRank.Size = New System.Drawing.Size(121, 19)
        Me.xAutoRank.TabIndex = 24
        Me.xAutoRank.Text = "Enable AutoRank"
        Me.xAutoRank.UseVisualStyleBackColor = True
        '
        'nMaxUndoStates
        '
        Me.nMaxUndoStates.Location = New System.Drawing.Point(115, 71)
        Me.nMaxUndoStates.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nMaxUndoStates.Name = "nMaxUndoStates"
        Me.nMaxUndoStates.Size = New System.Drawing.Size(58, 21)
        Me.nMaxUndoStates.TabIndex = 23
        Me.nMaxUndoStates.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lIPWarning
        '
        Me.lIPWarning.AutoSize = True
        Me.lIPWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lIPWarning.Location = New System.Drawing.Point(112, 131)
        Me.lIPWarning.Name = "lIPWarning"
        Me.lIPWarning.Size = New System.Drawing.Size(408, 13)
        Me.lIPWarning.TabIndex = 20
        Me.lIPWarning.Text = "Note: You do not need to specify an IP address unless you have multiple NICs or I" & _
    "Ps."
        '
        'tIP
        '
        Me.tIP.Location = New System.Drawing.Point(115, 107)
        Me.tIP.MaxLength = 15
        Me.tIP.Name = "tIP"
        Me.tIP.Size = New System.Drawing.Size(97, 21)
        Me.tIP.TabIndex = 19
        '
        'lAntispamMaxWarnings
        '
        Me.lAntispamMaxWarnings.AutoSize = True
        Me.lAntispamMaxWarnings.Location = New System.Drawing.Point(454, 62)
        Me.lAntispamMaxWarnings.Name = "lAntispamMaxWarnings"
        Me.lAntispamMaxWarnings.Size = New System.Drawing.Size(57, 15)
        Me.lAntispamMaxWarnings.TabIndex = 10
        Me.lAntispamMaxWarnings.Text = "warnings"
        '
        'gCrashReport
        '
        Me.gCrashReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gCrashReport.Controls.Add(Me.xCrash)
        Me.gCrashReport.Controls.Add(Me.lCrashReportDisclaimer)
        Me.gCrashReport.Location = New System.Drawing.Point(8, 13)
        Me.gCrashReport.Name = "gCrashReport"
        Me.gCrashReport.Size = New System.Drawing.Size(636, 80)
        Me.gCrashReport.TabIndex = 0
        Me.gCrashReport.TabStop = False
        Me.gCrashReport.Text = "Crash Reporting"
        '
        'xCrash
        '
        Me.xCrash.AutoSize = True
        Me.xCrash.Location = New System.Drawing.Point(25, 25)
        Me.xCrash.Name = "xCrash"
        Me.xCrash.Size = New System.Drawing.Size(15, 14)
        Me.xCrash.TabIndex = 2
        Me.xCrash.UseVisualStyleBackColor = True
        '
        'lCrashReportDisclaimer
        '
        Me.lCrashReportDisclaimer.AutoSize = True
        Me.lCrashReportDisclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCrashReportDisclaimer.Location = New System.Drawing.Point(45, 26)
        Me.lCrashReportDisclaimer.Name = "lCrashReportDisclaimer"
        Me.lCrashReportDisclaimer.Size = New System.Drawing.Size(468, 39)
        Me.lCrashReportDisclaimer.TabIndex = 1
        Me.lCrashReportDisclaimer.Text = "Send all Crash Reports To The GemsCraft Dev Team" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crash reports are when serious " & _
    "unexpected errors occur. Being able to receive crash reports helps" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "identify bug" & _
    "s and improve GemsCraft! "
        '
        'Misc
        '
        Me.Misc.BackColor = System.Drawing.Color.Silver
        Me.Misc.Controls.Add(Me.groupBox3)
        Me.Misc.Controls.Add(Me.groupBox1)
        Me.Misc.Location = New System.Drawing.Point(4, 22)
        Me.Misc.Name = "Misc"
        Me.Misc.Padding = New System.Windows.Forms.Padding(3)
        Me.Misc.Size = New System.Drawing.Size(652, 484)
        Me.Misc.TabIndex = 11
        Me.Misc.Text = "Misc"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label5)
        Me.groupBox3.Controls.Add(Me.websiteURL)
        Me.groupBox3.Controls.Add(Me.ReqsEditor)
        Me.groupBox3.Controls.Add(Me.SwearEditor)
        Me.groupBox3.Controls.Add(Me.MaxCapsValue)
        Me.groupBox3.Controls.Add(Me.MaxCaps)
        Me.groupBox3.Controls.Add(Me.SwearBox)
        Me.groupBox3.Controls.Add(Me.label3)
        Me.groupBox3.Location = New System.Drawing.Point(31, 199)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(595, 142)
        Me.groupBox3.TabIndex = 27
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Other Configurations"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(10, 73)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(76, 15)
        Me.label5.TabIndex = 28
        Me.label5.Text = "WebsiteURL"
        '
        'websiteURL
        '
        Me.websiteURL.Location = New System.Drawing.Point(110, 67)
        Me.websiteURL.Name = "websiteURL"
        Me.websiteURL.Size = New System.Drawing.Size(212, 21)
        Me.websiteURL.TabIndex = 28
        '
        'ReqsEditor
        '
        Me.ReqsEditor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ReqsEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ReqsEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ReqsEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReqsEditor.Location = New System.Drawing.Point(442, 94)
        Me.ReqsEditor.Name = "ReqsEditor"
        Me.ReqsEditor.Size = New System.Drawing.Size(125, 23)
        Me.ReqsEditor.TabIndex = 26
        Me.ReqsEditor.Text = "Edit Requirements"
        Me.ReqsEditor.UseVisualStyleBackColor = False
        '
        'SwearEditor
        '
        Me.SwearEditor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SwearEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.SwearEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SwearEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwearEditor.Location = New System.Drawing.Point(442, 65)
        Me.SwearEditor.Name = "SwearEditor"
        Me.SwearEditor.Size = New System.Drawing.Size(125, 23)
        Me.SwearEditor.TabIndex = 25
        Me.SwearEditor.Text = "Edit Profanity List"
        Me.SwearEditor.UseVisualStyleBackColor = False
        '
        'MaxCapsValue
        '
        Me.MaxCapsValue.Location = New System.Drawing.Point(110, 32)
        Me.MaxCapsValue.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.MaxCapsValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MaxCapsValue.Name = "MaxCapsValue"
        Me.MaxCapsValue.Size = New System.Drawing.Size(75, 21)
        Me.MaxCapsValue.TabIndex = 21
        Me.MaxCapsValue.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'MaxCaps
        '
        Me.MaxCaps.AutoSize = True
        Me.MaxCaps.Location = New System.Drawing.Point(10, 34)
        Me.MaxCaps.Name = "MaxCaps"
        Me.MaxCaps.Size = New System.Drawing.Size(94, 15)
        Me.MaxCaps.TabIndex = 20
        Me.MaxCaps.Text = "Maximum Caps"
        '
        'SwearBox
        '
        Me.SwearBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SwearBox.HideSelection = False
        Me.SwearBox.Location = New System.Drawing.Point(442, 34)
        Me.SwearBox.MaxLength = 64
        Me.SwearBox.Name = "SwearBox"
        Me.SwearBox.Size = New System.Drawing.Size(125, 21)
        Me.SwearBox.TabIndex = 22
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(229, 34)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(207, 15)
        Me.label3.TabIndex = 23
        Me.label3.Text = "Word for swears to be replaced with: "
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.CustomColor)
        Me.groupBox1.Controls.Add(Me.CustomText)
        Me.groupBox1.Controls.Add(Me.CustomName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.CustomAliases)
        Me.groupBox1.Location = New System.Drawing.Point(31, 27)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(595, 146)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Custom Chat Channel"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(224, 15)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Custom Chat Channel Command Name"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Cursor = System.Windows.Forms.Cursors.Help
        Me.label4.ForeColor = System.Drawing.Color.Red
        Me.label4.Location = New System.Drawing.Point(450, 17)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(139, 60)
        Me.label4.TabIndex = 25
        Me.label4.Text = "The name should be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in this format: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'staffchat'. No spaces or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "symbols (inclu" & _
    "ding ""/"")"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CustomColor
        '
        Me.CustomColor.BackColor = System.Drawing.Color.White
        Me.CustomColor.Location = New System.Drawing.Point(244, 62)
        Me.CustomColor.Name = "CustomColor"
        Me.CustomColor.Size = New System.Drawing.Size(100, 23)
        Me.CustomColor.TabIndex = 15
        Me.CustomColor.UseVisualStyleBackColor = False
        '
        'CustomText
        '
        Me.CustomText.AutoSize = True
        Me.CustomText.Location = New System.Drawing.Point(82, 70)
        Me.CustomText.Name = "CustomText"
        Me.CustomText.Size = New System.Drawing.Size(158, 15)
        Me.CustomText.TabIndex = 14
        Me.CustomText.Text = "Custom Chat Channel Color"
        '
        'CustomName
        '
        Me.CustomName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomName.HideSelection = False
        Me.CustomName.Location = New System.Drawing.Point(246, 20)
        Me.CustomName.MaxLength = 64
        Me.CustomName.Name = "CustomName"
        Me.CustomName.Size = New System.Drawing.Size(169, 21)
        Me.CustomName.TabIndex = 17
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(72, 115)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(168, 15)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Custom Chat Channel Aliases"
        '
        'CustomAliases
        '
        Me.CustomAliases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomAliases.HideSelection = False
        Me.CustomAliases.Location = New System.Drawing.Point(244, 109)
        Me.CustomAliases.MaxLength = 64
        Me.CustomAliases.Name = "CustomAliases"
        Me.CustomAliases.Size = New System.Drawing.Size(169, 21)
        Me.CustomAliases.TabIndex = 19
        '
        'lMaxUndoStates
        '
        Me.lMaxUndoStates.AutoSize = True
        Me.lMaxUndoStates.Location = New System.Drawing.Point(179, 73)
        Me.lMaxUndoStates.Name = "lMaxUndoStates"
        Me.lMaxUndoStates.Size = New System.Drawing.Size(72, 15)
        Me.lMaxUndoStates.TabIndex = 22
        Me.lMaxUndoStates.Text = "states, up to"
        '
        'bApply
        '
        Me.bApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bApply.BackColor = System.Drawing.Color.Black
        Me.bApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bApply.Location = New System.Drawing.Point(576, 530)
        Me.bApply.Name = "bApply"
        Me.bApply.Size = New System.Drawing.Size(100, 28)
        Me.bApply.TabIndex = 9
        Me.bApply.Text = "Apply"
        Me.bApply.UseVisualStyleBackColor = False
        '
        'bResetAll
        '
        Me.bResetAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bResetAll.BackColor = System.Drawing.Color.Gainsboro
        Me.bResetAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bResetAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bResetAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bResetAll.Location = New System.Drawing.Point(16, 530)
        Me.bResetAll.Name = "bResetAll"
        Me.bResetAll.Size = New System.Drawing.Size(114, 28)
        Me.bResetAll.TabIndex = 10
        Me.bResetAll.Text = "Reset All Defaults"
        Me.bResetAll.UseVisualStyleBackColor = False
        '
        'bResetTab
        '
        Me.bResetTab.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bResetTab.BackColor = System.Drawing.Color.Gainsboro
        Me.bResetTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bResetTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bResetTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bResetTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bResetTab.Location = New System.Drawing.Point(136, 530)
        Me.bResetTab.Name = "bResetTab"
        Me.bResetTab.Size = New System.Drawing.Size(100, 28)
        Me.bResetTab.TabIndex = 11
        Me.bResetTab.Text = "Reset Tab"
        Me.bResetTab.UseVisualStyleBackColor = False
        '
        'bCancel
        '
        Me.bCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancel.BackColor = System.Drawing.Color.Black
        Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bCancel.Location = New System.Drawing.Point(470, 530)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(100, 28)
        Me.bCancel.TabIndex = 8
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOK.BackColor = System.Drawing.Color.Black
        Me.bOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bOK.Location = New System.Drawing.Point(364, 530)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(100, 28)
        Me.bOK.TabIndex = 7
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = False
        '
        'xIP
        '
        Me.xIP.AutoSize = True
        Me.xIP.Location = New System.Drawing.Point(6, 109)
        Me.xIP.Name = "xIP"
        Me.xIP.Size = New System.Drawing.Size(103, 19)
        Me.xIP.TabIndex = 18
        Me.xIP.Text = "Designated IP"
        Me.xIP.UseVisualStyleBackColor = True
        '
        'tabAdvanced
        '
        Me.tabAdvanced.BackColor = System.Drawing.Color.Silver
        Me.tabAdvanced.Controls.Add(Me.gPerformance)
        Me.tabAdvanced.Controls.Add(Me.gAdvancedMisc)
        Me.tabAdvanced.Controls.Add(Me.gCrashReport)
        Me.tabAdvanced.Location = New System.Drawing.Point(4, 22)
        Me.tabAdvanced.Name = "tabAdvanced"
        Me.tabAdvanced.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabAdvanced.Size = New System.Drawing.Size(652, 484)
        Me.tabAdvanced.TabIndex = 6
        Me.tabAdvanced.Text = "Advanced"
        '
        'gPerformance
        '
        Me.gPerformance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gPerformance.Controls.Add(Me.lAdvancedWarning)
        Me.gPerformance.Controls.Add(Me.xLowLatencyMode)
        Me.gPerformance.Controls.Add(Me.lProcessPriority)
        Me.gPerformance.Controls.Add(Me.cProcessPriority)
        Me.gPerformance.Controls.Add(Me.nTickInterval)
        Me.gPerformance.Controls.Add(Me.lTickIntervalUnits)
        Me.gPerformance.Controls.Add(Me.lTickInterval)
        Me.gPerformance.Controls.Add(Me.nThrottling)
        Me.gPerformance.Controls.Add(Me.lThrottling)
        Me.gPerformance.Controls.Add(Me.lThrottlingUnits)
        Me.gPerformance.Location = New System.Drawing.Point(8, 318)
        Me.gPerformance.Name = "gPerformance"
        Me.gPerformance.Size = New System.Drawing.Size(636, 151)
        Me.gPerformance.TabIndex = 2
        Me.gPerformance.TabStop = False
        Me.gPerformance.Text = "Performance"
        '
        'lAdvancedWarning
        '
        Me.lAdvancedWarning.AutoSize = True
        Me.lAdvancedWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAdvancedWarning.Location = New System.Drawing.Point(15, 21)
        Me.lAdvancedWarning.Name = "lAdvancedWarning"
        Me.lAdvancedWarning.Size = New System.Drawing.Size(558, 30)
        Me.lAdvancedWarning.TabIndex = 0
        Me.lAdvancedWarning.Text = "Warning: Altering these settings may decrease your server's stability and perform" & _
    "ance." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you're not sure what these settings do, you probably shouldn't change " & _
    "them..."
        '
        'xLowLatencyMode
        '
        Me.xLowLatencyMode.AutoSize = True
        Me.xLowLatencyMode.Location = New System.Drawing.Point(6, 64)
        Me.xLowLatencyMode.Name = "xLowLatencyMode"
        Me.xLowLatencyMode.Size = New System.Drawing.Size(544, 19)
        Me.xLowLatencyMode.TabIndex = 3
        Me.xLowLatencyMode.Text = "Low-latency mode (disables Nagle's algorithm, reducing latency but increasing ban" & _
    "dwidth use)."
        Me.xLowLatencyMode.UseVisualStyleBackColor = True
        '
        'lProcessPriority
        '
        Me.lProcessPriority.AutoSize = True
        Me.lProcessPriority.Location = New System.Drawing.Point(19, 94)
        Me.lProcessPriority.Name = "lProcessPriority"
        Me.lProcessPriority.Size = New System.Drawing.Size(90, 15)
        Me.lProcessPriority.TabIndex = 10
        Me.lProcessPriority.Text = "Process priority"
        '
        'cProcessPriority
        '
        Me.cProcessPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cProcessPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cProcessPriority.Items.AddRange(New Object() {"(system default)", "High", "Above Normal", "Normal", "Below Normal", "Low"})
        Me.cProcessPriority.Location = New System.Drawing.Point(115, 91)
        Me.cProcessPriority.Name = "cProcessPriority"
        Me.cProcessPriority.Size = New System.Drawing.Size(109, 23)
        Me.cProcessPriority.TabIndex = 11
        '
        'nTickInterval
        '
        Me.nTickInterval.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nTickInterval.Location = New System.Drawing.Point(429, 92)
        Me.nTickInterval.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nTickInterval.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nTickInterval.Name = "nTickInterval"
        Me.nTickInterval.Size = New System.Drawing.Size(70, 21)
        Me.nTickInterval.TabIndex = 13
        Me.nTickInterval.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lTickIntervalUnits
        '
        Me.lTickIntervalUnits.AutoSize = True
        Me.lTickIntervalUnits.Location = New System.Drawing.Point(505, 94)
        Me.lTickIntervalUnits.Name = "lTickIntervalUnits"
        Me.lTickIntervalUnits.Size = New System.Drawing.Size(24, 15)
        Me.lTickIntervalUnits.TabIndex = 14
        Me.lTickIntervalUnits.Text = "ms"
        '
        'lTickInterval
        '
        Me.lTickInterval.AutoSize = True
        Me.lTickInterval.Location = New System.Drawing.Point(352, 94)
        Me.lTickInterval.Name = "lTickInterval"
        Me.lTickInterval.Size = New System.Drawing.Size(71, 15)
        Me.lTickInterval.TabIndex = 12
        Me.lTickInterval.Text = "Tick interval"
        '
        'nThrottling
        '
        Me.nThrottling.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nThrottling.Location = New System.Drawing.Point(115, 120)
        Me.nThrottling.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nThrottling.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nThrottling.Name = "nThrottling"
        Me.nThrottling.Size = New System.Drawing.Size(70, 21)
        Me.nThrottling.TabIndex = 16
        Me.nThrottling.Value = New Decimal(New Integer() {2048, 0, 0, 0})
        '
        'lThrottling
        '
        Me.lThrottling.AutoSize = True
        Me.lThrottling.Location = New System.Drawing.Point(22, 122)
        Me.lThrottling.Name = "lThrottling"
        Me.lThrottling.Size = New System.Drawing.Size(87, 15)
        Me.lThrottling.TabIndex = 15
        Me.lThrottling.Text = "Block throttling"
        '
        'lThrottlingUnits
        '
        Me.lThrottlingUnits.AutoSize = True
        Me.lThrottlingUnits.Location = New System.Drawing.Point(191, 122)
        Me.lThrottlingUnits.Name = "lThrottlingUnits"
        Me.lThrottlingUnits.Size = New System.Drawing.Size(129, 15)
        Me.lThrottlingUnits.TabIndex = 17
        Me.lThrottlingUnits.Text = "blocks / second / client"
        '
        'gAdvancedMisc
        '
        Me.gAdvancedMisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gAdvancedMisc.Controls.Add(Me.xAutoRank)
        Me.gAdvancedMisc.Controls.Add(Me.nMaxUndoStates)
        Me.gAdvancedMisc.Controls.Add(Me.lMaxUndoStates)
        Me.gAdvancedMisc.Controls.Add(Me.lIPWarning)
        Me.gAdvancedMisc.Controls.Add(Me.tIP)
        Me.gAdvancedMisc.Controls.Add(Me.xIP)
        Me.gAdvancedMisc.Controls.Add(Me.lConsoleName)
        Me.gAdvancedMisc.Controls.Add(Me.tConsoleName)
        Me.gAdvancedMisc.Controls.Add(Me.nMaxUndo)
        Me.gAdvancedMisc.Controls.Add(Me.lMaxUndoUnits)
        Me.gAdvancedMisc.Controls.Add(Me.xMaxUndo)
        Me.gAdvancedMisc.Controls.Add(Me.xRelayAllBlockUpdates)
        Me.gAdvancedMisc.Controls.Add(Me.xNoPartialPositionUpdates)
        Me.gAdvancedMisc.Location = New System.Drawing.Point(8, 99)
        Me.gAdvancedMisc.Name = "gAdvancedMisc"
        Me.gAdvancedMisc.Size = New System.Drawing.Size(636, 213)
        Me.gAdvancedMisc.TabIndex = 1
        Me.gAdvancedMisc.TabStop = False
        Me.gAdvancedMisc.Text = "Miscellaneous"
        '
        'lConsoleName
        '
        Me.lConsoleName.AutoSize = True
        Me.lConsoleName.Location = New System.Drawing.Point(6, 161)
        Me.lConsoleName.Name = "lConsoleName"
        Me.lConsoleName.Size = New System.Drawing.Size(87, 15)
        Me.lConsoleName.TabIndex = 7
        Me.lConsoleName.Text = "Console name"
        '
        'tConsoleName
        '
        Me.tConsoleName.Location = New System.Drawing.Point(115, 158)
        Me.tConsoleName.Name = "tConsoleName"
        Me.tConsoleName.Size = New System.Drawing.Size(167, 21)
        Me.tConsoleName.TabIndex = 8
        '
        'nMaxUndo
        '
        Me.nMaxUndo.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nMaxUndo.Location = New System.Drawing.Point(257, 71)
        Me.nMaxUndo.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nMaxUndo.Name = "nMaxUndo"
        Me.nMaxUndo.Size = New System.Drawing.Size(86, 21)
        Me.nMaxUndo.TabIndex = 5
        Me.nMaxUndo.Value = New Decimal(New Integer() {2000000, 0, 0, 0})
        '
        'lMaxUndoUnits
        '
        Me.lMaxUndoUnits.AutoSize = True
        Me.lMaxUndoUnits.Location = New System.Drawing.Point(349, 73)
        Me.lMaxUndoUnits.Name = "lMaxUndoUnits"
        Me.lMaxUndoUnits.Size = New System.Drawing.Size(259, 15)
        Me.lMaxUndoUnits.TabIndex = 6
        Me.lMaxUndoUnits.Text = "blocks each (up to 16.0 MB of RAM per player)"
        '
        'xMaxUndo
        '
        Me.xMaxUndo.AutoSize = True
        Me.xMaxUndo.Checked = True
        Me.xMaxUndo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xMaxUndo.Location = New System.Drawing.Point(6, 72)
        Me.xMaxUndo.Name = "xMaxUndo"
        Me.xMaxUndo.Size = New System.Drawing.Size(100, 19)
        Me.xMaxUndo.TabIndex = 4
        Me.xMaxUndo.Text = "Limit /undo to"
        Me.xMaxUndo.UseVisualStyleBackColor = True
        '
        'xRelayAllBlockUpdates
        '
        Me.xRelayAllBlockUpdates.AutoSize = True
        Me.xRelayAllBlockUpdates.Location = New System.Drawing.Point(6, 21)
        Me.xRelayAllBlockUpdates.Name = "xRelayAllBlockUpdates"
        Me.xRelayAllBlockUpdates.Size = New System.Drawing.Size(560, 19)
        Me.xRelayAllBlockUpdates.TabIndex = 1
        Me.xRelayAllBlockUpdates.Text = "When a player changes a block, send him the redundant update packet anyway (origi" & _
    "nal behavior)."
        Me.xRelayAllBlockUpdates.UseVisualStyleBackColor = True
        '
        'xNoPartialPositionUpdates
        '
        Me.xNoPartialPositionUpdates.AutoSize = True
        Me.xNoPartialPositionUpdates.Location = New System.Drawing.Point(6, 46)
        Me.xNoPartialPositionUpdates.Name = "xNoPartialPositionUpdates"
        Me.xNoPartialPositionUpdates.Size = New System.Drawing.Size(326, 19)
        Me.xNoPartialPositionUpdates.TabIndex = 2
        Me.xNoPartialPositionUpdates.Text = "Do not use partial position updates (opcodes 9, 10, 11)."
        Me.xNoPartialPositionUpdates.UseVisualStyleBackColor = True
        '
        'lAntispamInterval
        '
        Me.lAntispamInterval.AutoSize = True
        Me.lAntispamInterval.Location = New System.Drawing.Point(372, 27)
        Me.lAntispamInterval.Name = "lAntispamInterval"
        Me.lAntispamInterval.Size = New System.Drawing.Size(53, 15)
        Me.lAntispamInterval.TabIndex = 4
        Me.lAntispamInterval.Text = "seconds"
        '
        'lAnnouncementsUnits
        '
        Me.lAnnouncementsUnits.AutoSize = True
        Me.lAnnouncementsUnits.Location = New System.Drawing.Point(266, 27)
        Me.lAnnouncementsUnits.Name = "lAnnouncementsUnits"
        Me.lAnnouncementsUnits.Size = New System.Drawing.Size(28, 15)
        Me.lAnnouncementsUnits.TabIndex = 2
        Me.lAnnouncementsUnits.Text = "min"
        '
        'lColorMe
        '
        Me.lColorMe.AutoSize = True
        Me.lColorMe.Location = New System.Drawing.Point(402, 82)
        Me.lColorMe.Name = "lColorMe"
        Me.lColorMe.Size = New System.Drawing.Size(117, 15)
        Me.lColorMe.TabIndex = 12
        Me.lColorMe.Text = "/Me command color"
        '
        'bColorGlobal
        '
        Me.bColorGlobal.BackColor = System.Drawing.Color.White
        Me.bColorGlobal.Location = New System.Drawing.Point(525, 111)
        Me.bColorGlobal.Name = "bColorGlobal"
        Me.bColorGlobal.Size = New System.Drawing.Size(100, 23)
        Me.bColorGlobal.TabIndex = 13
        Me.bColorGlobal.UseVisualStyleBackColor = False
        '
        'bColorMe
        '
        Me.bColorMe.BackColor = System.Drawing.Color.White
        Me.bColorMe.Location = New System.Drawing.Point(525, 78)
        Me.bColorMe.Name = "bColorMe"
        Me.bColorMe.Size = New System.Drawing.Size(100, 23)
        Me.bColorMe.TabIndex = 13
        Me.bColorMe.UseVisualStyleBackColor = False
        '
        'gChatColors
        '
        Me.gChatColors.BackColor = System.Drawing.Color.Silver
        Me.gChatColors.Controls.Add(Me.lColorMe)
        Me.gChatColors.Controls.Add(Me.bColorGlobal)
        Me.gChatColors.Controls.Add(Me.bColorMe)
        Me.gChatColors.Controls.Add(Me.lColorWarning)
        Me.gChatColors.Controls.Add(Me.bColorWarning)
        Me.gChatColors.Controls.Add(Me.bColorSys)
        Me.gChatColors.Controls.Add(Me.lColorSys)
        Me.gChatColors.Controls.Add(Me.bColorPM)
        Me.gChatColors.Controls.Add(Me.lColorHelp)
        Me.gChatColors.Controls.Add(Me.lColorPM)
        Me.gChatColors.Controls.Add(Me.IColorGlobal)
        Me.gChatColors.Controls.Add(Me.lColorSay)
        Me.gChatColors.Controls.Add(Me.bColorAnnouncement)
        Me.gChatColors.Controls.Add(Me.lColorAnnouncement)
        Me.gChatColors.Controls.Add(Me.bColorHelp)
        Me.gChatColors.Controls.Add(Me.bColorSay)
        Me.gChatColors.Location = New System.Drawing.Point(8, 8)
        Me.gChatColors.Name = "gChatColors"
        Me.gChatColors.Size = New System.Drawing.Size(636, 139)
        Me.gChatColors.TabIndex = 0
        Me.gChatColors.TabStop = False
        Me.gChatColors.Text = "Colors"
        '
        'lColorWarning
        '
        Me.lColorWarning.AutoSize = True
        Me.lColorWarning.Location = New System.Drawing.Point(69, 53)
        Me.lColorWarning.Name = "lColorWarning"
        Me.lColorWarning.Size = New System.Drawing.Size(118, 15)
        Me.lColorWarning.TabIndex = 2
        Me.lColorWarning.Text = "Warning / error color"
        '
        'bColorWarning
        '
        Me.bColorWarning.BackColor = System.Drawing.Color.White
        Me.bColorWarning.Location = New System.Drawing.Point(193, 49)
        Me.bColorWarning.Name = "bColorWarning"
        Me.bColorWarning.Size = New System.Drawing.Size(100, 23)
        Me.bColorWarning.TabIndex = 3
        Me.bColorWarning.UseVisualStyleBackColor = False
        '
        'bColorSys
        '
        Me.bColorSys.BackColor = System.Drawing.Color.White
        Me.bColorSys.Location = New System.Drawing.Point(193, 20)
        Me.bColorSys.Name = "bColorSys"
        Me.bColorSys.Size = New System.Drawing.Size(100, 23)
        Me.bColorSys.TabIndex = 1
        Me.bColorSys.UseVisualStyleBackColor = False
        '
        'lColorSys
        '
        Me.lColorSys.AutoSize = True
        Me.lColorSys.Location = New System.Drawing.Point(56, 24)
        Me.lColorSys.Name = "lColorSys"
        Me.lColorSys.Size = New System.Drawing.Size(131, 15)
        Me.lColorSys.TabIndex = 0
        Me.lColorSys.Text = "System message color"
        '
        'bColorPM
        '
        Me.bColorPM.BackColor = System.Drawing.Color.White
        Me.bColorPM.Location = New System.Drawing.Point(193, 78)
        Me.bColorPM.Name = "bColorPM"
        Me.bColorPM.Size = New System.Drawing.Size(100, 23)
        Me.bColorPM.TabIndex = 5
        Me.bColorPM.UseVisualStyleBackColor = False
        '
        'lColorHelp
        '
        Me.lColorHelp.AutoSize = True
        Me.lColorHelp.Location = New System.Drawing.Point(70, 111)
        Me.lColorHelp.Name = "lColorHelp"
        Me.lColorHelp.Size = New System.Drawing.Size(117, 15)
        Me.lColorHelp.TabIndex = 6
        Me.lColorHelp.Text = "Help message color"
        '
        'lColorPM
        '
        Me.lColorPM.AutoSize = True
        Me.lColorPM.Location = New System.Drawing.Point(26, 82)
        Me.lColorPM.Name = "lColorPM"
        Me.lColorPM.Size = New System.Drawing.Size(161, 15)
        Me.lColorPM.TabIndex = 4
        Me.lColorPM.Text = "Private / rank message color"
        '
        'IColorGlobal
        '
        Me.IColorGlobal.AutoSize = True
        Me.IColorGlobal.Location = New System.Drawing.Point(402, 111)
        Me.IColorGlobal.Name = "IColorGlobal"
        Me.IColorGlobal.Size = New System.Drawing.Size(103, 15)
        Me.IColorGlobal.TabIndex = 10
        Me.IColorGlobal.Text = "Global Chat Color"
        '
        'lColorSay
        '
        Me.lColorSay.AutoSize = True
        Me.lColorSay.Location = New System.Drawing.Point(407, 53)
        Me.lColorSay.Name = "lColorSay"
        Me.lColorSay.Size = New System.Drawing.Size(114, 15)
        Me.lColorSay.TabIndex = 10
        Me.lColorSay.Text = "/Say message color"
        '
        'bColorAnnouncement
        '
        Me.bColorAnnouncement.BackColor = System.Drawing.Color.White
        Me.bColorAnnouncement.Location = New System.Drawing.Point(525, 20)
        Me.bColorAnnouncement.Name = "bColorAnnouncement"
        Me.bColorAnnouncement.Size = New System.Drawing.Size(100, 23)
        Me.bColorAnnouncement.TabIndex = 9
        Me.bColorAnnouncement.UseVisualStyleBackColor = False
        '
        'lColorAnnouncement
        '
        Me.lColorAnnouncement.AutoSize = True
        Me.lColorAnnouncement.Location = New System.Drawing.Point(342, 24)
        Me.lColorAnnouncement.Name = "lColorAnnouncement"
        Me.lColorAnnouncement.Size = New System.Drawing.Size(182, 15)
        Me.lColorAnnouncement.TabIndex = 8
        Me.lColorAnnouncement.Text = "Announcement and /Rules color"
        '
        'bColorHelp
        '
        Me.bColorHelp.BackColor = System.Drawing.Color.White
        Me.bColorHelp.Location = New System.Drawing.Point(193, 107)
        Me.bColorHelp.Name = "bColorHelp"
        Me.bColorHelp.Size = New System.Drawing.Size(100, 23)
        Me.bColorHelp.TabIndex = 7
        Me.bColorHelp.UseVisualStyleBackColor = False
        '
        'bColorSay
        '
        Me.bColorSay.BackColor = System.Drawing.Color.White
        Me.bColorSay.Location = New System.Drawing.Point(525, 49)
        Me.bColorSay.Name = "bColorSay"
        Me.bColorSay.Size = New System.Drawing.Size(100, 23)
        Me.bColorSay.TabIndex = 11
        Me.bColorSay.UseVisualStyleBackColor = False
        '
        'xShowConnectionMessages
        '
        Me.xShowConnectionMessages.AutoSize = True
        Me.xShowConnectionMessages.Location = New System.Drawing.Point(325, 45)
        Me.xShowConnectionMessages.Name = "xShowConnectionMessages"
        Me.xShowConnectionMessages.Size = New System.Drawing.Size(306, 19)
        Me.xShowConnectionMessages.TabIndex = 4
        Me.xShowConnectionMessages.Text = "Show a message when players join/leave SERVER."
        Me.xShowConnectionMessages.UseVisualStyleBackColor = True
        '
        'xShowJoinedWorldMessages
        '
        Me.xShowJoinedWorldMessages.AutoSize = True
        Me.xShowJoinedWorldMessages.Location = New System.Drawing.Point(325, 20)
        Me.xShowJoinedWorldMessages.Name = "xShowJoinedWorldMessages"
        Me.xShowJoinedWorldMessages.Size = New System.Drawing.Size(261, 19)
        Me.xShowJoinedWorldMessages.TabIndex = 3
        Me.xShowJoinedWorldMessages.Text = "Show a message when players join worlds."
        Me.xShowJoinedWorldMessages.UseVisualStyleBackColor = True
        '
        'xRankColorsInWorldNames
        '
        Me.xRankColorsInWorldNames.AutoSize = True
        Me.xRankColorsInWorldNames.Location = New System.Drawing.Point(325, 70)
        Me.xRankColorsInWorldNames.Name = "xRankColorsInWorldNames"
        Me.xRankColorsInWorldNames.Size = New System.Drawing.Size(243, 19)
        Me.xRankColorsInWorldNames.TabIndex = 5
        Me.xRankColorsInWorldNames.Text = "Color world names based on build rank."
        Me.xRankColorsInWorldNames.UseVisualStyleBackColor = True
        '
        'xRankPrefixesInList
        '
        Me.xRankPrefixesInList.AutoSize = True
        Me.xRankPrefixesInList.Location = New System.Drawing.Point(44, 70)
        Me.xRankPrefixesInList.Name = "xRankPrefixesInList"
        Me.xRankPrefixesInList.Size = New System.Drawing.Size(219, 19)
        Me.xRankPrefixesInList.TabIndex = 2
        Me.xRankPrefixesInList.Text = "Prefixes in player list (breaks skins)."
        Me.xRankPrefixesInList.UseVisualStyleBackColor = True
        '
        'xRankPrefixesInChat
        '
        Me.xRankPrefixesInChat.AutoSize = True
        Me.xRankPrefixesInChat.Location = New System.Drawing.Point(25, 45)
        Me.xRankPrefixesInChat.Name = "xRankPrefixesInChat"
        Me.xRankPrefixesInChat.Size = New System.Drawing.Size(133, 19)
        Me.xRankPrefixesInChat.TabIndex = 1
        Me.xRankPrefixesInChat.Text = "Show rank prefixes."
        Me.xRankPrefixesInChat.UseVisualStyleBackColor = True
        '
        'xRankColorsInChat
        '
        Me.xRankColorsInChat.AutoSize = True
        Me.xRankColorsInChat.Location = New System.Drawing.Point(25, 20)
        Me.xRankColorsInChat.Name = "xRankColorsInChat"
        Me.xRankColorsInChat.Size = New System.Drawing.Size(123, 19)
        Me.xRankColorsInChat.TabIndex = 0
        Me.xRankColorsInChat.Text = "Show rank colors."
        Me.xRankColorsInChat.UseVisualStyleBackColor = True
        '
        'gAppearence
        '
        Me.gAppearence.Controls.Add(Me.xShowConnectionMessages)
        Me.gAppearence.Controls.Add(Me.xShowJoinedWorldMessages)
        Me.gAppearence.Controls.Add(Me.xRankColorsInWorldNames)
        Me.gAppearence.Controls.Add(Me.xRankPrefixesInList)
        Me.gAppearence.Controls.Add(Me.xRankPrefixesInChat)
        Me.gAppearence.Controls.Add(Me.xRankColorsInChat)
        Me.gAppearence.Location = New System.Drawing.Point(7, 153)
        Me.gAppearence.Name = "gAppearence"
        Me.gAppearence.Size = New System.Drawing.Size(637, 97)
        Me.gAppearence.TabIndex = 1
        Me.gAppearence.TabStop = False
        Me.gAppearence.Text = "Appearence Tweaks"
        '
        'tabChat
        '
        Me.tabChat.BackColor = System.Drawing.Color.Silver
        Me.tabChat.Controls.Add(Me.gAppearence)
        Me.tabChat.Controls.Add(Me.gChatColors)
        Me.tabChat.Location = New System.Drawing.Point(4, 22)
        Me.tabChat.Name = "tabChat"
        Me.tabChat.Padding = New System.Windows.Forms.Padding(5, 5, 5, 10)
        Me.tabChat.Size = New System.Drawing.Size(652, 484)
        Me.tabChat.TabIndex = 10
        Me.tabChat.Text = "Chat"
        '
        'bGreeting
        '
        Me.bGreeting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGreeting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bGreeting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bGreeting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bGreeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGreeting.Location = New System.Drawing.Point(538, 20)
        Me.bGreeting.Name = "bGreeting"
        Me.bGreeting.Size = New System.Drawing.Size(92, 28)
        Me.bGreeting.TabIndex = 5
        Me.bGreeting.Text = "Edit Greeting"
        Me.bGreeting.UseVisualStyleBackColor = False
        '
        'nAnnouncements
        '
        Me.nAnnouncements.Enabled = False
        Me.nAnnouncements.Location = New System.Drawing.Point(210, 25)
        Me.nAnnouncements.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nAnnouncements.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nAnnouncements.Name = "nAnnouncements"
        Me.nAnnouncements.Size = New System.Drawing.Size(50, 21)
        Me.nAnnouncements.TabIndex = 1
        Me.nAnnouncements.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'xWoMEnableEnvExtensions
        '
        Me.xWoMEnableEnvExtensions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xWoMEnableEnvExtensions.AutoSize = True
        Me.xWoMEnableEnvExtensions.Location = New System.Drawing.Point(8, 436)
        Me.xWoMEnableEnvExtensions.Name = "xWoMEnableEnvExtensions"
        Me.xWoMEnableEnvExtensions.Size = New System.Drawing.Size(251, 19)
        Me.xWoMEnableEnvExtensions.TabIndex = 22
        Me.xWoMEnableEnvExtensions.Text = "Enable Env Extensions (/MapEdit or /Env)"
        Me.xWoMEnableEnvExtensions.UseVisualStyleBackColor = True
        '
        'bMapPath
        '
        Me.bMapPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMapPath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bMapPath.Enabled = False
        Me.bMapPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bMapPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bMapPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMapPath.Location = New System.Drawing.Point(587, 409)
        Me.bMapPath.Name = "bMapPath"
        Me.bMapPath.Size = New System.Drawing.Size(62, 23)
        Me.bMapPath.TabIndex = 10
        Me.bMapPath.Text = "Browse"
        Me.bMapPath.UseVisualStyleBackColor = False
        '
        'xMapPath
        '
        Me.xMapPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xMapPath.AutoSize = True
        Me.xMapPath.Location = New System.Drawing.Point(8, 409)
        Me.xMapPath.Name = "xMapPath"
        Me.xMapPath.Size = New System.Drawing.Size(189, 19)
        Me.xMapPath.TabIndex = 8
        Me.xMapPath.Text = "Custom path for storing maps:"
        Me.xMapPath.UseVisualStyleBackColor = True
        '
        'tMapPath
        '
        Me.tMapPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tMapPath.Enabled = False
        Me.tMapPath.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMapPath.Location = New System.Drawing.Point(203, 411)
        Me.tMapPath.Name = "tMapPath"
        Me.tMapPath.Size = New System.Drawing.Size(378, 19)
        Me.tMapPath.TabIndex = 9
        '
        'cDefaultBuildRank
        '
        Me.cDefaultBuildRank.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cDefaultBuildRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDefaultBuildRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cDefaultBuildRank.FormattingEnabled = True
        Me.cDefaultBuildRank.Location = New System.Drawing.Point(372, 378)
        Me.cDefaultBuildRank.Name = "cDefaultBuildRank"
        Me.cDefaultBuildRank.Size = New System.Drawing.Size(121, 23)
        Me.cDefaultBuildRank.TabIndex = 7
        '
        'tabWorlds
        '
        Me.tabWorlds.BackColor = System.Drawing.Color.Silver
        Me.tabWorlds.Controls.Add(Me.xWoMEnableEnvExtensions)
        Me.tabWorlds.Controls.Add(Me.bMapPath)
        Me.tabWorlds.Controls.Add(Me.xMapPath)
        Me.tabWorlds.Controls.Add(Me.tMapPath)
        Me.tabWorlds.Controls.Add(Me.lDefaultBuildRank)
        Me.tabWorlds.Controls.Add(Me.cDefaultBuildRank)
        Me.tabWorlds.Controls.Add(Me.cMainWorld)
        Me.tabWorlds.Controls.Add(Me.lMainWorld)
        Me.tabWorlds.Controls.Add(Me.bWorldEdit)
        Me.tabWorlds.Controls.Add(Me.bAddWorld)
        Me.tabWorlds.Controls.Add(Me.bWorldDelete)
        Me.tabWorlds.Controls.Add(Me.dgvWorlds)
        Me.tabWorlds.Location = New System.Drawing.Point(4, 22)
        Me.tabWorlds.Name = "tabWorlds"
        Me.tabWorlds.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabWorlds.Size = New System.Drawing.Size(652, 484)
        Me.tabWorlds.TabIndex = 9
        Me.tabWorlds.Text = "Worlds"
        '
        'lDefaultBuildRank
        '
        Me.lDefaultBuildRank.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lDefaultBuildRank.AutoSize = True
        Me.lDefaultBuildRank.Location = New System.Drawing.Point(24, 381)
        Me.lDefaultBuildRank.Name = "lDefaultBuildRank"
        Me.lDefaultBuildRank.Size = New System.Drawing.Size(342, 15)
        Me.lDefaultBuildRank.TabIndex = 6
        Me.lDefaultBuildRank.Text = "Default rank requirement for building on newly-loaded worlds:"
        '
        'cMainWorld
        '
        Me.cMainWorld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cMainWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMainWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cMainWorld.Location = New System.Drawing.Point(542, 17)
        Me.cMainWorld.Name = "cMainWorld"
        Me.cMainWorld.Size = New System.Drawing.Size(102, 23)
        Me.cMainWorld.TabIndex = 5
        '
        'lMainWorld
        '
        Me.lMainWorld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lMainWorld.AutoSize = True
        Me.lMainWorld.Location = New System.Drawing.Point(465, 20)
        Me.lMainWorld.Name = "lMainWorld"
        Me.lMainWorld.Size = New System.Drawing.Size(71, 15)
        Me.lMainWorld.TabIndex = 4
        Me.lMainWorld.Text = "Main world:"
        '
        'bWorldEdit
        '
        Me.bWorldEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bWorldEdit.Enabled = False
        Me.bWorldEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bWorldEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bWorldEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bWorldEdit.Location = New System.Drawing.Point(114, 13)
        Me.bWorldEdit.Name = "bWorldEdit"
        Me.bWorldEdit.Size = New System.Drawing.Size(100, 28)
        Me.bWorldEdit.TabIndex = 2
        Me.bWorldEdit.Text = "Edit"
        Me.bWorldEdit.UseVisualStyleBackColor = False
        '
        'bAddWorld
        '
        Me.bAddWorld.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bAddWorld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bAddWorld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bAddWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddWorld.Location = New System.Drawing.Point(8, 13)
        Me.bAddWorld.Name = "bAddWorld"
        Me.bAddWorld.Size = New System.Drawing.Size(100, 28)
        Me.bAddWorld.TabIndex = 1
        Me.bAddWorld.Text = "Add World"
        Me.bAddWorld.UseVisualStyleBackColor = False
        '
        'bWorldDelete
        '
        Me.bWorldDelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bWorldDelete.Enabled = False
        Me.bWorldDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bWorldDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bWorldDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bWorldDelete.Location = New System.Drawing.Point(220, 13)
        Me.bWorldDelete.Name = "bWorldDelete"
        Me.bWorldDelete.Size = New System.Drawing.Size(100, 28)
        Me.bWorldDelete.TabIndex = 3
        Me.bWorldDelete.Text = "Delete World"
        Me.bWorldDelete.UseVisualStyleBackColor = False
        '
        'dgvWorlds
        '
        Me.dgvWorlds.AllowUserToAddRows = False
        Me.dgvWorlds.AllowUserToDeleteRows = False
        Me.dgvWorlds.AllowUserToOrderColumns = True
        Me.dgvWorlds.AllowUserToResizeRows = False
        Me.dgvWorlds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWorlds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorlds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcName, Me.dgvcDescription, Me.dgvcAccess, Me.dgvcBuild, Me.dgvcBackup, Me.dgvcHidden, Me.dgvcBlockDB})
        Me.dgvWorlds.Location = New System.Drawing.Point(8, 47)
        Me.dgvWorlds.MultiSelect = False
        Me.dgvWorlds.Name = "dgvWorlds"
        Me.dgvWorlds.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvWorlds.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvWorlds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWorlds.Size = New System.Drawing.Size(636, 325)
        Me.dgvWorlds.TabIndex = 0
        '
        'dgvcName
        '
        Me.dgvcName.DataPropertyName = "Name"
        Me.dgvcName.HeaderText = "World Name"
        Me.dgvcName.Name = "dgvcName"
        Me.dgvcName.Width = 110
        '
        'dgvcDescription
        '
        Me.dgvcDescription.DataPropertyName = "Description"
        Me.dgvcDescription.HeaderText = ""
        Me.dgvcDescription.Name = "dgvcDescription"
        Me.dgvcDescription.ReadOnly = True
        Me.dgvcDescription.Width = 130
        '
        'dgvcAccess
        '
        Me.dgvcAccess.DataPropertyName = "AccessPermission"
        Me.dgvcAccess.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.dgvcAccess.HeaderText = "Access"
        Me.dgvcAccess.Name = "dgvcAccess"
        Me.dgvcAccess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgvcBuild
        '
        Me.dgvcBuild.DataPropertyName = "BuildPermission"
        Me.dgvcBuild.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.dgvcBuild.HeaderText = "Build"
        Me.dgvcBuild.Name = "dgvcBuild"
        Me.dgvcBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgvcBackup
        '
        Me.dgvcBackup.DataPropertyName = "Backup"
        Me.dgvcBackup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.dgvcBackup.HeaderText = "Backup"
        Me.dgvcBackup.Name = "dgvcBackup"
        Me.dgvcBackup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcBackup.Width = 90
        '
        'dgvcHidden
        '
        Me.dgvcHidden.DataPropertyName = "Hidden"
        Me.dgvcHidden.HeaderText = "Hide"
        Me.dgvcHidden.Name = "dgvcHidden"
        Me.dgvcHidden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcHidden.Width = 40
        '
        'dgvcBlockDB
        '
        Me.dgvcBlockDB.DataPropertyName = "BlockDBEnabled"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcBlockDB.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcBlockDB.HeaderText = "BlockDB"
        Me.dgvcBlockDB.Name = "dgvcBlockDB"
        Me.dgvcBlockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcBlockDB.ThreeState = True
        Me.dgvcBlockDB.Width = 60
        '
        'xAnnouncements
        '
        Me.xAnnouncements.AutoSize = True
        Me.xAnnouncements.BackColor = System.Drawing.Color.Firebrick
        Me.xAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xAnnouncements.Location = New System.Drawing.Point(24, 26)
        Me.xAnnouncements.Name = "xAnnouncements"
        Me.xAnnouncements.Size = New System.Drawing.Size(186, 20)
        Me.xAnnouncements.TabIndex = 0
        Me.xAnnouncements.Text = "Show announcements every"
        Me.xAnnouncements.UseVisualStyleBackColor = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(10, 160)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(112, 15)
        Me.label6.TabIndex = 20
        Me.label6.Text = "HeartBeat Location"
        '
        'HeartBeatUrlComboBox
        '
        Me.HeartBeatUrlComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HeartBeatUrlComboBox.FormattingEnabled = True
        Me.HeartBeatUrlComboBox.Items.AddRange(New Object() {"Minecraft.net", "ClassiCube.net"})
        Me.HeartBeatUrlComboBox.Location = New System.Drawing.Point(123, 157)
        Me.HeartBeatUrlComboBox.Name = "HeartBeatUrlComboBox"
        Me.HeartBeatUrlComboBox.Size = New System.Drawing.Size(194, 23)
        Me.HeartBeatUrlComboBox.TabIndex = 19
        '
        'nMaxPlayersPerWorld
        '
        Me.nMaxPlayersPerWorld.Location = New System.Drawing.Point(440, 74)
        Me.nMaxPlayersPerWorld.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.nMaxPlayersPerWorld.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nMaxPlayersPerWorld.Name = "nMaxPlayersPerWorld"
        Me.nMaxPlayersPerWorld.Size = New System.Drawing.Size(75, 21)
        Me.nMaxPlayersPerWorld.TabIndex = 12
        Me.nMaxPlayersPerWorld.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lMaxPlayersPerWorld
        '
        Me.lMaxPlayersPerWorld.AutoSize = True
        Me.lMaxPlayersPerWorld.Location = New System.Drawing.Point(299, 76)
        Me.lMaxPlayersPerWorld.Name = "lMaxPlayersPerWorld"
        Me.lMaxPlayersPerWorld.Size = New System.Drawing.Size(135, 15)
        Me.lMaxPlayersPerWorld.TabIndex = 11
        Me.lMaxPlayersPerWorld.Text = "Max players (per world)"
        '
        'lPort
        '
        Me.lPort.AutoSize = True
        Me.lPort.Location = New System.Drawing.Point(42, 103)
        Me.lPort.Name = "lPort"
        Me.lPort.Size = New System.Drawing.Size(75, 15)
        Me.lPort.TabIndex = 6
        Me.lPort.Text = "Port number"
        '
        'nPort
        '
        Me.nPort.Location = New System.Drawing.Point(123, 101)
        Me.nPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nPort.Name = "nPort"
        Me.nPort.Size = New System.Drawing.Size(75, 21)
        Me.nPort.TabIndex = 7
        Me.nPort.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.Silver
        Me.tabGeneral.Controls.Add(Me.gBasic)
        Me.tabGeneral.Controls.Add(Me.groupBox4)
        Me.tabGeneral.Controls.Add(Me.pictureBox1)
        Me.tabGeneral.Controls.Add(Me.groupBox2)
        Me.tabGeneral.Controls.Add(Me.gInformation)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabGeneral.Size = New System.Drawing.Size(652, 484)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'gBasic
        '
        Me.gBasic.Controls.Add(Me.label6)
        Me.gBasic.Controls.Add(Me.HeartBeatUrlComboBox)
        Me.gBasic.Controls.Add(Me.nMaxPlayersPerWorld)
        Me.gBasic.Controls.Add(Me.lMaxPlayersPerWorld)
        Me.gBasic.Controls.Add(Me.lPort)
        Me.gBasic.Controls.Add(Me.nPort)
        Me.gBasic.Controls.Add(Me.cDefaultRank)
        Me.gBasic.Controls.Add(Me.lDefaultRank)
        Me.gBasic.Controls.Add(Me.lUploadBandwidth)
        Me.gBasic.Controls.Add(Me.bMeasure)
        Me.gBasic.Controls.Add(Me.tServerName)
        Me.gBasic.Controls.Add(Me.lUploadBandwidthUnits)
        Me.gBasic.Controls.Add(Me.lServerName)
        Me.gBasic.Controls.Add(Me.nUploadBandwidth)
        Me.gBasic.Controls.Add(Me.tMOTD)
        Me.gBasic.Controls.Add(Me.lMOTD)
        Me.gBasic.Controls.Add(Me.cPublic)
        Me.gBasic.Controls.Add(Me.nMaxPlayers)
        Me.gBasic.Controls.Add(Me.lPublic)
        Me.gBasic.Controls.Add(Me.lMaxPlayers)
        Me.gBasic.Location = New System.Drawing.Point(8, 13)
        Me.gBasic.Name = "gBasic"
        Me.gBasic.Size = New System.Drawing.Size(636, 190)
        Me.gBasic.TabIndex = 0
        Me.gBasic.TabStop = False
        Me.gBasic.Text = "Basic Settings"
        '
        'cDefaultRank
        '
        Me.cDefaultRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDefaultRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cDefaultRank.FormattingEnabled = True
        Me.cDefaultRank.Location = New System.Drawing.Point(440, 128)
        Me.cDefaultRank.Name = "cDefaultRank"
        Me.cDefaultRank.Size = New System.Drawing.Size(170, 23)
        Me.cDefaultRank.TabIndex = 18
        '
        'lDefaultRank
        '
        Me.lDefaultRank.AutoSize = True
        Me.lDefaultRank.Location = New System.Drawing.Point(361, 131)
        Me.lDefaultRank.Name = "lDefaultRank"
        Me.lDefaultRank.Size = New System.Drawing.Size(73, 15)
        Me.lDefaultRank.TabIndex = 17
        Me.lDefaultRank.Text = "Default rank"
        '
        'lUploadBandwidth
        '
        Me.lUploadBandwidth.AutoSize = True
        Me.lUploadBandwidth.Location = New System.Drawing.Point(327, 103)
        Me.lUploadBandwidth.Name = "lUploadBandwidth"
        Me.lUploadBandwidth.Size = New System.Drawing.Size(107, 15)
        Me.lUploadBandwidth.TabIndex = 13
        Me.lUploadBandwidth.Text = "Upload bandwidth"
        '
        'bMeasure
        '
        Me.bMeasure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bMeasure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bMeasure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMeasure.Location = New System.Drawing.Point(559, 99)
        Me.bMeasure.Name = "bMeasure"
        Me.bMeasure.Size = New System.Drawing.Size(71, 23)
        Me.bMeasure.TabIndex = 16
        Me.bMeasure.Text = "Measure"
        Me.bMeasure.UseVisualStyleBackColor = False
        '
        'tServerName
        '
        Me.tServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tServerName.HideSelection = False
        Me.tServerName.Location = New System.Drawing.Point(123, 20)
        Me.tServerName.MaxLength = 64
        Me.tServerName.Name = "tServerName"
        Me.tServerName.Size = New System.Drawing.Size(507, 21)
        Me.tServerName.TabIndex = 1
        '
        'lUploadBandwidthUnits
        '
        Me.lUploadBandwidthUnits.AutoSize = True
        Me.lUploadBandwidthUnits.Location = New System.Drawing.Point(521, 103)
        Me.lUploadBandwidthUnits.Name = "lUploadBandwidthUnits"
        Me.lUploadBandwidthUnits.Size = New System.Drawing.Size(32, 15)
        Me.lUploadBandwidthUnits.TabIndex = 15
        Me.lUploadBandwidthUnits.Text = "KB/s"
        '
        'lServerName
        '
        Me.lServerName.AutoSize = True
        Me.lServerName.Location = New System.Drawing.Point(40, 23)
        Me.lServerName.Name = "lServerName"
        Me.lServerName.Size = New System.Drawing.Size(77, 15)
        Me.lServerName.TabIndex = 0
        Me.lServerName.Text = "Server name"
        '
        'nUploadBandwidth
        '
        Me.nUploadBandwidth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nUploadBandwidth.Location = New System.Drawing.Point(440, 101)
        Me.nUploadBandwidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nUploadBandwidth.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nUploadBandwidth.Name = "nUploadBandwidth"
        Me.nUploadBandwidth.Size = New System.Drawing.Size(75, 21)
        Me.nUploadBandwidth.TabIndex = 14
        Me.nUploadBandwidth.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'tMOTD
        '
        Me.tMOTD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tMOTD.Location = New System.Drawing.Point(123, 47)
        Me.tMOTD.MaxLength = 64
        Me.tMOTD.Name = "tMOTD"
        Me.tMOTD.Size = New System.Drawing.Size(507, 21)
        Me.tMOTD.TabIndex = 3
        '
        'lMOTD
        '
        Me.lMOTD.AutoSize = True
        Me.lMOTD.Location = New System.Drawing.Point(74, 50)
        Me.lMOTD.Name = "lMOTD"
        Me.lMOTD.Size = New System.Drawing.Size(43, 15)
        Me.lMOTD.TabIndex = 2
        Me.lMOTD.Text = "MOTD"
        '
        'cPublic
        '
        Me.cPublic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPublic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cPublic.FormattingEnabled = True
        Me.cPublic.Items.AddRange(New Object() {"Public", "Private"})
        Me.cPublic.Location = New System.Drawing.Point(123, 128)
        Me.cPublic.Name = "cPublic"
        Me.cPublic.Size = New System.Drawing.Size(75, 23)
        Me.cPublic.TabIndex = 10
        '
        'nMaxPlayers
        '
        Me.nMaxPlayers.Location = New System.Drawing.Point(123, 74)
        Me.nMaxPlayers.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nMaxPlayers.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nMaxPlayers.Name = "nMaxPlayers"
        Me.nMaxPlayers.Size = New System.Drawing.Size(75, 21)
        Me.nMaxPlayers.TabIndex = 5
        Me.nMaxPlayers.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lPublic
        '
        Me.lPublic.AutoSize = True
        Me.lPublic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPublic.Location = New System.Drawing.Point(14, 131)
        Me.lPublic.Name = "lPublic"
        Me.lPublic.Size = New System.Drawing.Size(103, 15)
        Me.lPublic.TabIndex = 9
        Me.lPublic.Text = "Server visibility"
        '
        'lMaxPlayers
        '
        Me.lMaxPlayers.AutoSize = True
        Me.lMaxPlayers.Location = New System.Drawing.Point(10, 76)
        Me.lMaxPlayers.Name = "lMaxPlayers"
        Me.lMaxPlayers.Size = New System.Drawing.Size(107, 15)
        Me.lMaxPlayers.TabIndex = 4
        Me.lMaxPlayers.Text = "Max players (total)"
        '
        'groupBox4
        '
        Me.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.groupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.bWiki)
        Me.groupBox4.Controls.Add(Me.bWeb)
        Me.groupBox4.Location = New System.Drawing.Point(468, 306)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(126, 94)
        Me.groupBox4.TabIndex = 5
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Contact Us"
        '
        'bWiki
        '
        Me.bWiki.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bWiki.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bWiki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bWiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bWiki.Location = New System.Drawing.Point(7, 60)
        Me.bWiki.Name = "bWiki"
        Me.bWiki.Size = New System.Drawing.Size(111, 23)
        Me.bWiki.TabIndex = 1
        Me.bWiki.Text = "Wiki"
        Me.bWiki.UseVisualStyleBackColor = False
        '
        'bWeb
        '
        Me.bWeb.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bWeb.Location = New System.Drawing.Point(8, 31)
        Me.bWeb.Name = "bWeb"
        Me.bWeb.Size = New System.Drawing.Size(110, 23)
        Me.bWeb.TabIndex = 1
        Me.bWeb.Text = "Website"
        Me.bWeb.UseVisualStyleBackColor = False
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.bChangelog)
        Me.groupBox2.Controls.Add(Me.bCredits)
        Me.groupBox2.Controls.Add(Me.bReadme)
        Me.groupBox2.Location = New System.Drawing.Point(51, 306)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(123, 135)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "About"
        '
        'bChangelog
        '
        Me.bChangelog.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bChangelog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bChangelog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bChangelog.Location = New System.Drawing.Point(7, 89)
        Me.bChangelog.Name = "bChangelog"
        Me.bChangelog.Size = New System.Drawing.Size(110, 23)
        Me.bChangelog.TabIndex = 2
        Me.bChangelog.Text = "Changelog"
        Me.bChangelog.UseVisualStyleBackColor = False
        '
        'bCredits
        '
        Me.bCredits.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCredits.Location = New System.Drawing.Point(6, 31)
        Me.bCredits.Name = "bCredits"
        Me.bCredits.Size = New System.Drawing.Size(111, 23)
        Me.bCredits.TabIndex = 1
        Me.bCredits.Text = "Credits"
        Me.bCredits.UseVisualStyleBackColor = False
        '
        'bReadme
        '
        Me.bReadme.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bReadme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bReadme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bReadme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bReadme.Location = New System.Drawing.Point(7, 60)
        Me.bReadme.Name = "bReadme"
        Me.bReadme.Size = New System.Drawing.Size(110, 23)
        Me.bReadme.TabIndex = 1
        Me.bReadme.Text = "Readme"
        Me.bReadme.UseVisualStyleBackColor = False
        '
        'gInformation
        '
        Me.gInformation.Controls.Add(Me.bGreeting)
        Me.gInformation.Controls.Add(Me.lAnnouncementsUnits)
        Me.gInformation.Controls.Add(Me.nAnnouncements)
        Me.gInformation.Controls.Add(Me.xAnnouncements)
        Me.gInformation.Controls.Add(Me.bRules)
        Me.gInformation.Controls.Add(Me.bAnnouncements)
        Me.gInformation.Location = New System.Drawing.Point(8, 219)
        Me.gInformation.Name = "gInformation"
        Me.gInformation.Size = New System.Drawing.Size(636, 57)
        Me.gInformation.TabIndex = 1
        Me.gInformation.TabStop = False
        Me.gInformation.Text = "Information"
        '
        'bRules
        '
        Me.bRules.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRules.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRules.Location = New System.Drawing.Point(445, 20)
        Me.bRules.Name = "bRules"
        Me.bRules.Size = New System.Drawing.Size(87, 28)
        Me.bRules.TabIndex = 4
        Me.bRules.Text = "Edit Rules"
        Me.bRules.UseVisualStyleBackColor = False
        '
        'bAnnouncements
        '
        Me.bAnnouncements.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAnnouncements.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bAnnouncements.Enabled = False
        Me.bAnnouncements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bAnnouncements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAnnouncements.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAnnouncements.Location = New System.Drawing.Point(301, 20)
        Me.bAnnouncements.Name = "bAnnouncements"
        Me.bAnnouncements.Size = New System.Drawing.Size(138, 28)
        Me.bAnnouncements.TabIndex = 3
        Me.bAnnouncements.Text = "Edit Announcements"
        Me.bAnnouncements.UseVisualStyleBackColor = False
        '
        'tabs
        '
        Me.tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabs.Controls.Add(Me.tabGeneral)
        Me.tabs.Controls.Add(Me.tabChat)
        Me.tabs.Controls.Add(Me.tabWorlds)
        Me.tabs.Controls.Add(Me.tabRanks)
        Me.tabs.Controls.Add(Me.tabSecurity)
        Me.tabs.Controls.Add(Me.gUpdate)
        Me.tabs.Controls.Add(Me.tabLogging)
        Me.tabs.Controls.Add(Me.tabIRC)
        Me.tabs.Controls.Add(Me.tabAdvanced)
        Me.tabs.Controls.Add(Me.Misc)
        Me.tabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabs.Location = New System.Drawing.Point(16, 14)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(660, 510)
        Me.tabs.TabIndex = 6
        '
        'tabRanks
        '
        Me.tabRanks.BackColor = System.Drawing.Color.Silver
        Me.tabRanks.Controls.Add(Me.gPermissionLimits)
        Me.tabRanks.Controls.Add(Me.lRankList)
        Me.tabRanks.Controls.Add(Me.bLowerRank)
        Me.tabRanks.Controls.Add(Me.bRaiseRank)
        Me.tabRanks.Controls.Add(Me.gRankOptions)
        Me.tabRanks.Controls.Add(Me.bDeleteRank)
        Me.tabRanks.Controls.Add(Me.vPermissions)
        Me.tabRanks.Controls.Add(Me.bAddRank)
        Me.tabRanks.Controls.Add(Me.lPermissions)
        Me.tabRanks.Controls.Add(Me.vRanks)
        Me.tabRanks.Location = New System.Drawing.Point(4, 22)
        Me.tabRanks.Name = "tabRanks"
        Me.tabRanks.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabRanks.Size = New System.Drawing.Size(652, 484)
        Me.tabRanks.TabIndex = 2
        Me.tabRanks.Text = "Ranks"
        '
        'gPermissionLimits
        '
        Me.gPermissionLimits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gPermissionLimits.Controls.Add(Me.permissionLimitBoxContainer)
        Me.gPermissionLimits.Location = New System.Drawing.Point(160, 292)
        Me.gPermissionLimits.Name = "gPermissionLimits"
        Me.gPermissionLimits.Size = New System.Drawing.Size(307, 186)
        Me.gPermissionLimits.TabIndex = 7
        Me.gPermissionLimits.TabStop = False
        Me.gPermissionLimits.Text = "Permission Limits"
        '
        'permissionLimitBoxContainer
        '
        Me.permissionLimitBoxContainer.AutoScroll = True
        Me.permissionLimitBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.permissionLimitBoxContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.permissionLimitBoxContainer.Location = New System.Drawing.Point(3, 17)
        Me.permissionLimitBoxContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.permissionLimitBoxContainer.Name = "permissionLimitBoxContainer"
        Me.permissionLimitBoxContainer.Size = New System.Drawing.Size(301, 166)
        Me.permissionLimitBoxContainer.TabIndex = 0
        Me.permissionLimitBoxContainer.WrapContents = False
        '
        'lRankList
        '
        Me.lRankList.AutoSize = True
        Me.lRankList.Location = New System.Drawing.Point(8, 10)
        Me.lRankList.Name = "lRankList"
        Me.lRankList.Size = New System.Drawing.Size(58, 15)
        Me.lRankList.TabIndex = 0
        Me.lRankList.Text = "Rank List"
        '
        'bLowerRank
        '
        Me.bLowerRank.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLowerRank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bLowerRank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bLowerRank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bLowerRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLowerRank.Location = New System.Drawing.Point(84, 455)
        Me.bLowerRank.Name = "bLowerRank"
        Me.bLowerRank.Size = New System.Drawing.Size(70, 23)
        Me.bLowerRank.TabIndex = 5
        Me.bLowerRank.Text = "▼ Lower"
        Me.bLowerRank.UseVisualStyleBackColor = False
        '
        'bRaiseRank
        '
        Me.bRaiseRank.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bRaiseRank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bRaiseRank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bRaiseRank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bRaiseRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRaiseRank.Location = New System.Drawing.Point(8, 455)
        Me.bRaiseRank.Name = "bRaiseRank"
        Me.bRaiseRank.Size = New System.Drawing.Size(70, 23)
        Me.bRaiseRank.TabIndex = 4
        Me.bRaiseRank.Text = "▲ Raise"
        Me.bRaiseRank.UseVisualStyleBackColor = False
        '
        'gRankOptions
        '
        Me.gRankOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gRankOptions.Controls.Add(Me.lFillLimitUnits)
        Me.gRankOptions.Controls.Add(Me.nFillLimit)
        Me.gRankOptions.Controls.Add(Me.lFillLimit)
        Me.gRankOptions.Controls.Add(Me.nCopyPasteSlots)
        Me.gRankOptions.Controls.Add(Me.lCopyPasteSlots)
        Me.gRankOptions.Controls.Add(Me.xAllowSecurityCircumvention)
        Me.gRankOptions.Controls.Add(Me.lAntiGrief1)
        Me.gRankOptions.Controls.Add(Me.lAntiGrief3)
        Me.gRankOptions.Controls.Add(Me.nAntiGriefSeconds)
        Me.gRankOptions.Controls.Add(Me.bColorRank)
        Me.gRankOptions.Controls.Add(Me.xDrawLimit)
        Me.gRankOptions.Controls.Add(Me.lDrawLimitUnits)
        Me.gRankOptions.Controls.Add(Me.lKickIdleUnits)
        Me.gRankOptions.Controls.Add(Me.nDrawLimit)
        Me.gRankOptions.Controls.Add(Me.nKickIdle)
        Me.gRankOptions.Controls.Add(Me.xAntiGrief)
        Me.gRankOptions.Controls.Add(Me.lAntiGrief2)
        Me.gRankOptions.Controls.Add(Me.xKickIdle)
        Me.gRankOptions.Controls.Add(Me.nAntiGriefBlocks)
        Me.gRankOptions.Controls.Add(Me.xReserveSlot)
        Me.gRankOptions.Controls.Add(Me.tPrefix)
        Me.gRankOptions.Controls.Add(Me.lPrefix)
        Me.gRankOptions.Controls.Add(Me.lRankColor)
        Me.gRankOptions.Controls.Add(Me.tRankName)
        Me.gRankOptions.Controls.Add(Me.lRankName)
        Me.gRankOptions.Location = New System.Drawing.Point(160, 13)
        Me.gRankOptions.Name = "gRankOptions"
        Me.gRankOptions.Size = New System.Drawing.Size(307, 273)
        Me.gRankOptions.TabIndex = 6
        Me.gRankOptions.TabStop = False
        Me.gRankOptions.Text = "Rank Options"
        '
        'lFillLimitUnits
        '
        Me.lFillLimitUnits.AutoSize = True
        Me.lFillLimitUnits.Location = New System.Drawing.Point(239, 245)
        Me.lFillLimitUnits.Name = "lFillLimitUnits"
        Me.lFillLimitUnits.Size = New System.Drawing.Size(42, 15)
        Me.lFillLimitUnits.TabIndex = 24
        Me.lFillLimitUnits.Text = "blocks"
        '
        'nFillLimit
        '
        Me.nFillLimit.Location = New System.Drawing.Point(174, 243)
        Me.nFillLimit.Maximum = New Decimal(New Integer() {2048, 0, 0, 0})
        Me.nFillLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nFillLimit.Name = "nFillLimit"
        Me.nFillLimit.Size = New System.Drawing.Size(59, 21)
        Me.nFillLimit.TabIndex = 23
        Me.nFillLimit.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'lFillLimit
        '
        Me.lFillLimit.AutoSize = True
        Me.lFillLimit.Location = New System.Drawing.Point(85, 245)
        Me.lFillLimit.Name = "lFillLimit"
        Me.lFillLimit.Size = New System.Drawing.Size(83, 15)
        Me.lFillLimit.TabIndex = 22
        Me.lFillLimit.Text = "Flood-fill limit:"
        '
        'nCopyPasteSlots
        '
        Me.nCopyPasteSlots.Location = New System.Drawing.Point(174, 216)
        Me.nCopyPasteSlots.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nCopyPasteSlots.Name = "nCopyPasteSlots"
        Me.nCopyPasteSlots.Size = New System.Drawing.Size(59, 21)
        Me.nCopyPasteSlots.TabIndex = 21
        '
        'lCopyPasteSlots
        '
        Me.lCopyPasteSlots.AutoSize = True
        Me.lCopyPasteSlots.Location = New System.Drawing.Point(50, 218)
        Me.lCopyPasteSlots.Name = "lCopyPasteSlots"
        Me.lCopyPasteSlots.Size = New System.Drawing.Size(118, 15)
        Me.lCopyPasteSlots.TabIndex = 20
        Me.lCopyPasteSlots.Text = "Copy/paste slot limit:"
        '
        'xAllowSecurityCircumvention
        '
        Me.xAllowSecurityCircumvention.AutoSize = True
        Me.xAllowSecurityCircumvention.Location = New System.Drawing.Point(12, 165)
        Me.xAllowSecurityCircumvention.Name = "xAllowSecurityCircumvention"
        Me.xAllowSecurityCircumvention.Size = New System.Drawing.Size(271, 19)
        Me.xAllowSecurityCircumvention.TabIndex = 16
        Me.xAllowSecurityCircumvention.Text = "Allow removing own access/build restrictions."
        Me.xAllowSecurityCircumvention.UseVisualStyleBackColor = True
        '
        'lAntiGrief1
        '
        Me.lAntiGrief1.AutoSize = True
        Me.lAntiGrief1.Location = New System.Drawing.Point(50, 135)
        Me.lAntiGrief1.Name = "lAntiGrief1"
        Me.lAntiGrief1.Size = New System.Drawing.Size(47, 15)
        Me.lAntiGrief1.TabIndex = 11
        Me.lAntiGrief1.Text = "Kick on"
        '
        'lAntiGrief3
        '
        Me.lAntiGrief3.AutoSize = True
        Me.lAntiGrief3.Location = New System.Drawing.Point(275, 135)
        Me.lAntiGrief3.Name = "lAntiGrief3"
        Me.lAntiGrief3.Size = New System.Drawing.Size(26, 15)
        Me.lAntiGrief3.TabIndex = 15
        Me.lAntiGrief3.Text = "sec"
        '
        'nAntiGriefSeconds
        '
        Me.nAntiGriefSeconds.Location = New System.Drawing.Point(229, 133)
        Me.nAntiGriefSeconds.Name = "nAntiGriefSeconds"
        Me.nAntiGriefSeconds.Size = New System.Drawing.Size(40, 21)
        Me.nAntiGriefSeconds.TabIndex = 14
        '
        'bColorRank
        '
        Me.bColorRank.BackColor = System.Drawing.Color.White
        Me.bColorRank.Location = New System.Drawing.Point(201, 47)
        Me.bColorRank.Name = "bColorRank"
        Me.bColorRank.Size = New System.Drawing.Size(100, 24)
        Me.bColorRank.TabIndex = 6
        Me.bColorRank.UseVisualStyleBackColor = False
        '
        'xDrawLimit
        '
        Me.xDrawLimit.AutoSize = True
        Me.xDrawLimit.Location = New System.Drawing.Point(12, 190)
        Me.xDrawLimit.Name = "xDrawLimit"
        Me.xDrawLimit.Size = New System.Drawing.Size(81, 19)
        Me.xDrawLimit.TabIndex = 17
        Me.xDrawLimit.Text = "Draw limit"
        Me.xDrawLimit.UseVisualStyleBackColor = True
        '
        'lDrawLimitUnits
        '
        Me.lDrawLimitUnits.AutoSize = True
        Me.lDrawLimitUnits.Location = New System.Drawing.Point(172, 191)
        Me.lDrawLimitUnits.Name = "lDrawLimitUnits"
        Me.lDrawLimitUnits.Size = New System.Drawing.Size(42, 15)
        Me.lDrawLimitUnits.TabIndex = 19
        Me.lDrawLimitUnits.Text = "blocks"
        '
        'lKickIdleUnits
        '
        Me.lKickIdleUnits.AutoSize = True
        Me.lKickIdleUnits.Location = New System.Drawing.Point(181, 79)
        Me.lKickIdleUnits.Name = "lKickIdleUnits"
        Me.lKickIdleUnits.Size = New System.Drawing.Size(51, 15)
        Me.lKickIdleUnits.TabIndex = 9
        Me.lKickIdleUnits.Text = "minutes"
        '
        'nDrawLimit
        '
        Me.nDrawLimit.Increment = New Decimal(New Integer() {32, 0, 0, 0})
        Me.nDrawLimit.Location = New System.Drawing.Point(99, 189)
        Me.nDrawLimit.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nDrawLimit.Name = "nDrawLimit"
        Me.nDrawLimit.Size = New System.Drawing.Size(67, 21)
        Me.nDrawLimit.TabIndex = 18
        '
        'nKickIdle
        '
        Me.nKickIdle.Location = New System.Drawing.Point(116, 77)
        Me.nKickIdle.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nKickIdle.Name = "nKickIdle"
        Me.nKickIdle.Size = New System.Drawing.Size(59, 21)
        Me.nKickIdle.TabIndex = 8
        '
        'xAntiGrief
        '
        Me.xAntiGrief.AutoSize = True
        Me.xAntiGrief.Location = New System.Drawing.Point(12, 108)
        Me.xAntiGrief.Name = "xAntiGrief"
        Me.xAntiGrief.Size = New System.Drawing.Size(213, 19)
        Me.xAntiGrief.TabIndex = 10
        Me.xAntiGrief.Text = "Enable grief / autoclicker detection"
        Me.xAntiGrief.UseVisualStyleBackColor = True
        '
        'lAntiGrief2
        '
        Me.lAntiGrief2.AutoSize = True
        Me.lAntiGrief2.Location = New System.Drawing.Point(168, 135)
        Me.lAntiGrief2.Name = "lAntiGrief2"
        Me.lAntiGrief2.Size = New System.Drawing.Size(55, 15)
        Me.lAntiGrief2.TabIndex = 13
        Me.lAntiGrief2.Text = "blocks in"
        '
        'xKickIdle
        '
        Me.xKickIdle.AutoSize = True
        Me.xKickIdle.Location = New System.Drawing.Point(12, 78)
        Me.xKickIdle.Name = "xKickIdle"
        Me.xKickIdle.Size = New System.Drawing.Size(98, 19)
        Me.xKickIdle.TabIndex = 7
        Me.xKickIdle.Text = "Kick if idle for"
        Me.xKickIdle.UseVisualStyleBackColor = True
        '
        'nAntiGriefBlocks
        '
        Me.nAntiGriefBlocks.Location = New System.Drawing.Point(103, 133)
        Me.nAntiGriefBlocks.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nAntiGriefBlocks.Name = "nAntiGriefBlocks"
        Me.nAntiGriefBlocks.Size = New System.Drawing.Size(59, 21)
        Me.nAntiGriefBlocks.TabIndex = 12
        '
        'xReserveSlot
        '
        Me.xReserveSlot.AutoSize = True
        Me.xReserveSlot.Location = New System.Drawing.Point(12, 51)
        Me.xReserveSlot.Name = "xReserveSlot"
        Me.xReserveSlot.Size = New System.Drawing.Size(129, 19)
        Me.xReserveSlot.TabIndex = 4
        Me.xReserveSlot.Text = "Reserve player slot"
        Me.xReserveSlot.UseVisualStyleBackColor = True
        '
        'tPrefix
        '
        Me.tPrefix.Enabled = False
        Me.tPrefix.Location = New System.Drawing.Point(279, 20)
        Me.tPrefix.MaxLength = 1
        Me.tPrefix.Name = "tPrefix"
        Me.tPrefix.Size = New System.Drawing.Size(22, 21)
        Me.tPrefix.TabIndex = 3
        '
        'lPrefix
        '
        Me.lPrefix.AutoSize = True
        Me.lPrefix.Enabled = False
        Me.lPrefix.Location = New System.Drawing.Point(235, 23)
        Me.lPrefix.Name = "lPrefix"
        Me.lPrefix.Size = New System.Drawing.Size(38, 15)
        Me.lPrefix.TabIndex = 2
        Me.lPrefix.Text = "Prefix"
        '
        'lRankColor
        '
        Me.lRankColor.AutoSize = True
        Me.lRankColor.Location = New System.Drawing.Point(159, 52)
        Me.lRankColor.Name = "lRankColor"
        Me.lRankColor.Size = New System.Drawing.Size(36, 15)
        Me.lRankColor.TabIndex = 5
        Me.lRankColor.Text = "Color"
        '
        'tRankName
        '
        Me.tRankName.Location = New System.Drawing.Point(62, 20)
        Me.tRankName.MaxLength = 16
        Me.tRankName.Name = "tRankName"
        Me.tRankName.Size = New System.Drawing.Size(143, 21)
        Me.tRankName.TabIndex = 1
        '
        'lRankName
        '
        Me.lRankName.AutoSize = True
        Me.lRankName.Location = New System.Drawing.Point(15, 23)
        Me.lRankName.Name = "lRankName"
        Me.lRankName.Size = New System.Drawing.Size(41, 15)
        Me.lRankName.TabIndex = 0
        Me.lRankName.Text = "Name"
        '
        'bDeleteRank
        '
        Me.bDeleteRank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bDeleteRank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bDeleteRank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bDeleteRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDeleteRank.Location = New System.Drawing.Point(84, 28)
        Me.bDeleteRank.Name = "bDeleteRank"
        Me.bDeleteRank.Size = New System.Drawing.Size(70, 23)
        Me.bDeleteRank.TabIndex = 3
        Me.bDeleteRank.Text = "Delete"
        Me.bDeleteRank.UseVisualStyleBackColor = False
        '
        'vPermissions
        '
        Me.vPermissions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vPermissions.CheckBoxes = True
        Me.vPermissions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chPermissions})
        Me.vPermissions.GridLines = True
        Me.vPermissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.vPermissions.Location = New System.Drawing.Point(473, 28)
        Me.vPermissions.MultiSelect = False
        Me.vPermissions.Name = "vPermissions"
        Me.vPermissions.ShowGroups = False
        Me.vPermissions.ShowItemToolTips = True
        Me.vPermissions.Size = New System.Drawing.Size(171, 450)
        Me.vPermissions.TabIndex = 9
        Me.vPermissions.UseCompatibleStateImageBehavior = False
        Me.vPermissions.View = System.Windows.Forms.View.Details
        '
        'chPermissions
        '
        Me.chPermissions.Width = 150
        '
        'bAddRank
        '
        Me.bAddRank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bAddRank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bAddRank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bAddRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddRank.Location = New System.Drawing.Point(8, 28)
        Me.bAddRank.Name = "bAddRank"
        Me.bAddRank.Size = New System.Drawing.Size(70, 23)
        Me.bAddRank.TabIndex = 2
        Me.bAddRank.Text = "Add Rank"
        Me.bAddRank.UseVisualStyleBackColor = False
        '
        'lPermissions
        '
        Me.lPermissions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lPermissions.AutoSize = True
        Me.lPermissions.Location = New System.Drawing.Point(473, 10)
        Me.lPermissions.Name = "lPermissions"
        Me.lPermissions.Size = New System.Drawing.Size(107, 15)
        Me.lPermissions.TabIndex = 8
        Me.lPermissions.Text = "Rank Permissions"
        '
        'vRanks
        '
        Me.vRanks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.vRanks.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vRanks.FormattingEnabled = True
        Me.vRanks.IntegralHeight = False
        Me.vRanks.ItemHeight = 15
        Me.vRanks.Location = New System.Drawing.Point(8, 57)
        Me.vRanks.Name = "vRanks"
        Me.vRanks.Size = New System.Drawing.Size(146, 392)
        Me.vRanks.TabIndex = 1
        '
        'tabSecurity
        '
        Me.tabSecurity.BackColor = System.Drawing.Color.Silver
        Me.tabSecurity.Controls.Add(Me.gBlockDB)
        Me.tabSecurity.Controls.Add(Me.gSecurityMisc)
        Me.tabSecurity.Controls.Add(Me.gSpamChat)
        Me.tabSecurity.Controls.Add(Me.gVerify)
        Me.tabSecurity.Location = New System.Drawing.Point(4, 22)
        Me.tabSecurity.Name = "tabSecurity"
        Me.tabSecurity.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.tabSecurity.Size = New System.Drawing.Size(652, 484)
        Me.tabSecurity.TabIndex = 7
        Me.tabSecurity.Text = "Security"
        '
        'gBlockDB
        '
        Me.gBlockDB.Controls.Add(Me.cBlockDBAutoEnableRank)
        Me.gBlockDB.Controls.Add(Me.xBlockDBAutoEnable)
        Me.gBlockDB.Controls.Add(Me.xBlockDBEnabled)
        Me.gBlockDB.Location = New System.Drawing.Point(8, 100)
        Me.gBlockDB.Name = "gBlockDB"
        Me.gBlockDB.Size = New System.Drawing.Size(636, 88)
        Me.gBlockDB.TabIndex = 1
        Me.gBlockDB.TabStop = False
        Me.gBlockDB.Text = "BlockDB"
        '
        'cBlockDBAutoEnableRank
        '
        Me.cBlockDBAutoEnableRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBlockDBAutoEnableRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cBlockDBAutoEnableRank.FormattingEnabled = True
        Me.cBlockDBAutoEnableRank.Location = New System.Drawing.Point(408, 55)
        Me.cBlockDBAutoEnableRank.Name = "cBlockDBAutoEnableRank"
        Me.cBlockDBAutoEnableRank.Size = New System.Drawing.Size(121, 23)
        Me.cBlockDBAutoEnableRank.TabIndex = 2
        Me.cBlockDBAutoEnableRank.TabStop = False
        '
        'xBlockDBAutoEnable
        '
        Me.xBlockDBAutoEnable.AutoSize = True
        Me.xBlockDBAutoEnable.Enabled = False
        Me.xBlockDBAutoEnable.Location = New System.Drawing.Point(42, 55)
        Me.xBlockDBAutoEnable.Name = "xBlockDBAutoEnable"
        Me.xBlockDBAutoEnable.Size = New System.Drawing.Size(360, 19)
        Me.xBlockDBAutoEnable.TabIndex = 1
        Me.xBlockDBAutoEnable.TabStop = False
        Me.xBlockDBAutoEnable.Text = "Automatically enable BlockDB on worlds that can be edited by"
        Me.xBlockDBAutoEnable.UseVisualStyleBackColor = True
        '
        'xBlockDBEnabled
        '
        Me.xBlockDBEnabled.AutoSize = True
        Me.xBlockDBEnabled.Location = New System.Drawing.Point(42, 30)
        Me.xBlockDBEnabled.Name = "xBlockDBEnabled"
        Me.xBlockDBEnabled.Size = New System.Drawing.Size(249, 19)
        Me.xBlockDBEnabled.TabIndex = 0
        Me.xBlockDBEnabled.Text = "Enable BlockDB (per-block edit tracking)."
        Me.xBlockDBEnabled.UseVisualStyleBackColor = True
        '
        'gSecurityMisc
        '
        Me.gSecurityMisc.Controls.Add(Me.xAnnounceRankChangeReasons)
        Me.gSecurityMisc.Controls.Add(Me.xRequireKickReason)
        Me.gSecurityMisc.Controls.Add(Me.lPatrolledRankAndBelow)
        Me.gSecurityMisc.Controls.Add(Me.cPatrolledRank)
        Me.gSecurityMisc.Controls.Add(Me.lPatrolledRank)
        Me.gSecurityMisc.Controls.Add(Me.xAnnounceRankChanges)
        Me.gSecurityMisc.Controls.Add(Me.xAnnounceKickAndBanReasons)
        Me.gSecurityMisc.Controls.Add(Me.xRequireRankChangeReason)
        Me.gSecurityMisc.Controls.Add(Me.xRequireBanReason)
        Me.gSecurityMisc.Location = New System.Drawing.Point(8, 294)
        Me.gSecurityMisc.Name = "gSecurityMisc"
        Me.gSecurityMisc.Size = New System.Drawing.Size(636, 178)
        Me.gSecurityMisc.TabIndex = 3
        Me.gSecurityMisc.TabStop = False
        Me.gSecurityMisc.Text = "Misc"
        '
        'xAnnounceRankChangeReasons
        '
        Me.xAnnounceRankChangeReasons.AutoSize = True
        Me.xAnnounceRankChangeReasons.Location = New System.Drawing.Point(304, 109)
        Me.xAnnounceRankChangeReasons.Name = "xAnnounceRankChangeReasons"
        Me.xAnnounceRankChangeReasons.Size = New System.Drawing.Size(253, 19)
        Me.xAnnounceRankChangeReasons.TabIndex = 6
        Me.xAnnounceRankChangeReasons.Text = "Announce promotion && demotion reasons"
        Me.xAnnounceRankChangeReasons.UseVisualStyleBackColor = True
        '
        'xRequireKickReason
        '
        Me.xRequireKickReason.AutoSize = True
        Me.xRequireKickReason.Location = New System.Drawing.Point(42, 59)
        Me.xRequireKickReason.Name = "xRequireKickReason"
        Me.xRequireKickReason.Size = New System.Drawing.Size(135, 19)
        Me.xRequireKickReason.TabIndex = 1
        Me.xRequireKickReason.Text = "Require kick reason"
        Me.xRequireKickReason.UseVisualStyleBackColor = True
        '
        'lPatrolledRankAndBelow
        '
        Me.lPatrolledRankAndBelow.AutoSize = True
        Me.lPatrolledRankAndBelow.Location = New System.Drawing.Point(257, 143)
        Me.lPatrolledRankAndBelow.Name = "lPatrolledRankAndBelow"
        Me.lPatrolledRankAndBelow.Size = New System.Drawing.Size(72, 15)
        Me.lPatrolledRankAndBelow.TabIndex = 9
        Me.lPatrolledRankAndBelow.Text = "(and below)"
        '
        'cPatrolledRank
        '
        Me.cPatrolledRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPatrolledRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPatrolledRank.FormattingEnabled = True
        Me.cPatrolledRank.Location = New System.Drawing.Point(128, 140)
        Me.cPatrolledRank.Name = "cPatrolledRank"
        Me.cPatrolledRank.Size = New System.Drawing.Size(123, 23)
        Me.cPatrolledRank.TabIndex = 8
        '
        'lPatrolledRank
        '
        Me.lPatrolledRank.AutoSize = True
        Me.lPatrolledRank.Location = New System.Drawing.Point(39, 143)
        Me.lPatrolledRank.Name = "lPatrolledRank"
        Me.lPatrolledRank.Size = New System.Drawing.Size(83, 15)
        Me.lPatrolledRank.TabIndex = 7
        Me.lPatrolledRank.Text = "Patrolled rank"
        '
        'xAnnounceRankChanges
        '
        Me.xAnnounceRankChanges.AutoSize = True
        Me.xAnnounceRankChanges.Location = New System.Drawing.Point(304, 84)
        Me.xAnnounceRankChanges.Name = "xAnnounceRankChanges"
        Me.xAnnounceRankChanges.Size = New System.Drawing.Size(231, 19)
        Me.xAnnounceRankChanges.TabIndex = 5
        Me.xAnnounceRankChanges.Text = "Announce promotions and demotions"
        Me.xAnnounceRankChanges.UseVisualStyleBackColor = True
        '
        'xAnnounceKickAndBanReasons
        '
        Me.xAnnounceKickAndBanReasons.AutoSize = True
        Me.xAnnounceKickAndBanReasons.Location = New System.Drawing.Point(304, 59)
        Me.xAnnounceKickAndBanReasons.Name = "xAnnounceKickAndBanReasons"
        Me.xAnnounceKickAndBanReasons.Size = New System.Drawing.Size(244, 19)
        Me.xAnnounceKickAndBanReasons.TabIndex = 4
        Me.xAnnounceKickAndBanReasons.Text = "Announce kick, ban, and unban reasons"
        Me.xAnnounceKickAndBanReasons.UseVisualStyleBackColor = True
        '
        'xRequireRankChangeReason
        '
        Me.xRequireRankChangeReason.AutoSize = True
        Me.xRequireRankChangeReason.Location = New System.Drawing.Point(42, 109)
        Me.xRequireRankChangeReason.Name = "xRequireRankChangeReason"
        Me.xRequireRankChangeReason.Size = New System.Drawing.Size(236, 19)
        Me.xRequireRankChangeReason.TabIndex = 3
        Me.xRequireRankChangeReason.Text = "Require promotion && demotion reason"
        Me.xRequireRankChangeReason.UseVisualStyleBackColor = True
        '
        'xRequireBanReason
        '
        Me.xRequireBanReason.AutoSize = True
        Me.xRequireBanReason.Location = New System.Drawing.Point(42, 84)
        Me.xRequireBanReason.Name = "xRequireBanReason"
        Me.xRequireBanReason.Size = New System.Drawing.Size(184, 19)
        Me.xRequireBanReason.TabIndex = 2
        Me.xRequireBanReason.Text = "Require ban && unban reason"
        Me.xRequireBanReason.UseVisualStyleBackColor = True
        '
        'gSpamChat
        '
        Me.gSpamChat.Controls.Add(Me.lAntispamMaxWarnings)
        Me.gSpamChat.Controls.Add(Me.nAntispamMaxWarnings)
        Me.gSpamChat.Controls.Add(Me.xAntispamKicks)
        Me.gSpamChat.Controls.Add(Me.lSpamMuteSeconds)
        Me.gSpamChat.Controls.Add(Me.lAntispamInterval)
        Me.gSpamChat.Controls.Add(Me.nSpamMute)
        Me.gSpamChat.Controls.Add(Me.lSpamMute)
        Me.gSpamChat.Controls.Add(Me.nAntispamInterval)
        Me.gSpamChat.Controls.Add(Me.lAntispamMessageCount)
        Me.gSpamChat.Controls.Add(Me.nAntispamMessageCount)
        Me.gSpamChat.Controls.Add(Me.lSpamChat)
        Me.gSpamChat.Location = New System.Drawing.Point(8, 194)
        Me.gSpamChat.Name = "gSpamChat"
        Me.gSpamChat.Size = New System.Drawing.Size(636, 94)
        Me.gSpamChat.TabIndex = 2
        Me.gSpamChat.TabStop = False
        Me.gSpamChat.Text = "Chat Spam Prevention"
        '
        'nSpamMute
        '
        Me.nSpamMute.Location = New System.Drawing.Point(153, 59)
        Me.nSpamMute.Name = "nSpamMute"
        Me.nSpamMute.Size = New System.Drawing.Size(62, 21)
        Me.nSpamMute.TabIndex = 6
        '
        'lSpamMute
        '
        Me.lSpamMute.AutoSize = True
        Me.lSpamMute.Location = New System.Drawing.Point(39, 62)
        Me.lSpamMute.Name = "lSpamMute"
        Me.lSpamMute.Size = New System.Drawing.Size(108, 15)
        Me.lSpamMute.TabIndex = 5
        Me.lSpamMute.Text = "Mute spammer for"
        '
        'nAntispamInterval
        '
        Me.nAntispamInterval.Location = New System.Drawing.Point(304, 25)
        Me.nAntispamInterval.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nAntispamInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nAntispamInterval.Name = "nAntispamInterval"
        Me.nAntispamInterval.Size = New System.Drawing.Size(62, 21)
        Me.nAntispamInterval.TabIndex = 3
        Me.nAntispamInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lAntispamMessageCount
        '
        Me.lAntispamMessageCount.AutoSize = True
        Me.lAntispamMessageCount.Location = New System.Drawing.Point(219, 27)
        Me.lAntispamMessageCount.Name = "lAntispamMessageCount"
        Me.lAntispamMessageCount.Size = New System.Drawing.Size(77, 15)
        Me.lAntispamMessageCount.TabIndex = 2
        Me.lAntispamMessageCount.Text = "messages in"
        '
        'nAntispamMessageCount
        '
        Me.nAntispamMessageCount.Location = New System.Drawing.Point(153, 25)
        Me.nAntispamMessageCount.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nAntispamMessageCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nAntispamMessageCount.Name = "nAntispamMessageCount"
        Me.nAntispamMessageCount.Size = New System.Drawing.Size(62, 21)
        Me.nAntispamMessageCount.TabIndex = 1
        Me.nAntispamMessageCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lSpamChat
        '
        Me.lSpamChat.AutoSize = True
        Me.lSpamChat.Location = New System.Drawing.Point(39, 31)
        Me.lSpamChat.Name = "lSpamChat"
        Me.lSpamChat.Size = New System.Drawing.Size(97, 15)
        Me.lSpamChat.TabIndex = 0
        Me.lSpamChat.Text = "Limit chat rate to"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.GemsCraftGUI.My.Resources.Resources.icon
        Me.pictureBox1.Location = New System.Drawing.Point(212, 294)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(213, 175)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'URLLabel
        '
        Me.URLLabel.AutoSize = True
        Me.URLLabel.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLLabel.ForeColor = System.Drawing.Color.Black
        Me.URLLabel.Location = New System.Drawing.Point(7, 10)
        Me.URLLabel.Name = "URLLabel"
        Me.URLLabel.Size = New System.Drawing.Size(31, 12)
        Me.URLLabel.TabIndex = 9
        Me.URLLabel.Text = "URL:"
        '
        'bPlay
        '
        Me.bPlay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPlay.Enabled = False
        Me.bPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPlay.Location = New System.Drawing.Point(641, 4)
        Me.bPlay.Name = "bPlay"
        Me.bPlay.Size = New System.Drawing.Size(48, 23)
        Me.bPlay.TabIndex = 8
        Me.bPlay.Text = "Play"
        Me.bPlay.UseVisualStyleBackColor = False
        '
        'uriDisplay
        '
        Me.uriDisplay.Location = New System.Drawing.Point(44, 6)
        Me.uriDisplay.Name = "uriDisplay"
        Me.uriDisplay.Size = New System.Drawing.Size(591, 20)
        Me.uriDisplay.TabIndex = 10
        '
        'logBox
        '
        Me.logBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logBox.BackColor = System.Drawing.Color.Black
        Me.logBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logBox.HideSelection = False
        Me.logBox.Location = New System.Drawing.Point(9, 32)
        Me.logBox.Name = "logBox"
        Me.logBox.ReadOnly = True
        Me.logBox.Size = New System.Drawing.Size(526, 502)
        Me.logBox.TabIndex = 11
        Me.logBox.Text = ""
        '
        'playerListLabel
        '
        Me.playerListLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerListLabel.AutoSize = True
        Me.playerListLabel.BackColor = System.Drawing.Color.Transparent
        Me.playerListLabel.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerListLabel.ForeColor = System.Drawing.Color.Black
        Me.playerListLabel.Location = New System.Drawing.Point(541, 34)
        Me.playerListLabel.Name = "playerListLabel"
        Me.playerListLabel.Size = New System.Drawing.Size(65, 12)
        Me.playerListLabel.TabIndex = 13
        Me.playerListLabel.Text = "Player list"
        '
        'playerList
        '
        Me.playerList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerList.BackColor = System.Drawing.Color.White
        Me.playerList.FormattingEnabled = True
        Me.playerList.IntegralHeight = False
        Me.playerList.Location = New System.Drawing.Point(541, 50)
        Me.playerList.Name = "playerList"
        Me.playerList.Size = New System.Drawing.Size(144, 484)
        Me.playerList.TabIndex = 12
        '
        'bVoice
        '
        Me.bVoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bVoice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bVoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bVoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVoice.Image = CType(resources.GetObject("bVoice.Image"), System.Drawing.Image)
        Me.bVoice.Location = New System.Drawing.Point(648, 540)
        Me.bVoice.Name = "bVoice"
        Me.bVoice.Size = New System.Drawing.Size(37, 29)
        Me.bVoice.TabIndex = 14
        Me.bVoice.UseVisualStyleBackColor = False
        '
        'console
        '
        Me.console.Location = New System.Drawing.Point(9, 540)
        Me.console.Name = "console"
        Me.console.Size = New System.Drawing.Size(634, 20)
        Me.console.TabIndex = 15
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(704, 614)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "GemsCraft GUI"
        Me.TabControl1.ResumeLayout(False)
        Me.tabConfig.ResumeLayout(False)
        Me.tabServer.ResumeLayout(False)
        Me.tabServer.PerformLayout()
        CType(Me.nLogLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabIRC.ResumeLayout(False)
        Me.tabIRC.PerformLayout()
        Me.gIRCAdv.ResumeLayout(False)
        Me.gIRCAdv.PerformLayout()
        Me.gIRCOptions.ResumeLayout(False)
        Me.gIRCOptions.PerformLayout()
        Me.gIRCNetwork.ResumeLayout(False)
        Me.gIRCNetwork.PerformLayout()
        CType(Me.nIRCDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nIRCBotPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gLogFile.ResumeLayout(False)
        Me.gLogFile.PerformLayout()
        Me.tabLogging.ResumeLayout(False)
        Me.gConsole.ResumeLayout(False)
        Me.gConsole.PerformLayout()
        Me.gDataBackup.ResumeLayout(False)
        Me.gDataBackup.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        CType(Me.nMaxConnectionsPerIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gUpdate.ResumeLayout(False)
        Me.gSaving.ResumeLayout(False)
        Me.gSaving.PerformLayout()
        CType(Me.nSaveInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBackups.ResumeLayout(False)
        Me.gBackups.PerformLayout()
        CType(Me.nMaxBackupSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxBackups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nBackupInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gVerify.ResumeLayout(False)
        Me.gVerify.PerformLayout()
        CType(Me.nAntispamMaxWarnings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxUndoStates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gCrashReport.ResumeLayout(False)
        Me.gCrashReport.PerformLayout()
        Me.Misc.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.MaxCapsValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.tabAdvanced.ResumeLayout(False)
        Me.gPerformance.ResumeLayout(False)
        Me.gPerformance.PerformLayout()
        CType(Me.nTickInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nThrottling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gAdvancedMisc.ResumeLayout(False)
        Me.gAdvancedMisc.PerformLayout()
        CType(Me.nMaxUndo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gChatColors.ResumeLayout(False)
        Me.gChatColors.PerformLayout()
        Me.gAppearence.ResumeLayout(False)
        Me.gAppearence.PerformLayout()
        Me.tabChat.ResumeLayout(False)
        CType(Me.nAnnouncements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWorlds.ResumeLayout(False)
        Me.tabWorlds.PerformLayout()
        CType(Me.dgvWorlds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxPlayersPerWorld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGeneral.ResumeLayout(False)
        Me.gBasic.ResumeLayout(False)
        Me.gBasic.PerformLayout()
        CType(Me.nUploadBandwidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.gInformation.ResumeLayout(False)
        Me.gInformation.PerformLayout()
        Me.tabs.ResumeLayout(False)
        Me.tabRanks.ResumeLayout(False)
        Me.tabRanks.PerformLayout()
        Me.gPermissionLimits.ResumeLayout(False)
        Me.gRankOptions.ResumeLayout(False)
        Me.gRankOptions.PerformLayout()
        CType(Me.nFillLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCopyPasteSlots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAntiGriefSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDrawLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nKickIdle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAntiGriefBlocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSecurity.ResumeLayout(False)
        Me.gBlockDB.ResumeLayout(False)
        Me.gBlockDB.PerformLayout()
        Me.gSecurityMisc.ResumeLayout(False)
        Me.gSecurityMisc.PerformLayout()
        Me.gSpamChat.ResumeLayout(False)
        Me.gSpamChat.PerformLayout()
        CType(Me.nSpamMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAntispamInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nAntispamMessageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabConfig As System.Windows.Forms.TabPage
    Friend WithEvents tabServer As System.Windows.Forms.TabPage
    Private WithEvents bApply As System.Windows.Forms.Button
    Private WithEvents bResetAll As System.Windows.Forms.Button
    Private WithEvents bResetTab As System.Windows.Forms.Button
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents bOK As System.Windows.Forms.Button
    Private WithEvents tabs As System.Windows.Forms.TabControl
    Private WithEvents tabGeneral As System.Windows.Forms.TabPage
    Private WithEvents gBasic As System.Windows.Forms.GroupBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents HeartBeatUrlComboBox As System.Windows.Forms.ComboBox
    Private WithEvents nMaxPlayersPerWorld As System.Windows.Forms.NumericUpDown
    Private WithEvents lMaxPlayersPerWorld As System.Windows.Forms.Label
    Private WithEvents lPort As System.Windows.Forms.Label
    Private WithEvents nPort As System.Windows.Forms.NumericUpDown
    Private WithEvents cDefaultRank As System.Windows.Forms.ComboBox
    Private WithEvents lDefaultRank As System.Windows.Forms.Label
    Private WithEvents lUploadBandwidth As System.Windows.Forms.Label
    Private WithEvents bMeasure As System.Windows.Forms.Button
    Private WithEvents tServerName As System.Windows.Forms.TextBox
    Private WithEvents lUploadBandwidthUnits As System.Windows.Forms.Label
    Private WithEvents lServerName As System.Windows.Forms.Label
    Private WithEvents nUploadBandwidth As System.Windows.Forms.NumericUpDown
    Private WithEvents tMOTD As System.Windows.Forms.TextBox
    Private WithEvents lMOTD As System.Windows.Forms.Label
    Private WithEvents cPublic As System.Windows.Forms.ComboBox
    Private WithEvents nMaxPlayers As System.Windows.Forms.NumericUpDown
    Private WithEvents lPublic As System.Windows.Forms.Label
    Private WithEvents lMaxPlayers As System.Windows.Forms.Label
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents bWiki As System.Windows.Forms.Button
    Private WithEvents bWeb As System.Windows.Forms.Button
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents bChangelog As System.Windows.Forms.Button
    Private WithEvents bCredits As System.Windows.Forms.Button
    Private WithEvents bReadme As System.Windows.Forms.Button
    Private WithEvents gInformation As System.Windows.Forms.GroupBox
    Private WithEvents bGreeting As System.Windows.Forms.Button
    Private WithEvents lAnnouncementsUnits As System.Windows.Forms.Label
    Private WithEvents nAnnouncements As System.Windows.Forms.NumericUpDown
    Private WithEvents xAnnouncements As System.Windows.Forms.CheckBox
    Private WithEvents bRules As System.Windows.Forms.Button
    Private WithEvents bAnnouncements As System.Windows.Forms.Button
    Private WithEvents tabChat As System.Windows.Forms.TabPage
    Private WithEvents gAppearence As System.Windows.Forms.GroupBox
    Private WithEvents xShowConnectionMessages As System.Windows.Forms.CheckBox
    Private WithEvents xShowJoinedWorldMessages As System.Windows.Forms.CheckBox
    Private WithEvents xRankColorsInWorldNames As System.Windows.Forms.CheckBox
    Private WithEvents xRankPrefixesInList As System.Windows.Forms.CheckBox
    Private WithEvents xRankPrefixesInChat As System.Windows.Forms.CheckBox
    Private WithEvents xRankColorsInChat As System.Windows.Forms.CheckBox
    Private WithEvents gChatColors As System.Windows.Forms.GroupBox
    Private WithEvents lColorMe As System.Windows.Forms.Label
    Private WithEvents bColorGlobal As System.Windows.Forms.Button
    Private WithEvents bColorMe As System.Windows.Forms.Button
    Private WithEvents lColorWarning As System.Windows.Forms.Label
    Private WithEvents bColorWarning As System.Windows.Forms.Button
    Private WithEvents bColorSys As System.Windows.Forms.Button
    Private WithEvents lColorSys As System.Windows.Forms.Label
    Private WithEvents bColorPM As System.Windows.Forms.Button
    Private WithEvents lColorHelp As System.Windows.Forms.Label
    Private WithEvents lColorPM As System.Windows.Forms.Label
    Private WithEvents IColorGlobal As System.Windows.Forms.Label
    Private WithEvents lColorSay As System.Windows.Forms.Label
    Private WithEvents bColorAnnouncement As System.Windows.Forms.Button
    Private WithEvents lColorAnnouncement As System.Windows.Forms.Label
    Private WithEvents bColorHelp As System.Windows.Forms.Button
    Private WithEvents bColorSay As System.Windows.Forms.Button
    Private WithEvents tabWorlds As System.Windows.Forms.TabPage
    Private WithEvents xWoMEnableEnvExtensions As System.Windows.Forms.CheckBox
    Private WithEvents bMapPath As System.Windows.Forms.Button
    Private WithEvents xMapPath As System.Windows.Forms.CheckBox
    Private WithEvents tMapPath As System.Windows.Forms.TextBox
    Private WithEvents lDefaultBuildRank As System.Windows.Forms.Label
    Private WithEvents cDefaultBuildRank As System.Windows.Forms.ComboBox
    Private WithEvents cMainWorld As System.Windows.Forms.ComboBox
    Private WithEvents lMainWorld As System.Windows.Forms.Label
    Private WithEvents bWorldEdit As System.Windows.Forms.Button
    Private WithEvents bAddWorld As System.Windows.Forms.Button
    Private WithEvents bWorldDelete As System.Windows.Forms.Button
    Private WithEvents dgvWorlds As System.Windows.Forms.DataGridView
    Private WithEvents dgvcName As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dgvcDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dgvcAccess As System.Windows.Forms.DataGridViewComboBoxColumn
    Private WithEvents dgvcBuild As System.Windows.Forms.DataGridViewComboBoxColumn
    Private WithEvents dgvcBackup As System.Windows.Forms.DataGridViewComboBoxColumn
    Private WithEvents dgvcHidden As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents dgvcBlockDB As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents tabRanks As System.Windows.Forms.TabPage
    Private WithEvents gPermissionLimits As System.Windows.Forms.GroupBox
    Private WithEvents permissionLimitBoxContainer As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents lRankList As System.Windows.Forms.Label
    Private WithEvents bLowerRank As System.Windows.Forms.Button
    Private WithEvents bRaiseRank As System.Windows.Forms.Button
    Private WithEvents gRankOptions As System.Windows.Forms.GroupBox
    Private WithEvents lFillLimitUnits As System.Windows.Forms.Label
    Private WithEvents nFillLimit As System.Windows.Forms.NumericUpDown
    Private WithEvents lFillLimit As System.Windows.Forms.Label
    Private WithEvents nCopyPasteSlots As System.Windows.Forms.NumericUpDown
    Private WithEvents lCopyPasteSlots As System.Windows.Forms.Label
    Private WithEvents xAllowSecurityCircumvention As System.Windows.Forms.CheckBox
    Private WithEvents lAntiGrief1 As System.Windows.Forms.Label
    Private WithEvents lAntiGrief3 As System.Windows.Forms.Label
    Private WithEvents nAntiGriefSeconds As System.Windows.Forms.NumericUpDown
    Private WithEvents bColorRank As System.Windows.Forms.Button
    Private WithEvents xDrawLimit As System.Windows.Forms.CheckBox
    Private WithEvents lDrawLimitUnits As System.Windows.Forms.Label
    Private WithEvents lKickIdleUnits As System.Windows.Forms.Label
    Private WithEvents nDrawLimit As System.Windows.Forms.NumericUpDown
    Private WithEvents nKickIdle As System.Windows.Forms.NumericUpDown
    Private WithEvents xAntiGrief As System.Windows.Forms.CheckBox
    Private WithEvents lAntiGrief2 As System.Windows.Forms.Label
    Private WithEvents xKickIdle As System.Windows.Forms.CheckBox
    Private WithEvents nAntiGriefBlocks As System.Windows.Forms.NumericUpDown
    Private WithEvents xReserveSlot As System.Windows.Forms.CheckBox
    Private WithEvents tPrefix As System.Windows.Forms.TextBox
    Private WithEvents lPrefix As System.Windows.Forms.Label
    Private WithEvents lRankColor As System.Windows.Forms.Label
    Private WithEvents tRankName As System.Windows.Forms.TextBox
    Private WithEvents lRankName As System.Windows.Forms.Label
    Private WithEvents bDeleteRank As System.Windows.Forms.Button
    Private WithEvents vPermissions As System.Windows.Forms.ListView
    Private WithEvents chPermissions As System.Windows.Forms.ColumnHeader
    Private WithEvents bAddRank As System.Windows.Forms.Button
    Private WithEvents lPermissions As System.Windows.Forms.Label
    Private WithEvents vRanks As System.Windows.Forms.ListBox
    Private WithEvents tabSecurity As System.Windows.Forms.TabPage
    Private WithEvents gBlockDB As System.Windows.Forms.GroupBox
    Private WithEvents cBlockDBAutoEnableRank As System.Windows.Forms.ComboBox
    Private WithEvents xBlockDBAutoEnable As System.Windows.Forms.CheckBox
    Private WithEvents xBlockDBEnabled As System.Windows.Forms.CheckBox
    Private WithEvents gSecurityMisc As System.Windows.Forms.GroupBox
    Private WithEvents xAnnounceRankChangeReasons As System.Windows.Forms.CheckBox
    Private WithEvents xRequireKickReason As System.Windows.Forms.CheckBox
    Private WithEvents lPatrolledRankAndBelow As System.Windows.Forms.Label
    Private WithEvents cPatrolledRank As System.Windows.Forms.ComboBox
    Private WithEvents lPatrolledRank As System.Windows.Forms.Label
    Private WithEvents xAnnounceRankChanges As System.Windows.Forms.CheckBox
    Private WithEvents xAnnounceKickAndBanReasons As System.Windows.Forms.CheckBox
    Private WithEvents xRequireRankChangeReason As System.Windows.Forms.CheckBox
    Private WithEvents xRequireBanReason As System.Windows.Forms.CheckBox
    Private WithEvents gSpamChat As System.Windows.Forms.GroupBox
    Private WithEvents lAntispamMaxWarnings As System.Windows.Forms.Label
    Private WithEvents nAntispamMaxWarnings As System.Windows.Forms.NumericUpDown
    Private WithEvents xAntispamKicks As System.Windows.Forms.CheckBox
    Private WithEvents lSpamMuteSeconds As System.Windows.Forms.Label
    Private WithEvents lAntispamInterval As System.Windows.Forms.Label
    Private WithEvents nSpamMute As System.Windows.Forms.NumericUpDown
    Private WithEvents lSpamMute As System.Windows.Forms.Label
    Private WithEvents nAntispamInterval As System.Windows.Forms.NumericUpDown
    Private WithEvents lAntispamMessageCount As System.Windows.Forms.Label
    Private WithEvents nAntispamMessageCount As System.Windows.Forms.NumericUpDown
    Private WithEvents lSpamChat As System.Windows.Forms.Label
    Private WithEvents gVerify As System.Windows.Forms.GroupBox
    Private WithEvents nMaxConnectionsPerIP As System.Windows.Forms.NumericUpDown
    Private WithEvents xAllowUnverifiedLAN As System.Windows.Forms.CheckBox
    Private WithEvents xMaxConnectionsPerIP As System.Windows.Forms.CheckBox
    Private WithEvents lVerifyNames As System.Windows.Forms.Label
    Private WithEvents cVerifyNames As System.Windows.Forms.ComboBox
    Private WithEvents gUpdate As System.Windows.Forms.TabPage
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents bUpdate As System.Windows.Forms.Button
    Private WithEvents checkUpdate As System.Windows.Forms.CheckBox
    Private WithEvents gDataBackup As System.Windows.Forms.GroupBox
    Private WithEvents xBackupDataOnStartup As System.Windows.Forms.CheckBox
    Private WithEvents gSaving As System.Windows.Forms.GroupBox
    Private WithEvents nSaveInterval As System.Windows.Forms.NumericUpDown
    Private WithEvents lSaveIntervalUnits As System.Windows.Forms.Label
    Private WithEvents xSaveInterval As System.Windows.Forms.CheckBox
    Private WithEvents gBackups As System.Windows.Forms.GroupBox
    Private WithEvents xBackupOnlyWhenChanged As System.Windows.Forms.CheckBox
    Private WithEvents lMaxBackupSize As System.Windows.Forms.Label
    Private WithEvents xMaxBackupSize As System.Windows.Forms.CheckBox
    Private WithEvents nMaxBackupSize As System.Windows.Forms.NumericUpDown
    Private WithEvents xMaxBackups As System.Windows.Forms.CheckBox
    Private WithEvents xBackupOnStartup As System.Windows.Forms.CheckBox
    Private WithEvents lMaxBackups As System.Windows.Forms.Label
    Private WithEvents nMaxBackups As System.Windows.Forms.NumericUpDown
    Private WithEvents nBackupInterval As System.Windows.Forms.NumericUpDown
    Private WithEvents lBackupIntervalUnits As System.Windows.Forms.Label
    Private WithEvents xBackupInterval As System.Windows.Forms.CheckBox
    Private WithEvents xBackupOnJoin As System.Windows.Forms.CheckBox
    Private WithEvents tabLogging As System.Windows.Forms.TabPage
    Private WithEvents gLogFile As System.Windows.Forms.GroupBox
    Private WithEvents lLogFileOptionsDescription As System.Windows.Forms.Label
    Private WithEvents xLogLimit As System.Windows.Forms.CheckBox
    Private WithEvents vLogFileOptions As System.Windows.Forms.ListView
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents lLogLimitUnits As System.Windows.Forms.Label
    Private WithEvents nLogLimit As System.Windows.Forms.NumericUpDown
    Private WithEvents cLogMode As System.Windows.Forms.ComboBox
    Private WithEvents lLogMode As System.Windows.Forms.Label
    Private WithEvents gConsole As System.Windows.Forms.GroupBox
    Private WithEvents lLogConsoleOptionsDescription As System.Windows.Forms.Label
    Private WithEvents vConsoleOptions As System.Windows.Forms.ListView
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents tabIRC As System.Windows.Forms.TabPage
    Private WithEvents gIRCAdv As System.Windows.Forms.GroupBox
    Private WithEvents tServPass As System.Windows.Forms.TextBox
    Private WithEvents xServPass As System.Windows.Forms.CheckBox
    Private WithEvents tChanPass As System.Windows.Forms.TextBox
    Private WithEvents xChanPass As System.Windows.Forms.CheckBox
    Private WithEvents xIRCListShowNonEnglish As System.Windows.Forms.CheckBox
    Private WithEvents gIRCOptions As System.Windows.Forms.GroupBox
    Private WithEvents xIRCBotAnnounceServerEvents As System.Windows.Forms.CheckBox
    Private WithEvents xIRCUseColor As System.Windows.Forms.CheckBox
    Private WithEvents lIRCNoForwardingMessage As System.Windows.Forms.Label
    Private WithEvents xIRCBotAnnounceIRCJoins As System.Windows.Forms.CheckBox
    Private WithEvents bColorIRC As System.Windows.Forms.Button
    Private WithEvents lColorIRC As System.Windows.Forms.Label
    Private WithEvents xIRCBotForwardFromIRC As System.Windows.Forms.CheckBox
    Private WithEvents xIRCBotAnnounceServerJoins As System.Windows.Forms.CheckBox
    Private WithEvents xIRCBotForwardFromServer As System.Windows.Forms.CheckBox
    Private WithEvents gIRCNetwork As System.Windows.Forms.GroupBox
    Private WithEvents lIRCDelayUnits As System.Windows.Forms.Label
    Private WithEvents xIRCRegisteredNick As System.Windows.Forms.CheckBox
    Private WithEvents tIRCNickServMessage As System.Windows.Forms.TextBox
    Private WithEvents lIRCNickServMessage As System.Windows.Forms.Label
    Private WithEvents tIRCNickServ As System.Windows.Forms.TextBox
    Private WithEvents lIRCNickServ As System.Windows.Forms.Label
    Private WithEvents nIRCDelay As System.Windows.Forms.NumericUpDown
    Private WithEvents lIRCDelay As System.Windows.Forms.Label
    Private WithEvents lIRCBotChannels2 As System.Windows.Forms.Label
    Private WithEvents lIRCBotChannels3 As System.Windows.Forms.Label
    Private WithEvents tIRCBotChannels As System.Windows.Forms.TextBox
    Private WithEvents lIRCBotChannels As System.Windows.Forms.Label
    Private WithEvents nIRCBotPort As System.Windows.Forms.NumericUpDown
    Private WithEvents lIRCBotPort As System.Windows.Forms.Label
    Private WithEvents tIRCBotNetwork As System.Windows.Forms.TextBox
    Private WithEvents lIRCBotNetwork As System.Windows.Forms.Label
    Private WithEvents lIRCBotNick As System.Windows.Forms.Label
    Private WithEvents tIRCBotNick As System.Windows.Forms.TextBox
    Private WithEvents lIRCList As System.Windows.Forms.Label
    Private WithEvents xIRCBotEnabled As System.Windows.Forms.CheckBox
    Private WithEvents cIRCList As System.Windows.Forms.ComboBox
    Private WithEvents tabAdvanced As System.Windows.Forms.TabPage
    Private WithEvents gPerformance As System.Windows.Forms.GroupBox
    Private WithEvents lAdvancedWarning As System.Windows.Forms.Label
    Private WithEvents xLowLatencyMode As System.Windows.Forms.CheckBox
    Private WithEvents lProcessPriority As System.Windows.Forms.Label
    Private WithEvents cProcessPriority As System.Windows.Forms.ComboBox
    Private WithEvents nTickInterval As System.Windows.Forms.NumericUpDown
    Private WithEvents lTickIntervalUnits As System.Windows.Forms.Label
    Private WithEvents lTickInterval As System.Windows.Forms.Label
    Private WithEvents nThrottling As System.Windows.Forms.NumericUpDown
    Private WithEvents lThrottling As System.Windows.Forms.Label
    Private WithEvents lThrottlingUnits As System.Windows.Forms.Label
    Private WithEvents gAdvancedMisc As System.Windows.Forms.GroupBox
    Private WithEvents xAutoRank As System.Windows.Forms.CheckBox
    Private WithEvents nMaxUndoStates As System.Windows.Forms.NumericUpDown
    Private WithEvents lMaxUndoStates As System.Windows.Forms.Label
    Private WithEvents lIPWarning As System.Windows.Forms.Label
    Private WithEvents tIP As System.Windows.Forms.TextBox
    Private WithEvents xIP As System.Windows.Forms.CheckBox
    Private WithEvents lConsoleName As System.Windows.Forms.Label
    Private WithEvents tConsoleName As System.Windows.Forms.TextBox
    Private WithEvents nMaxUndo As System.Windows.Forms.NumericUpDown
    Private WithEvents lMaxUndoUnits As System.Windows.Forms.Label
    Private WithEvents xMaxUndo As System.Windows.Forms.CheckBox
    Private WithEvents xRelayAllBlockUpdates As System.Windows.Forms.CheckBox
    Private WithEvents xNoPartialPositionUpdates As System.Windows.Forms.CheckBox
    Private WithEvents gCrashReport As System.Windows.Forms.GroupBox
    Private WithEvents xCrash As System.Windows.Forms.CheckBox
    Private WithEvents lCrashReportDisclaimer As System.Windows.Forms.Label
    Private WithEvents Misc As System.Windows.Forms.TabPage
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents websiteURL As System.Windows.Forms.TextBox
    Private WithEvents ReqsEditor As System.Windows.Forms.Button
    Private WithEvents SwearEditor As System.Windows.Forms.Button
    Private WithEvents MaxCapsValue As System.Windows.Forms.NumericUpDown
    Private WithEvents MaxCaps As System.Windows.Forms.Label
    Private WithEvents SwearBox As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents CustomColor As System.Windows.Forms.Button
    Private WithEvents CustomText As System.Windows.Forms.Label
    Private WithEvents CustomName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents CustomAliases As System.Windows.Forms.TextBox
    Private WithEvents toolTip As System.Windows.Forms.ToolTip
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents URLLabel As System.Windows.Forms.Label
    Private WithEvents bPlay As System.Windows.Forms.Button
    Private WithEvents uriDisplay As System.Windows.Forms.TextBox
    Private WithEvents logBox As System.Windows.Forms.RichTextBox
    Private WithEvents playerListLabel As System.Windows.Forms.Label
    Private WithEvents playerList As System.Windows.Forms.ListBox
    Private WithEvents bVoice As System.Windows.Forms.Button
    Friend WithEvents console As GemsCraftGUI.ConsoleBox
End Class
