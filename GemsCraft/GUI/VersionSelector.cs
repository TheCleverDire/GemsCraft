using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemsCraft.Network;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace GemsCraftGUI
{
    public partial class VersionSelector : MetroForm
    {
        private List<string> _alphaVersions = new List<string>();
        private List<string> _betaVersions = new List<string>();
        private List<string> _otherVersions = new List<string>();
        public VersionSelector()
        {
            InitializeComponent();

            string json = UrlExecution.Execute("http://apotter96.com/software/GemsCraft/Versions.txt");
            string[] o = JsonConvert.DeserializeObject<string[]>(json);

            // Organize the versions to their respective lists
            foreach (string version in o)
            {
                if (version.ToLower()[0].ToString() == "a")
                {
                    _alphaVersions.Add(version);
                }
                else if (version.ToLower()[0].ToString() == "b")
                {
                    _betaVersions.Add(version);
                }
                else
                {
                    _otherVersions.Add(version);
                }
            }
        }

        private void VersionSelector_Load(object sender, EventArgs e)
        {
            SetUpList();
        }

        private void SetUpList()
        {
            versionBox.Items.Clear();
            if (chkAlpha.Checked)
            {
                foreach (string version in _alphaVersions)
                {
                    versionBox.Items.Add("Alpha " + version.Substring(1));
                }
            }
            if (chkBeta.Checked)
            {
                foreach (string version in _betaVersions)
                {
                    versionBox.Items.Add("Beta " + version.Substring(1));
                }
            }

            foreach (string version in _otherVersions)
            {
                versionBox.Items.Add(version);
            }
        }
        private void chkAlpha_CheckedChanged(object sender, EventArgs e)
        {
            SetUpList();
        }

        public string SelectedVersion;
        public new void Show()
        {
            base.ShowDialog();
        }

        public new void ShowDialog()
        {
            throw new NotImplementedException();
        }
        private void chkBeta_CheckedChanged(object sender, EventArgs e)
        {
            SetUpList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (versionBox.SelectedIndex < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select a version", "Select One");
            }
            else
            {
                List<string> combined = new List<string>();
                if (chkAlpha.Checked)
                {
                    combined.AddRange(_alphaVersions);
                }
                if (chkBeta.Checked)
                {
                    combined.AddRange(_betaVersions);
                }
                combined.AddRange(_otherVersions);
                
                SelectedVersion = combined[versionBox.SelectedIndex];
            }
            Close();
        }
    }
}
