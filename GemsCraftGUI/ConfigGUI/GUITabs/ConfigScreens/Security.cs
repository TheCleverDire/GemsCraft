using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using fCraft.Utils;
using MetroFramework.Forms;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;
using Color = System.Drawing.Color;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class Security : ExtendedMetroForm
    {
        public Security()
        {
            InitializeComponent();
            txtRemotePass.TextChanged += txtRemotePass_Click;
        }

        private void txtRemotePass_Click(object sender, EventArgs e)
        {
            if (txtRemotePass.Text.ToLower() == "password") return;
           
            switch (PasswordAdvisor.CheckStrength(txtRemotePass.Text))
            {
                case PasswordScore.VeryWeak:
                    metroLabel1.ForeColor = Color.Red;
                    metroLabel1.Text = "Very Weak";
                    break;
                case PasswordScore.Weak:
                    metroLabel1.ForeColor = Color.Maroon;
                    metroLabel1.Text = "Weak";
                    break;
                case PasswordScore.Medium:
                    metroLabel1.ForeColor = Color.Yellow;
                    metroLabel1.Text = "Medium";
                    break;
                case PasswordScore.Strong:
                    metroLabel1.ForeColor = Color.Lime;
                    metroLabel1.Text = "Strong";
                    break;
                case PasswordScore.VeryStrong:
                    metroLabel1.ForeColor = Color.Green;
                    metroLabel1.Text = "Very strong";
                    break;
            }
        }

        private void lPatrolledRank_Click(object sender, EventArgs e)
        {

        }

        private void cPatrolledRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  
        private void chkOnTheGo_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in metroTile1.Controls)
            {
                control.Enabled = chkOnTheGo.Checked;
            }
            chkOnTheGo.Enabled = true;
        }
    }
}
