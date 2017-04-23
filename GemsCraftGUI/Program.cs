using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using fCraft.ConfigGUI;
using GemsCraftGUI.ConfigGUI.GUITabs;
using GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens;
using JetBrains.Annotations;
using static GemsCraftGUI.ConfigGUI.GUITabs.ConfigModule;
namespace GemsCraftGUI
{
    static class Program
    {
        internal static MainForm MainFormGUI;
        internal static MainScreen MainScreenGUI;

        internal static General GeneralScreen;
        internal static Ranks RankScreen;
        internal static ConfigGUI.GUITabs.ConfigScreens.Chat ChatScreen;
        internal static Worlds WorldScreen;
        internal static Security SecurityScreen;
        internal static SavingBackup SavingBackupScreen;
        internal static Logging LoggingScreen;
        internal static Irc IrcScreen;
        internal static Advanced AdvancedScreen;
        internal static Misc MiscScreen;
        internal static Cpe CpeScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            MainFormGUI = new MainForm();
            Application.Run(MainFormGUI);
            
        }

        
    }
}
