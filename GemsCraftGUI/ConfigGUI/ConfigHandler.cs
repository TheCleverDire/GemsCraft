using fCraft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft.ConfigGUI;
using GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens;
using JetBrains.Annotations;

namespace GemsCraftGUI.ConfigGUI
{
    public class ConfigHandler
    {
        public static bool UsePrefixes;
        public static Rank _selectedRank;
        public static string ToComboBoxOption(fCraft.Rank rank)
        {
            return UsePrefixes ? $"{rank.Prefix,1}{rank.Name}" : rank.Name;
        }

        static void FillRankList([NotNull] ComboBox box, string firstItem)
        {
            if (box == null) throw new ArgumentNullException("box");
            box.Items.Clear();
            box.Items.Add(firstItem);
            foreach (var rank in RankManager.Ranks)
            {
                box.Items.Add(ToComboBoxOption(rank));
            }
        }
        public static void RebuildRankList()
        {
            Program.RankConfig.vRanks.Items.Clear();
            foreach (var rank in RankManager.Ranks)
            {
                Program.RankConfig.vRanks.Items.Add(ToComboBoxOption(rank));
            }

            FillRankList(Program.GeneralConfig.cDefaultRank, "(lowest rank)");
            Program.GeneralConfig.cDefaultRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultRank);
            /// FillRankList(cDefaultBuildRank, "(default rank)"); TODO - Add to WorldConfig
            /// cDefaultBuildRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultBuildRank); TODO - Same
            /// FillRankList(cPatrolledRank, "(default rank)"); TODO - Add to Security
            //// cPatrolledRank.SelectedIndex = RankManager.GetIndex(RankManager.PatrolledRank);
            //// FillRankList(cBlockDBAutoEnableRank, "(default rank)");
            ///  cBlockDBAutoEnableRank.SelectedIndex = RankManager.GetIndex(RankManager.BlockDbAutoEnableRank);

            if (_selectedRank != null)
            {
                Program.RankConfig.vRanks.SelectedIndex = _selectedRank.Index;
            }
            SelectRank(_selectedRank);

            foreach (var box in _permissionLimitBoxes.Values)
            {
                box.RebuildList();
                box.SelectRank(_selectedRank);
            }
        }

        public static BindingList<string> _rankNameList;

        public static void SelectRank(Rank rank)
        {
            if (rank == null)
            {
                if (Program.RankConfig.vRanks.SelectedIndex != -1)
                {
                    Program.RankConfig.vRanks.ClearSelected();
                    return;
                }
                DisableRankOptions();
                return;
            }
            if (Program.RankConfig.vRanks.SelectedIndex != rank.Index)
            {
                Program.RankConfig.vRanks.SelectedIndex = rank.Index;
                return;
            }
            _selectedRank = rank;
            Program.RankConfig.tRankName.Text = rank.Name;

            ApplyColor(Program.RankConfig.bColorRank, fCraft.Color.ParseToIndex(rank.Color));

            Program.RankConfig.tPrefix.Text = rank.Prefix;

            foreach (var box in _permissionLimitBoxes.Values)
            {
                box.SelectRank(rank);
            }

            Program.RankConfig.xReserveSlot.Checked = rank.ReservedSlot;
            Program.RankConfig.xKickIdle.Checked = rank.IdleKickTimer > 0;
            Program.RankConfig.nKickIdle.Value = rank.IdleKickTimer;
            Program.RankConfig.nKickIdle.Enabled = Program.RankConfig.xKickIdle.Checked;
            Program.RankConfig.xAntiGrief.Checked = (rank.AntiGriefBlocks > 0 && rank.AntiGriefSeconds > 0);
            Program.RankConfig.nAntiGriefBlocks.Value = rank.AntiGriefBlocks;
            Program.RankConfig.nAntiGriefBlocks.Enabled = Program.RankConfig.xAntiGrief.Checked;
            Program.RankConfig.nAntiGriefSeconds.Value = rank.AntiGriefSeconds;
            Program.RankConfig.nAntiGriefSeconds.Enabled = Program.RankConfig.xAntiGrief.Checked;
            Program.RankConfig.xDrawLimit.Checked = (rank.DrawLimit > 0);
            Program.RankConfig.nDrawLimit.Value = rank.DrawLimit;
            Program.RankConfig.nCopyPasteSlots.Value = rank.CopySlots;
            Program.RankConfig.nFillLimit.Value = rank.FillLimit;
            Program.RankConfig.xAllowSecurityCircumvention.Checked = rank.AllowSecurityCircumvention;

            foreach (ListViewItem item in Program.RankConfig.vPermissions.Items)
            {
                item.Checked = rank.Permissions[item.Index];
                item.Font = item.Checked ? Program.RankConfig._bold : Program.RankConfig.vPermissions.Font;
            }

            foreach (ListViewItem item in Program.RankConfig.vPermissions.Items)
            {
                CheckPermissionConsistency((Permission)item.Tag, item.Checked);
            }

            Program.RankConfig.xDrawLimit.Enabled = rank.Can(Permission.Draw) || rank.Can(Permission.CopyAndPaste);
            Program.RankConfig.nDrawLimit.Enabled = Program.RankConfig.xDrawLimit.Checked;
            Program.RankConfig.xAllowSecurityCircumvention.Enabled = rank.Can(Permission.ManageWorlds) || rank.Can(Permission.ManageZones);

            Program.RankConfig.gRankOptions.Enabled = true;
            Program.RankConfig.lPermissions.Enabled = true;
            Program.RankConfig.vPermissions.Enabled = true;

            Program.RankConfig.bDeleteRank.Enabled = true;
            Program.RankConfig.bRaiseRank.Enabled = (_selectedRank != RankManager.HighestRank);
            Program.RankConfig.bLowerRank.Enabled = (_selectedRank != RankManager.LowestRank);
        }

        public static void DisableRankOptions()
        {
            _selectedRank = null;
            Program.RankConfig.bDeleteRank.Enabled = false;
            Program.RankConfig.bRaiseRank.Enabled = false;
            Program.RankConfig.bLowerRank.Enabled = false;
            Program.RankConfig.tRankName.Text = "";
            Program.RankConfig.bColorRank.Text = "";
            Program.RankConfig.tPrefix.Text = "";

            foreach (var box in _permissionLimitBoxes.Values)
            {
                box.SelectRank(null);
            }

            Program.RankConfig.xReserveSlot.Checked = false;
            Program.RankConfig.xKickIdle.Checked = false;
            Program.RankConfig.nKickIdle.Value = 0;
            Program.RankConfig.xAntiGrief.Checked = false;
            Program.RankConfig.nAntiGriefBlocks.Value = 0;
            Program.RankConfig.xDrawLimit.Checked = false;
            Program.RankConfig.nDrawLimit.Value = 0;
            Program.RankConfig.xAllowSecurityCircumvention.Checked = false;
            Program.RankConfig.nCopyPasteSlots.Value = 0;
            Program.RankConfig.nFillLimit.Value = 32;
            foreach (ListViewItem item in Program.RankConfig.vPermissions.Items)
            {
                item.Checked = false;
                item.Font = Program.RankConfig.vPermissions.Font;
            }
            Program.RankConfig.gRankOptions.Enabled = false;
            Program.RankConfig.lPermissions.Enabled = false;
            Program.RankConfig.vPermissions.Enabled = false;
        }

        #region Colors
        public static int _colorSys, _colorSay, _colorHelp, _colorAnnouncement, _colorPm, _colorIrc, _colorMe, _colorWarning, _colorCustom, _colorGlobal;

        public static void ApplyColor(Button button, int color)
        {
            button.Text = fCraft.Color.GetName(color);
            button.BackColor = ColorPicker.ColorPairs[color].Background;
            button.ForeColor = ColorPicker.ColorPairs[color].Foreground;
        }

        #endregion

        public static readonly Dictionary<Permission, PermissionLimitBox> _permissionLimitBoxes = new Dictionary<Permission, PermissionLimitBox>();

        const string DefaultPermissionLimitString = "(own rank)";
        public static void FillPermissionLimitBoxes()
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
                Program.RankConfig.permissionLimitBoxContainer.Controls.Add(box);
            }
        }

        public static void CheckPermissionConsistency(Permission permission, bool check)
        {
            switch (permission)
            {
                case Permission.Chat:
                    if (!check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.Say].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.Say].ForeColor = SystemColors.GrayText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.UseColorCodes].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.UseColorCodes].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.Say].ForeColor = SystemColors.ControlText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.UseColorCodes].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.Say:
                    if (check) Program.RankConfig.vPermissions.Items[(int)Permission.Chat].Checked = true;
                    break;

                case Permission.UseColorCodes:
                    if (check) Program.RankConfig.vPermissions.Items[(int)Permission.Chat].Checked = true;
                    break;

                case Permission.Ban:
                    if (!check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanIP].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanIP].ForeColor = SystemColors.GrayText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanAll].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanIP].ForeColor = SystemColors.ControlText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.BanIP:
                    if (check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.Ban].Checked = true;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanAll].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanAll].ForeColor = SystemColors.GrayText;
                    }
                    break;

                case Permission.BanAll:
                    if (check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.Ban].Checked = true;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BanIP].Checked = true;
                    }
                    break;

                case Permission.Draw:
                    Program.RankConfig.xDrawLimit.Enabled = Program.RankConfig.vPermissions.Items[(int)Permission.Draw].Checked ||
                                         Program.RankConfig.vPermissions.Items[(int)Permission.CopyAndPaste].Checked;
                    if (check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.DrawAdvanced].ForeColor = SystemColors.ControlText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.CopyAndPaste].ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.DrawAdvanced].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.DrawAdvanced].ForeColor = SystemColors.GrayText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.CopyAndPaste].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.CopyAndPaste].ForeColor = SystemColors.GrayText;
                    }
                    break;

                case Permission.DrawAdvanced:
                    Program.RankConfig.lFillLimit.Enabled = check;
                    Program.RankConfig.lFillLimitUnits.Enabled = check;
                    Program.RankConfig.nFillLimit.Enabled = check;
                    break;

                case Permission.CopyAndPaste:
                    Program.RankConfig.xDrawLimit.Enabled = Program.RankConfig.vPermissions.Items[(int)Permission.Draw].Checked ||
                                         Program.RankConfig.vPermissions.Items[(int)Permission.CopyAndPaste].Checked;
                    Program.RankConfig.lCopyPasteSlots.Enabled = check;
                    Program.RankConfig.nCopyPasteSlots.Enabled = check;
                    break;

                case Permission.ManageWorlds:
                case Permission.ManageZones:
                    Program.RankConfig.xAllowSecurityCircumvention.Enabled = Program.RankConfig.vPermissions.Items[(int)Permission.ManageWorlds].Checked ||
                                                         Program.RankConfig.vPermissions.Items[(int)Permission.ManageZones].Checked;
                    break;

                case Permission.Teleport:
                    if (!check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.Patrol].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.Patrol].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.Patrol].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.Patrol:
                    if (check) Program.RankConfig.vPermissions.Items[(int)Permission.Teleport].Checked = true;
                    break;

                case Permission.Delete:
                    if (!check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.DeleteAdmincrete].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.DeleteAdmincrete].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.DeleteAdmincrete].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.DeleteAdmincrete:
                    if (check) Program.RankConfig.vPermissions.Items[(int)Permission.Delete].Checked = true;
                    break;

                case Permission.Build:
                    if (!check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceAdmincrete].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceAdmincrete].ForeColor = SystemColors.GrayText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceGrass].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceGrass].ForeColor = SystemColors.GrayText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceLava].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceLava].ForeColor = SystemColors.GrayText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceWater].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceWater].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceAdmincrete].ForeColor = SystemColors.ControlText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceGrass].ForeColor = SystemColors.ControlText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceLava].ForeColor = SystemColors.ControlText;
                        Program.RankConfig.vPermissions.Items[(int)Permission.PlaceWater].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.PlaceAdmincrete:
                case Permission.PlaceGrass:
                case Permission.PlaceLava:
                case Permission.PlaceWater:
                    if (check) Program.RankConfig.vPermissions.Items[(int)Permission.Build].Checked = true;
                    break;

                case Permission.Bring:
                    if (!check)
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.BringAll].Checked = false;
                        Program.RankConfig.vPermissions.Items[(int)Permission.BringAll].ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        Program.RankConfig.vPermissions.Items[(int)Permission.BringAll].ForeColor = SystemColors.ControlText;
                    }
                    break;

                case Permission.BringAll:
                    if (check) Program.RankConfig.vPermissions.Items[(int)Permission.Bring].Checked = true;
                    break;

            }

            if (_permissionLimitBoxes.ContainsKey(permission))
            {
                _permissionLimitBoxes[permission].PermissionToggled(check);
            }
        }
    }
}
