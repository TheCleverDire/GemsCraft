using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using fCraft.Network;
using Facebook;
using GemsCraftGUI.fCraftGUI;
using MetroFramework.Forms;
using Tweetinvi.Models;
using Tweetinvi;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class Misc : ExtendedMetroForm
    {
        public Misc()
        {
            InitializeComponent();
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            SocialMedia.AuthenticateTwitter();
        }

        private void chkSocial_CheckedChanged(object sender, EventArgs e)
        {
            btnTwitter.Enabled = chkSocial.Checked;
            ConfigKey.SocialMediaEnabled.TrySetValue(chkSocial.Checked);

            if (btnTwitter.Enabled == false)
            {
                ConfigKey.TwitterAuthenticated.TrySetValue(false);
            }
        }

        private void TwitterTimer_Tick(object sender, EventArgs e)
        {
            btnTwitter.Enabled = !ConfigKey.TwitterAuthenticated.Enabled();

            metroLabel1.Text = metroLabel1.Text.Replace("{0}", btnTwitter.Enabled ? "Not Authenticated" : "Authenticated");
            metroLabel1.ForeColor = btnTwitter.Enabled ? System.Drawing.Color.Maroon : System.Drawing.Color.Green;
        }
    }
}
