using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using fCraft.ServerGUI;
using GemsCraftGUI.ConfigGUI;
using GemsCraftGUI.Properties;
using GemsCraftGUI.ServerGUI;
using JetBrains.Annotations;
using Color = System.Drawing.Color;
using MetroFramework.Forms;
using static GemsCraftGUI.Program;

namespace GemsCraftGUI.ConfigGUI.GUITabs
{
    public class ConfigModule
    {
        internal static MainForm _instance;
        internal static Font _bold;
        internal static Rank _selectedRank;
        internal static UpdaterSettingsPopup _updaterWindow = new UpdaterSettingsPopup();
        internal static readonly SortableBindingList<WorldListEntry> Worlds = new SortableBindingList<WorldListEntry>();
        
        #region Handlers
        //Fixes all event handlers that were lost on the GUI switch
        void ConfigEventHandlers()
        {
            //All the Config Handlers
            //this.HeartBeatUrlComboBox.SelectedIndexChanged += new System.EventHandler(this.HeartBeatUrlComboBox_SelectedIndexChanged);

            // GeneralScreen 
            GeneralScreen.nMaxPlayersPerWorld.Validating += nMaxPlayerPerWorld_Validating;
            GeneralScreen.cDefaultRank.SelectedIndexChanged += cDefaultRank_SelectedIndexChanged;
            GeneralScreen.bMeasure.Click += bMeasure_Click;
            GeneralScreen.nMaxPlayers.ValueChanged += new System.EventHandler(this.nMaxPlayers_ValueChanged);
            GeneralScreen.bChangelog.Click += new System.EventHandler(this.bChangelog_Click);
            GeneralScreen.bCredits.Click += new System.EventHandler(this.bCredits_Click);
            GeneralScreen.bReadme.Click += new System.EventHandler(this.bReadme_Click);
            GeneralScreen.bGreeting.Click += new System.EventHandler(this.bGreeting_Click);
            GeneralScreen.xAnnouncements.CheckedChanged += new System.EventHandler(this.xAnnouncements_CheckedChanged);
            GeneralScreen.bRules.Click += new System.EventHandler(this.bRules_Click);
            GeneralScreen.bAnnouncements.Click += new System.EventHandler(this.bAnnouncements_Click);

            // ChatScreen
            ChatScreen.xRankPrefixesInChat.CheckedChanged += new System.EventHandler(this.xRankPrefixesInChat_CheckedChanged);
            ChatScreen.bColorMe.Click += new System.EventHandler(this.bColorMe_Click);
            ChatScreen.bColorWarning.Click += new System.EventHandler(this.bColorWarning_Click);
            ChatScreen.bColorSys.Click += new System.EventHandler(this.bColorSys_Click);
            ChatScreen.bColorPM.Click += new System.EventHandler(this.bColorPM_Click);
            ChatScreen.bColorAnnouncement.Click += new System.EventHandler(this.bColorAnnouncement_Click);
            ChatScreen.bColorHelp.Click += new System.EventHandler(this.bColorHelp_Click);
            ChatScreen.bColorSay.Click += new System.EventHandler(this.bColorSay_Click);
            ChatScreen.bColorGlobal.Click += new System.EventHandler(this.bColorGlobal_Click);

            // WorldScreen
            WorldScreen.bMapPath.Click += new System.EventHandler(this.bMapPath_Click);
            WorldScreen.xMapPath.CheckedChanged += new System.EventHandler(this.xMapPath_CheckedChanged);
            WorldScreen.cDefaultBuildRank.SelectedIndexChanged += new System.EventHandler(this.cDefaultBuildRank_SelectedIndexChanged);
            WorldScreen.bWorldEdit.Click += new System.EventHandler(this.bWorldEdit_Click);
            WorldScreen.bAddWorld.Click += new System.EventHandler(this.bAddWorld_Click);
            WorldScreen.bWorldDelete.Click += new System.EventHandler(this.bWorldDel_Click);
            WorldScreen.dgvWorlds.SelectionChanged += new System.EventHandler(this.dgvWorlds_Click);
            WorldScreen.dgvWorlds.Click += new System.EventHandler(this.dgvWorlds_Click);

            // RankScreen
            RankScreen.bLowerRank.Click += new System.EventHandler(this.bLowerRank_Click);
            RankScreen.bRaiseRank.Click += new System.EventHandler(this.bRaiseRank_Click);
            RankScreen.nFillLimit.ValueChanged += new System.EventHandler(this.nFillLimit_ValueChanged);
            RankScreen.nCopyPasteSlots.ValueChanged += new System.EventHandler(this.nCopyPasteSlots_ValueChanged);
            RankScreen.xAllowSecurityCircumvention.CheckedChanged += new System.EventHandler(this.xAllowSecurityCircumvention_CheckedChanged);
            RankScreen.nAntiGriefSeconds.ValueChanged += new System.EventHandler(this.nAntiGriefSeconds_ValueChanged);
            RankScreen.bColorRank.Click += new System.EventHandler(this.bColorRank_Click);
            RankScreen.xDrawLimit.CheckedChanged += new System.EventHandler(this.xDrawLimit_CheckedChanged);
            RankScreen.nDrawLimit.ValueChanged += new System.EventHandler(this.nDrawLimit_ValueChanged);
            RankScreen.nKickIdle.ValueChanged += new System.EventHandler(this.nKickIdle_ValueChanged);
            RankScreen.xAntiGrief.CheckedChanged += new System.EventHandler(this.xAntiGrief_CheckedChanged);
            RankScreen.xKickIdle.CheckedChanged += new System.EventHandler(this.xKickIdle_CheckedChanged);
            RankScreen.nAntiGriefBlocks.ValueChanged += new System.EventHandler(this.nAntiGriefBlocks_ValueChanged);
            RankScreen.xReserveSlot.CheckedChanged += new System.EventHandler(this.xReserveSlot_CheckedChanged);
            RankScreen.tPrefix.Validating += new System.ComponentModel.CancelEventHandler(this.tPrefix_Validating);
            RankScreen.tRankName.Validating += new System.ComponentModel.CancelEventHandler(this.tRankName_Validating);
            RankScreen.bDeleteRank.Click += new System.EventHandler(this.bDeleteRank_Click);
            RankScreen.vPermissions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.vPermissions_ItemChecked);
            RankScreen.bAddRank.Click += new System.EventHandler(this.bAddRank_Click);
            RankScreen.vRanks.SelectedIndexChanged += new System.EventHandler(this.vRanks_SelectedIndexChanged);

            // SecurityScreen
            SecurityScreen.cBlockDBAutoEnableRank.SelectedIndexChanged += new System.EventHandler(this.cBlockDBAutoEnableRank_SelectedIndexChanged);
            SecurityScreen.xBlockDBAutoEnable.CheckedChanged += new System.EventHandler(this.xBlockDBAutoEnable_CheckedChanged);
            SecurityScreen.xBlockDBEnabled.CheckedChanged += new System.EventHandler(this.xBlockDBEnabled_CheckedChanged);
            SecurityScreen.cPatrolledRank.SelectedIndexChanged += new System.EventHandler(this.cPatrolledRank_SelectedIndexChanged);
            SecurityScreen.xAnnounceRankChanges.CheckedChanged += new System.EventHandler(this.xAnnounceRankChanges_CheckedChanged);
            SecurityScreen.xAntispamKicks.CheckedChanged += new System.EventHandler(this.xSpamChatKick_CheckedChanged);
            SecurityScreen.xMaxConnectionsPerIP.CheckedChanged += new System.EventHandler(this.xMaxConnectionsPerIP_CheckedChanged);
            SecurityScreen.cVerifyNames.SelectedIndexChanged += new System.EventHandler(this.cVerifyNames_SelectedIndexChanged);

            // SavingBackupScreen
            SavingBackupScreen.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            SavingBackupScreen.xSaveInterval.CheckedChanged += new System.EventHandler(this.xSaveAtInterval_CheckedChanged);
            SavingBackupScreen.xMaxBackupSize.CheckedChanged += new System.EventHandler(this.xMaxBackupSize_CheckedChanged);
            SavingBackupScreen.xMaxBackups.CheckedChanged += new System.EventHandler(this.xMaxBackups_CheckedChanged);
            SavingBackupScreen.xBackupInterval.CheckedChanged += new System.EventHandler(this.xBackupAtInterval_CheckedChanged);

            // LoggingScreen
            LoggingScreen.xLogLimit.CheckedChanged += new System.EventHandler(this.xLogLimit_CheckedChanged);
            LoggingScreen.vLogFileOptions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.vLogFileOptions_ItemChecked);
            LoggingScreen.vConsoleOptions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.vConsoleOptions_ItemChecked);

            // IrcScreen
            IrcScreen.xServPass.CheckedChanged += new System.EventHandler(this.xServPass_CheckedChanged);
            IrcScreen.xChanPass.CheckedChanged += new System.EventHandler(this.xChanPass_CheckedChanged);
            IrcScreen.xIRCListShowNonEnglish.CheckedChanged += new System.EventHandler(this.xIRCListShowNonEnglish_CheckedChanged);
            IrcScreen.bColorIRC.Click += new System.EventHandler(this.bColorIRC_Click);
            IrcScreen.xIRCRegisteredNick.CheckedChanged += new System.EventHandler(this.xIRCRegisteredNick_CheckedChanged);
            IrcScreen.xIRCBotEnabled.CheckedChanged += new System.EventHandler(this.xIRC_CheckedChanged);
            IrcScreen.cIRCList.SelectedIndexChanged += new System.EventHandler(this.cIRCList_SelectedIndexChanged);

            // AdvancedScreen
            AdvancedScreen.nMaxUndoStates.ValueChanged += new System.EventHandler(this.nMaxUndo_ValueChanged);
            AdvancedScreen.tIP.Validating += new System.ComponentModel.CancelEventHandler(this.tIP_Validating);
            AdvancedScreen.xIP.CheckedChanged += new System.EventHandler(this.xIP_CheckedChanged);
            AdvancedScreen.nMaxUndo.ValueChanged += new System.EventHandler(this.nMaxUndo_ValueChanged);
            AdvancedScreen.xMaxUndo.CheckedChanged += new System.EventHandler(this.xMaxUndo_CheckedChanged);
            
            // MiscScreen
            MiscScreen.websiteURL.TextChanged += new System.EventHandler(this.websiteURL_TextChanged);
            MiscScreen.ReqsEditor.Click += new System.EventHandler(this.ReqsEditor_Click);
            MiscScreen.SwearEditor.Click += new System.EventHandler(this.SwearEditor_Click);
            MiscScreen.CustomColor.Click += new System.EventHandler(this.button1_Click);
            MiscScreen.CustomText.Click += new System.EventHandler(this.label1_Click);

            
           /* MainForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigUI_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);*/
        }

        void StartServerHandlers()
        {
            //Server Handlers
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            this.bVoice.Click += new System.EventHandler(this.bVoice_Click);
        }

        private void nMaxPlayerPerWorld_Validating(object sender, CancelEventArgs e)
        {
            CheckMaxPlayersPerWorldValue();
        }

        private void cDefaultRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.DefaultRank = RankManager.FindRank(GeneralScreen.cDefaultRank.SelectedIndex - 1);
        }

        private void bMeasure_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.speedtest.net/");
        }

        private void bAnnouncements_Click(object sender, EventArgs e)
        {
            var popup = new TextEditorPopup(Paths.AnnouncementsFileName, "");
            popup.ShowDialog();
        }

        private void xAnnouncements_CheckedChanged(object sender, EventArgs e)
        {
            nAnnouncements.Enabled = xAnnouncements.Checked;
            bAnnouncements.Enabled = xAnnouncements.Checked;
        }

        private void tIP_Validating(object sender, CancelEventArgs e)
        {
            IPAddress ip;
            if (Server.IsIp(tIP.Text) && IPAddress.TryParse(tIP.Text, out ip))
            {
                tIP.ForeColor = SystemColors.ControlText;
            }
            else
            {
                tIP.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void xIP_CheckedChanged(object sender, EventArgs e)
        {
            tIP.Enabled = xIP.Checked;
        }

        private void bGreeting_Click(object sender, EventArgs e)
        {
            var popup = new TextEditorPopup(Paths.GreetingFileName,
@"Welcome to {SERVER_NAME}
Your rank is {RANK}&S. Type &H/Help&S for help.");
            popup.ShowDialog();
        }
        

        private void nMaxPlayers_ValueChanged(object sender, EventArgs e)
        {
            CheckMaxPlayersPerWorldValue();
        }

        private void bCredits_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
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

        private void bRules_Click(object sender, EventArgs e)
        {
            TextEditorPopup popup = new TextEditorPopup(Paths.RulesFileName, "Use common sense!");
            popup.ShowDialog();
        }

        private void xRankPrefixesInChat_CheckedChanged(object sender, EventArgs e)
        {
            UsePrefixes = xRankPrefixesInChat.Checked;
            tPrefix.Enabled = UsePrefixes;
            lPrefix.Enabled = UsePrefixes;
            RebuildRankList();
        }

        int _colorSys, _colorSay, _colorHelp, _colorAnnouncement, _colorPm, _colorIrc, _colorMe, _colorWarning, _colorCustom, _colorGlobal;

        void ApplyColor(Button button, int color)
        {
            button.Text = fCraft.Color.GetName(color);
            button.BackColor = ColorPicker.ColorPairs[color].Background;
            button.ForeColor = ColorPicker.ColorPairs[color].Foreground;
            bApply.Enabled = true;
        }

        private void bColorSys_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("System message color", _colorSys);
            picker.ShowDialog();
            _colorSys = picker.ColorIndex;
            ApplyColor(bColorSys, _colorSys);
            fCraft.Color.Sys = fCraft.Color.Parse(_colorSys);
        }

        private void bColorHelp_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Help message color", _colorHelp);
            picker.ShowDialog();
            _colorHelp = picker.ColorIndex;
            ApplyColor(bColorHelp, _colorHelp);
            fCraft.Color.Help = fCraft.Color.Parse(_colorHelp);
        }

        private void bColorSay_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("/Say message color", _colorSay);
            picker.ShowDialog();
            _colorSay = picker.ColorIndex;
            ApplyColor(bColorSay, _colorSay);
            fCraft.Color.Say = fCraft.Color.Parse(_colorSay);
        }

        private void bColorAnnouncement_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Announcement color", _colorAnnouncement);
            picker.ShowDialog();
            _colorAnnouncement = picker.ColorIndex;
            ApplyColor(bColorAnnouncement, _colorAnnouncement);
            fCraft.Color.Announcement = fCraft.Color.Parse(_colorAnnouncement);
        }

        private void bColorPM_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Private / rank chat color", _colorPm);
            picker.ShowDialog();
            _colorPm = picker.ColorIndex;
            ApplyColor(bColorPM, _colorPm);
            fCraft.Color.PM = fCraft.Color.Parse(_colorPm);
        }

        private void bColorWarning_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Warning / Error message color", _colorWarning);
            picker.ShowDialog();
            _colorWarning = picker.ColorIndex;
            ApplyColor(bColorWarning, _colorWarning);
            fCraft.Color.Warning = fCraft.Color.Parse(_colorWarning);
        }

        private void bColorMe_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("/Me command color", _colorMe);
            picker.ShowDialog();
            _colorMe = picker.ColorIndex;
            ApplyColor(bColorMe, _colorMe);
            fCraft.Color.Me = fCraft.Color.Parse(_colorMe);
        }

        private void bColorIRC_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("IRC message color", _colorIrc);
            picker.ShowDialog();
            _colorIrc = picker.ColorIndex;
            ApplyColor(bColorIRC, _colorIrc);
            fCraft.Color.IRC = fCraft.Color.Parse(_colorIrc);
        }

        private void bColorGlobal_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Global message color", _colorGlobal);
            picker.ShowDialog();
            _colorGlobal = picker.ColorIndex;
            ApplyColor(bColorGlobal, _colorGlobal);
            fCraft.Color.Global = fCraft.Color.Parse(_colorGlobal);
        }

        private void bColorRank_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Rank color for \"" + _selectedRank.Name + "\"", fCraft.Color.ParseToIndex(_selectedRank.Color));
            picker.ShowDialog();
            ApplyColor(bColorRank, picker.ColorIndex);
            _selectedRank.Color = fCraft.Color.Parse(picker.ColorIndex);
        }


        void HandleTabChatChange(object sender, EventArgs args)
        {
            UpdateChatPreview();
        }

        void UpdateChatPreview()
        {
            List<string> lines = new List<string>();
            if (xShowConnectionMessages.Checked)
            {
                lines.Add(String.Format("&SPlayer {0}{1}LeChosenOne&S connected, joined {2}{3}main",
                                          xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : "",
                                          xRankColorsInWorldNames.Checked ? RankManager.LowestRank.Color : "",
                                          xRankPrefixesInChat.Checked ? RankManager.LowestRank.Prefix : ""));
            }
            lines.Add("&R<*- This is an announcement -*>");
            lines.Add("&YThis is a /say announcement");
            lines.Add(String.Format("{0}{1}LeChosenOne&F: This is a normal chat message",
                                      xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                      xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            lines.Add("&Pfrom Dingus: This is a private message /whisper");
            lines.Add("&M*LeChosenOne is using /Me to write this");
            if (xShowJoinedWorldMessages.Checked)
            {
                Rank midRank = RankManager.LowestRank;
                if (RankManager.LowestRank.NextRankUp != null)
                {
                    midRank = RankManager.LowestRank.NextRankUp;
                }

                lines.Add(String.Format("&SPlayer {0}{1}Dingus&S joined {2}{3}SomeOtherMap",
                                          xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : "",
                                          xRankColorsInWorldNames.Checked ? midRank.Color : "",
                                          xRankPrefixesInChat.Checked ? midRank.Prefix : ""));
            }
            lines.Add("&SUnknown command \"kikc\", see &H/Commands");
            if (xAnnounceKickAndBanReasons.Checked)
            {
                lines.Add(String.Format("&W{0}{1}LeChosenOne&W was kicked by {0}{1}Dingus&W: Reason goes here",
                                          xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }
            else
            {
                lines.Add(String.Format("&W{0}{1}CopperPenquin96&W was kicked by {0}{1}gamer1",
                                          xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }

            if (xShowConnectionMessages.Checked)
            {
                lines.Add(String.Format("&S{0}{1}Bob&S left the server.",
                                          xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }

            chatPreview1.SetText(lines.ToArray());
        }

        void WorldListErrorHandler(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                string columnName = dgvWorlds.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show(e.Exception.Message, "Error editing " + columnName);
            }
            else
            {
                MessageBox.Show(e.Exception.ToString(), "An error occured in the world list");
            }
        }

        private void bAddWorld_Click(object sender, EventArgs e)
        {
            AddWorldPopup popup = new AddWorldPopup(null);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                Worlds.Add(popup.World);
                popup.World.LoadedBy = WorldListEntry.WorldInfoSignature;
                popup.World.LoadedOn = DateTime.UtcNow;
            }
            if (cMainWorld.SelectedItem == null)
            {
                FillWorldList();
                if (cMainWorld.Items.Count > 0)
                {
                    cMainWorld.SelectedIndex = 0;
                }
            }
            else
            {
                string mainWorldName = cMainWorld.SelectedItem.ToString();
                FillWorldList();
                cMainWorld.SelectedItem = mainWorldName;
            }
        }

        private void bWorldEdit_Click(object sender, EventArgs e)
        {
            AddWorldPopup popup = new AddWorldPopup(Worlds[dgvWorlds.SelectedRows[0].Index]);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                string oldName = Worlds[dgvWorlds.SelectedRows[0].Index].Name;
                Worlds[dgvWorlds.SelectedRows[0].Index] = popup.World;
                HandleWorldRename(oldName, popup.World.Name);
            }
        }

        private void dgvWorlds_Click(object sender, EventArgs e)
        {
            bool oneRowSelected = (dgvWorlds.SelectedRows.Count == 1);
            bWorldDelete.Enabled = oneRowSelected;
            bWorldEdit.Enabled = oneRowSelected;
        }

        private void bWorldDel_Click(object sender, EventArgs e)
        {
            if (dgvWorlds.SelectedRows.Count > 0)
            {
                WorldListEntry world = Worlds[dgvWorlds.SelectedRows[0].Index];

                // prompt to delete map file, if it exists
                if (File.Exists(world.FullFileName))
                {
                    string promptMessage = String.Format("Are you sure you want to delete world \"{0}\"?", world.Name);

                    if (MessageBox.Show(promptMessage, "Deleting a world", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    string fileDeleteWarning = "Do you want to delete the map file (" + world.FileName + ") as well?";
                    if (MessageBox.Show(fileDeleteWarning, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(world.FullFileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("You have to delete the file (" + world.FileName + ") manually. " +
                                             "An error occured while trying to delete it automatically:" + Environment.NewLine + ex,
                                             "Could not delete map file");
                        }
                    }
                }

                Worlds.Remove(world);

                if (cMainWorld.SelectedItem == null)
                {
                    // deleting non-main world
                    FillWorldList();
                    if (cMainWorld.Items.Count > 0)
                    {
                        cMainWorld.SelectedIndex = 0;
                    }

                }
                else
                {
                    // deleting main world
                    string mainWorldName = cMainWorld.SelectedItem.ToString();
                    FillWorldList();
                    if (mainWorldName == world.Name)
                    {
                        MessageBox.Show("Main world has been reset.");
                        if (cMainWorld.Items.Count > 0)
                        {
                            cMainWorld.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        cMainWorld.SelectedItem = mainWorldName;
                    }
                }
            }
        }

        private void bMapPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                SelectedPath = tMapPath.Text,
                Description = "Select a directory to save map files to"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tMapPath.Text = dialog.SelectedPath;
            }
        }

        private void nMaxUndo_ValueChanged(object sender, EventArgs e)
        {
            if (xMaxUndo.Checked)
            {
                var maxMemUsage = Math.Ceiling(nMaxUndoStates.Value * (nMaxUndo.Value * 8) / (1024 * 1024));
                lMaxUndoUnits.Text = string.Format("blocks each (up to {0} MB of RAM per player)", maxMemUsage);
            }
            else
            {
                lMaxUndoUnits.Text = "blocks each";
            }
        }

        private void xMaxUndo_CheckedChanged(object sender, EventArgs e)
        {
            nMaxUndo.Enabled = xMaxUndo.Checked;
            lMaxUndoUnits.Enabled = xMaxUndo.Checked;
        }

        private void xMapPath_CheckedChanged(object sender, EventArgs e)
        {
            tMapPath.Enabled = xMapPath.Checked;
            bMapPath.Enabled = xMapPath.Checked;
        }

        private void ConfigUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bApply.Enabled) return;
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
                permissionLimitBoxContainer.Controls.Add(box);
            }
        }

        

        private void cDefaultBuildRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.DefaultBuildRank = RankManager.FindRank(cDefaultBuildRank.SelectedIndex - 1);
        }

        private void cPatrolledRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.PatrolledRank = RankManager.FindRank(cPatrolledRank.SelectedIndex - 1);
        }

        private void cBlockDBAutoEnableRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.BlockDbAutoEnableRank = RankManager.FindRank(cBlockDBAutoEnableRank.SelectedIndex - 1);
        }

        private void xBlockDBEnabled_CheckedChanged(object sender, EventArgs e)
        {
            xBlockDBAutoEnable.Enabled = xBlockDBEnabled.Checked;
            cBlockDBAutoEnableRank.Enabled = xBlockDBEnabled.Checked && xBlockDBAutoEnable.Checked;
        }

        private void xBlockDBAutoEnable_CheckedChanged(object sender, EventArgs e)
        {
            cBlockDBAutoEnableRank.Enabled = xBlockDBEnabled.Checked && xBlockDBAutoEnable.Checked;
        }

        private void nFillLimit_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            _selectedRank.FillLimit = Convert.ToInt32(nFillLimit.Value);
        }


        public static bool UsePrefixes;


        public static string ToComboBoxOption(Rank rank)
        {
            return UsePrefixes ? $"{rank.Prefix,1}{rank.Name}" : rank.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Custom Chat command color", _colorCustom);
            picker.ShowDialog();
            _colorCustom = picker.ColorIndex;
            ApplyColor(CustomColor, _colorCustom);
            fCraft.Color.Custom = fCraft.Color.Parse(_colorCustom);
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

        private void websiteURL_TextChanged(object sender, EventArgs e)
        {
            websiteURL.Text = websiteURL.Text.Trim();
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

        private void xChanPass_CheckedChanged(object sender, EventArgs e)
        {
            if (xChanPass.Checked)
            {
                tChanPass.Enabled = true;
            }
            else
            {
                tChanPass.Enabled = false;
                tChanPass.Text = "password";
            }
        }

        private void xServPass_CheckedChanged(object sender, EventArgs e)
        {
            if (xServPass.Checked)
            {
                tServPass.Enabled = true;
            }
            else
            {
                tServPass.Enabled = false;
                tServPass.Text = "defaultPass";
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
        private void bStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please note that once the server is started, you cannot modify " +
                            "the Ranks or World Tabs in the Config");
            tabWorlds.Enabled = false;
            tabRanks.Enabled = false;
            StartUp(sender, e);
            console.OnCommand += console_Enter;
            logBox.LinkClicked += Link_Clicked;
            MenuItem[] menuItems = { new MenuItem("Copy", CopyMenuOnClickHandler) };
            logBox.ContextMenu = new ContextMenu(menuItems);
            logBox.ContextMenu.Popup += CopyMenuPopupHandler;
            playerList.MouseDoubleClick += playerList_MouseDoubleClick;
            StartEnable();
            LoadCustomThemes();
            PrisonData.Init();
        }

        void StartEnable()
        {
            bStart.Enabled = false;
            uriDisplay.Enabled = true;
            bPlay.Enabled = true;
            btnRestart.Enabled = true;
            pStop.Enabled = true;
            playerList.Enabled = true;
            logBox.Enabled = true;
            bVoice.Enabled = true;
            ThemeBox.Enabled = true;
        }

        private void bAddRank_Click(object sender, EventArgs e)
        {
            var number = 1;
            while (RankManager.RanksByName.ContainsKey("rank" + number)) number++;

            var rank = new Rank("rank" + number, RankManager.GenerateId());

            RankManager.AddRank(rank);
            _selectedRank = null;

            RebuildRankList();
            SelectRank(rank);

            _rankNameList.Insert(rank.Index + 1, ToComboBoxOption(rank));
        }

        private void bDeleteRank_Click(object sender, EventArgs e)
        {
            if (vRanks.SelectedItem == null) return;
            _selectedRank = null;
            var index = vRanks.SelectedIndex;
            var deletedRank = RankManager.FindRank(index);
            if (deletedRank == null) return;

            var messages = "";

            // Ask for substitute rank
            var popup = new DeleteRankPopup(deletedRank);
            if (popup.ShowDialog() != DialogResult.OK) return;

            var replacementRank = popup.SubstituteRank;

            // Update default rank
            if (RankManager.DefaultRank == deletedRank)
            {
                RankManager.DefaultRank = replacementRank;
                messages += "DefaultRank has been changed to \"" + replacementRank.Name + "\"" + Environment.NewLine;
            }

            // Update defaultbuild rank
            if (RankManager.DefaultBuildRank == deletedRank)
            {
                RankManager.DefaultBuildRank = replacementRank;
                messages += "DefaultBuildRank has been changed to \"" + replacementRank.Name + "\"" + Environment.NewLine;
            }

            // Update patrolled rank
            if (RankManager.PatrolledRank == deletedRank)
            {
                RankManager.PatrolledRank = replacementRank;
                messages += "PatrolledRank has been changed to \"" + replacementRank.Name + "\"" + Environment.NewLine;
            }

            // Update patrolled rank
            if (RankManager.BlockDbAutoEnableRank == deletedRank)
            {
                RankManager.BlockDbAutoEnableRank = replacementRank;
                messages += "BlockDBAutoEnableRank has been changed to \"" + replacementRank.Name + "\"" + Environment.NewLine;
            }

            // Delete rank
            if (RankManager.DeleteRank(deletedRank, replacementRank))
            {
                messages += "Some of the rank limits for kick, ban, promote, and/or demote have been reset." + Environment.NewLine;
            }
            vRanks.Items.RemoveAt(index);

            // Update world permissions
            string worldUpdates = "";
            foreach (WorldListEntry world in Worlds)
            {
                if (world.AccessPermission == ToComboBoxOption(deletedRank))
                {
                    world.AccessPermission = ToComboBoxOption(replacementRank);
                    worldUpdates += " - " + world.Name + ": access permission changed to " + replacementRank.Name + Environment.NewLine;
                }
                if (world.BuildPermission == ToComboBoxOption(deletedRank))
                {
                    world.BuildPermission = ToComboBoxOption(replacementRank);
                    worldUpdates += " - " + world.Name + ": build permission changed to " + replacementRank.Name + Environment.NewLine;
                }
            }

            _rankNameList.RemoveAt(index + 1);

            if (worldUpdates.Length > 0)
            {
                messages += "The following worlds were affected:" + Environment.NewLine + worldUpdates;
            }

            if (messages.Length > 0)
            {
                MessageBox.Show(messages, "Warning");
            }

            RebuildRankList();

            if (index < vRanks.Items.Count)
            {
                vRanks.SelectedIndex = index;
            }
        }


        private void tPrefix_Validating(object sender, CancelEventArgs e)
        {
            if (_selectedRank == null) return;
            tPrefix.Text = tPrefix.Text.Trim();
            if (tPrefix.Text.Length > 0 && !Rank.IsValidPrefix(tPrefix.Text))
            {
                MessageBox.Show("Invalid prefix character!\n" +
                    "Prefixes may only contain characters that are allowed in chat (except space).", "Warning");
                tPrefix.ForeColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                tPrefix.ForeColor = SystemColors.ControlText;
            }
            if (_selectedRank.Prefix == tPrefix.Text) return;

            string oldName = ToComboBoxOption(_selectedRank);

            // To avoid DataErrors in World tab's DataGridView while renaming a rank,
            // the new name is first added to the list of options (without removing the old name)
            _rankNameList.Insert(_selectedRank.Index + 1, String.Format("{0,1}{1}", tPrefix.Text, _selectedRank.Name));

            _selectedRank.Prefix = tPrefix.Text;

            // Remove the old name from the list of options
            _rankNameList.Remove(oldName);

            Worlds.ResetBindings();
            RebuildRankList();
        }

        private void xReserveSlot_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            _selectedRank.ReservedSlot = xReserveSlot.Checked;
        }

        private void nKickIdle_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null || !xKickIdle.Checked) return;
            _selectedRank.IdleKickTimer = Convert.ToInt32(nKickIdle.Value);
        }

        private void nAntiGriefBlocks_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null || !xAntiGrief.Checked) return;
            _selectedRank.AntiGriefBlocks = Convert.ToInt32(nAntiGriefBlocks.Value);
        }

        private void nAntiGriefSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null || !xAntiGrief.Checked) return;
            _selectedRank.AntiGriefSeconds = Convert.ToInt32(nAntiGriefSeconds.Value);
        }

        private void nDrawLimit_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null || !xDrawLimit.Checked) return;
            _selectedRank.DrawLimit = Convert.ToInt32(nDrawLimit.Value);
            double cubed = Math.Pow(Convert.ToDouble(nDrawLimit.Value), 1 / 3d);
            lDrawLimitUnits.Text = String.Format("blocks ({0:0}\u00B3)", cubed);
        }

        private void nCopyPasteSlots_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            _selectedRank.CopySlots = Convert.ToInt32(nCopyPasteSlots.Value);
        }

        private void xAllowSecurityCircumvention_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            _selectedRank.AllowSecurityCircumvention = xAllowSecurityCircumvention.Checked;
        }


        private void xSpamChatKick_CheckedChanged(object sender, EventArgs e)
        {
            nAntispamMaxWarnings.Enabled = xAntispamKicks.Checked;
        }

        private void vRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vRanks.SelectedIndex != -1)
            {
                SelectRank(RankManager.FindRank(vRanks.SelectedIndex));
            }
            else
            {
                DisableRankOptions();
            }
        }

        private void xKickIdle_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            if (xKickIdle.Checked)
            {
                nKickIdle.Value = _selectedRank.IdleKickTimer;
            }
            else
            {
                nKickIdle.Value = 0;
                _selectedRank.IdleKickTimer = 0;
            }
            nKickIdle.Enabled = xKickIdle.Checked;
        }

        private void xAntiGrief_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            if (xAntiGrief.Checked)
            {
                nAntiGriefBlocks.Value = _selectedRank.AntiGriefBlocks;
                nAntiGriefSeconds.Value = _selectedRank.AntiGriefSeconds;
            }
            else
            {
                nAntiGriefBlocks.Value = 0;
                _selectedRank.AntiGriefBlocks = 0;
                nAntiGriefSeconds.Value = 0;
                _selectedRank.AntiGriefSeconds = 0;
            }
            nAntiGriefBlocks.Enabled = xAntiGrief.Checked;
            nAntiGriefSeconds.Enabled = xAntiGrief.Checked;
        }

        private void xDrawLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            if (xDrawLimit.Checked)
            {
                nDrawLimit.Value = _selectedRank.DrawLimit;
                double cubed = Math.Pow(Convert.ToDouble(nDrawLimit.Value), 1 / 3d);
                lDrawLimitUnits.Text = String.Format("blocks ({0:0}\u00B3)", cubed);
            }
            else
            {
                nDrawLimit.Value = 0;
                _selectedRank.DrawLimit = 0;
                lDrawLimitUnits.Text = "blocks";
            }
            nDrawLimit.Enabled = xDrawLimit.Checked;
        }

        private void vPermissions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            bool check = e.Item.Checked;
            e.Item.Font = check ? _bold : vPermissions.Font;
            if (_selectedRank == null) return;

            Permission permission = (Permission)e.Item.Tag;
            CheckPermissionConsistency(permission, check);

            _selectedRank.Permissions[(int)e.Item.Tag] = e.Item.Checked;
        }

        void CheckPermissionConsistency(Permission permission, bool check)
        {
            switch (permission)
            {
                case Permission.Chat:
                    if (!check)
                    {
                        vPermissions.Items[(int)Permission.Say].Checked = false;
                        vPermissions.Items[(int)Permission.Say].ForeColor = SystemColors.GrayText;
                        vPermissions.Items[(int)Permission.UseColorCodes].Checked = false;
                        vPermissions.Items[(int)Permission.UseColorCodes].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.Say].ForeColor = SystemColors.ControlText;
                        vPermissions.Items[(int)Permission.UseColorCodes].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.Say:
                    if (check) vPermissions.Items[(int)Permission.Chat].Checked = true;
                    break;

                case Permission.UseColorCodes:
                    if (check) vPermissions.Items[(int)Permission.Chat].Checked = true;
                    break;

                case Permission.Ban:
                    if (!check)
                    {
                        vPermissions.Items[(int)Permission.BanIP].Checked = false;
                        vPermissions.Items[(int)Permission.BanIP].ForeColor = SystemColors.GrayText;
                        vPermissions.Items[(int)Permission.BanAll].Checked = false;
                        vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.BanIP].ForeColor = SystemColors.ControlText;
                        vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.BanIP:
                    if (check)
                    {
                        vPermissions.Items[(int)Permission.Ban].Checked = true;
                        vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.BanAll].Checked = false;
                        vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.GrayText;
                    }
                    break;

                case Permission.BanAll:
                    if (check)
                    {
                        vPermissions.Items[(int)Permission.Ban].Checked = true;
                        vPermissions.Items[(int)Permission.BanIP].Checked = true;
                    }
                    break;

                case Permission.Draw:
                    xDrawLimit.Enabled = vPermissions.Items[(int)Permission.Draw].Checked ||
                                         vPermissions.Items[(int)Permission.CopyAndPaste].Checked;
                    if (check)
                    {
                        vPermissions.Items[(int)Permission.DrawAdvanced].ForeColor = SystemColors.ControlText;
                        vPermissions.Items[(int)Permission.CopyAndPaste].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.DrawAdvanced].Checked = false;
                        vPermissions.Items[(int)Permission.DrawAdvanced].ForeColor = SystemColors.GrayText;
                        vPermissions.Items[(int)Permission.CopyAndPaste].Checked = false;
                        vPermissions.Items[(int)Permission.CopyAndPaste].ForeColor = SystemColors.GrayText;
                    }
                    break;

                case Permission.DrawAdvanced:
                    lFillLimit.Enabled = check;
                    lFillLimitUnits.Enabled = check;
                    nFillLimit.Enabled = check;
                    break;

                case Permission.CopyAndPaste:
                    xDrawLimit.Enabled = vPermissions.Items[(int)Permission.Draw].Checked ||
                                         vPermissions.Items[(int)Permission.CopyAndPaste].Checked;
                    lCopyPasteSlots.Enabled = check;
                    nCopyPasteSlots.Enabled = check;
                    break;

                case Permission.ManageWorlds:
                case Permission.ManageZones:
                    xAllowSecurityCircumvention.Enabled = vPermissions.Items[(int)Permission.ManageWorlds].Checked ||
                                                          vPermissions.Items[(int)Permission.ManageZones].Checked;
                    break;

                case Permission.Teleport:
                    if (!check)
                    {
                        vPermissions.Items[(int)Permission.Patrol].Checked = false;
                        vPermissions.Items[(int)Permission.Patrol].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.Patrol].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.Patrol:
                    if (check) vPermissions.Items[(int)Permission.Teleport].Checked = true;
                    break;

                case Permission.Delete:
                    if (!check)
                    {
                        vPermissions.Items[(int)Permission.DeleteAdmincrete].Checked = false;
                        vPermissions.Items[(int)Permission.DeleteAdmincrete].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.DeleteAdmincrete].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.DeleteAdmincrete:
                    if (check) vPermissions.Items[(int)Permission.Delete].Checked = true;
                    break;

                case Permission.Build:
                    if (!check)
                    {
                        vPermissions.Items[(int)Permission.PlaceAdmincrete].Checked = false;
                        vPermissions.Items[(int)Permission.PlaceAdmincrete].ForeColor = SystemColors.GrayText;
                        vPermissions.Items[(int)Permission.PlaceGrass].Checked = false;
                        vPermissions.Items[(int)Permission.PlaceGrass].ForeColor = SystemColors.GrayText;
                        vPermissions.Items[(int)Permission.PlaceLava].Checked = false;
                        vPermissions.Items[(int)Permission.PlaceLava].ForeColor = SystemColors.GrayText;
                        vPermissions.Items[(int)Permission.PlaceWater].Checked = false;
                        vPermissions.Items[(int)Permission.PlaceWater].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.PlaceAdmincrete].ForeColor = SystemColors.ControlText;
                        vPermissions.Items[(int)Permission.PlaceGrass].ForeColor = SystemColors.ControlText;
                        vPermissions.Items[(int)Permission.PlaceLava].ForeColor = SystemColors.ControlText;
                        vPermissions.Items[(int)Permission.PlaceWater].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.PlaceAdmincrete:
                case Permission.PlaceGrass:
                case Permission.PlaceLava:
                case Permission.PlaceWater:
                    if (check) vPermissions.Items[(int)Permission.Build].Checked = true;
                    break;

                case Permission.Bring:
                    if (!check)
                    {
                        vPermissions.Items[(int)Permission.BringAll].Checked = false;
                        vPermissions.Items[(int)Permission.BringAll].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        vPermissions.Items[(int)Permission.BringAll].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.BringAll:
                    if (check) vPermissions.Items[(int)Permission.Bring].Checked = true;
                    break;

            }

            if (_permissionLimitBoxes.ContainsKey(permission))
            {
                _permissionLimitBoxes[permission].PermissionToggled(check);
            }
        }

        private void tRankName_Validating(object sender, CancelEventArgs e)
        {
            tRankName.ForeColor = SystemColors.ControlText;
            if (_selectedRank == null) return;

            string newName = tRankName.Text.Trim();

            if (newName == _selectedRank.Name)
            {
            }
            if (newName.Length == 0)
            {
                MessageBox.Show("Rank name cannot be blank.");
                tRankName.ForeColor = Color.Red;
                e.Cancel = true;

            }
            else if (!Rank.IsValidRankName(newName))
            {
                MessageBox.Show("Rank name can only contain letters, digits, and underscores.");
                tRankName.ForeColor = Color.Red;
                e.Cancel = true;

            }
            else if (!RankManager.CanRenameRank(_selectedRank, newName))
            {
                MessageBox.Show("There is already another rank named \"" + newName + "\".\n" +
                                "Duplicate rank names are not allowed.");
                tRankName.ForeColor = Color.Red;
                e.Cancel = true;

            }
            else
            {
                string oldName = ToComboBoxOption(_selectedRank);

                // To avoid DataErrors in World tab's DataGridView while renaming a rank,
                // the new name is first added to the list of options (without removing the old name)
                _rankNameList.Insert(_selectedRank.Index + 1, String.Format("{0,1}{1}", _selectedRank.Prefix, newName));

                RankManager.RenameRank(_selectedRank, newName);

                // Remove the old name from the list of options
                _rankNameList.Remove(oldName);

                Worlds.ResetBindings();
                RebuildRankList();
            }
        }


        private void bRaiseRank_Click(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            if (RankManager.RaiseRank(_selectedRank))
            {
                RebuildRankList();
                _rankNameList.Insert(_selectedRank.Index + 1, ToComboBoxOption(_selectedRank));
                _rankNameList.RemoveAt(_selectedRank.Index + 3);
            }
        }

        private void bLowerRank_Click(object sender, EventArgs e)
        {
            if (_selectedRank == null) return;
            if (RankManager.LowerRank(_selectedRank))
            {
                RebuildRankList();
                _rankNameList.Insert(_selectedRank.Index + 2, ToComboBoxOption(_selectedRank));
                _rankNameList.RemoveAt(_selectedRank.Index);
            }
        }
        #endregion



    }

}
