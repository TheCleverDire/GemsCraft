using fCraft;
using MetroFramework.Forms;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public partial class GeneralConfig : MetroForm
    {
        public GeneralConfig()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void GeneralConfig_Load(object sender, System.EventArgs e)
        {
            Program.MainForm.ApplyTabGeneral();
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            Program.MainForm.SaveGeneral();
            Program.MainForm.SaveEverything();
            Close();
        }
    }
}
