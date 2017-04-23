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
using fCraft.GUI;
using static GemsCraftGUI.Program;
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
            GeneralScreen.ShowDialog();
        }

        private void tileRanks_Click(object sender, EventArgs e)
        {
            if (!Server.IsRunning)
            {
                RankScreen.ShowDialog();
            }
        }

        private void tileChat_Click(object sender, EventArgs e)
        {
            ChatScreen.ShowDialog();
        }

        private void tileWorlds_Click(object sender, EventArgs e)
        {
            if (!Server.IsRunning)
            {
                WorldScreen.ShowDialog();
            }
        }

        private void tileSecurity_Click(object sender, EventArgs e)
        {
            SecurityScreen.ShowDialog();
        }

        private void tileSavingAndBackup_Click(object sender, EventArgs e)
        {
            SavingBackupScreen.ShowDialog();
        }

        private void tileLogging_Click(object sender, EventArgs e)
        {
            LoggingScreen.ShowDialog();
        }

        private void tileIrc_Click(object sender, EventArgs e)
        {
            IrcScreen.ShowDialog();
        }

        private void tileAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedScreen.ShowDialog();
        }

        private void tileMisc_Click(object sender, EventArgs e)
        {
            MiscScreen.ShowDialog();
        }

        private void tileCpe_Click(object sender, EventArgs e)
        {
            CpeScreen.ShowDialog();
        }

        private void tileAbout_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ConfigModule.SaveEverything();
        }
    }
}
