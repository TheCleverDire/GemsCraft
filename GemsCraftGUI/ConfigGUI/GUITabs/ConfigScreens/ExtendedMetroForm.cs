using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    public class ExtendedMetroForm : MetroForm
    {
        public ExtendedMetroForm() : base()
        {
            FormClosing += AppendMethod;
        }

        private void AppendMethod(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
