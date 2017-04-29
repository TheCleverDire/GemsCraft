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
using MetroFramework.Forms;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class Cpe : ExtendedMetroForm
    {
        public Cpe()
        {
            InitializeComponent();
        }

        

        private void chkMessageTypeAllowed_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in gboMessageType.Controls)
            {
                if (c.Name != "chkMessageTypeAllowed" || c.Name != "btnSeeKeyWords")
                {
                    c.Enabled = chkMessageTypeAllowed.Checked;
                }
            }
            chkMessageTypeAllowed.Enabled = true;
            btnSeeKeyWords.Enabled = true;
        }

        private void chkStatus1_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.Status1Enabled.TrySetValue(chkStatus1.Checked);
            ConfigKey.Status1Text.TrySetValue("");
            txtStatus1.Enabled = chkStatus1.Checked;
        }

        private void chkStatus2_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.Status2Enabled.TrySetValue(chkStatus2.Checked);
            ConfigKey.Status2Text.TrySetValue("");
            txtStatus2.Enabled = chkStatus2.Checked;
        }

        private void chkStatus3_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.Status3Enabled.TrySetValue(chkStatus3.Checked);
            ConfigKey.Status3Text.TrySetValue("");
            txtStatus3.Enabled = chkStatus3.Checked;
        }

        private void chkBottomRight3_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.Br3Enabled.TrySetValue(chkBottomRight3);
            ConfigKey.Br3Text.TrySetValue("");
            txtBottomRight3.Enabled = chkBottomRight3.Checked;
        }

        private void chkBottomRight2_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.Br2Enabled.TrySetValue(chkBottomRight2);
            ConfigKey.Br2Text.TrySetValue("");
            txtBottomRight2.Enabled = chkBottomRight2.Checked;
        }

        private void chkBottomRight1_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.Br1Enabled.TrySetValue(chkBottomRight1);
            ConfigKey.Br1Text.TrySetValue("");
            txtBottomRight1.Enabled = chkBottomRight1.Checked;
        }

        private void btnSeeKeyWords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageType is capable of using specific keywords.\n\n" +
                           "Insert these values (case sensitive) into your MT's to use them:\n" +
                           "{servername} = The server's name\n" +
                           "{rank} = The player's rank\n" +
                           "{world} = The player's current map\n" +
                           "{version} = The current GemsCraft version\n" +
                           "{player} = The player's username (Do not confused with nick)\n" +
                           "{lastcmd} = The player's last used command");
        }
        

        private void chkCustomBlocksAllowed_CheckedChanged(object sender, EventArgs e)
        {
            clbBlocks.Enabled = chkCustomBlocksAllowed.Checked;
        }
        

        private void chkEnvColorsAllowed_CheckedChanged(object sender, EventArgs e)
        {
            chkTimeBasedSky.Enabled = chkEnvColorsAllowed.Checked;
            numHourLength.Enabled = chkEnvColorsAllowed.Checked;
        }

        private void chkTimeBasedSky_CheckedChanged(object sender, EventArgs e)
        {
            numHourLength.Enabled = chkTimeBasedSky.Checked;
        }

        private void numHourLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkClickDistanceAllowed_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.ClickDistanceEnabled.TrySetValue(chkClickDistanceAllowed.Checked);
        }

        private void chkHeldBlockAllowed_CheckedChanged(object sender, EventArgs e)
        {
            ConfigKey.HeldBlockEnabled.TrySetValue(chkHeldBlockAllowed.Checked);
        }
    }
}
