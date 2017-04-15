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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.ServerTab = new MetroFramework.Controls.MetroTabPage();
            this.ThemeBox = new MetroFramework.Controls.MetroComboBox();
            this.btnRestart = new MetroFramework.Controls.MetroButton();
            this.pStop = new MetroFramework.Controls.MetroButton();
            this.bStart = new MetroFramework.Controls.MetroButton();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.playerListLabel = new MetroFramework.Controls.MetroLabel();
            this.bVoice = new MetroFramework.Controls.MetroButton();
            this.console = new fCraft.ServerGUI.ConsoleBox();
            this.picServerStatus = new System.Windows.Forms.PictureBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.URLLabel = new MetroFramework.Controls.MetroLabel();
            this.bPlay = new MetroFramework.Controls.MetroButton();
            this.uriDisplay = new MetroFramework.Controls.MetroTextBox();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.ServerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServerTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1325, 1006);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // ServerTab
            // 
            this.ServerTab.BackColor = System.Drawing.Color.Gray;
            this.ServerTab.Controls.Add(this.ThemeBox);
            this.ServerTab.Controls.Add(this.btnRestart);
            this.ServerTab.Controls.Add(this.pStop);
            this.ServerTab.Controls.Add(this.bStart);
            this.ServerTab.Controls.Add(this.logBox);
            this.ServerTab.Controls.Add(this.playerListLabel);
            this.ServerTab.Controls.Add(this.bVoice);
            this.ServerTab.Controls.Add(this.console);
            this.ServerTab.Controls.Add(this.picServerStatus);
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
            this.ServerTab.Size = new System.Drawing.Size(1317, 964);
            this.ServerTab.TabIndex = 1;
            this.ServerTab.Text = "Server";
            this.ServerTab.VerticalScrollbarBarColor = true;
            this.ServerTab.VerticalScrollbarHighlightOnWheel = false;
            this.ServerTab.VerticalScrollbarSize = 10;
            this.ServerTab.Click += new System.EventHandler(this.tabPage2_Click);
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
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(542, 62);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(143, 10);
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
            this.pStop.Size = new System.Drawing.Size(143, 10);
            this.pStop.TabIndex = 17;
            this.pStop.Text = "Stop";
            this.pStop.UseSelectable = true;
            this.pStop.Click += new System.EventHandler(this.pStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(541, 6);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(144, 10);
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
            this.logBox.Size = new System.Drawing.Size(1081, 581);
            this.logBox.TabIndex = 14;
            this.logBox.Text = "";
            this.logBox.Visible = false;
            // 
            // playerListLabel
            // 
            this.playerListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerListLabel.AutoSize = true;
            this.playerListLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerListLabel.ForeColor = System.Drawing.Color.Black;
            this.playerListLabel.Location = new System.Drawing.Point(1089, 259);
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
            this.bVoice.Location = new System.Drawing.Point(1196, 944);
            this.bVoice.Name = "bVoice";
            this.bVoice.Size = new System.Drawing.Size(37, 10);
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
            // picServerStatus
            // 
            this.picServerStatus.Image = global::GemsCraftGUI.Properties.Resources.server_off;
            this.picServerStatus.Location = new System.Drawing.Point(546, 91);
            this.picServerStatus.Name = "picServerStatus";
            this.picServerStatus.Size = new System.Drawing.Size(143, 72);
            this.picServerStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServerStatus.TabIndex = 19;
            this.picServerStatus.TabStop = false;
            this.picServerStatus.Click += new System.EventHandler(this.picServerStatus_Click);
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.BackColor = System.Drawing.Color.Silver;
            this.playerList.Enabled = false;
            this.playerList.FormattingEnabled = true;
            this.playerList.IntegralHeight = false;
            this.playerList.Location = new System.Drawing.Point(1090, 281);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(144, 332);
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
            this.bPlay.Size = new System.Drawing.Size(48, 10);
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1317, 964);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 11111;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 1084);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GemsCraft";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.ServerTab.ResumeLayout(false);
            this.ServerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroTabControl tabControl1;
        internal MetroTabPage ServerTab;
        internal ToolTip toolTip;
        internal ToolTip toolTip1;
        internal MetroLabel URLLabel;
        internal MetroButton bPlay;
        internal MetroTextBox uriDisplay;
        internal MetroLabel playerListLabel;
        internal ListBox playerList;
        internal MetroButton bVoice;
        internal RichTextBox logBox;
        internal fCraft.ServerGUI.ConsoleBox console;
        internal MetroButton bStart;
        internal MetroButton pStop;
        internal MetroButton btnRestart;
        internal PictureBox picServerStatus;
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
        internal MetroComboBox ThemeBox;
        internal MetroTabPage tabPage1;
        internal MetroComboBox cinternal;
        internal MetroLabel linternal;
    }


}