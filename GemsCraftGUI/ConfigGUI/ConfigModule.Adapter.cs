using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using fCraft;
using fCraft.ConfigGUI;
using JetBrains.Annotations;
using static GemsCraftGUI.Program;

namespace GemsCraftGUI.ConfigGUI.GUITabs
{
    partial class ConfigModule
    {
        // Moved SaveEverything() to Adapter
        internal static void SaveEverything()
        {
            using (LogRecorder applyLogger = new LogRecorder())
            {
                MainForm.SaveConfig();
                if (applyLogger.HasMessages)
                {
                    MessageBox.Show(applyLogger.MessageString, "Some problems were encountered with the selected values.");
                    return;
                }
            }
            using (LogRecorder saveLogger = new LogRecorder())
            {
                if (saveLogger.HasMessages)
                {
                    MessageBox.Show(saveLogger.MessageString, "Some problems were encountered while saving.");
                }
            }
        }
        
    }
}
