// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using fCraft;
using fCraft.ConfigGUI;
using fCraft.Events;
using fCraft.GUI;
using fCraft.Network;
using fCraft.ServerGUI;
using GemsCraftGUI.ConfigGUI.GUITabs;
using GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens;
using GemsCraftGUI.Properties;
using GemsCraftGUI.ServerGUI;
using Color = System.Drawing.Color;
using MetroFramework.Forms;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;
using static GemsCraftGUI.Program;
using static Microsoft.VisualBasic.Interaction;
namespace GemsCraftGUI
{
    public sealed partial class MainForm : MetroForm
    {

        #region Initialization

        public MainForm()
        {
            MainScreenGUI = new MainScreen();
            GeneralScreen = new General();
            RankScreen = new Ranks();
            ChatScreen = new ConfigGUI.GUITabs.ConfigScreens.Chat();
            WorldScreen = new Worlds();
            SecurityScreen = new Security();
            SavingBackupScreen = new SavingBackup();
            LoggingScreen = new Logging();
            IrcScreen = new Irc();
            AdvancedScreen = new Advanced();
            MiscScreen = new Misc();
            CpeScreen = new Cpe();
            Program.MainFormGUI = this;
            InitializeComponent();
            //ConfigEventHandlers();
            WorldScreen.dgvcBlockDB.TrueValue = YesNoAuto.Yes;
            WorldScreen.dgvcBlockDB.FalseValue = YesNoAuto.No;
            WorldScreen.dgvcBlockDB.IndeterminateValue = YesNoAuto.Auto;
            Bold = new Font(Font, FontStyle.Bold);
            Shown += Init;
            Text = "GemsCraft " + Updater.LatestStable;
            foreach (var b in Player.CustomBlocks)
            {
                CpeScreen.clbBlocks.Items.Add(b.ToString());
            }
            ApplyTabs();
        }

        internal void ConfigEventHandlers()
        {
            //All the Config Handlers
            //this.HeartBeatUrlComboBox.SelectedIndexChanged += new System.EventHandler(this.HeartBeatUrlComboBox_SelectedIndexChanged);
            StartServerHandlers();
            // GeneralScreen 
            GeneralScreen.nMaxPlayersPerWorld.Validating += nMaxPlayerPerWorld_Validating;
            GeneralScreen.cDefaultRank.SelectedIndexChanged += cDefaultRank_SelectedIndexChanged;
            GeneralScreen.bMeasure.Click += bMeasure_Click;
            GeneralScreen.nMaxPlayers.ValueChanged += new System.EventHandler(ConfigModule.nMaxPlayers_ValueChanged);
            GeneralScreen.bChangelog.Click += new System.EventHandler(bChangelog_Click);
            GeneralScreen.bCredits.Click += new System.EventHandler(this.bCredits_Click);
            GeneralScreen.bReadme.Click += new System.EventHandler(this.bReadme_Click);
            GeneralScreen.bGreeting.Click += new System.EventHandler(this.bGreeting_Click);
            GeneralScreen.xAnnouncements.CheckedChanged += new System.EventHandler(ConfigModule.xAnnouncements_CheckedChanged);
            GeneralScreen.bRules.Click += new System.EventHandler(this.bRules_Click);
            GeneralScreen.bAnnouncements.Click += new System.EventHandler(this.bAnnouncements_Click);

            // ChatScreen
            ChatScreen.xRankPrefixesInChat.CheckedChanged += new System.EventHandler(ConfigModule.xRankPrefixesInChat_CheckedChanged);
            ChatScreen.bColorMe.Click += new System.EventHandler(this.bColorMe_Click);
            ChatScreen.bColorWarning.Click += new System.EventHandler(this.bColorWarning_Click);
            ChatScreen.bColorSys.Click += new System.EventHandler(this.bColorSys_Click);
            ChatScreen.bColorPM.Click += new System.EventHandler(this.bColorPM_Click);
            ChatScreen.bColorAnnouncement.Click += new System.EventHandler(this.bColorAnnouncement_Click);
            ChatScreen.bColorHelp.Click += new System.EventHandler(this.bColorHelp_Click);
            ChatScreen.bColorSay.Click += new System.EventHandler(this.bColorSay_Click);
            ChatScreen.bColorGlobal.Click += new System.EventHandler(this.bColorGlobal_Click);

            // WorldScreen
            WorldScreen.xMapPath.CheckedChanged += new System.EventHandler(ConfigModule.xMapPath_CheckedChanged);
            WorldScreen.cDefaultBuildRank.SelectedIndexChanged += new System.EventHandler(this.cDefaultBuildRank_SelectedIndexChanged);
            
            WorldScreen.dgvWorlds.SelectionChanged += new System.EventHandler(ConfigModule.dgvWorlds_Click);
            WorldScreen.dgvWorlds.Click += new System.EventHandler(ConfigModule.dgvWorlds_Click);

            // RankScreen
            RankScreen.bLowerRank.Click += new System.EventHandler(ConfigModule.bLowerRank_Click);
            RankScreen.bRaiseRank.Click += new System.EventHandler(ConfigModule.bRaiseRank_Click);
            RankScreen.nFillLimit.ValueChanged += new System.EventHandler(ConfigModule.nFillLimit_ValueChanged);
            RankScreen.nCopyPasteSlots.ValueChanged += new System.EventHandler(ConfigModule.nCopyPasteSlots_ValueChanged);
            RankScreen.xAllowSecurityCircumvention.CheckedChanged += new System.EventHandler(ConfigModule.xAllowSecurityCircumvention_CheckedChanged);
            RankScreen.nAntiGriefSeconds.ValueChanged += new System.EventHandler(ConfigModule.nAntiGriefSeconds_ValueChanged);
            RankScreen.bColorRank.Click += new System.EventHandler(ConfigModule.bColorRank_Click);
            RankScreen.xDrawLimit.CheckedChanged += new System.EventHandler(ConfigModule.xDrawLimit_CheckedChanged);
            RankScreen.nDrawLimit.ValueChanged += new System.EventHandler(ConfigModule.nDrawLimit_ValueChanged);
            RankScreen.nKickIdle.ValueChanged += new System.EventHandler(ConfigModule.nKickIdle_ValueChanged);
            RankScreen.xAntiGrief.CheckedChanged += new System.EventHandler(ConfigModule.xAntiGrief_CheckedChanged);
            RankScreen.xKickIdle.CheckedChanged += new System.EventHandler(ConfigModule.xKickIdle_CheckedChanged);
            RankScreen.nAntiGriefBlocks.ValueChanged += new System.EventHandler(ConfigModule.nAntiGriefBlocks_ValueChanged);
            RankScreen.xReserveSlot.CheckedChanged += new System.EventHandler(ConfigModule.xReserveSlot_CheckedChanged);
            RankScreen.tPrefix.Validating += new System.ComponentModel.CancelEventHandler(ConfigModule.tPrefix_Validating);
            RankScreen.tRankName.Validating += new System.ComponentModel.CancelEventHandler(ConfigModule.tRankName_Validating);
            RankScreen.bDeleteRank.Click += new System.EventHandler(ConfigModule.bDeleteRank_Click);
            RankScreen.vPermissions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(ConfigModule.vPermissions_ItemChecked);
            RankScreen.bAddRank.Click += new System.EventHandler(ConfigModule.bAddRank_Click);
            RankScreen.vRanks.SelectedIndexChanged += new System.EventHandler(ConfigModule.vRanks_SelectedIndexChanged);

            // SecurityScreen
            SecurityScreen.cBlockDBAutoEnableRank.SelectedIndexChanged += new System.EventHandler(this.cBlockDBAutoEnableRank_SelectedIndexChanged);
            SecurityScreen.xBlockDBAutoEnable.CheckedChanged += new System.EventHandler(this.xBlockDBAutoEnable_CheckedChanged);
            SecurityScreen.xBlockDBEnabled.CheckedChanged += new System.EventHandler(this.xBlockDBEnabled_CheckedChanged);
            SecurityScreen.cPatrolledRank.SelectedIndexChanged += new System.EventHandler(this.cPatrolledRank_SelectedIndexChanged);
            SecurityScreen.xAnnounceRankChanges.CheckedChanged += new System.EventHandler(xAnnounceRankChanges_CheckedChanged);
            SecurityScreen.xAntispamKicks.CheckedChanged += new System.EventHandler(xSpamChatKick_CheckedChanged);
            SecurityScreen.xMaxConnectionsPerIP.CheckedChanged += new System.EventHandler(xMaxConnectionsPerIP_CheckedChanged);
            SecurityScreen.cVerifyNames.SelectedIndexChanged += new System.EventHandler(cVerifyNames_SelectedIndexChanged);

            // SavingBackupScreen
            SavingBackupScreen.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            SavingBackupScreen.xSaveInterval.CheckedChanged += new System.EventHandler(xSaveAtInterval_CheckedChanged);
            SavingBackupScreen.xMaxBackupSize.CheckedChanged += new System.EventHandler(xMaxBackupSize_CheckedChanged);
            SavingBackupScreen.xMaxBackups.CheckedChanged += new System.EventHandler(xMaxBackups_CheckedChanged);
            SavingBackupScreen.xBackupInterval.CheckedChanged += new System.EventHandler(xBackupAtInterval_CheckedChanged);

            // LoggingScreen
            LoggingScreen.xLogLimit.CheckedChanged += new System.EventHandler(xLogLimit_CheckedChanged);
            LoggingScreen.vLogFileOptions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(vLogFileOptions_ItemChecked);
            LoggingScreen.vConsoleOptions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(vConsoleOptions_ItemChecked);

            // IrcScreen
            IrcScreen.xServPass.CheckedChanged += new System.EventHandler(xServPass_CheckedChanged);
            IrcScreen.xChanPass.CheckedChanged += new System.EventHandler(xChanPass_CheckedChanged);
            IrcScreen.xIRCListShowNonEnglish.CheckedChanged += new System.EventHandler(xIRCListShowNonEnglish_CheckedChanged);
            IrcScreen.bColorIRC.Click += new System.EventHandler(this.bColorIRC_Click);
            IrcScreen.xIRCRegisteredNick.CheckedChanged += new System.EventHandler(xIRCRegisteredNick_CheckedChanged);
            IrcScreen.xIRCBotEnabled.CheckedChanged += new System.EventHandler(xIRC_CheckedChanged);
            IrcScreen.cIRCList.SelectedIndexChanged += new System.EventHandler(cIRCList_SelectedIndexChanged);

            // AdvancedScreen
            AdvancedScreen.nMaxUndoStates.ValueChanged += new System.EventHandler(nMaxUndo_ValueChanged);
            AdvancedScreen.tIP.Validating += new System.ComponentModel.CancelEventHandler(tIP_Validating);
            AdvancedScreen.xIP.CheckedChanged += new System.EventHandler(xIP_CheckedChanged);
            AdvancedScreen.nMaxUndo.ValueChanged += new System.EventHandler(nMaxUndo_ValueChanged);
            AdvancedScreen.xMaxUndo.CheckedChanged += new System.EventHandler(xMaxUndo_CheckedChanged);

            // MiscScreen
            MiscScreen.websiteURL.TextChanged += new System.EventHandler(websiteURL_TextChanged);
            MiscScreen.ReqsEditor.Click += new System.EventHandler(this.ReqsEditor_Click);
            MiscScreen.SwearEditor.Click += new System.EventHandler(this.SwearEditor_Click);
            MiscScreen.CustomColor.Click += new System.EventHandler(button1_Click);
            MiscScreen.CustomText.Click += new System.EventHandler(this.label1_Click);


            /* MainForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigUI_FormClosing);
             this.Load += new System.EventHandler(this.MainForm_Load);*/
        }

        private void StartServerHandlers()
        {
            //Server Handlers
            MainFormGUI.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            MainFormGUI.bVoice.Click += new System.EventHandler(this.bVoice_Click);
        }
        public void ApplyTabs()
        {
            Config.Load(false, false);
            ApplyTabGeneral();
            ApplyTabRanks();
            ApplyTabChat();
            
            ApplyTabCpe();
            ApplyTabIrc();
            ApplyTabLogging();
            ApplyTabSecurity();
            ApplyTabWorlds();
            ApplyTabSavingAndBackup();
            ApplyTabAdvanced();
        }

        #region Server

        #endregion
        void Init(object sender, EventArgs e)
        {
            // fills Permission and LogType lists
            FillEnumLists();

            // create hidden boxes for permission limits
            FillPermissionLimitBoxes();

            // fill out all the tool tips
            FillToolTipsGeneral();
            
            
            FillToolTipsRanks();
            FillToolTipsChat();
            FillToolTipsWorlds();
            FillToolTipsSecurity();
            FillToolTipsSavingAndBackup();
            FillToolTipsLogging();
            FillToolTipsIrc();
            FillToolTipsAdvanced();

            foreach (var b in Player.CustomBlocks)
            {
                CpeScreen.clbBlocks.Items.Add(b.ToString());
            }
            FillToolTipsCpe();

           

            FillIrcNetworkList(false);

            // Initialize fCraft's args, paths, and logging backend.
            Server.InitLibrary(Environment.GetCommandLineArgs());

            WorldScreen.dgvWorlds.DataError += WorldListErrorHandler;

            LoadConfig();

            // Redraw chat preview when re-entering the tab.
            // This ensured that changes to rank colors/prefixes are applied.
            ChatScreen.Enter += (o, e2) => UpdateChatPreview();

            /*if (HeartBeatUrlComboBox.SelectedItem == null)
            {
                HeartBeatUrlComboBox.Text = "ClassiCube.net";
            }*/
        }

        void WorldListErrorHandler(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                string columnName = WorldScreen.dgvWorlds.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show(e.Exception.Message, "Error editing " + columnName);
            }
            else
            {
                MessageBox.Show(e.Exception.ToString(), "An error occured in the world list");
            }
        }

        void FillIrcNetworkList(bool showNonEnglishNetworks)
        {
            IrcScreen.cIRCList.Items.Clear();
            foreach (var network in IrcNetworks)
            {
                if (showNonEnglishNetworks || !network.IsNonEnglish)
                {
                    IrcScreen.cIRCList.Items.Add(network.Name);
                }
            }
        }
        void FillEnumLists()
        {
            foreach (var item in from Permission permission in 
                                     Enum.GetValues(typeof(Permission)) 
                                 select new ListViewItem(permission.ToString()) { Tag = permission })
            {
                RankScreen.vPermissions.Items.Add(item);
            }

            foreach (var item in from LogType type in Enum.GetValues(typeof(LogType)) where type != LogType.Trace select new ListViewItem(type.ToString()) { Tag = type })
            {
                LoggingScreen.vLogFileOptions.Items.Add(item);
                LoggingScreen.vConsoleOptions.Items.Add((ListViewItem)item.Clone());
            }
        }


        
        #endregion
        

        #region General

        private void bMeasure_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.speedtest.net/");
        }

        private void bAnnouncements_Click(object sender, EventArgs e)
        {
            var popup = new TextEditorPopup(Paths.AnnouncementsFileName, "");
            popup.ShowDialog();
        }

        
        private void bGreeting_Click(object sender, EventArgs e)
        {
            var popup = new TextEditorPopup(Paths.GreetingFileName,
@"Welcome to {SERVER_NAME}
Your rank is {RANK}&S. Type &H/Help&S for help.");
            popup.ShowDialog();
        }

        
        

        private void bCredits_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        #endregion
        

        #region Apply / Save / Cancel Buttons

        public static void SaveEverything()
        {
            using (LogRecorder applyLogger = new LogRecorder())
            {
                SaveConfig();
                if (applyLogger.HasMessages)
                {
                    MessageBox.Show(applyLogger.MessageString, "Some problems were encountered with the selected values.");
                    return;
                }
            }
            using (LogRecorder saveLogger = new LogRecorder())
            {
                Config.Save();
                if (saveLogger.HasMessages)
                {
                    MessageBox.Show(saveLogger.MessageString, "Some problems were encountered while saving.");
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


       


        #region Utils

        #region Change Detection

        void SomethingChanged(object sender, EventArgs args)
        {
            // bApply.Enabled = true;
        }


        void AddChangeHandler(Control c, EventHandler handler)
        {
            var box = c as CheckBox;
            if (box != null)
            {
                box.CheckedChanged += handler;
            }
            else
            {
                var comboBox = c as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged += handler;
                }
                else
                {
                    var view = c as ListView;
                    if (view != null)
                    {
                        view.ItemChecked += ((o, e) => handler(o, e));
                    }
                    else
                    {
                        var down = c as NumericUpDown;
                        if (down != null)
                        {
                            down.ValueChanged += handler;
                        }
                        else
                        {
                            var listBox = c as ListBox;
                            if (listBox != null)
                            {
                                listBox.SelectedIndexChanged += handler;
                            }
                            else if (c is TextBoxBase)
                            {
                                c.TextChanged += handler;
                            }
                        }
                    }
                }
            }
            foreach (Control child in c.Controls)
            {
                AddChangeHandler(child, handler);
            }
        }

        #endregion


        #region Colors

        internal static int _colorSys, _colorSay, _colorHelp, _colorAnnouncement, _colorPm;
        internal static int _colorIrc;
        static int _colorMe;
        static int _colorWarning;
        static int _colorCustom;
        static int _colorGlobal;

        void ApplyColor(Button button, int color)
        {
            button.Text = fCraft.Color.GetName(color);
            button.BackColor = ColorPicker.ColorPairs[color].Background;
            button.ForeColor = ColorPicker.ColorPairs[color].Foreground;
            // bApply.Enabled = true;
        }

        private void bColorSys_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("System message color", _colorSys);
            picker.ShowDialog();
            _colorSys = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorSys, _colorSys);
            fCraft.Color.Sys = fCraft.Color.Parse(_colorSys);
        }

        private void bColorHelp_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Help message color", _colorHelp);
            picker.ShowDialog();
            _colorHelp = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorHelp, _colorHelp);
            fCraft.Color.Help = fCraft.Color.Parse(_colorHelp);
        }

        private void bColorSay_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("/Say message color", _colorSay);
            picker.ShowDialog();
            _colorSay = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorSay, _colorSay);
            fCraft.Color.Say = fCraft.Color.Parse(_colorSay);
        }

        private void bColorAnnouncement_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Announcement color", _colorAnnouncement);
            picker.ShowDialog();
            _colorAnnouncement = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorAnnouncement, _colorAnnouncement);
            fCraft.Color.Announcement = fCraft.Color.Parse(_colorAnnouncement);
        }

        private void bColorPM_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Private / rank chat color", _colorPm);
            picker.ShowDialog();
            _colorPm = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorPM, _colorPm);
            fCraft.Color.PM = fCraft.Color.Parse(_colorPm);
        }

        private void bColorWarning_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Warning / Error message color", _colorWarning);
            picker.ShowDialog();
            _colorWarning = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorWarning, _colorWarning);
            fCraft.Color.Warning = fCraft.Color.Parse(_colorWarning);
        }

        private void bColorMe_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("/Me command color", _colorMe);
            picker.ShowDialog();
            _colorMe = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorMe, _colorMe);
            fCraft.Color.Me = fCraft.Color.Parse(_colorMe);
        }

        private void bColorIRC_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("IRC message color", _colorIrc);
            picker.ShowDialog();
            _colorIrc = picker.ColorIndex;
            ApplyColor(IrcScreen.bColorIRC, _colorIrc);
            fCraft.Color.IRC = fCraft.Color.Parse(_colorIrc);
        }

        private void bColorGlobal_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Global message color", _colorGlobal);
            picker.ShowDialog();
            _colorGlobal = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorGlobal, _colorGlobal);
            fCraft.Color.Global = fCraft.Color.Parse(_colorGlobal);
        }

        private void bColorRank_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Rank color for \"" + SelectedRank.Name + "\"", fCraft.Color.ParseToIndex(SelectedRank.Color));
            picker.ShowDialog();
            ApplyColor(RankScreen.bColorRank, picker.ColorIndex);
            SelectedRank.Color = fCraft.Color.Parse(picker.ColorIndex);
        }


        void HandleTabChatChange(object sender, EventArgs args)
        {
            UpdateChatPreview();
        }

        void UpdateChatPreview()
        {
            List<string> lines = new List<string>();
            if (ChatScreen.xShowConnectionMessages.Checked)
            {
                lines.Add(String.Format("&SPlayer {0}{1}LeChosenOne&S connected, joined {2}{3}main",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : "",
                                          ChatScreen.xRankColorsInWorldNames.Checked ? RankManager.LowestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.LowestRank.Prefix : ""));
            }
            lines.Add("&R<*- This is an announcement -*>");
            lines.Add("&YThis is a /say announcement");
            lines.Add(String.Format("{0}{1}LeChosenOne&F: This is a normal chat message",
                                      ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                      ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            lines.Add("&Pfrom Dingus: This is a private message /whisper");
            lines.Add("&M*LeChosenOne is using /Me to write this");
            if (ChatScreen.xShowJoinedWorldMessages.Checked)
            {
                Rank midRank = RankManager.LowestRank;
                if (RankManager.LowestRank.NextRankUp != null)
                {
                    midRank = RankManager.LowestRank.NextRankUp;
                }

                lines.Add(String.Format("&SPlayer {0}{1}Dingus&S joined {2}{3}SomeOtherMap",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : "",
                                          ChatScreen.xRankColorsInWorldNames.Checked ? midRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? midRank.Prefix : ""));
            }
            lines.Add("&SUnknown command \"kikc\", see &H/Commands");
            if (SecurityScreen.xAnnounceKickAndBanReasons.Checked)
            {
                lines.Add(String.Format("&W{0}{1}LeChosenOne&W was kicked by {0}{1}Dingus&W: Reason goes here",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }
            else
            {
                lines.Add(String.Format("&W{0}{1}LeChosenOne&W was kicked by {0}{1}gamer1",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }

            if (ChatScreen.xShowConnectionMessages.Checked)
            {
                lines.Add(String.Format("&S{0}{1}Dingus&S left the server.",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }

            ChatScreen.chatPreview1.SetText(lines.ToArray());
        }

        #endregion


        private void bRules_Click(object sender, EventArgs e)
        {
            TextEditorPopup popup = new TextEditorPopup(Paths.RulesFileName, "Use common sense!");
            popup.ShowDialog();
        }


        internal static bool IsWorldNameTaken(string name)
        {
            return ConfigModule.Worlds.Any(world => world.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }


        


        internal static void HandleWorldRename(string from, string to)
        {
            if (WorldScreen.cMainWorld.Items.Count == 0) return;
            if (WorldScreen.cMainWorld.SelectedItem == null)
            {
                WorldScreen.cMainWorld.SelectedIndex = 0;
            }
            else
            {
                string mainWorldName = WorldScreen.cMainWorld.SelectedItem.ToString();
                ConfigModule.FillWorldList();
                WorldScreen.cMainWorld.SelectedItem = mainWorldName == @from ? to : mainWorldName;
            }
        }

        #endregion


        private void ConfigUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Would you like to save the changes before exiting?", "Warning", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    SaveEverything();
                    return;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    return;
            }
        }


        readonly Dictionary<Permission, PermissionLimitBox> _permissionLimitBoxes = new Dictionary<Permission, PermissionLimitBox>();

        const string DefaultPermissionLimitString = "(own rank)";
        void FillPermissionLimitBoxes()
        {

            _permissionLimitBoxes[Permission.Kick] = new PermissionLimitBox("Kick limit", Permission.Kick, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Ban] = new PermissionLimitBox("Ban limit", Permission.Ban, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Promote] = new PermissionLimitBox("Promote limit", Permission.Promote, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Demote] = new PermissionLimitBox("Demote limit", Permission.Demote, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Hide] = new PermissionLimitBox("Can hide from", Permission.Hide, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Freeze] = new PermissionLimitBox("Freeze limit", Permission.Freeze, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Mute] = new PermissionLimitBox("Mute limit", Permission.Mute, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Bring] = new PermissionLimitBox("Bring limit", Permission.Bring, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Spectate] = new PermissionLimitBox("Spectate limit", Permission.Spectate, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.UndoOthersActions] = new PermissionLimitBox("Undo limit", Permission.UndoOthersActions, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Slap] = new PermissionLimitBox("Slap limit", Permission.Slap, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Kill] = new PermissionLimitBox("Kill limit", Permission.Kill, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Possess] = new PermissionLimitBox("Possess limit", Permission.Possess, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Warn] = new PermissionLimitBox("Warn limit", Permission.Warn, DefaultPermissionLimitString);
            _permissionLimitBoxes[Permission.Gtfo] = new PermissionLimitBox("Gtfo limit", Permission.Gtfo, DefaultPermissionLimitString);

            foreach (var box in _permissionLimitBoxes.Values)
            {
                RankScreen.permissionLimitBoxContainer.Controls.Add(box);
            }
        }


        private void cDefaultRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.DefaultRank = RankManager.FindRank(GeneralScreen.cDefaultRank.SelectedIndex - 1);
        }

        private void cDefaultBuildRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.DefaultBuildRank = RankManager.FindRank(WorldScreen.cDefaultBuildRank.SelectedIndex - 1);
        }

        private void cPatrolledRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.PatrolledRank = RankManager.FindRank(SecurityScreen.cPatrolledRank.SelectedIndex - 1);
        }

        private void cBlockDBAutoEnableRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.BlockDbAutoEnableRank = RankManager.FindRank(SecurityScreen.cBlockDBAutoEnableRank.SelectedIndex - 1);
        }

        private void xBlockDBEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.xBlockDBAutoEnable.Enabled = SecurityScreen.xBlockDBEnabled.Checked;
            SecurityScreen.cBlockDBAutoEnableRank.Enabled = SecurityScreen.xBlockDBEnabled.Checked && SecurityScreen.xBlockDBAutoEnable.Checked;
        }

        private void xBlockDBAutoEnable_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.cBlockDBAutoEnableRank.Enabled = SecurityScreen.xBlockDBEnabled.Checked && SecurityScreen.xBlockDBAutoEnable.Checked;
        }

        private void nFillLimit_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            SelectedRank.FillLimit = Convert.ToInt32(RankScreen.nFillLimit.Value);
        }


        public static bool UsePrefixes;


        public static string ToComboBoxOption(Rank rank)
        {
            return UsePrefixes ? $"{rank.Prefix,1}{rank.Name}" : rank.Name;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void SwearEditor_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Paths.SwearWordsFileName))
            {
                TextWriter tsw = new StreamWriter(Paths.SwearWordsFileName);
                tsw.Write("//This is where you edit the swearwords on your " +
                    "server, each word should be on a seperate line." +
                    "WARNING: Make sure to delete this line when you're " +
                    "finished reading it!");
                tsw.Close();
                Process.Start(Paths.SwearWordsFileName);
            }
            else Process.Start(Paths.SwearWordsFileName);
        }

        private void ReqsEditor_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Paths.ReqPath))
            {
                Directory.CreateDirectory(Paths.ReqPath);
                Path.Combine(Paths.ReqPath, "requirements.txt");
                File.WriteAllText(Path.Combine(Paths.ReqPath, "requirements.txt"), "//" +
                    "This is the requirements file, here is where you list the requirements " +
                    "for your server's ranks. You can either list all of the requirements " +
                    "here or you can split it into sections by creating text documents in " +
                    "this same directory(requirements folder) (sections are the most preferable). Make sure " +
                    "the text documents are the same name of the rank you are listing " +
                    "the requirements for. If you wish to use color codes use & instead of %");
                Process.Start(Paths.ReqTextPath);

            }

            else if (!File.Exists(Paths.ReqTextPath))
            {
                Process.Start(Paths.ReqDirectory);
            }

            else if (File.Exists(Paths.ReqTextPath))
            {
                Process.Start(Paths.ReqTextPath);
            }
        }
        



        private void bReadme_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/apotter96/GemsCraft/blob/master/README.md");
            }
            catch
            {
                // ignored
            }
        }

        private void bChangelog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/apotter96/GemsCraft/blob/master/zGemsCraft%20Changelog.txt");
            }
            catch
            {
                // ignored
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updater.HasMostRecentVersion())
                {

                    var answer = MessageBox.Show("A GemsCraft Update is available. Would you like to download the latest GemsCraft Version?", "GemsCraft Updater", MessageBoxButtons.YesNo);
                    if (answer != DialogResult.Yes) return;
                    using (new WebClient())
                    {
                        try
                        {
                            //download new zip in current directory
                            Process.Start("http://gemscraft.net/Version/" + Updater.LatestStable + ".zip");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update error: " + ex);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Your GemsCraft version is up to date!");
                }
            }

            catch (WebException error)
            {
                MessageBox.Show("There was an internet connection error. Server was unable to check for updates. Error: \n\r" + error);
            }
            catch (Exception error)
            {
                MessageBox.Show("There was an error in trying to check for updates:\n\r " + error);
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void HeartBeatUrlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        volatile bool _shutdownPending, _startupComplete, _shutdownComplete;
        const int MaxLinesInLog = 2000,
                  LinesToTrimWhenExceeded = 50;
        bool _listening;
        

        #region Startup
        Thread _startupThread;

        internal void StartUp(object sender, EventArgs a)
        {
            /*tabChat.SelectedIndexChanged += tabChat_tabSelected;*/
            Logger.Logged += OnLogged;
            Heartbeat.UriChanged += OnHeartbeatUriChanged;
            Server.PlayerListChanged += OnPlayerListChanged;
            Server.ShutdownEnded += OnServerShutdownEnded;
            Text = "GemsCraft " + Updater.LatestStable + " - starting...";
            _startupThread = new Thread(StartupThread)
            {
                Name = "GemsCraft ServerGUI Startup"
            };
            _startupThread.Start();
        }

        void StartupThread()
        {
            // Mark start of logging
            Logger.Log(LogType.SystemActivity, "------ Log Starts {0} ({1}) ------",
                 DateTime.Now.ToLongDateString(), DateTime.Now.ToShortDateString()); // localized
            Logger.Log(LogType.SystemActivity, "Attempting to start server based on " + Updater.UserAgent);
#if !DEBUG
            try
            {
#endif

                //Server.InitLibrary(Environment.GetCommandLineArgs());
                if (_shutdownPending) return;

                Server.InitServer(false); // False for being GUI
                if (_shutdownPending) return;

                BeginInvoke((Action)OnInitSuccess);


                // set process priority
                if (!ConfigKey.ProcessPriority.IsBlank())
                {
                    try
                    {
                        Process.GetCurrentProcess().PriorityClass = ConfigKey.ProcessPriority.GetEnum<ProcessPriorityClass>();
                    }
                    catch (Exception)
                    {
                        Logger.Log(LogType.Warning,
                                    "MainForm.StartServer: Could not set process priority, using defaults.");
                    }
                }

                if (_shutdownPending) return;
                if (Server.StartServer())
                {
                    _startupComplete = true;
                    BeginInvoke((Action)OnStartupSuccess);
                }
                else
                {
                    BeginInvoke((Action)OnStartupFailure);
                }
#if !DEBUG
            }
            catch (Exception ex)
            {
                Logger.LogAndReportCrash("Unhandled exception in ServerGUI.StartUp", "ServerGUI", ex, true);
                Shutdown(ShutdownReason.Crashed, Server.HasArg(ArgKey.ExitOnCrash));
            }
#endif
        }


        void OnInitSuccess()
        {
            Text = "GemsCraft " + " - " + ConfigKey.ServerName.GetString();
        }

        static void UpdateCheck()
        {
            Logger.Log(LogType.SystemActivity, "Checking for GemsCraft updates...");
            try
            {
                Logger.Log(LogType.SystemActivity,
                    Updater.HasMostRecentVersion()
                        ? "GemsCraft is up-to-date!"
                        : "GemsCraft is out-of-date! To update, run updateinstaller.exe!");
            }
            catch (WebException)
            {
                Console.WriteLine("There was an internet connection error. Server was unable to check for updates.");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error in trying to check for updates:\n\r " + e);
            }
        }

        void OnStartupSuccess()
        {
            if (!ConfigKey.HeartbeatEnabled.Enabled())
            {
                uriDisplay.Text = null;
            }
            console.Enabled = true;
            console.Text = "";
            picServerStatus.Image = Resources.server_on;
            if (ConfigKey.OnTheGoEnabled.Enabled())
            {
                RemoteControl.StartRemoteServer();
            }
        }


        void OnStartupFailure()
        {
            Shutdown(ShutdownReason.FailedToStart, Server.HasArg(ArgKey.ExitOnCrash));
        }

        #endregion


        #region Shutdown

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_startupThread != null && !_shutdownComplete)
            {
                Shutdown(ShutdownReason.ProcessClosing, true);
                e.Cancel = true;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        internal void Shutdown(ShutdownReason reason, bool quit, bool closeIt = true)
        {
            if (_shutdownPending) return;
            _shutdownPending = true;
            console.Enabled = false;
            console.Text = "Shutting down...";
            Text = "GemsCraft " + " - shutting down...";
            uriDisplay.Enabled = false;
            if (!_startupComplete)
            {
                _startupThread.Join();
            }
            Server.Shutdown(new ShutdownParams(reason, TimeSpan.Zero, quit, false), false, closeIt);
        }


        void OnServerShutdownEnded(object sender, ShutdownEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate
                {
                    _shutdownComplete = true;
                    switch (e.ShutdownParams.Reason)
                    {
                        case ShutdownReason.FailedToInitialize:
                        case ShutdownReason.FailedToStart:
                        case ShutdownReason.Crashed:
                            if (Server.HasArg(ArgKey.ExitOnCrash))
                            {
                                Application.Exit();
                            }
                            break;
                        default:
                            Application.Exit();
                            break;
                    }
                });
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException) { }
        }

        #endregion


        public void OnLogged(object sender, LogEventArgs e)
        {
            try
            {
                if (_shutdownComplete) return;
                if (logBox.InvokeRequired)
                {
                    BeginInvoke((EventHandler<LogEventArgs>) OnLogged, sender, e);
                }
                else
                {
                    // store user's selection
                    int userSelectionStart = logBox.SelectionStart;
                    int userSelectionLength = logBox.SelectionLength;
                    bool userSelecting = (logBox.SelectionStart != logBox.Text.Length && logBox.Focused ||
                                          logBox.SelectionLength > 0);

                    // insert and color a new message
                    int oldLength = logBox.Text.Length;
                    string msgToAppend = e.Message + Environment.NewLine;

                    /*if (e.MessageType == LogType.GlobalChat) //If Global Message, send to global and stop
                    {
                        logGlobal.SelectionColor = System.Drawing.Color.LightGray;
                        logGlobal.AppendText(msgToAppend);
                        return;
                    }
                    else*/
                    logBox.AppendText(msgToAppend);
                    logBox.Select(oldLength, msgToAppend.Length);
                    switch (e.MessageType)
                    {
                        case LogType.PrivateChat:
                            logBox.SelectionColor = Color.Teal;
                            break;
                        case LogType.IRC:
                            if (ThemeBox.SelectedItem == null)
                            {
                                // ReSharper disable once AssignNullToNotNullAttribute
                                logBox.SelectionColor = Color.FromName(fCraft.Color.GetName(fCraft.Color.IRC));
                            }
                            else
                            {
                                switch (ThemeBox.SelectedItem.ToString())
                                {
                                    default:
                                        logBox.SelectionColor = Color.LightSkyBlue;
                                        break;
                                    case "Default LC":
                                        logBox.SelectionColor = Color.Navy;
                                        break;
                                }
                            }
                            break;
                        case LogType.ChangedWorld:
                            logBox.SelectionColor = Color.Orange;
                            break;
                        case LogType.Warning:
                            if (ThemeBox.SelectedItem == null)
                            {
                                logBox.SelectionColor = Color.Yellow;
                            }
                            else
                            {
                                switch (ThemeBox.SelectedItem.ToString())
                                {
                                    default:
                                        logBox.SelectionColor = Color.MediumOrchid;
                                        break;
                                    case "Default LC":
                                        logBox.SelectionColor = Color.Yellow;
                                        break;
                                }
                            }
                            break;
                        case LogType.Debug:
                            logBox.SelectionColor = Color.DarkGray;
                            break;
                        case LogType.Error:
                        case LogType.SeriousError:
                            logBox.SelectionColor = Color.Red;
                            break;
                        case LogType.ConsoleInput:
                        case LogType.ConsoleOutput:
                            if (ThemeBox.SelectedItem == null)
                            {
                                logBox.SelectionColor = Color.White;
                            }
                            else
                            {
                                switch (ThemeBox.SelectedItem.ToString())
                                {
                                    default:
                                        logBox.SelectionColor = Color.Black;
                                        break;
                                    case "Default LC":
                                        logBox.SelectionColor = Color.White;
                                        break;
                                }
                            }
                            break;
                        default:
                            if (ThemeBox.SelectedItem == null)
                            {
                                logBox.SelectionColor = Color.LightGray;
                            }
                            else
                            {
                                switch (ThemeBox.SelectedItem.ToString())
                                {
                                    default:
                                        logBox.SelectionColor = Color.Black;
                                        break;
                                    case "Default LC":
                                        logBox.SelectionColor = Color.LightGray;
                                        break;
                                }
                            }
                            break;
                    }

                    // cut off the log, if too long
                    if (logBox.Lines.Length > MaxLinesInLog)
                    {
                        logBox.SelectionStart = 0;
                        logBox.SelectionLength = logBox.GetFirstCharIndexFromLine(LinesToTrimWhenExceeded);
                        userSelectionStart -= logBox.SelectionLength;
                        if (userSelectionStart < 0) userSelecting = false;
                        string textToAdd = "----- cut off, see " + Logger.CurrentLogFileName + " for complete log -----" +
                                           Environment.NewLine;
                        logBox.SelectedText = textToAdd;
                        userSelectionStart += textToAdd.Length;
                        logBox.SelectionColor = Color.DarkGray;
                    }

                    // either restore user's selection, or scroll to end
                    if (userSelecting)
                    {
                        logBox.Select(userSelectionStart, userSelectionLength);
                    }
                    else
                    {
                        logBox.SelectionStart = logBox.Text.Length;
                        logBox.ScrollToCaret();
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void OnHeartbeatUriChanged(object sender, UriChangedEventArgs e)
        {
            try
            {
                if (_shutdownPending) return;
                if (uriDisplay.InvokeRequired)
                {
                    BeginInvoke((EventHandler<UriChangedEventArgs>)OnHeartbeatUriChanged,
                            sender, e);
                }
                else
                {
                    uriDisplay.Text = e.NewUri.ToString();
                    uriDisplay.Enabled = true;
                    bPlay.Enabled = true;
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException) { }
        }


        public void OnPlayerListChanged(object sender, EventArgs e)
        {
            try
            {
                if (_shutdownPending) return;
                if (playerList.InvokeRequired)
                {
                    BeginInvoke((EventHandler)OnPlayerListChanged, null, EventArgs.Empty);
                }
                else
                {
                    playerList.Items.Clear();
                    Player[] playerListCache = Server.Players.OrderBy(p => p.Info.Rank.Index).ToArray();
                    foreach (Player player in playerListCache)
                    {
                        playerList.Items.Add(player.Info.Rank.Name + " - " + player.Name);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException) { }
        }

        internal void console_Enter()
        {
            string[] separator = { Environment.NewLine };
            string[] lines = console.Text.Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
#if !DEBUG
                try
                {
#endif
                    if (line.Equals("/Clear", StringComparison.OrdinalIgnoreCase))
                    {
                        logBox.Clear();
                    }
                    else if (line.Equals("/credits", StringComparison.OrdinalIgnoreCase))
                    {
                        new AboutWindow().Show();
                    }
                    else
                    {
                        /* if (onGlobal)
                         {
                             fCraft.GlobalChat.GlobalThread.SendChannelMessage("[console]: " + line);
                             Logger.Log(LogType.GlobalChat, "[console]: " + line);
                             return;
                         }
                         else */
                        {
                            Player.Console.ParseMessage(line, true, true);
                        }
                    }
#if !DEBUG
                }
                catch (Exception ex)
                {
                    Logger.LogToConsole("Error occured while trying to execute last console command: ");
                    Logger.LogToConsole(ex.GetType().Name + ": " + ex.Message);
                    Logger.LogAndReportCrash("Exception executing command from console", "ServerGUI", ex, false);
                }
#endif
            }
            console.Text = "";
        }
        
        private void bPlay_Click(object sender, EventArgs e)
        {
            
            
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }
        internal void Link_Clicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        internal void CopyMenuOnClickHandler(object sender, EventArgs e)
        {
            if (logBox.SelectedText.Length > 0)
                Clipboard.SetText(logBox.SelectedText, TextDataFormat.Text);
        }

        internal void CopyMenuPopupHandler(object sender, EventArgs e)
        {
            ContextMenu menu = sender as ContextMenu;
            if (menu != null)
            {
                menu.MenuItems[0].Enabled = (logBox.SelectedText.Length > 0);
            }
        }


        public void SetDefTheme()
        {
            BackColor = Color.Black;
            playerList.BackColor = Color.Silver;
            logBox.BackColor = Color.Black;
            ServerTab.BackColor = Color.Gray;
            logBox.SelectAll();
            logBox.SelectionColor = Color.LightGray;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }
        public void SetAltTheme()
        {
            BackColor = Color.Green;
            playerList.BackColor = Color.White;
            logBox.BackColor = Color.Black;
            ServerTab.BackColor = Color.Gold;
            logBox.SelectAll();
            logBox.SelectionColor = Color.LightGray;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }
        public void SetPinkTheme()
        {
            BackColor = Color.Pink;
            playerList.BackColor = Color.LightPink;
            logBox.BackColor = Color.LightPink;
            ServerTab.BackColor = Color.DeepPink;
            logBox.SelectAll();
            logBox.SelectionColor = Color.Black;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();

        }

        public void SetYellowTheme()
        {
            BackColor = Color.LightGoldenrodYellow;
            playerList.BackColor = Color.LightYellow;
            logBox.BackColor = Color.LightYellow;
            ServerTab.BackColor = Color.Yellow;
            logBox.SelectAll();
            logBox.SelectionColor = Color.Black;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();

        }

        public void SetGreenTheme()
        {
            BackColor = Color.SpringGreen;
            playerList.BackColor = Color.LightGreen;
            logBox.BackColor = Color.LightGreen;
            ServerTab.BackColor = Color.Green;
            logBox.SelectAll();
            logBox.SelectionColor = Color.Black;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();

        }

        public void SetPurpleTheme()
        {
            BackColor = Color.MediumPurple;
            playerList.BackColor = Color.Plum;
            logBox.BackColor = Color.Plum;
            ServerTab.BackColor = Color.Purple;
            logBox.SelectAll();
            logBox.SelectionColor = Color.Black;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();

        }

        public void SetGreyTheme()
        {
            BackColor = SystemColors.Control;
            playerList.BackColor = SystemColors.ControlLight;
            logBox.BackColor = SystemColors.ControlLight;
            ServerTab.BackColor = Color.Gray;
            logBox.SelectAll();
            logBox.SelectionColor = Color.Black;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();

        }

        public void SetCustomTheme(CustomTheme cTheme)
        {
            BackColor = cTheme.MainBackColor;
            playerList.BackColor = cTheme.PlayerListBackColor;
            logBox.BackColor = cTheme.LogBackColor;
            ServerTab.BackColor = cTheme.TabBackColor;
            logBox.SelectAll();
            logBox.SelectionColor = cTheme.TextColor;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }

        /*public void tabChat_tabSelected(object sender, EventArgs e)
          {
              if (tabChat.SelectedTab == tabServer)
              {
                  onGlobal = false;
                  return;
              }
              if (tabChat.SelectedTab == tabGlobal)
              {
                  onGlobal = true;
                  return;
              }
          }*/


        internal void bStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please note that once the server is started, you cannot modify " +
                            "the Ranks or World Screens in the Configuration");
            MainScreenGUI.tileWorlds.Enabled = false;
            MainScreenGUI.tileRanks.Enabled = false;
            MainFormGUI.StartUp(sender, e);
            MainFormGUI.console.OnCommand += MainFormGUI.console_Enter;
            MainFormGUI.logBox.LinkClicked += MainFormGUI.Link_Clicked;
            MenuItem[] menuItems =
            {
                new MenuItem("Copy", MainFormGUI.CopyMenuOnClickHandler)
            };
            MainFormGUI.logBox.ContextMenu = new ContextMenu(menuItems);
            MainFormGUI.logBox.ContextMenu.Popup += MainFormGUI.CopyMenuPopupHandler;
            MainFormGUI.playerList.MouseDoubleClick += MainFormGUI.playerList_MouseDoubleClick;
            StartEnable();
            //LoadCustomThemes(); - Legacy

        }

        #region PlayerViewer

        internal void playerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string s = (string)playerList.Items[playerList.SelectedIndex];
                s = s.Substring(s.IndexOf('-'),
                    s.Length - s.IndexOf('-'))
                    .Replace("-", "")
                    .Replace(" ", "")
                    .Trim();
                PlayerInfo player = PlayerDB.FindPlayerInfoExact(s);
                if (player == null) return;
                var v = new PlayerViewer(player);
                v.Show();
            }
            catch
            {
                // ignored
            } //do nothing at all
        }


        #endregion

        #region VoiceCommands

        private void bVoice_Click(object sender, EventArgs e)
        {
            if (MonoCompat.IsMono)
            {
                Logger.Log(LogType.Warning, "Voice commands are for windows operating systems only");
                return;
            }

            //if button was already clicked, cancel
            if (_listening)
            {
                _listening = false;
                bVoice.ForeColor = Color.Black;
                return;
            }

            var engine = new SpeechRecognitionEngine();
            bVoice.ForeColor = Color.Aqua;
            var commands = new Choices();
            commands.Add("restart", "shutdown", "status report", "players", "help");
            var gr = new Grammar(new GrammarBuilder(commands));
            try
            {
                _listening = true;
                engine.RequestRecognizerUpdate();
                engine.LoadGrammar(gr);
                engine.SpeechRecognized += engine_SpeechRecognized;
                engine.SetInputToDefaultAudioDevice();
                engine.RecognizeAsync(RecognizeMode.Multiple);
                engine.Recognize();
            }

            catch
            {
                // ignored
            }
        }

        private string messageBoxMessage =
            "You will now need to select the ClassicSharp exe. Do not select the launcher. ";
        private void bPlay_Click_1(object sender, EventArgs e)
        {
            var filePath = "cc_location.txt";
            if (!File.Exists(filePath) || File.ReadAllText(filePath) == string.Empty)
            {
                MessageBox.Show(messageBoxMessage);
                openFileDialog1.Title = "Select ClassicSharp Launcher";
                openFileDialog1.ShowDialog();
                var filePathX = openFileDialog1.FileName;
                if (filePathX.Substring(filePathX.LastIndexOf(".") + 1) != "exe")
                {
                    var addedMessage = "You must select an executable (exe)";
                    if (messageBoxMessage != messageBoxMessage + addedMessage)
                    {
                        messageBoxMessage += addedMessage;
                    }
                    bPlay_Click_1(sender, e);
                }
                else
                {
                    var writer = File.CreateText(filePath);
                    writer.WriteLine(filePathX);
                    writer.Flush();
                    writer.Close();
                    MessageBox.Show("You must now click \"Play\" again to open ClassicSharp");
                }
            }
            else
            {
                try
                {
                    Process.Start(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, something went wrong when trying to open ClassicSharp. Exception: " + ex.ToString());
                }
            }
        }

        void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
            try
            {
                engine = new SpeechRecognitionEngine();
                String message = "";
                String results = e.Result.Text;
                if (!_listening)
                {
                    return;
                }
                switch (results)
                {
                    case "help":
                        reader.Speak("The available commands are restart, shutdown, status report, and players.");
                        Logger.Log(LogType.ConsoleOutput, "The available commands are restart, shutdown, status report, and a players.");
                        bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "restart":
                        reader.Speak("The server is now restarting.");
                        ShutdownParams param = new ShutdownParams(ShutdownReason.Restarting, TimeSpan.FromSeconds(5), true, true, "Restarting", Player.Console);
                        Server.Shutdown(param, true);
                        bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "shutdown":
                        reader.Speak("The server is now shutting down.");
                        Shutdown(ShutdownReason.ShuttingDown, true);
                        bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "status report":
                        reader.Speak("Server has been up for " + Math.Round(DateTime.UtcNow.Subtract(Server.StartTime).TotalHours, 1, MidpointRounding.AwayFromZero) + " hours.");
                        Player.Console.ParseMessage("/sinfo", true, false);
                        bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "players":
                        message = Server.Players.Aggregate(message, (current, p) => current + p.Name);
                        reader.Speak(message);
                        Player.Console.ParseMessage("/players", true, false);
                        bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    default:
                        bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                }
            }
            catch (Exception)
            {
                //Audio Device is either missing or damaged, actual Exception is System.Speech.Internal.Synthesis.AudioException
                engine.RecognizeAsyncStop();
                engine.Dispose();
            }
        }
        #endregion

        private void pStop_Click(object sender, EventArgs e)
        {
            var msgBoxResult = MessageBox.Show("Doing so will shutdown your server! Players will disconnect! Are you sure?",
                "Stop Server",
                MessageBoxButtons.YesNo);
            if (msgBoxResult.Equals(DialogResult.Yes))
            {
                Shutdown(ShutdownReason.ShuttingDown, false, false);
            }
        }

        private void bWeb_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://gemscraft.net");
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            SaveEverything();
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Server.IsRestarting = true;
            ShutdownParams sp = new ShutdownParams(ShutdownReason.Restarting, TimeSpan.FromSeconds(5), true, true);
            Server.Shutdown(sp, false);
        }

        private void playerListLabel_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            tabPage1.Controls.Clear();
            tabPage1.Controls.Add(new ConfigGUI.GUITabs.MainScreen());
            ConfigEventHandlers();
            if (!Updater.HasMostRecentVersion())
            {
                MessageBox.Show("Your GemsCraft is out of date using version " + Updater.LatestStable + "! " +
                                "You should consider updating to " + Updater.GetCurrentOnline());
            }
            
        }

        /*private void mcbPrison_CheckedChanged(object sender, EventArgs e)
        {
            cboPrison.Enabled = mcbPrison.Checked;
            //cboPrison.SelectedIndex = 0;
        }
        */
        
        
        
    }
}