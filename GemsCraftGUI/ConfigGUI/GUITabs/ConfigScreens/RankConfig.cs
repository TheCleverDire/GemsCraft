using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using fCraft.ConfigGUI;
using MetroFramework.Forms;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class RankConfig : MetroForm
    {
        public Font _bold;
        public RankConfig()
        {
            InitializeComponent();
            _bold = new Font(Font, FontStyle.Bold);

            bAddRank.Click += bAddRank_Click;
        }

        private void RankConfig_Load(object sender, EventArgs e)
        {
            Program.MainForm.ApplyTabRanks();
        }

        private void bAddRank_Click(object sender, EventArgs e)
        {
            var number = 1;
            while (RankManager.RanksByName.ContainsKey("rank" + number)) number++;

            var rank = new Rank("rank" + number, RankManager.GenerateId());

            RankManager.AddRank(rank);
            ConfigHandler._selectedRank = null;

            ConfigHandler.RebuildRankList();
            ConfigHandler.SelectRank(rank);

            ConfigHandler._rankNameList.Insert(rank.Index + 1, ConfigHandler.ToComboBoxOption(rank));
        }

        private void bDeleteRank_Click(object sender, EventArgs e)
        {
            if (vRanks.SelectedItem == null) return;
            ConfigHandler._selectedRank = null;
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
    }
}
