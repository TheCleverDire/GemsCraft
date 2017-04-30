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
using System.Windows.Forms;
using fCraft;
using fCraft.ConfigGUI;
using fCraft.GUI;
using JetBrains.Annotations;
using Color = System.Drawing.Color;
using static GemsCraftGUI.Program;

namespace GemsCraftGUI.ConfigGUI.GUITabs
{
    public partial class ConfigModule
    {
        internal static MainForm Instance;
        internal static Font Bold;
        internal static Rank SelectedRank;
        internal static UpdaterSettingsPopup UpdaterWindow = new UpdaterSettingsPopup();
        internal static readonly SortableBindingList<WorldListEntry> Worlds = new SortableBindingList<WorldListEntry>();
        
        #region Handlers
        //Fixes all event handlers that were lost on the GUI switch
        

        internal static void bVoice_Click(object sender, EventArgs e)
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
                MainFormGUI.bVoice.ForeColor = Color.Black;
                return;
            }

            var engine = new SpeechRecognitionEngine();
            MainFormGUI.bVoice.ForeColor = Color.Aqua;
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
        internal static void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
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
                        MainFormGUI.bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "restart":
                        reader.Speak("The server is now restarting.");
                        ShutdownParams param = new ShutdownParams(ShutdownReason.Restarting, TimeSpan.FromSeconds(5), true, true, "Restarting", Player.Console);
                        Server.Shutdown(param, true);
                        MainFormGUI.bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "shutdown":
                        reader.Speak("The server is now shutting down.");
                        MainFormGUI.Shutdown(ShutdownReason.ShuttingDown, true);
                        MainFormGUI.bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "status report":
                        reader.Speak("Server has been up for " + Math.Round(DateTime.UtcNow.Subtract(Server.StartTime).TotalHours, 1, MidpointRounding.AwayFromZero) + " hours.");
                        Player.Console.ParseMessage("/sinfo", true, false);
                        MainFormGUI.bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    case "players":
                        message = Server.Players.Aggregate(message, (current, p) => current + p.Name);
                        reader.Speak(message);
                        Player.Console.ParseMessage("/players", true, false);
                        MainFormGUI.bVoice.ForeColor = Color.Black;
                        engine.RecognizeAsyncStop();
                        engine.Dispose();
                        _listening = false;
                        break;
                    default:
                        MainFormGUI.bVoice.ForeColor = Color.Black;
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
        

        internal static void nMaxPlayerPerWorld_Validating(object sender, CancelEventArgs e)
        {
            CheckMaxPlayersPerWorldValue();
        }

        internal static void CheckMaxPlayersPerWorldValue()
        {
            if (GeneralScreen.nMaxPlayersPerWorld.Value > GeneralScreen.nMaxPlayers.Value)
            {
                GeneralScreen.nMaxPlayersPerWorld.Value = GeneralScreen.nMaxPlayers.Value;
            }
            GeneralScreen.nMaxPlayersPerWorld.Maximum = Math.Min(128, GeneralScreen.nMaxPlayers.Value);
        }

        internal static void cDefaultRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.DefaultRank = RankManager.FindRank(GeneralScreen.cDefaultRank.SelectedIndex - 1);
        }

        internal static void bMeasure_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.speedtest.net/");
        }

        internal static void bAnnouncements_Click(object sender, EventArgs e)
        {
            var popup = new TextEditorPopup(Paths.AnnouncementsFileName, "");
            popup.ShowDialog();
        }

        internal static void xAnnouncements_CheckedChanged(object sender, EventArgs e)
        {
            GeneralScreen.nAnnouncements.Enabled = GeneralScreen.xAnnouncements.Checked;
            GeneralScreen.bAnnouncements.Enabled = GeneralScreen.xAnnouncements.Checked;
        }

        internal static void tIP_Validating(object sender, CancelEventArgs e)
        {
            IPAddress ip;
            if (Server.IsIp(AdvancedScreen.tIP.Text) && IPAddress.TryParse(AdvancedScreen.tIP.Text, out ip))
            {
                AdvancedScreen.tIP.ForeColor = SystemColors.ControlText;
            }
            else
            {
                AdvancedScreen.tIP.ForeColor = Color.Red;
                e.Cancel = true;
            }
        }

        internal static void xIP_CheckedChanged(object sender, EventArgs e)
        {
            AdvancedScreen.tIP.Enabled = AdvancedScreen.xIP.Checked;
        }

        internal static void bGreeting_Click(object sender, EventArgs e)
        {
            var popup = new TextEditorPopup(Paths.GreetingFileName,
@"Welcome to {SERVER_NAME}
Your rank is {RANK}&S. Type &H/Help&S for help.");
            popup.ShowDialog();
        }


        internal static void nMaxPlayers_ValueChanged(object sender, EventArgs e)
        {
            CheckMaxPlayersPerWorldValue();
        }

        internal static void bCredits_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        internal static void bChangelog_Click(object sender, EventArgs e)
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

        internal static void bReadme_Click(object sender, EventArgs e)
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

        internal static void bRules_Click(object sender, EventArgs e)
        {
            TextEditorPopup popup = new TextEditorPopup(Paths.RulesFileName, "Use common sense!");
            popup.ShowDialog();
        }

        internal static void FillRankList([NotNull] ComboBox box, string firstItem)
        {
            if (box == null) throw new ArgumentNullException("box");
            box.Items.Clear();
            box.Items.Add(firstItem);
            foreach (var rank in RankManager.Ranks)
            {
                box.Items.Add(ToComboBoxOption(rank));
            }
        }

        internal static void RebuildRankList()
        {
            RankScreen.vRanks.Items.Clear();
            foreach (var rank in RankManager.Ranks)
            {
                RankScreen.vRanks.Items.Add(ToComboBoxOption(rank));
            }

            FillRankList(GeneralScreen.cDefaultRank, "(lowest rank)");
            GeneralScreen.cDefaultRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultRank);

            FillRankList(WorldScreen.cDefaultBuildRank, "(default rank)");
            WorldScreen.cDefaultBuildRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultBuildRank);

            FillRankList(SecurityScreen.cPatrolledRank, "(default rank)");
            SecurityScreen.cPatrolledRank.SelectedIndex = RankManager.GetIndex(RankManager.PatrolledRank);

            FillRankList(SecurityScreen.cBlockDBAutoEnableRank, "(default rank)");
            SecurityScreen.cBlockDBAutoEnableRank.SelectedIndex = RankManager.GetIndex(RankManager.BlockDbAutoEnableRank);

            if (SelectedRank != null)
            {
                RankScreen.vRanks.SelectedIndex = SelectedRank.Index;
            }
            SelectRank(SelectedRank);

            foreach (var box in _permissionLimitBoxes.Values)
            {
                box.RebuildList();
                box.SelectRank(SelectedRank);
            }
        }

        internal static void DisableRankOptions()
        {
            SelectedRank = null;
            RankScreen.bDeleteRank.Enabled = false;
            RankScreen.bRaiseRank.Enabled = false;
            RankScreen.bLowerRank.Enabled = false;
            RankScreen.tRankName.Text = "";
            RankScreen.bColorRank.Text = "";
            RankScreen.tPrefix.Text = "";

            foreach (var box in _permissionLimitBoxes.Values)
            {
                box.SelectRank(null);
            }

            RankScreen.xReserveSlot.Checked = false;
            RankScreen.xKickIdle.Checked = false;
            RankScreen.nKickIdle.Value = 0;
            RankScreen.xAntiGrief.Checked = false;
            RankScreen.nAntiGriefBlocks.Value = 0;
            RankScreen.xDrawLimit.Checked = false;
            RankScreen.nDrawLimit.Value = 0;
            RankScreen.xAllowSecurityCircumvention.Checked = false;
            RankScreen.nCopyPasteSlots.Value = 0;
            RankScreen.nFillLimit.Value = 32;
            foreach (ListViewItem item in RankScreen.vPermissions.Items)
            {
                item.Checked = false;
                item.Font = RankScreen.vPermissions.Font;
            }
            RankScreen.gRankOptions.Enabled = false;
            RankScreen.lPermissions.Enabled = false;
            RankScreen.vPermissions.Enabled = false;
        }

        internal static BindingList<string> _rankNameList;

        static void SelectRank(Rank rank)
        {
            if (rank == null)
            {
                if (RankScreen.vRanks.SelectedIndex != -1)
                {
                    RankScreen.vRanks.ClearSelected();
                    return;
                }
                DisableRankOptions();
                return;
            }
            if (RankScreen.vRanks.SelectedIndex != rank.Index)
            {
                RankScreen.vRanks.SelectedIndex = rank.Index;
                return;
            }
            SelectedRank = rank;
            RankScreen.tRankName.Text = rank.Name;

            ApplyColor(RankScreen.bColorRank, fCraft.Color.ParseToIndex(rank.Color));

            RankScreen.tPrefix.Text = rank.Prefix;

            foreach (var box in _permissionLimitBoxes.Values)
            {
                box.SelectRank(rank);
            }

            RankScreen.xReserveSlot.Checked = rank.ReservedSlot;
            RankScreen.xKickIdle.Checked = rank.IdleKickTimer > 0;
            RankScreen.nKickIdle.Value = rank.IdleKickTimer;
            RankScreen.nKickIdle.Enabled = RankScreen.xKickIdle.Checked;
            RankScreen.xAntiGrief.Checked = (rank.AntiGriefBlocks > 0 && rank.AntiGriefSeconds > 0);
            RankScreen.nAntiGriefBlocks.Value = rank.AntiGriefBlocks;
            RankScreen.nAntiGriefBlocks.Enabled = RankScreen.xAntiGrief.Checked;
            RankScreen.nAntiGriefSeconds.Value = rank.AntiGriefSeconds;
            RankScreen.nAntiGriefSeconds.Enabled = RankScreen.xAntiGrief.Checked;
            RankScreen.xDrawLimit.Checked = (rank.DrawLimit > 0);
            RankScreen.nDrawLimit.Value = rank.DrawLimit;
            RankScreen.nCopyPasteSlots.Value = rank.CopySlots;
            RankScreen.nFillLimit.Value = rank.FillLimit;
            RankScreen.xAllowSecurityCircumvention.Checked = rank.AllowSecurityCircumvention;

            foreach (ListViewItem item in RankScreen.vPermissions.Items)
            {
                item.Checked = rank.Permissions[item.Index];
                item.Font = item.Checked ? Bold : RankScreen.vPermissions.Font;
            }

            foreach (ListViewItem item in RankScreen.vPermissions.Items)
            {
                CheckPermissionConsistency((Permission)item.Tag, item.Checked);
            }

            RankScreen.xDrawLimit.Enabled = rank.Can(Permission.Draw) || rank.Can(Permission.CopyAndPaste);
            RankScreen.nDrawLimit.Enabled = RankScreen.xDrawLimit.Checked;
            RankScreen.xAllowSecurityCircumvention.Enabled = rank.Can(Permission.ManageWorlds) || rank.Can(Permission.ManageZones);

            RankScreen.gRankOptions.Enabled = true;
            RankScreen.lPermissions.Enabled = true;
            RankScreen.vPermissions.Enabled = true;

            RankScreen.bDeleteRank.Enabled = true;
            RankScreen.bRaiseRank.Enabled = (SelectedRank != RankManager.HighestRank);
            RankScreen.bLowerRank.Enabled = (SelectedRank != RankManager.LowestRank);
        }

        internal static void xRankPrefixesInChat_CheckedChanged(object sender, EventArgs e)
        {
            UsePrefixes = ChatScreen.xRankPrefixesInChat.Checked;
            RankScreen.tPrefix.Enabled = UsePrefixes;
            RankScreen.lPrefix.Enabled = UsePrefixes;
            RebuildRankList();
        }

        internal static int _colorSys, _colorSay, _colorHelp, _colorAnnouncement, _colorPm, _colorIrc, _colorMe, _colorWarning, _colorCustom, _colorGlobal;

        static void ApplyColor(Button button, int color)
        {
            button.Text = fCraft.Color.GetName(color);
            button.BackColor = ColorPicker.ColorPairs[color].Background;
            button.ForeColor = ColorPicker.ColorPairs[color].Foreground;
        }

        internal static void bColorSys_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("System message color", _colorSys);
            picker.ShowDialog();
            _colorSys = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorSys, _colorSys);
            fCraft.Color.Sys = fCraft.Color.Parse(_colorSys);
        }

        internal static void bColorHelp_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Help message color", _colorHelp);
            picker.ShowDialog();
            _colorHelp = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorHelp, _colorHelp);
            fCraft.Color.Help = fCraft.Color.Parse(_colorHelp);
        }

        internal static void bColorSay_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("/Say message color", _colorSay);
            picker.ShowDialog();
            _colorSay = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorSay, _colorSay);
            fCraft.Color.Say = fCraft.Color.Parse(_colorSay);
        }

        internal static void bColorAnnouncement_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Announcement color", _colorAnnouncement);
            picker.ShowDialog();
            _colorAnnouncement = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorAnnouncement, _colorAnnouncement);
            fCraft.Color.Announcement = fCraft.Color.Parse(_colorAnnouncement);
        }

        internal static void bColorPM_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Private / rank chat color", _colorPm);
            picker.ShowDialog();
            _colorPm = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorPM, _colorPm);
            fCraft.Color.PM = fCraft.Color.Parse(_colorPm);
        }

        internal static void bColorWarning_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Warning / Error message color", _colorWarning);
            picker.ShowDialog();
            _colorWarning = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorWarning, _colorWarning);
            fCraft.Color.Warning = fCraft.Color.Parse(_colorWarning);
        }

        internal static void bColorMe_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("/Me command color", _colorMe);
            picker.ShowDialog();
            _colorMe = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorMe, _colorMe);
            fCraft.Color.Me = fCraft.Color.Parse(_colorMe);
        }

        internal static void bColorIRC_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("IRC message color", _colorIrc);
            picker.ShowDialog();
            _colorIrc = picker.ColorIndex;
            ApplyColor(IrcScreen.bColorIRC, _colorIrc);
            fCraft.Color.IRC = fCraft.Color.Parse(_colorIrc);
        }

        internal static void bColorGlobal_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Global message color", _colorGlobal);
            picker.ShowDialog();
            _colorGlobal = picker.ColorIndex;
            ApplyColor(ChatScreen.bColorGlobal, _colorGlobal);
            fCraft.Color.Global = fCraft.Color.Parse(_colorGlobal);
        }

        internal static void bColorRank_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Rank color for \"" + SelectedRank.Name + "\"", fCraft.Color.ParseToIndex(SelectedRank.Color));
            picker.ShowDialog();
            ApplyColor(RankScreen.bColorRank, picker.ColorIndex);
            SelectedRank.Color = fCraft.Color.Parse(picker.ColorIndex);
        }
        

        void UpdateChatPreview()
        {
            List<string> lines = new List<string>();
            if (ChatScreen.xShowConnectionMessages.Checked)
            {
                // ReSharper disable once UseStringInterpolation
                lines.Add(string.Format("&SPlayer {0}{1}LeChosenOne&S connected, joined {2}{3}main",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : "",
                                          ChatScreen.xRankColorsInWorldNames.Checked ? RankManager.LowestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.LowestRank.Prefix : ""));
            }
            lines.Add("&R<*- This is an announcement -*>");
            lines.Add("&YThis is a /say announcement");
            // ReSharper disable once UseStringInterpolation
            lines.Add(string.Format("{0}{1}LeChosenOne&F: This is a normal chat message",
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

                // ReSharper disable once UseStringInterpolation
                lines.Add(string.Format("&SPlayer {0}{1}Dingus&S joined {2}{3}SomeOtherMap",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : "",
                                          ChatScreen.xRankColorsInWorldNames.Checked ? midRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? midRank.Prefix : ""));
            }
            lines.Add("&SUnknown command \"kikc\", see &H/Commands");
            if (SecurityScreen.xAnnounceKickAndBanReasons.Checked)
            {
                lines.Add(string.Format("&W{0}{1}LeChosenOne&W was kicked by {0}{1}Dingus&W: Reason goes here",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }
            else
            {
                lines.Add(string.Format("&W{0}{1}CopperPenquin96&W was kicked by {0}{1}gamer1",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }

            if (ChatScreen.xShowConnectionMessages.Checked)
            {
                // ReSharper disable once UseStringInterpolation
                lines.Add(string.Format("&S{0}{1}Bob&S left the server.",
                                          ChatScreen.xRankColorsInChat.Checked ? RankManager.HighestRank.Color : "",
                                          ChatScreen.xRankPrefixesInChat.Checked ? RankManager.HighestRank.Prefix : ""));
            }

            ChatScreen.chatPreview1.SetText(lines.ToArray());
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
        

        internal static void FillWorldList()
        {
            WorldScreen.cMainWorld.Items.Clear();
            
            foreach (var world in Worlds)
            {
                WorldScreen.cMainWorld.Items.Add(world.Name);
            }

            WorldScreen.cboPrison.Items.Clear();
            foreach (var world in Worlds)
            {
                WorldScreen.cboPrison.Items.Add(world.Name);
            }
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
                FillWorldList();
                WorldScreen .cMainWorld.SelectedItem = mainWorldName == from ? to : mainWorldName;
            }
        }

        internal static void dgvWorlds_Click(object sender, EventArgs e)
        {
            bool oneRowSelected = (WorldScreen.dgvWorlds.SelectedRows.Count == 1);
            WorldScreen.bWorldDelete.Enabled = oneRowSelected;
            WorldScreen.bWorldEdit.Enabled = oneRowSelected;
        }
        

        internal static void nMaxUndo_ValueChanged(object sender, EventArgs e)
        {
            if (AdvancedScreen.xMaxUndo.Checked)
            {
                var maxMemUsage = Math.Ceiling(AdvancedScreen.nMaxUndoStates.Value * (AdvancedScreen.nMaxUndo.Value * 8) / (1024 * 1024));
                AdvancedScreen.lMaxUndoUnits.Text = $"blocks each (up to {maxMemUsage} MB of RAM per player)";
            }
            else
            {
               AdvancedScreen.lMaxUndoUnits.Text = "blocks each";
            }
        }

        internal static void xMaxUndo_CheckedChanged(object sender, EventArgs e)
        {
            AdvancedScreen.nMaxUndo.Enabled = AdvancedScreen.xMaxUndo.Checked;
            AdvancedScreen.lMaxUndoUnits.Enabled = AdvancedScreen.xMaxUndo.Checked;
        }

        internal static void xMapPath_CheckedChanged(object sender, EventArgs e)
        {
            WorldScreen.tMapPath.Enabled = WorldScreen.xMapPath.Checked;
            WorldScreen.bMapPath.Enabled = WorldScreen.xMapPath.Checked;
        }

        internal static void ConfigUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!bApply.Enabled) return;
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


        static readonly Dictionary<Permission, PermissionLimitBox> _permissionLimitBoxes = new Dictionary<Permission, PermissionLimitBox>();

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

        

        internal static void cDefaultBuildRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.DefaultBuildRank = RankManager.FindRank(WorldScreen.cDefaultBuildRank.SelectedIndex - 1);
        }

        internal static void cPatrolledRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.PatrolledRank = RankManager.FindRank(SecurityScreen.cPatrolledRank.SelectedIndex - 1);
        }

        internal static void cBlockDBAutoEnableRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankManager.BlockDbAutoEnableRank = RankManager.FindRank(SecurityScreen.cBlockDBAutoEnableRank.SelectedIndex - 1);
        }

        internal static void xBlockDBEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.xBlockDBAutoEnable.Enabled = SecurityScreen.xBlockDBEnabled.Checked;
            SecurityScreen.cBlockDBAutoEnableRank.Enabled = SecurityScreen.xBlockDBEnabled.Checked && SecurityScreen.xBlockDBAutoEnable.Checked;
        }

        internal static void xBlockDBAutoEnable_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.cBlockDBAutoEnableRank.Enabled = SecurityScreen.xBlockDBEnabled.Checked && SecurityScreen.xBlockDBAutoEnable.Checked;
        }

        internal static void nFillLimit_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            SelectedRank.FillLimit = Convert.ToInt32(RankScreen.nFillLimit.Value);
        }


        public static bool UsePrefixes;


        public static string ToComboBoxOption(Rank rank)
        {
            return UsePrefixes ? $"{rank.Prefix,1}{rank.Name}" : rank.Name;
        }

        internal static void label1_Click(object sender, EventArgs e)
        {

        }

        internal static void button1_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Custom Chat command color", _colorCustom);
            picker.ShowDialog();
            _colorCustom = picker.ColorIndex;
            ApplyColor(MiscScreen.CustomColor, _colorCustom);
            fCraft.Color.Custom = fCraft.Color.Parse(_colorCustom);
        }


        internal static void SwearEditor_Click(object sender, EventArgs e)
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

        internal static void ReqsEditor_Click(object sender, EventArgs e)
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

        internal static void websiteURL_TextChanged(object sender, EventArgs e)
        {
            MiscScreen.websiteURL.Text = MiscScreen.websiteURL.Text.Trim();
        }

        

        internal static void bUpdate_Click(object sender, EventArgs e)
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

        internal static void xChanPass_CheckedChanged(object sender, EventArgs e)
        {
            if (IrcScreen.xChanPass.Checked)
            {
                IrcScreen.tChanPass.Enabled = true;
            }
            else
            {
                IrcScreen.tChanPass.Enabled = false;
                IrcScreen.tChanPass.Text = "password";
            }
        }

        internal static void xServPass_CheckedChanged(object sender, EventArgs e)
        {
            if (IrcScreen.xServPass.Checked)
            {
                IrcScreen.tServPass.Enabled = true;
            }
            else
            {
                IrcScreen.tServPass.Enabled = false;
                IrcScreen.tServPass.Text = "defaultPass";
            }
        }

        
        volatile bool _shutdownPending, _startupComplete, _shutdownComplete;
        const int MaxLinesInLog = 2000,
                  LinesToTrimWhenExceeded = 50;
        static bool _listening;
        

        internal static void StartEnable()
        {
            MainFormGUI.bStart.Enabled = false;
            MainFormGUI.uriDisplay.Enabled = true;
            MainFormGUI.bPlay.Enabled = true;
            MainFormGUI.btnRestart.Enabled = true;
            MainFormGUI.pStop.Enabled = true;
            MainFormGUI.playerList.Enabled = true;
            MainFormGUI.logBox.Enabled = true;
            MainFormGUI.bVoice.Enabled = true;
          
            //ThemeBox.Enabled = true; - Legacy
        }

        internal static void bAddRank_Click(object sender, EventArgs e)
        {
            var number = 1;
            while (RankManager.RanksByName.ContainsKey("rank" + number)) number++;

            var rank = new Rank("rank" + number, RankManager.GenerateId());

            RankManager.AddRank(rank);
            SelectedRank = null;

            RebuildRankList();
            SelectRank(rank);

            _rankNameList.Insert(rank.Index + 1, ToComboBoxOption(rank));
        }

        internal static void bDeleteRank_Click(object sender, EventArgs e)
        {
            if (RankScreen.vRanks.SelectedItem == null) return;
            SelectedRank = null;
            var index = RankScreen.vRanks.SelectedIndex;
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
            RankScreen.vRanks.Items.RemoveAt(index);

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

            if (index < RankScreen.vRanks.Items.Count)
            {
                RankScreen.vRanks.SelectedIndex = index;
            }
        }


        internal static void tPrefix_Validating(object sender, CancelEventArgs e)
        {
            if (SelectedRank == null) return;
            RankScreen.tPrefix.Text = RankScreen.tPrefix.Text.Trim();
            if (RankScreen.tPrefix.Text.Length > 0 && !Rank.IsValidPrefix(RankScreen.tPrefix.Text))
            {
                MessageBox.Show("Invalid prefix character!\n" +
                    "Prefixes may only contain characters that are allowed in chat (except space).", "Warning");
                RankScreen.tPrefix.ForeColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                RankScreen.tPrefix.ForeColor = SystemColors.ControlText;
            }
            if (SelectedRank.Prefix == RankScreen.tPrefix.Text) return;

            string oldName = ToComboBoxOption(SelectedRank);

            // To avoid DataErrors in World tab's DataGridView while renaming a rank,
            // the new name is first added to the list of options (without removing the old name)
            _rankNameList.Insert(SelectedRank.Index + 1, $"{RankScreen.tPrefix.Text,1}{SelectedRank.Name}");

            SelectedRank.Prefix = RankScreen.tPrefix.Text;

            // Remove the old name from the list of options
            _rankNameList.Remove(oldName);

            Worlds.ResetBindings();
            RebuildRankList();
        }

        internal static void xReserveSlot_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            SelectedRank.ReservedSlot = RankScreen.xReserveSlot.Checked;
        }

        internal static void nKickIdle_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null || !RankScreen.xKickIdle.Checked) return;
            SelectedRank.IdleKickTimer = Convert.ToInt32(RankScreen.nKickIdle.Value);
        }

        internal static void nAntiGriefBlocks_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null || !RankScreen.xAntiGrief.Checked) return;
            SelectedRank.AntiGriefBlocks = Convert.ToInt32(RankScreen.nAntiGriefBlocks.Value);
        }

        internal static void nAntiGriefSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null || !RankScreen.xAntiGrief.Checked) return;
            SelectedRank.AntiGriefSeconds = Convert.ToInt32(RankScreen.nAntiGriefSeconds.Value);
        }

        internal static void nDrawLimit_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null || !RankScreen.xDrawLimit.Checked) return;
            SelectedRank.DrawLimit = Convert.ToInt32(RankScreen.nDrawLimit.Value);
            double cubed = Math.Pow(Convert.ToDouble(RankScreen.nDrawLimit.Value), 1 / 3d);
            RankScreen.lDrawLimitUnits.Text = $@"blocks ({cubed:0}³)";
        }

        internal static void nCopyPasteSlots_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            SelectedRank.CopySlots = Convert.ToInt32(RankScreen.nCopyPasteSlots.Value);
        }

        internal static void xAllowSecurityCircumvention_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            SelectedRank.AllowSecurityCircumvention = RankScreen.xAllowSecurityCircumvention.Checked;
        }


        internal static void xSpamChatKick_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.nAntispamMaxWarnings.Enabled = SecurityScreen.xAntispamKicks.Checked;
        }

        internal static void vRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RankScreen.vRanks.SelectedIndex != -1)
            {
                SelectRank(RankManager.FindRank(RankScreen.vRanks.SelectedIndex));
            }
            else
            {
                DisableRankOptions();
            }
        }

        internal static void xKickIdle_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            if (RankScreen.xKickIdle.Checked)
            {
                RankScreen.nKickIdle.Value = SelectedRank.IdleKickTimer;
            }
            else
            {
                RankScreen.nKickIdle.Value = 0;
                SelectedRank.IdleKickTimer = 0;
            }
            RankScreen.nKickIdle.Enabled = RankScreen.xKickIdle.Checked;
        }

        internal static void xAntiGrief_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            if (RankScreen.xAntiGrief.Checked)
            {
                RankScreen.nAntiGriefBlocks.Value = SelectedRank.AntiGriefBlocks;
                RankScreen.nAntiGriefSeconds.Value = SelectedRank.AntiGriefSeconds;
            }
            else
            {
                RankScreen.nAntiGriefBlocks.Value = 0;
                SelectedRank.AntiGriefBlocks = 0;
                RankScreen.nAntiGriefSeconds.Value = 0;
                SelectedRank.AntiGriefSeconds = 0;
            }
            RankScreen.nAntiGriefBlocks.Enabled = RankScreen.xAntiGrief.Checked;
            RankScreen.nAntiGriefSeconds.Enabled = RankScreen.xAntiGrief.Checked;
        }

        internal static void xDrawLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            if (RankScreen.xDrawLimit.Checked)
            {
                RankScreen.nDrawLimit.Value = SelectedRank.DrawLimit;
                double cubed = Math.Pow(Convert.ToDouble(RankScreen.nDrawLimit.Value), 1 / 3d);
                RankScreen.lDrawLimitUnits.Text = $@"blocks ({cubed:0}³)";
            }
            else
            {
                RankScreen.nDrawLimit.Value = 0;
                SelectedRank.DrawLimit = 0;
                RankScreen.lDrawLimitUnits.Text = "blocks";
            }
            RankScreen.nDrawLimit.Enabled = RankScreen.xDrawLimit.Checked;
        }

        internal static void vPermissions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            bool check = e.Item.Checked;
            e.Item.Font = check ? Bold : RankScreen.vPermissions.Font;
            if (SelectedRank == null) return;

            Permission permission = (Permission)e.Item.Tag;
            CheckPermissionConsistency(permission, check);

            SelectedRank.Permissions[(int)e.Item.Tag] = e.Item.Checked;
        }

        static void CheckPermissionConsistency(Permission permission, bool check)
        {
            switch (permission)
            {
                case Permission.Chat:
                    if (!check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.Say].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.Say].ForeColor = SystemColors.GrayText;
                        RankScreen.vPermissions.Items[(int)Permission.UseColorCodes].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.UseColorCodes].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.Say].ForeColor = SystemColors.ControlText;
                        RankScreen.vPermissions.Items[(int)Permission.UseColorCodes].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.Say:
                    if (check) RankScreen.vPermissions.Items[(int)Permission.Chat].Checked = true;
                    break;

                case Permission.UseColorCodes:
                    if (check) RankScreen.vPermissions.Items[(int)Permission.Chat].Checked = true;
                    break;

                case Permission.Ban:
                    if (!check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.BanIP].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.BanIP].ForeColor = SystemColors.GrayText;
                        RankScreen.vPermissions.Items[(int)Permission.BanAll].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.BanIP].ForeColor = SystemColors.ControlText;
                        RankScreen.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.BanIP:
                    if (check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.Ban].Checked = true;
                        RankScreen.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.BanAll].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.GrayText;
                    }
                    break;

                case Permission.BanAll:
                    if (check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.Ban].Checked = true;
                        RankScreen.vPermissions.Items[(int)Permission.BanIP].Checked = true;
                    }
                    break;

                case Permission.Draw:
                    RankScreen.xDrawLimit.Enabled = RankScreen.vPermissions.Items[(int)Permission.Draw].Checked ||
                                         RankScreen.vPermissions.Items[(int)Permission.CopyAndPaste].Checked;
                    if (check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.DrawAdvanced].ForeColor = SystemColors.ControlText;
                        RankScreen.vPermissions.Items[(int)Permission.CopyAndPaste].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.DrawAdvanced].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.DrawAdvanced].ForeColor = SystemColors.GrayText;
                        RankScreen.vPermissions.Items[(int)Permission.CopyAndPaste].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.CopyAndPaste].ForeColor = SystemColors.GrayText;
                    }
                    break;

                case Permission.DrawAdvanced:
                    RankScreen.lFillLimit.Enabled = check;
                    RankScreen.lFillLimitUnits.Enabled = check;
                    RankScreen.nFillLimit.Enabled = check;
                    break;

                case Permission.CopyAndPaste:
                    RankScreen.xDrawLimit.Enabled = RankScreen.vPermissions.Items[(int)Permission.Draw].Checked ||
                                         RankScreen.vPermissions.Items[(int)Permission.CopyAndPaste].Checked;
                    RankScreen.lCopyPasteSlots.Enabled = check;
                    RankScreen.nCopyPasteSlots.Enabled = check;
                    break;

                case Permission.ManageWorlds:
                case Permission.ManageZones:
                    RankScreen.xAllowSecurityCircumvention.Enabled = RankScreen.vPermissions.Items[(int)Permission.ManageWorlds].Checked ||
                                                          RankScreen.vPermissions.Items[(int)Permission.ManageZones].Checked;
                    break;

                case Permission.Teleport:
                    if (!check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.Patrol].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.Patrol].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.Patrol].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.Patrol:
                    if (check) RankScreen.vPermissions.Items[(int)Permission.Teleport].Checked = true;
                    break;

                case Permission.Delete:
                    if (!check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.DeleteAdmincrete].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.DeleteAdmincrete].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.DeleteAdmincrete].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.DeleteAdmincrete:
                    if (check) RankScreen.vPermissions.Items[(int)Permission.Delete].Checked = true;
                    break;

                case Permission.Build:
                    if (!check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.PlaceAdmincrete].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceAdmincrete].ForeColor = SystemColors.GrayText;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceGrass].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceGrass].ForeColor = SystemColors.GrayText;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceLava].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceLava].ForeColor = SystemColors.GrayText;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceWater].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceWater].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.PlaceAdmincrete].ForeColor = SystemColors.ControlText;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceGrass].ForeColor = SystemColors.ControlText;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceLava].ForeColor = SystemColors.ControlText;
                        RankScreen.vPermissions.Items[(int)Permission.PlaceWater].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.PlaceAdmincrete:
                case Permission.PlaceGrass:
                case Permission.PlaceLava:
                case Permission.PlaceWater:
                    if (check) RankScreen.vPermissions.Items[(int)Permission.Build].Checked = true;
                    break;

                case Permission.Bring:
                    if (!check)
                    {
                        RankScreen.vPermissions.Items[(int)Permission.BringAll].Checked = false;
                        RankScreen.vPermissions.Items[(int)Permission.BringAll].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        RankScreen.vPermissions.Items[(int)Permission.BringAll].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.BringAll:
                    if (check) RankScreen.vPermissions.Items[(int)Permission.Bring].Checked = true;
                    break;

            }

            if (_permissionLimitBoxes.ContainsKey(permission))
            {
                _permissionLimitBoxes[permission].PermissionToggled(check);
            }
        }

        internal static void tRankName_Validating(object sender, CancelEventArgs e)
        {
            RankScreen.tRankName.ForeColor = SystemColors.ControlText;
            if (SelectedRank == null) return;

            string newName = RankScreen.tRankName.Text.Trim();

            if (newName == SelectedRank.Name)
            {
            }
            if (newName.Length == 0)
            {
                MessageBox.Show("Rank name cannot be blank.");
                RankScreen.tRankName.ForeColor = Color.Red;
                e.Cancel = true;

            }
            else if (!Rank.IsValidRankName(newName))
            {
                MessageBox.Show("Rank name can only contain letters, digits, and underscores.");
                RankScreen.tRankName.ForeColor = Color.Red;
                e.Cancel = true;

            }
            else if (!RankManager.CanRenameRank(SelectedRank, newName))
            {
                MessageBox.Show("There is already another rank named \"" + newName + "\".\n" +
                                "Duplicate rank names are not allowed.");
                RankScreen.tRankName.ForeColor = Color.Red;
                e.Cancel = true;

            }
            else
            {
                string oldName = ToComboBoxOption(SelectedRank);

                // To avoid DataErrors in World tab's DataGridView while renaming a rank,
                // the new name is first added to the list of options (without removing the old name)
                _rankNameList.Insert(SelectedRank.Index + 1, $"{SelectedRank.Prefix,1}{newName}");

                RankManager.RenameRank(SelectedRank, newName);

                // Remove the old name from the list of options
                _rankNameList.Remove(oldName);

                Worlds.ResetBindings();
                RebuildRankList();
            }
        }


        internal static void bRaiseRank_Click(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            if (RankManager.RaiseRank(SelectedRank))
            {
                RebuildRankList();
                _rankNameList.Insert(SelectedRank.Index + 1, ToComboBoxOption(SelectedRank));
                _rankNameList.RemoveAt(SelectedRank.Index + 3);
            }
        }

        internal static void bLowerRank_Click(object sender, EventArgs e)
        {
            if (SelectedRank == null) return;
            if (RankManager.LowerRank(SelectedRank))
            {
                RebuildRankList();
                _rankNameList.Insert(SelectedRank.Index + 2, ToComboBoxOption(SelectedRank));
                _rankNameList.RemoveAt(SelectedRank.Index);
            }
        }

        internal static void xAnnounceRankChanges_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.xAnnounceRankChangeReasons.Enabled = SecurityScreen.xAnnounceRankChanges.Checked;
        }

        internal static void cVerifyNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecurityScreen.xAllowUnverifiedLAN.Enabled = (SecurityScreen.cVerifyNames.SelectedIndex != 0);
            SecurityScreen.xAllowUnverifiedLAN.Checked = !SecurityScreen.xAllowUnverifiedLAN.Enabled;
        }

        internal static void xMaxConnectionsPerIP_CheckedChanged(object sender, EventArgs e)
        {
            SecurityScreen.nMaxConnectionsPerIP.Enabled = SecurityScreen.xMaxConnectionsPerIP.Checked;
        }

        internal static void xSaveAtInterval_CheckedChanged(object sender, EventArgs e)
        {
            SavingBackupScreen.nSaveInterval.Enabled = SavingBackupScreen.xSaveInterval.Checked;
        }

        internal static void xBackupAtInterval_CheckedChanged(object sender, EventArgs e)
        {
            SavingBackupScreen.nBackupInterval.Enabled = SavingBackupScreen.xBackupInterval.Checked;
        }

        internal static void xMaxBackups_CheckedChanged(object sender, EventArgs e)
        {
            SavingBackupScreen.nMaxBackups.Enabled = SavingBackupScreen.xMaxBackups.Checked;
        }

        internal static void xMaxBackupSize_CheckedChanged(object sender, EventArgs e)
        {
            SavingBackupScreen.nMaxBackupSize.Enabled = SavingBackupScreen.xMaxBackupSize.Checked;
        }

        internal static void vConsoleOptions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Font = e.Item.Checked ? Bold : LoggingScreen.vConsoleOptions.Font;
        }

        internal static void vLogFileOptions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Font = e.Item.Checked ? Bold : LoggingScreen.vLogFileOptions.Font;
        }

        internal static void xLogLimit_CheckedChanged(object sender, EventArgs e)
        {
            LoggingScreen.nLogLimit.Enabled = LoggingScreen.xLogLimit.Checked;
        }

        internal static void xIRC_CheckedChanged(object sender, EventArgs e)
        {
            IrcScreen.gIRCNetwork.Enabled = IrcScreen.xIRCBotEnabled.Checked;
            IrcScreen.gIRCOptions.Enabled = IrcScreen.xIRCBotEnabled.Checked;
            IrcScreen.lIRCList.Enabled = IrcScreen.xIRCBotEnabled.Checked;
            IrcScreen.cIRCList.Enabled = IrcScreen.xIRCBotEnabled.Checked;
            IrcScreen.xIRCListShowNonEnglish.Enabled = IrcScreen.xIRCBotEnabled.Checked;
        }


        internal struct IrcNetwork
        {
            const int DefaultIrcPort = 6667;

            public readonly string Name, Host;
            public readonly int Port;
            public readonly bool IsNonEnglish;

            public IrcNetwork(string name, string host, int port = DefaultIrcPort, bool isNonEnglish = false)
            {
                Name = name;
                Host = host;
                Port = port;
                IsNonEnglish = isNonEnglish;
            }
        }

        internal static readonly IrcNetwork[] IrcNetworks = new[]{
            new IrcNetwork("FreeNode", "chat.freenode.net"),
            new IrcNetwork("QuakeNet", "irc.quakenet.org"),
            new IrcNetwork("IRCnet", "irc.belwue.de"),
            new IrcNetwork("Undernet", "irc.undernet.org"),
            new IrcNetwork("EFNet", "irc.servercentral.net"),
            new IrcNetwork("Ustream", "c.ustream.tv"),
            new IrcNetwork("WebChat", "irc.webchat.org"),
            new IrcNetwork("DALnet", "irc.dal.net"),
            new IrcNetwork("Rizon","irc.rizon.net"),
            new IrcNetwork("IRC-Hispano [ES]", "irc.irc-hispano.org", 6667, true),
            new IrcNetwork("FCirc", "irc.friend.td.nu"),
            new IrcNetwork("GameSurge", "irc.gamesurge.net"),
            new IrcNetwork("LinkNet", "irc.link-net.org"),
            new IrcNetwork("OltreIrc [IT]", "irc.oltreirc.net", 6667,true),
            new IrcNetwork("AllNetwork", "irc.allnetwork.org"),
            new IrcNetwork("SwiftIRC", "irc.swiftirc.net"),
            new IrcNetwork("OpenJoke", "irc.openjoke.org"),
            new IrcNetwork("Abjects", "irc.abjects.net"),
            new IrcNetwork("OFTC", "irc.oftc.net"),
            new IrcNetwork("ChatZona [ES]", "irc.chatzona.org", 6667, true ),
            new IrcNetwork("synIRC", "irc.synirc.net"),
            new IrcNetwork("OnlineGamesNet", "irc.OnlineGamesNet.net"),
            new IrcNetwork("DarkSin [IT]", "irc.darksin.it", 6667,true),
            new IrcNetwork("RusNet", "irc.run.net", 6667,true),
            new IrcNetwork("ExplosionIRC", "irc.explosionirc.net"),
            new IrcNetwork("IrCQ-Net", "irc.icq.com"),
            new IrcNetwork("IRCHighWay", "irc.irchighway.net"),
            new IrcNetwork("EsperNet", "irc.esper.net"),
            new IrcNetwork("euIRC", "irc.euirc.net"),
            new IrcNetwork("P2P-NET", "irc.p2p-irc.net"),
            new IrcNetwork("Mibbit", "irc.mibbit.com"),
            new IrcNetwork("kiss0fdeath", "irc.kiss0fdeath.net"),
            new IrcNetwork("P2P-NET.EU", "titan.ca.p2p-net.eu"),
            new IrcNetwork("2ch [JP]", "irc.2ch.net", 6667,true),
            new IrcNetwork("SorceryNet", "irc.sorcery.net", 9000),
            new IrcNetwork("FurNet", "irc.furnet.org"),
            new IrcNetwork("GIMPnet", "irc.gimp.org"),
            new IrcNetwork("Coldfront", "irc.coldfront.net"),
            new IrcNetwork("MindForge", "irc.mindforge.org"),
            new IrcNetwork("Zurna.Net [TR]","irc.zurna.net",6667,true),
            new IrcNetwork("7-indonesia [ID]", "irc.7-indonesia.org", 6667,true),
            new IrcNetwork("EpiKnet", "irc.epiknet.org"),
            new IrcNetwork("EnterTheGame", "irc.enterthegame.com"),
            new IrcNetwork("DalNet(ru) [RU]", "irc.chatnet.ru", 6667,true),
            new IrcNetwork("GalaxyNet", "irc.galaxynet.org"),
            new IrcNetwork("Omerta", "irc.barafranca.com"),
            new IrcNetwork("SlashNET", "irc.slashnet.org"),
            new IrcNetwork("DarkMyst", "irc2.darkmyst.org"),
            new IrcNetwork("iZ-smart.net", "irc.iZ-smart.net"),
            new IrcNetwork("ItaLiaN-AmiCi [IT]", "irc.italian-amici.com", 6667,true),
            new IrcNetwork("Aitvaras [LT]", "irc.data.lt", 6667,true),
            new IrcNetwork("V-IRC [RU]", "irc.v-irc.ru", 6667,true),
            new IrcNetwork("ByroeNet [ID]", "irc.byroe.net", 6667,true),
            new IrcNetwork("Azzurra [IT]", "irc.azzurra.org", 6667,true),
            new IrcNetwork("Europa-IRC.DE [DE]", "irc.europa-irc.de", 6667,true),
            new IrcNetwork("ByNets [BY]", "irc.bynets.org", 6667,true),
            new IrcNetwork("GRNet [GR]", "global.irc.gr", 6667,true),
            new IrcNetwork("OceanIRC", "irc.oceanirc.net"),
            new IrcNetwork("UniBG [BG]", "irc.ITDNet.net", 6667,true),
            new IrcNetwork("KampungChat.Org [MY]", "irc.kampungchat.org", 6667,true),
            new IrcNetwork("WeNet [RU]", "ircworld.ru", 6667,true),
            new IrcNetwork("Stratics", "irc.stratics.com"),
            new IrcNetwork("Mozilla", "irc.mozilla.org"),
            new IrcNetwork("bondage.com", "irc.bondage.com"),
            new IrcNetwork("ShakeIT [BG]", "irc.index.bg", 6667,true),
            new IrcNetwork("NetGamers.Org", "firefly.no.eu.netgamers.org"),
            new IrcNetwork("FroZyn", "irc.Frozyn.us"),
            new IrcNetwork("PTnet", "irc.ptnet.org"),
            new IrcNetwork("Recycled-IRC", "yare.recycled-irc.net"),
            new IrcNetwork("Foonetic", "irc.foonetic.net"),
            new IrcNetwork("AlphaIRC", "irc.alphairc.com"),
            new IrcNetwork("KreyNet", "chat.be.krey.net"),
            new IrcNetwork("GeekShed", "irc.geekshed.net"),
            new IrcNetwork("VirtuaLife.com.br [BR]", "irc.virtualife.com.br", 6667,true),
            new IrcNetwork("IRCGate.it [IT]", "marte.ircgate.it", 6667,true),
            new IrcNetwork("Worldnet", "irc.worldnet.net"),
            new IrcNetwork("PIK [BA]", "irc.krstarica.com", 6667,true),
            new IrcNetwork("Friend4ever [IT]", "irc.friend4ever.it", 6667,true),
            new IrcNetwork("AustNet", "irc.austnet.org"),
            new IrcNetwork("GamesNET","irc.GamesNET.net")
        }.OrderBy(network => network.Name).ToArray();

        internal static void cIRCList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IrcScreen.cIRCList.SelectedIndex < 0) return;
            var selectedNetwork = (string) IrcScreen.cIRCList.Items[IrcScreen.cIRCList.SelectedIndex];
            var network = IrcNetworks.First(n => (n.Name == selectedNetwork));
            IrcScreen.tIRCBotNetwork.Text = network.Host;
            IrcScreen.nIRCBotPort.Value = network.Port;
        }

        internal static void xIRCListShowNonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            FillIrcNetworkList(IrcScreen.xIRCListShowNonEnglish.Checked);
        }

        static void FillIrcNetworkList(bool showNonEnglishNetworks)
        {
            IrcScreen.cIRCList.Items.Clear();
            foreach (var network in IrcNetworks.Where(network => showNonEnglishNetworks || !network.IsNonEnglish))
            {
                IrcScreen.cIRCList.Items.Add(network.Name);
            }
        }

        internal static void xIRCRegisteredNick_CheckedChanged(object sender, EventArgs e)
        {
            IrcScreen.tIRCNickServ.Enabled = IrcScreen.xIRCRegisteredNick.Checked;
            IrcScreen.tIRCNickServMessage.Enabled = IrcScreen.xIRCRegisteredNick.Checked;
        }
        #endregion



    }

}
