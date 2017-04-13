using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemsCraftGUI.ConfigGUI.GUITabs
{
    public partial class MainScreen : BaseTab
    {
        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void tileGeneral_Click(object sender, EventArgs e)
        {
            Program.GeneralConfig = new ConfigScreens.GeneralConfig();
            Program.GeneralConfig.ShowDialog();
        }

        private void tileRanks_Click(object sender, EventArgs e)
        {
            Program.RankConfig = new ConfigScreens.RankConfig();
            Program.RankConfig.ShowDialog();
        }
    }
}
