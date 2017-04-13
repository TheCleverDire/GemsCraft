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
    // 667, 592
    public partial class BaseTab : Form
    {
        public BaseTab()
        {
            InitializeComponent();
            TopLevel = false;
            Location = new Point(0, 0);
            Visible = true;
            this.ControlBox = false;
        }
    }
}
