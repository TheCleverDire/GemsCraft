using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft.ConfigGUI;
using MetroFramework.Forms;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;
using static GemsCraftGUI.Program;
using System.IO;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class Worlds : ExtendedMetroForm
    {
        public Worlds()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                foreach (Control c in Controls)
                {
                    if (c.HasChildren)
                    {
                        foreach (Control cx in c.Controls)
                        {
                            cx.Enabled = false;
                        }
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = false;
                    }
                }
            }
        }

        private void bAddWorld_Click(object sender, EventArgs e)
        {
            AddWorldPopup popup = new AddWorldPopup(null);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                ConfigModule.Worlds.Add(popup.World);
                popup.World.LoadedBy = WorldListEntry.WorldInfoSignature;
                popup.World.LoadedOn = DateTime.UtcNow;
            }
            if (WorldScreen.cMainWorld.SelectedItem == null)
            {
                FillWorldList();
                if (WorldScreen.cMainWorld.Items.Count > 0)
                {
                    WorldScreen.cMainWorld.SelectedIndex = 0;
                }

            }
            else
            {
                string mainWorldName = WorldScreen.cMainWorld.SelectedItem.ToString();
                FillWorldList();
                WorldScreen.cMainWorld.SelectedItem = mainWorldName;
            }
        }

        private void bWorldEdit_Click(object sender, EventArgs e)
        {
            AddWorldPopup popup = new AddWorldPopup(ConfigModule.Worlds[WorldScreen.dgvWorlds.SelectedRows[0].Index]);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                string oldName = ConfigModule.Worlds[WorldScreen.dgvWorlds.SelectedRows[0].Index].Name;
                ConfigModule.Worlds[WorldScreen.dgvWorlds.SelectedRows[0].Index] = popup.World;
                HandleWorldRename(oldName, popup.World.Name);
            }
        }

        private void bWorldDelete_Click(object sender, EventArgs e)
        {
            if (WorldScreen.dgvWorlds.SelectedRows.Count > 0)
            {
                WorldListEntry world = ConfigModule.Worlds[WorldScreen.dgvWorlds.SelectedRows[0].Index];

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
                                            "An error occured while trying to delete it automatically:" +
                                            Environment.NewLine + ex,
                                "Could not delete map file");
                        }
                    }
                }

                ConfigModule.Worlds.Remove(world);

                if (WorldScreen.cMainWorld.SelectedItem == null)
                {
                    // deleting non-main world
                    FillWorldList();
                    if (WorldScreen.cMainWorld.Items.Count > 0)
                    {
                        WorldScreen.cMainWorld.SelectedIndex = 0;
                    }

                }
                else
                {
                    // deleting main world
                    string mainWorldName = WorldScreen.cMainWorld.SelectedItem.ToString();
                    FillWorldList();
                    if (mainWorldName == world.Name)
                    {
                        MessageBox.Show("Main world has been reset.");
                        if (WorldScreen.cMainWorld.Items.Count > 0)
                        {
                            WorldScreen.cMainWorld.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        WorldScreen.cMainWorld.SelectedItem = mainWorldName;
                    }
                }
            }
        }

        private void bMapPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                SelectedPath = WorldScreen.tMapPath.Text,
                Description = "Select a directory to save map files to"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WorldScreen.tMapPath.Text = dialog.SelectedPath;
            }
        }
    }
}
