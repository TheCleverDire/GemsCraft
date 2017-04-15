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
        internal static MainForm MainFormGUI = new MainForm();
        internal static MainScreen MainScreenGUI = new MainScreen();

        internal static General GeneralScreen = new General();
        internal static Ranks RankScreen = new Ranks();
        internal static ConfigGUI.GUITabs.ConfigScreens.Chat ChatScreen = new ConfigGUI.GUITabs.ConfigScreens.Chat();
        internal static Worlds WorldScreen = new Worlds();
        internal static Security SecurityScreen = new Security();
        internal static SavingBackup SavingBackupScreen = new SavingBackup();
        internal static Logging LoggingScreen = new Logging();
        internal static Irc IrcScreen = new Irc();
        internal static Advanced AdvancedScreen = new Advanced();
        internal static Misc MiscScreen = new Misc();
        internal static Cpe CpeScreen = new Cpe();

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
