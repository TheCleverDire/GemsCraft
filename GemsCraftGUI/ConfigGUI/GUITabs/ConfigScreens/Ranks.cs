using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class Ranks : ExtendedMetroForm
    {
        public Ranks()
        {
            InitializeComponent();
        }

        private void Ranks_Load(object sender, EventArgs e)
        {
            
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!vPermissions.Enabled) return;
            for (var i = 0; i <= vPermissions.Items.Count - 1; i++)
            {
                vPermissions.Items[i].Checked = true;
            }
        }
    }
}
