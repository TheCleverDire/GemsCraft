// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using fCraft;
using fCraft.ConfigGUI;
using JetBrains.Annotations;
using System.Collections.Generic;
using GemsCraftGUI.ConfigGUI;
using GemsCraftGUI.ConfigGUI.GUITabs;
using GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens;
using static GemsCraftGUI.Program;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;

namespace GemsCraftGUI
{
    // This section handles transfer of settings from Config to the specific UI controls, and vice versa.
    // Effectively, it's an adapter between Config's and ConfigUI's representations of the settings
    partial class MainForm
    {
        #region Loading & Applying Config

        void LoadConfig()
        {
            string missingFileMsg = null;
            if (!File.Exists(Paths.WorldListFileName) && !File.Exists(Paths.ConfigFileName))
            {
                missingFileMsg =
                    $"Configuration ({Paths.ConfigFileName}) and world list ({Paths.WorldListFileName}) were not found. Using defaults.";
            }
            else if (!File.Exists(Paths.ConfigFileName))
            {
                missingFileMsg = $"Configuration ({Paths.ConfigFileName}) was not found. Using defaults.";
            }
            else if (!File.Exists(Paths.WorldListFileName))
            {
                missingFileMsg = $"World list ({Paths.WorldListFileName}) was not found. Assuming 0 worlds.";
            }
            if (missingFileMsg != null)
            {
                MessageBox.Show(missingFileMsg);
            }

            using (var loadLogger = new LogRecorder())
            {
                if (Config.Load(false, false))
                {
                    if (loadLogger.HasMessages)
                    {
                        MessageBox.Show(loadLogger.MessageString, "Config loading warnings");
                    }
                }
                else
                {
                    MessageBox.Show(loadLogger.MessageString, "Error occured while trying to load config");
                }
            }

            /*ApplyTabGeneral();
            ApplyTabChat();
            ApplyTabWorlds(); // also reloads world list
            ApplyTabRanks();
            ApplyTabSecurity();
            ApplyTabSavingAndBackup();
            ApplyTabLogging();
            ApplyTabIrc();
            ApplyTabAdvanced();
            ApplyTabCpe();*/
            /*ddChangeHandler(tabs, SomethingChanged);
            AddChangeHandler(bResetTab, SomethingChanged);
            AddChangeHandler(bResetAll, SomethingChanged);
            WorldScreen.dgvWorlds.CellValueChanged += delegate
            {
                SomethingChanged(null, null);
            };

            AddChangeHandler(tabChat, HandleTabChatChange);
            bApply.Enabled = false;*/
        }


        void LoadWorldList()
        {
            if (ConfigModule.Worlds.Count > 0)
            {
                ConfigModule.Worlds.Clear();
            }
            if (!File.Exists(Paths.WorldListFileName)) return;

            try
            {
                XDocument doc = XDocument.Load(Paths.WorldListFileName);
                XElement root = doc.Root;
                if (root == null)
                {
                    MessageBox.Show("Worlds.xml is empty or corrupted.");
                    return;
                }

                string errorLog = "";
                using (LogRecorder logRecorder = new LogRecorder())
                {
                    foreach (XElement el in root.Elements("World"))
                    {
                        try
                        {
                            ConfigModule.Worlds.Add(new WorldListEntry(el));
                        }
                        catch (Exception ex)
                        {
                            errorLog += ex + Environment.NewLine;
                        }
                    }
                    if (logRecorder.HasMessages)
                    {
                        MessageBox.Show(logRecorder.MessageString, "World list loading warnings.");
                    }
                }
                if (errorLog.Length > 0)
                {
                    MessageBox.Show("Some errors occured while loading the world list:" + Environment.NewLine + errorLog, "Warning");
                }

                FillWorldList();
                var mainWorldAttr = root.Attribute("main");
                if (mainWorldAttr != null)
                {
                    foreach (
                        WorldListEntry world in 
                        ConfigModule.Worlds.Where(
                            world => 
                            string.Equals(world.Name, mainWorldAttr.Value, 
                                StringComparison.CurrentCultureIgnoreCase)))
                    {
                        WorldScreen.cMainWorld.SelectedItem = world.Name;
                        break;
                    }
                }

                
                PrisonData.SetUpData();
                var prisonWorldAttr = PrisonData.Obj.World;
                if (prisonWorldAttr != null)
                {
                    if (ConfigModule.Worlds.Any(world => string.Equals(world.Name, prisonWorldAttr,
                                StringComparison.CurrentCultureIgnoreCase)))
                    {
                        var loopCount = 0;
                        foreach (var v in WorldScreen.cboPrison.Items)
                        {
                            if (string.Equals(v.ToString(), prisonWorldAttr, StringComparison.CurrentCultureIgnoreCase))
                            {
                                WorldScreen.cboPrison.SelectedIndex = loopCount;
                            }
                            loopCount++;
                        }
                    }
                }
                if (ConfigKey.PrisonEnabled.Enabled())
                {
                    if (WorldScreen.cboPrison.SelectedIndex == -1)
                    {
                        var si = WorldScreen.cboPrison.SelectedIndex;
                        WorldScreen.cboPrison.SelectedIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while loading the world list: " + Environment.NewLine + ex, "Warning");
            }

            ConfigModule.Worlds.ListChanged += SomethingChanged;
        }


        public void ApplyTabGeneral()
        {

            GeneralScreen.tServerName.Text = ConfigKey.ServerName.GetString();
            MiscScreen.CustomName.Text = ConfigKey.CustomChatName.GetString(); // TODO - Move to ApplyTabMisc()
            MiscScreen.SwearBox.Text = ConfigKey.SwearName.GetString(); // TODO - Move to ApplyTabMisc()
            MiscScreen.CustomAliases.Text = ConfigKey.CustomAliasName.GetString(); // TODO - Move to ApplyTabMisc()
            GeneralScreen.tMOTD.Text = ConfigKey.MOTD.GetString();
            MiscScreen.websiteURL.Text = ConfigKey.WebsiteURL.GetString(); // TODO - Move to ApplyTabMisc()
            MiscScreen.chkSocial.Checked = ConfigKey.SocialMediaEnabled.Enabled();

            GeneralScreen.nMaxPlayers.Value = ConfigKey.MaxPlayers.GetInt();
            CheckMaxPlayersPerWorldValue();
            GeneralScreen.nMaxPlayersPerWorld.Value = ConfigKey.MaxPlayersPerWorld.GetInt();

           // checkUpdate.Checked = ConfigKey.CheckForUpdates.GetString() == "True"; // TODO - Move to ApplyTabSaving()



            FillRankList(GeneralScreen.cDefaultRank, "(lowest rank)");
            if (ConfigKey.DefaultRank.IsBlank())
            {
                GeneralScreen.cDefaultRank.SelectedIndex = 0;
            }
            else
            {
                RankManager.DefaultRank = Rank.Parse(ConfigKey.DefaultRank.GetString());
                GeneralScreen.cDefaultRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultRank);
            }

            GeneralScreen.cPublic.SelectedIndex = ConfigKey.IsPublic.Enabled() ? 0 : 1;
            GeneralScreen.nPort.Value = ConfigKey.Port.GetInt();
            MiscScreen.MaxCapsValue.Value = ConfigKey.MaxCaps.GetInt(); // TODO - Move to ApplyTabMisc()
            GeneralScreen.nUploadBandwidth.Value = ConfigKey.UploadBandwidth.GetInt();

            int interval = 0;
            GeneralScreen.xAnnouncements.Checked = ConfigKey.AnnouncementInterval.TryGetInt(out interval) && interval > 0;

            GeneralScreen.nAnnouncements.Value = GeneralScreen.xAnnouncements.Checked ? ConfigKey.AnnouncementInterval.GetInt() : 1;

            // UpdaterSettingsWindow
            UpdaterWindow.BackupBeforeUpdate = ConfigKey.BackupBeforeUpdate.Enabled();
            UpdaterWindow.RunBeforeUpdate = ConfigKey.RunBeforeUpdate.GetString();
            UpdaterWindow.RunAfterUpdate = ConfigKey.RunAfterUpdate.GetString();
            UpdaterWindow.UpdaterMode = ConfigKey.UpdaterMode.GetEnum<UpdaterMode>();
        }


        void ApplyTabChat()
        {
            ChatScreen.xRankColorsInChat.Checked = ConfigKey.RankColorsInChat.Enabled();
            ChatScreen.xRankPrefixesInChat.Checked = ConfigKey.RankPrefixesInChat.Enabled();
            ChatScreen.xRankPrefixesInList.Checked = ConfigKey.RankPrefixesInList.Enabled();
            ChatScreen.xRankColorsInWorldNames.Checked = ConfigKey.RankColorsInWorldNames.Enabled();
            ChatScreen.xShowJoinedWorldMessages.Checked = ConfigKey.ShowJoinedWorldMessages.Enabled();
            ChatScreen.xShowConnectionMessages.Checked = ConfigKey.ShowConnectionMessages.Enabled();

            _colorSys = Color.ParseToIndex(ConfigKey.SystemMessageColor.GetString());
            ApplyColor(ChatScreen.bColorSys, _colorSys);
            Color.Sys = Color.Parse(_colorSys);

            _colorCustom = Color.ParseToIndex(ConfigKey.CustomChatColor.GetString());
            ApplyColor(MiscScreen.CustomColor, _colorCustom);
            Color.Custom = Color.Parse(_colorCustom);

            _colorHelp = Color.ParseToIndex(ConfigKey.HelpColor.GetString());
            ApplyColor(ChatScreen.bColorHelp, _colorHelp);
            Color.Help = Color.Parse(_colorHelp);

            _colorSay = Color.ParseToIndex(ConfigKey.SayColor.GetString());
            ApplyColor(ChatScreen.bColorSay, _colorSay);
            Color.Say = Color.Parse(_colorSay);

            _colorAnnouncement = Color.ParseToIndex(ConfigKey.AnnouncementColor.GetString());
            ApplyColor(ChatScreen.bColorAnnouncement, _colorAnnouncement);
            Color.Announcement = Color.Parse(_colorAnnouncement);

            _colorPm = Color.ParseToIndex(ConfigKey.PrivateMessageColor.GetString());
            ApplyColor(ChatScreen.bColorPM, _colorPm);
            Color.PM = Color.Parse(_colorPm);

            _colorWarning = Color.ParseToIndex(ConfigKey.WarningColor.GetString());
            ApplyColor(ChatScreen.bColorWarning, _colorWarning);
            Color.Warning = Color.Parse(_colorWarning);

            _colorMe = Color.ParseToIndex(ConfigKey.MeColor.GetString());
            ApplyColor(ChatScreen.bColorMe, _colorMe);
            Color.Me = Color.Parse(_colorMe);

            _colorGlobal = Color.ParseToIndex(ConfigKey.GlobalColor.GetString());
            ApplyColor(ChatScreen.bColorGlobal, _colorGlobal);
            Color.Global = Color.Parse(_colorGlobal);

            UpdateChatPreview();
        }


        void ApplyTabWorlds()
        {
            if (_rankNameList == null)
            {
                _rankNameList = new BindingList<string> {
                    WorldListEntry.DefaultRankOption
                };
                foreach (Rank rank in RankManager.Ranks)
                {
                    _rankNameList.Add(MainForm.ToComboBoxOption(rank));
                }
                WorldScreen.dgvcAccess.DataSource = _rankNameList;
                WorldScreen.dgvcBuild.DataSource = _rankNameList;
                WorldScreen.dgvcBackup.DataSource = WorldListEntry.BackupEnumNames;

                LoadWorldList();
                WorldScreen.dgvWorlds.DataSource = ConfigModule.Worlds;

            }
            else
            {
                //dgvWorlds.DataSource = null;
                _rankNameList.Clear();
                _rankNameList.Add(WorldListEntry.DefaultRankOption);
                foreach (Rank rank in RankManager.Ranks)
                {
                    _rankNameList.Add(MainForm.ToComboBoxOption(rank));
                }
                foreach (WorldListEntry world in ConfigModule.Worlds)
                {
                    world.ReparseRanks();
                }
                ConfigModule.Worlds.ResetBindings();
                //dgvWorlds.DataSource = worlds;
            }

            FillRankList(WorldScreen.cDefaultBuildRank, "(default rank)");
            if (ConfigKey.DefaultBuildRank.IsBlank())
            {
                WorldScreen.cDefaultBuildRank.SelectedIndex = 0;
            }
            else
            {
                RankManager.DefaultBuildRank = Rank.Parse(ConfigKey.DefaultBuildRank.GetString());
                WorldScreen.cDefaultBuildRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultBuildRank);
            }

            if (Paths.IsDefaultMapPath(ConfigKey.MapPath.GetString()))
            {
                WorldScreen.tMapPath.Text = Paths.MapPathDefault;
                WorldScreen.xMapPath.Checked = false;
            }
            else
            {
                WorldScreen.tMapPath.Text = ConfigKey.MapPath.GetString();
                WorldScreen.xMapPath.Checked = true;
            }

            WorldScreen.xWoMEnableEnvExtensions.Checked = ConfigKey.WoMEnableEnvExtensions.Enabled();
            WorldScreen.mcbPrison.Checked = ConfigKey.PrisonEnabled.Enabled();
        }


        public void ApplyTabRanks()
        {
            SelectedRank = null;
            RebuildRankList();
            DisableRankOptions();
        }


        void ApplyTabSecurity()
        {
            SecurityScreen.txtRemotePass.Text = ConfigKey.OnTheGoPassword.GetString();
            ApplyEnum(SecurityScreen.cVerifyNames, ConfigKey.VerifyNames, NameVerificationMode.Balanced);

            SecurityScreen.nMaxConnectionsPerIP.Value = ConfigKey.MaxConnectionsPerIP.GetInt();
            SecurityScreen.xMaxConnectionsPerIP.Checked = (SecurityScreen.nMaxConnectionsPerIP.Value > 0);
            SecurityScreen.xAllowUnverifiedLAN.Checked = ConfigKey.AllowUnverifiedLAN.Enabled();

            SecurityScreen.nAntispamMessageCount.Value = ConfigKey.AntispamMessageCount.GetInt();
            SecurityScreen.nAntispamInterval.Value = ConfigKey.AntispamInterval.GetInt();
            SecurityScreen.nSpamMute.Value = ConfigKey.AntispamMuteDuration.GetInt();

            SecurityScreen.xAntispamKicks.Checked = (ConfigKey.AntispamMaxWarnings.GetInt() > 0);
            SecurityScreen.nAntispamMaxWarnings.Value = ConfigKey.AntispamMaxWarnings.GetInt();
            if (!SecurityScreen.xAntispamKicks.Checked) SecurityScreen.nAntispamMaxWarnings.Enabled = false;

            SecurityScreen.xRequireKickReason.Checked = ConfigKey.RequireKickReason.Enabled();
            SecurityScreen.xRequireBanReason.Checked = ConfigKey.RequireBanReason.Enabled();
            SecurityScreen.xRequireRankChangeReason.Checked = ConfigKey.RequireRankChangeReason.Enabled();
            SecurityScreen.xAnnounceKickAndBanReasons.Checked = ConfigKey.AnnounceKickAndBanReasons.Enabled();
            SecurityScreen.xAnnounceRankChanges.Checked = ConfigKey.AnnounceRankChanges.Enabled();
            SecurityScreen.xAnnounceRankChangeReasons.Checked = ConfigKey.AnnounceRankChangeReasons.Enabled();
            SecurityScreen.xAnnounceRankChangeReasons.Enabled = SecurityScreen.xAnnounceRankChanges.Checked;

            FillRankList(SecurityScreen.cPatrolledRank, "(default rank)");
            if (ConfigKey.PatrolledRank.IsBlank())
            {
                SecurityScreen.cPatrolledRank.SelectedIndex = 0;
            }
            else
            {
                RankManager.PatrolledRank = Rank.Parse(ConfigKey.PatrolledRank.GetString());
                SecurityScreen.cPatrolledRank.SelectedIndex = RankManager.GetIndex(RankManager.PatrolledRank);
            }


            SecurityScreen.xBlockDBEnabled.Checked = ConfigKey.BlockDBEnabled.Enabled();
            SecurityScreen.xBlockDBAutoEnable.Checked = ConfigKey.BlockDBAutoEnable.Enabled();

            FillRankList(SecurityScreen.cBlockDBAutoEnableRank, "(default rank)");
            if (ConfigKey.BlockDBAutoEnableRank.IsBlank())
            {
                SecurityScreen.cBlockDBAutoEnableRank.SelectedIndex = 0;
            }
            else
            {
                RankManager.BlockDbAutoEnableRank = Rank.Parse(ConfigKey.BlockDBAutoEnableRank.GetString());
                SecurityScreen.cBlockDBAutoEnableRank.SelectedIndex = RankManager.GetIndex(RankManager.BlockDbAutoEnableRank);
            }
        }


        void ApplyTabSavingAndBackup()
        {
            SavingBackupScreen.xSaveInterval.Checked = (ConfigKey.SaveInterval.GetInt() > 0);
            SavingBackupScreen.nSaveInterval.Value = ConfigKey.SaveInterval.GetInt();
            if (!SavingBackupScreen.xSaveInterval.Checked) SavingBackupScreen.nSaveInterval.Enabled = false;

            SavingBackupScreen.xBackupOnStartup.Checked = ConfigKey.BackupOnStartup.Enabled();
            SavingBackupScreen.xBackupOnJoin.Checked = ConfigKey.BackupOnJoin.Enabled();
            SavingBackupScreen.xBackupOnlyWhenChanged.Checked = ConfigKey.BackupOnlyWhenChanged.Enabled();

            SavingBackupScreen.xBackupInterval.Checked = (ConfigKey.DefaultBackupInterval.GetInt() > 0);
            SavingBackupScreen.nBackupInterval.Value = ConfigKey.DefaultBackupInterval.GetInt();
            if (!SavingBackupScreen.xBackupInterval.Checked) SavingBackupScreen.nBackupInterval.Enabled = false;

            SavingBackupScreen.xMaxBackups.Checked = (ConfigKey.MaxBackups.GetInt() > 0);
            SavingBackupScreen.nMaxBackups.Value = ConfigKey.MaxBackups.GetInt();
            if (!SavingBackupScreen.xMaxBackups.Checked) SavingBackupScreen.nMaxBackups.Enabled = false;

            SavingBackupScreen.xMaxBackupSize.Checked = (ConfigKey.MaxBackupSize.GetInt() > 0);
            SavingBackupScreen.nMaxBackupSize.Value = ConfigKey.MaxBackupSize.GetInt();
            if (!SavingBackupScreen.xMaxBackupSize.Checked) SavingBackupScreen.nMaxBackupSize.Enabled = false;

            SavingBackupScreen.xBackupDataOnStartup.Checked = ConfigKey.BackupDataOnStartup.Enabled();
        }


        void ApplyTabLogging()
        {
            foreach (ListViewItem item in LoggingScreen.vConsoleOptions.Items)
            {
                item.Checked = Logger.ConsoleOptions[item.Index];
            }
            foreach (ListViewItem item in LoggingScreen.vLogFileOptions.Items)
            {
                item.Checked = Logger.LogFileOptions[item.Index];
            }

            ApplyEnum(LoggingScreen.cLogMode, ConfigKey.LogMode, LogSplittingType.OneFile);

            LoggingScreen.xLogLimit.Checked = (ConfigKey.MaxLogs.GetInt() > 0);
            LoggingScreen.nLogLimit.Value = ConfigKey.MaxLogs.GetInt();
            if (!LoggingScreen.xLogLimit.Checked) LoggingScreen.nLogLimit.Enabled = false;
        }


        void ApplyTabIrc()
        {
            IrcScreen.xIRCBotEnabled.Checked = ConfigKey.IRCBotEnabled.Enabled();
            IrcScreen.gIRCNetwork.Enabled = IrcScreen.xIRCBotEnabled.Checked;
            IrcScreen.gIRCOptions.Enabled = IrcScreen.xIRCBotEnabled.Checked;

            IrcScreen.tIRCBotNetwork.Text = ConfigKey.IRCBotNetwork.GetString();
            IrcScreen.nIRCBotPort.Value = ConfigKey.IRCBotPort.GetInt();
            IrcScreen.nIRCDelay.Value = ConfigKey.IRCDelay.GetInt();

            IrcScreen.tIRCBotChannels.Text = ConfigKey.IRCBotChannels.GetString();

            IrcScreen.tIRCBotNick.Text = ConfigKey.IRCBotNick.GetString();
            IrcScreen.xIRCRegisteredNick.Checked = ConfigKey.IRCRegisteredNick.Enabled();

            IrcScreen.tIRCNickServ.Text = ConfigKey.IRCNickServ.GetString();
            IrcScreen.tIRCNickServMessage.Text = ConfigKey.IRCNickServMessage.GetString();

            IrcScreen.xIRCBotAnnounceIRCJoins.Checked = ConfigKey.IRCBotAnnounceIRCJoins.Enabled();
            IrcScreen.xIRCBotAnnounceServerJoins.Checked = ConfigKey.IRCBotAnnounceServerJoins.Enabled();
            IrcScreen.xIRCBotForwardFromIRC.Checked = ConfigKey.IRCBotForwardFromIRC.Enabled();
            IrcScreen.xIRCBotForwardFromServer.Checked = ConfigKey.IRCBotForwardFromServer.Enabled();


            _colorIrc = Color.ParseToIndex(ConfigKey.IRCMessageColor.GetString());
            ApplyColor(IrcScreen.bColorIRC, _colorIrc);
            Color.IRC = Color.Parse(_colorIrc);

            IrcScreen.xIRCUseColor.Checked = ConfigKey.IRCUseColor.Enabled();
            IrcScreen.xIRCBotAnnounceServerEvents.Checked = ConfigKey.IRCBotAnnounceServerEvents.Enabled();

            //if server pass is in use
            if (ConfigKey.IRCBotNetworkPass.GetString() != "defaultPass")
            {
                IrcScreen.xServPass.Checked = true;
            }

            //if chan pass is in use
            if (ConfigKey.IRCChannelPassword.GetString() != "password")
            {
                IrcScreen.xChanPass.Checked = true;
            }

            IrcScreen.tChanPass.Text = ConfigKey.IRCChannelPassword.GetString();
            IrcScreen.tServPass.Text = ConfigKey.IRCBotNetworkPass.GetString();
                
        }


        void ApplyTabAdvanced()
        {
            AdvancedScreen.xRelayAllBlockUpdates.Checked = ConfigKey.RelayAllBlockUpdates.Enabled();
            AdvancedScreen.xNoPartialPositionUpdates.Checked = ConfigKey.NoPartialPositionUpdates.Enabled();
            AdvancedScreen.nTickInterval.Value = ConfigKey.TickInterval.GetInt();

            if (ConfigKey.ProcessPriority.IsBlank())
            {
                AdvancedScreen.cProcessPriority.SelectedIndex = 0; // Default
            }
            else
            {
                switch (ConfigKey.ProcessPriority.GetEnum<ProcessPriorityClass>())
                {
                    case ProcessPriorityClass.High:
                        AdvancedScreen.cProcessPriority.SelectedIndex = 1; break;
                    case ProcessPriorityClass.AboveNormal:
                        AdvancedScreen.cProcessPriority.SelectedIndex = 2; break;
                    case ProcessPriorityClass.Normal:
                        AdvancedScreen.cProcessPriority.SelectedIndex = 3; break;
                    case ProcessPriorityClass.BelowNormal:
                        AdvancedScreen.cProcessPriority.SelectedIndex = 4; break;
                    case ProcessPriorityClass.Idle:
                        AdvancedScreen.cProcessPriority.SelectedIndex = 5; break;
                }
            }



            AdvancedScreen.nThrottling.Value = ConfigKey.BlockUpdateThrottling.GetInt();
            AdvancedScreen.xLowLatencyMode.Checked = ConfigKey.LowLatencyMode.Enabled();
            AdvancedScreen.xAutoRank.Checked = ConfigKey.AutoRankEnabled.Enabled();


            if (ConfigKey.MaxUndo.GetInt() > 0)
            {
                AdvancedScreen.xMaxUndo.Checked = true;
                AdvancedScreen.nMaxUndo.Value = ConfigKey.MaxUndo.GetInt();
            }
            else
            {
                AdvancedScreen.xMaxUndo.Checked = false;
                AdvancedScreen.nMaxUndo.Value = (int)ConfigKey.MaxUndo.GetDefault();
            }
            AdvancedScreen.nMaxUndoStates.Value = ConfigKey.MaxUndoStates.GetInt();

            AdvancedScreen.tConsoleName.Text = ConfigKey.ConsoleName.GetString();

            AdvancedScreen.tIP.Text = ConfigKey.IP.GetString();
            if (ConfigKey.IP.IsBlank() || ConfigKey.IP.IsDefault())
            {
                AdvancedScreen.tIP.Enabled = false;
                AdvancedScreen.xIP.Checked = false;
            }
            else
            {
                AdvancedScreen.tIP.Enabled = true;
                AdvancedScreen.xIP.Checked = true;
            }
            
            
            //Dragon stuffs
            var dragonString = ConfigKey.DragonDefault.GetString();
            if (dragonString == null || dragonString.Equals("Fire"))
            {
                MiscScreen.cboDragonDefault.SelectedIndex = 0;
            }
            else
            {
                MiscScreen.cboDragonDefault.SelectedIndex = MiscScreen.cboDragonDefault.FindStringExact(dragonString);
            }

            for (var x = 0; x <= 3; x++)
            {
                MiscScreen.clbDragonPermits.SetItemCheckState(x, CheckStateS(x));
            }
        }

        // TODO - Insert all CPE configs here
        void ApplyTabCpe()
        {
            CpeScreen.chkClickDistanceAllowed.Checked = ConfigKey.ClickDistanceEnabled.Enabled();
            #region CB
            CpeScreen.chkCustomBlocksAllowed.Checked = ConfigKey.CustomBlocksEnabled.Enabled();
            //var newItemList = clbBlocks.Items.Cast<bool>().ToList();
            var Confi = ConfigKey.CobbleSlabEnabled.Enabled();
            var clb = CpeScreen.clbBlocks;
            CpeScreen.clbBlocks.SetItemChecked(0, Bk(ConfigKey.CobbleSlabEnabled));
            CpeScreen.clbBlocks.SetItemChecked(1, Bk(ConfigKey.RopeEnabled));
            CpeScreen.clbBlocks.SetItemChecked(2, Bk(ConfigKey.SandstoneEnabled));
            CpeScreen.clbBlocks.SetItemChecked(3, Bk(ConfigKey.SnowEnabled));
            CpeScreen.clbBlocks.SetItemChecked(4, Bk(ConfigKey.FireEnabled));
            CpeScreen.clbBlocks.SetItemChecked(5, Bk(ConfigKey.LightPinkEnabled));
            CpeScreen.clbBlocks.SetItemChecked(6, Bk(ConfigKey.DarkGreenEnabled));
            CpeScreen.clbBlocks.SetItemChecked(7, Bk(ConfigKey.BrownEnabled));
            CpeScreen.clbBlocks.SetItemChecked(8, Bk(ConfigKey.DarkBlueEnabled));
            CpeScreen.clbBlocks.SetItemChecked(9, Bk(ConfigKey.TurquoiseEnabled));
            CpeScreen.clbBlocks.SetItemChecked(10, Bk(ConfigKey.IceEnabled));
            CpeScreen.clbBlocks.SetItemChecked(11, Bk(ConfigKey.TileEnabled));
            CpeScreen.clbBlocks.SetItemChecked(12, Bk(ConfigKey.MagmaEnabled));
            CpeScreen.clbBlocks.SetItemChecked(13, Bk(ConfigKey.PillarEnabled));
            CpeScreen.clbBlocks.SetItemChecked(14, Bk(ConfigKey.CrateEnabled));
            CpeScreen.clbBlocks.SetItemChecked(15, Bk(ConfigKey.StoneBrickEnabled));
            #endregion

            CpeScreen.chkHeldBlockAllowed.Checked = ConfigKey.HeldBlockEnabled.Enabled();

            #region MessageTypes

            CpeScreen.chkMessageTypeAllowed.Checked = ConfigKey.MessageTypeEnabled.Enabled();
            CpeScreen.chkAnnouncementMT.Checked = ConfigKey.AnnouncementsAtTop.Enabled();

            CpeScreen.chkBottomRight1.Checked = ConfigKey.Br1Enabled.Enabled();
            CpeScreen.txtBottomRight1.Text = ConfigKey.Br1Text.GetString() ?? ConfigKey.Br1Text.GetDefault().ToString();
            CpeScreen.chkBottomRight2.Checked = ConfigKey.Br2Enabled.Enabled();
            CpeScreen.txtBottomRight2.Text = ConfigKey.Br2Text.GetString() ?? ConfigKey.Br2Text.GetDefault().ToString();
            CpeScreen.chkBottomRight3.Checked = ConfigKey.Br3Enabled.Enabled();
            CpeScreen.txtBottomRight3.Text = ConfigKey.Br3Text.GetString() ?? ConfigKey.Br3Text.GetDefault().ToString();

            CpeScreen.chkStatus1.Checked = ConfigKey.Status1Enabled.Enabled();
            CpeScreen.txtStatus1.Text = ConfigKey.Status1Text.GetString() ?? ConfigKey.Status1Text.GetDefault().ToString();
            CpeScreen.chkStatus2.Checked = ConfigKey.Status2Enabled.Enabled();
            CpeScreen.txtStatus2.Text = ConfigKey.Status2Text.GetString() ?? ConfigKey.Status2Text.GetDefault().ToString();
            CpeScreen.chkStatus3.Checked = ConfigKey.Status3Enabled.Enabled();
            CpeScreen.txtStatus3.Text = ConfigKey.Status3Text.GetString() ?? ConfigKey.Status3Text.GetDefault().ToString();
            #endregion

            CpeScreen.chkEnvColorsAllowed.Checked = ConfigKey.EnvColorsEnabled.Enabled();
            CpeScreen.chkTimeBasedSky.Checked = ConfigKey.TimeSkyEnabled.Enabled();
            CpeScreen.numHourLength.Value = ConfigKey.GameTimeHourMinutes.GetInt();
        }
        private static bool Bk(ConfigKey cK)
        {
            return cK.Enabled();
        }
        static CheckState CheckStateS(int dragblock)
        {
            var desBool = false;
            switch (dragblock)
            {
                case 0:
                    desBool = ConfigKey.DragonFire.Enabled();
                    break;
                case 1:
                    desBool = ConfigKey.DragonMagma.Enabled();
                    break;
                case 2:
                    desBool = ConfigKey.DragonLava.Enabled();
                    break;
                case 3:
                    desBool = ConfigKey.DragonRed.Enabled();
                    break;
            }
            return desBool ? CheckState.Checked : CheckState.Unchecked;
        }
        static void ApplyEnum<TEnum>([NotNull] ComboBox box, ConfigKey key, TEnum def) where TEnum : struct
        {
            if (box == null) throw new ArgumentNullException(nameof(box));
            if (!typeof(TEnum).IsEnum) throw new ArgumentException("Enum type required");
            try
            {
                if (key.IsBlank())
                {
                    box.SelectedIndex = (int)(object)def;
                }
                else
                {
                    box.SelectedIndex = (int)Enum.Parse(typeof(TEnum), key.GetString(), true);
                }
            }
            catch (ArgumentException)
            {
                box.SelectedIndex = (int)(object)def;
            }
        }

        #endregion


        #region Saving Config

        internal static void SaveGeneral()
        {
            ConfigKey.ServerName.TrySetValue(GeneralScreen.tServerName.Text);
            ConfigKey.MOTD.TrySetValue(GeneralScreen.tMOTD.Text);
            ConfigKey.MaxPlayers.TrySetValue(GeneralScreen.nMaxPlayers.Value);
            ConfigKey.MaxPlayersPerWorld.TrySetValue(GeneralScreen.nMaxPlayersPerWorld.Value);

            ConfigKey.DefaultRank.TrySetValue(GeneralScreen.cDefaultRank.SelectedIndex == 0 ? "" : RankManager.DefaultRank.FullName);
            ConfigKey.IsPublic.TrySetValue(GeneralScreen.cPublic.SelectedIndex == 0);
            ConfigKey.Port.TrySetValue(GeneralScreen.nPort.Value);

            ConfigKey.UploadBandwidth.TrySetValue(GeneralScreen.nUploadBandwidth.Value);

            ConfigKey.AnnouncementInterval.TrySetValue(GeneralScreen.xAnnouncements.Checked ? GeneralScreen.nAnnouncements.Value : 0);
            /*
            // UpdaterSettingsWindow
            ConfigKey.UpdaterMode.TrySetValue(_updaterWindow.UpdaterMode);
            ConfigKey.BackupBeforeUpdate.TrySetValue(_updaterWindow.BackupBeforeUpdate);
            ConfigKey.RunBeforeUpdate.TrySetValue(_updaterWindow.RunBeforeUpdate);
            ConfigKey.RunAfterUpdate.TrySetValue(_updaterWindow.RunAfterUpdate);*/
        }

        internal static void SaveMisc()
        {
            ConfigKey.CustomChatName.TrySetValue(MiscScreen.CustomName.Text); // TODO - Move to SaveMisc()
            ConfigKey.SwearName.TrySetValue(MiscScreen.SwearBox.Text);
            // ConfigKey.CheckForUpdates.TrySetValue(checkUpdate.Checked.ToString());
            ConfigKey.WebsiteURL.TrySetValue(MiscScreen.websiteURL.Text);
            ConfigKey.CustomAliasName.TrySetValue(MiscScreen.CustomAliases.Text);
            ConfigKey.MaxCaps.TrySetValue(MiscScreen.MaxCapsValue.Value);

            ConfigKey.DragonDefault.TrySetValue(MiscScreen.cboDragonDefault.SelectedItem.ToString());
            ConfigKey.DragonFire.TrySetValue(MiscScreen.clbDragonPermits.GetItemChecked(0));
            ConfigKey.DragonMagma.TrySetValue(MiscScreen.clbDragonPermits.GetItemChecked(1));
            ConfigKey.DragonLava.TrySetValue(MiscScreen.clbDragonPermits.GetItemChecked(2));
            ConfigKey.DragonRed.TrySetValue(MiscScreen.clbDragonPermits.GetItemChecked(3));
            
            SaveWorldList();
            
        }

        internal static void SaveAdvanced()
        {
            if (AdvancedScreen.xIP.Checked)
            {
                ConfigKey.IP.TrySetValue(AdvancedScreen.tIP.Text);
            }
            else
            {
                ConfigKey.IP.ResetValue();
            }
            
            ConfigKey.RelayAllBlockUpdates.TrySetValue(AdvancedScreen.xRelayAllBlockUpdates.Checked);
            ConfigKey.NoPartialPositionUpdates.TrySetValue(AdvancedScreen.xNoPartialPositionUpdates.Checked);
            ConfigKey.TickInterval.TrySetValue(Convert.ToInt32(AdvancedScreen.nTickInterval.Value));

            switch (AdvancedScreen.cProcessPriority.SelectedIndex)
            {
                case 0:
                    ConfigKey.ProcessPriority.ResetValue(); break;
                case 1:
                    ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.High); break;
                case 2:
                    ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.AboveNormal); break;
                case 3:
                    ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.Normal); break;
                case 4:
                    ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.BelowNormal); break;
                case 5:
                    ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.Idle); break;
            }

            ConfigKey.BlockUpdateThrottling.TrySetValue(Convert.ToInt32(AdvancedScreen.nThrottling.Value));

            ConfigKey.LowLatencyMode.TrySetValue(AdvancedScreen.xLowLatencyMode.Checked);

            ConfigKey.AutoRankEnabled.TrySetValue(AdvancedScreen.xAutoRank.Checked);

            ConfigKey.MaxUndo.TrySetValue(AdvancedScreen.xMaxUndo.Checked ? Convert.ToInt32(AdvancedScreen.nMaxUndo.Value) : 0);
            ConfigKey.MaxUndoStates.TrySetValue(Convert.ToInt32(AdvancedScreen.nMaxUndoStates.Value));

            ConfigKey.ConsoleName.TrySetValue(AdvancedScreen.tConsoleName.Text);
        }

        internal static void SaveChat()
        {
            ConfigKey.SystemMessageColor.TrySetValue(Color.GetName(_colorSys));
            ConfigKey.CustomChatColor.TrySetValue(Color.GetName(_colorCustom));
            ConfigKey.HelpColor.TrySetValue(Color.GetName(_colorHelp));
            ConfigKey.SayColor.TrySetValue(Color.GetName(_colorSay));
            ConfigKey.AnnouncementColor.TrySetValue(Color.GetName(_colorAnnouncement));
            ConfigKey.PrivateMessageColor.TrySetValue(Color.GetName(_colorPm));
            ConfigKey.WarningColor.TrySetValue(Color.GetName(_colorWarning));
            ConfigKey.MeColor.TrySetValue(Color.GetName(_colorMe));
            ConfigKey.GlobalColor.TrySetValue(Color.GetName(_colorGlobal));
            ConfigKey.ShowJoinedWorldMessages.TrySetValue(ChatScreen.xShowJoinedWorldMessages.Checked);
            ConfigKey.RankColorsInWorldNames.TrySetValue(ChatScreen.xRankColorsInWorldNames.Checked);
            ConfigKey.RankColorsInChat.TrySetValue(ChatScreen.xRankColorsInChat.Checked);
            ConfigKey.RankPrefixesInChat.TrySetValue(ChatScreen.xRankPrefixesInChat.Checked);
            ConfigKey.RankPrefixesInList.TrySetValue(ChatScreen.xRankPrefixesInList.Checked);
            ConfigKey.ShowConnectionMessages.TrySetValue(ChatScreen.xShowConnectionMessages.Checked);
        }

        internal static void SaveWorlds()
        {
            ConfigKey.DefaultBuildRank.TrySetValue(WorldScreen.cDefaultBuildRank.SelectedIndex == 0
                ? ""
                : RankManager.DefaultBuildRank.FullName);

            ConfigKey.MapPath.TrySetValue(WorldScreen.xMapPath.Checked ? WorldScreen.tMapPath.Text : ConfigKey.MapPath.GetDefault());

            ConfigKey.WoMEnableEnvExtensions.TrySetValue(WorldScreen.xWoMEnableEnvExtensions.Checked);
            ConfigKey.PrisonEnabled.TrySetValue(WorldScreen.mcbPrison.Checked);
        }

        internal static void SaveSecurity()
        {
            ConfigKey.OnTheGoPassword.TrySetValue(SecurityScreen.txtRemotePass.Text);
            WriteEnum<NameVerificationMode>(SecurityScreen.cVerifyNames, ConfigKey.VerifyNames);

            ConfigKey.MaxConnectionsPerIP.TrySetValue(SecurityScreen.xMaxConnectionsPerIP.Checked ? SecurityScreen.nMaxConnectionsPerIP.Value : 0);
            ConfigKey.AllowUnverifiedLAN.TrySetValue(SecurityScreen.xAllowUnverifiedLAN.Checked);

            ConfigKey.AntispamMessageCount.TrySetValue(SecurityScreen.nAntispamMessageCount.Value);
            ConfigKey.AntispamInterval.TrySetValue(SecurityScreen.nAntispamInterval.Value);
            ConfigKey.AntispamMuteDuration.TrySetValue(SecurityScreen.nSpamMute.Value);

            ConfigKey.AntispamMaxWarnings.TrySetValue(SecurityScreen.xAntispamKicks.Checked ? SecurityScreen.nAntispamMaxWarnings.Value : 0);

            ConfigKey.RequireKickReason.TrySetValue(SecurityScreen.xRequireKickReason.Checked);
            ConfigKey.RequireBanReason.TrySetValue(SecurityScreen.xRequireBanReason.Checked);
            ConfigKey.RequireRankChangeReason.TrySetValue(SecurityScreen.xRequireRankChangeReason.Checked);
            ConfigKey.AnnounceKickAndBanReasons.TrySetValue(SecurityScreen.xAnnounceKickAndBanReasons.Checked);
            ConfigKey.AnnounceRankChanges.TrySetValue(SecurityScreen.xAnnounceRankChanges.Checked);
            ConfigKey.AnnounceRankChangeReasons.TrySetValue(SecurityScreen.xAnnounceRankChangeReasons.Checked);

            ConfigKey.PatrolledRank.TrySetValue(SecurityScreen.cPatrolledRank.SelectedIndex == 0
                ? ""
                : RankManager.PatrolledRank.FullName);

            ConfigKey.BlockDBEnabled.TrySetValue(SecurityScreen.xBlockDBEnabled.Checked);
            ConfigKey.BlockDBAutoEnable.TrySetValue(SecurityScreen.xBlockDBAutoEnable.Checked);
            ConfigKey.BlockDBAutoEnableRank.TrySetValue(SecurityScreen.cBlockDBAutoEnableRank.SelectedIndex == 0
                ? ""
                : RankManager.BlockDbAutoEnableRank.FullName);
        }

        internal static void SaveSavingAndBackup()
        {
            ConfigKey.SaveInterval.TrySetValue(SavingBackupScreen.xSaveInterval.Checked ? SavingBackupScreen.nSaveInterval.Value : 0);
            ConfigKey.BackupOnStartup.TrySetValue(SavingBackupScreen.xBackupOnStartup.Checked);
            ConfigKey.BackupOnJoin.TrySetValue(SavingBackupScreen.xBackupOnJoin.Checked);
            ConfigKey.BackupOnlyWhenChanged.TrySetValue(SavingBackupScreen.xBackupOnlyWhenChanged.Checked);

            ConfigKey.DefaultBackupInterval.TrySetValue(SavingBackupScreen.xBackupInterval.Checked ? SavingBackupScreen.nBackupInterval.Value : 0);
            ConfigKey.MaxBackups.TrySetValue(SavingBackupScreen.xMaxBackups.Checked ? SavingBackupScreen.nMaxBackups.Value : 0);
            ConfigKey.MaxBackupSize.TrySetValue(SavingBackupScreen.xMaxBackupSize.Checked ? SavingBackupScreen.nMaxBackupSize.Value : 0);

            ConfigKey.BackupDataOnStartup.TrySetValue(SavingBackupScreen.xBackupDataOnStartup.Checked);
        }

        internal static void SaveLogging()
        {
            WriteEnum<LogSplittingType>(LoggingScreen.cLogMode, ConfigKey.LogMode);
            if (LoggingScreen.xLogLimit.Checked) ConfigKey.MaxLogs.TrySetValue(LoggingScreen.nLogLimit.Value);
            else ConfigKey.MaxLogs.TrySetValue("0");
            foreach (ListViewItem item in LoggingScreen.vConsoleOptions.Items)
            {
                Logger.ConsoleOptions[item.Index] = item.Checked;
            }
            foreach (ListViewItem item in LoggingScreen.vLogFileOptions.Items)
            {
                Logger.LogFileOptions[item.Index] = item.Checked;
            }
        }

        internal static void SaveIrc()
        {
            ConfigKey.IRCBotEnabled.TrySetValue(IrcScreen.xIRCBotEnabled.Checked);

            ConfigKey.IRCBotNetwork.TrySetValue(IrcScreen.tIRCBotNetwork.Text);
            ConfigKey.IRCBotPort.TrySetValue(IrcScreen.nIRCBotPort.Value);
            ConfigKey.IRCDelay.TrySetValue(IrcScreen.nIRCDelay.Value);

            ConfigKey.IRCBotChannels.TrySetValue(IrcScreen.tIRCBotChannels.Text);

            ConfigKey.IRCBotNick.TrySetValue(IrcScreen.tIRCBotNick.Text);
            ConfigKey.IRCRegisteredNick.TrySetValue(IrcScreen.xIRCRegisteredNick.Checked);
            ConfigKey.IRCNickServ.TrySetValue(IrcScreen.tIRCNickServ.Text);
            ConfigKey.IRCNickServMessage.TrySetValue(IrcScreen.tIRCNickServMessage.Text);

            ConfigKey.IRCBotAnnounceIRCJoins.TrySetValue(IrcScreen.xIRCBotAnnounceIRCJoins.Checked);
            ConfigKey.IRCBotAnnounceServerJoins.TrySetValue(IrcScreen.xIRCBotAnnounceServerJoins.Checked);
            ConfigKey.IRCBotAnnounceServerEvents.TrySetValue(IrcScreen.xIRCBotAnnounceServerEvents.Checked);
            ConfigKey.IRCBotForwardFromIRC.TrySetValue(IrcScreen.xIRCBotForwardFromIRC.Checked);
            ConfigKey.IRCBotForwardFromServer.TrySetValue(IrcScreen.xIRCBotForwardFromServer.Checked);

            ConfigKey.IRCMessageColor.TrySetValue(Color.GetName(_colorIrc));
            ConfigKey.IRCUseColor.TrySetValue(IrcScreen.xIRCUseColor.Checked);

            ConfigKey.IRCBotNetworkPass.TrySetValue(IrcScreen.tServPass.Text);
            ConfigKey.IRCChannelPassword.TrySetValue(IrcScreen.tChanPass.Text);
        }

        internal static void SaveCpe()
        {
            //CPE
            //TODO insert all CPE configs
            ConfigKey.ClickDistanceEnabled.TrySetValue(CpeScreen.chkClickDistanceAllowed.Checked);
            #region CB
            ConfigKey.CustomBlocksEnabled.TrySetValue(CpeScreen.chkCustomBlocksAllowed.Checked);
            ConfigKey.CobbleSlabEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(0));
            ConfigKey.RopeEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(1));
            ConfigKey.SandstoneEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(2));
            ConfigKey.SnowEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(3));
            ConfigKey.FireEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(4));
            ConfigKey.LightPinkEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(5));
            ConfigKey.DarkGreenEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(6));
            ConfigKey.BrownEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(7));
            ConfigKey.DarkBlueEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(8));
            ConfigKey.TurquoiseEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(9));
            ConfigKey.IceEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(10));
            ConfigKey.TileEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(11));
            ConfigKey.MagmaEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(12));
            ConfigKey.PillarEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(13));
            ConfigKey.CrateEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(14));
            ConfigKey.StoneBrickEnabled.TrySetValue(CpeScreen.clbBlocks.GetItemChecked(15));
            #endregion

            #region MessageTypes

            ConfigKey.AnnouncementsAtTop.TrySetValue(CpeScreen.chkAnnouncementMT.Checked);
            ConfigKey.MessageTypeEnabled.TrySetValue(CpeScreen.chkMessageTypeAllowed.Checked);

            ConfigKey.Br1Enabled.TrySetValue(CpeScreen.chkBottomRight1.Checked);
            ConfigKey.Br1Text.TrySetValue(CpeScreen.txtBottomRight1.Text ?? ConfigKey.Br1Text.GetDefault().ToString());
            ConfigKey.Br2Enabled.TrySetValue(CpeScreen.chkBottomRight2.Checked);
            ConfigKey.Br2Text.TrySetValue(CpeScreen.txtBottomRight2.Text ?? ConfigKey.Br2Text.GetDefault().ToString());
            ConfigKey.Br3Enabled.TrySetValue(CpeScreen.chkBottomRight3.Checked);
            ConfigKey.Br3Text.TrySetValue(CpeScreen.txtBottomRight3.Text ?? ConfigKey.Br3Text.GetDefault().ToString());

            ConfigKey.Status1Enabled.TrySetValue(CpeScreen.chkStatus1.Checked);
            ConfigKey.Status1Text.TrySetValue(CpeScreen.txtStatus1.Text ?? ConfigKey.Status1Text.GetDefault().ToString());
            ConfigKey.Status2Enabled.TrySetValue(CpeScreen.chkStatus2.Checked);
            ConfigKey.Status2Text.TrySetValue(CpeScreen.txtStatus2.Text ?? ConfigKey.Status2Text.GetDefault().ToString());
            ConfigKey.Status3Enabled.TrySetValue(CpeScreen.chkStatus3.Checked);
            ConfigKey.Status3Text.TrySetValue(CpeScreen.txtStatus3.Text ?? ConfigKey.Status3Text.GetDefault().ToString());
            #endregion

            ConfigKey.EnvColorsEnabled.TrySetValue(CpeScreen.chkEnvColorsAllowed.Checked);
            ConfigKey.TimeSkyEnabled.TrySetValue(CpeScreen.chkTimeBasedSky.Checked);
            ConfigKey.GameTimeHourMinutes.TrySetValue(CpeScreen.numHourLength.Value);
        }

        internal static void SaveConfig()
        {
            SaveChat();
            SaveAdvanced();
            SaveCpe();
            SaveGeneral();
            SaveIrc();
            SaveLogging();
            SaveMisc();
            SaveSavingAndBackup();
            SaveSecurity();
            SaveWorlds();
            Config.Save();
        }

        private readonly ConfigKey[] _cbConfigs = {
            ConfigKey.CobbleSlabEnabled, ConfigKey.RopeEnabled, ConfigKey.SandstoneEnabled,
            ConfigKey.SnowEnabled, ConfigKey.FireEnabled, ConfigKey.LightPinkEnabled, ConfigKey.DarkGreenEnabled,
            ConfigKey.BrownEnabled, ConfigKey.DarkBlueEnabled, ConfigKey.TurquoiseEnabled, ConfigKey.IceEnabled,
            ConfigKey.TileEnabled, ConfigKey.MagmaEnabled, ConfigKey.PillarEnabled, ConfigKey.CrateEnabled,
            ConfigKey.StoneBrickEnabled, ConfigKey.DefaultRank // Last item never used to protect against exception
        };

        private ConfigKey MyConfig(int i)
        {
            return _cbConfigs[i];
        }
        private int MyIntConfig(ConfigKey cK)
        {
            var intLoop = 0;
            foreach (var ck in _cbConfigs)
            {
                if (cK.Equals(ck))
                {
                    return intLoop;
                }
                intLoop++;
            }
            return -1;
        }

        static void SaveWorldList()
        {
            const string worldListTempFileName = Paths.WorldListFileName + ".tmp";
            try
            {
                XDocument doc = new XDocument();
                XElement root = new XElement("fCraftWorldList");
                foreach (WorldListEntry world in ConfigModule.Worlds)
                {
                    root.Add(world.Serialize());
                }
                if (WorldScreen.cMainWorld.SelectedItem != null)
                {
                    root.Add(new XAttribute("main", WorldScreen.cMainWorld.SelectedItem));
                }
                if (WorldScreen.mcbPrison.Enabled)
                {
                    var ws = WorldScreen;
                    var cP = ws.cboPrison;
                    var si = cP.SelectedItem;
                    if (si != null) PrisonData.Obj.World = WorldScreen.cboPrison.SelectedItem.ToString();
                    if (!Directory.Exists("Prison/")) Directory.CreateDirectory("Prison/");
                    PrisonData.SaveData();
                }
                doc.Add(root);
                doc.Save(worldListTempFileName);
                Paths.MoveOrReplace(worldListTempFileName, Paths.WorldListFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occured while trying to save world list ({Paths.WorldListFileName}): {Environment.NewLine}{ex}");
            }
        }


        static void WriteEnum<TEnum>([NotNull] ComboBox box, ConfigKey key) where TEnum : struct
        {
            if (box == null) throw new ArgumentNullException("box");
            if (!typeof(TEnum).IsEnum) throw new ArgumentException("Enum type required");
            try
            {
                TEnum val = (TEnum)Enum.Parse(typeof(TEnum), box.SelectedIndex.ToString(), true);
                key.TrySetValue(val);
            }
            catch (ArgumentException)
            {
                Logger.Log(LogType.Error,
                            "ConfigUI.WriteEnum<{0}>: Could not parse value for {1}. Using default ({2}).",
                            typeof(TEnum).Name, key, key.GetString());
            }
        }

        #endregion
    }
}
