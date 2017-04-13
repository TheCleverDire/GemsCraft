using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using fCraft.ConfigGUI;
using GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens;
using JetBrains.Annotations;

namespace GemsCraftGUI
{
    static class Program
    {
        public static MainForm MainForm = new MainForm();
        public static GeneralConfig GeneralConfig = new GeneralConfig();
        public static RankConfig RankConfig = new RankConfig();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            Application.Run(MainForm);
        }

        
    }
}
