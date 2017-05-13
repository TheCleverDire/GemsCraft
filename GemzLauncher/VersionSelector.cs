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
using Newtonsoft.Json;

namespace GemzLauncher
{
    public partial class VersionSelector : Form
    {
        public VersionSelector()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public string VersionSelected;
        private void VersionSelector_Load(object sender, EventArgs e)
        {
            var result = Updater.ExecutePhp("http://gemz.ml/Download/AllVersions.php");
            var obj = JsonConvert.DeserializeObject<List<string>>(result);
            foreach (var i in obj)
            {
                listBox1.Items.Add(i);
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            VersionSelected = listBox1.SelectedItem.ToString();
            Hide();
        }
    }
}
