using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using GemsCraft;
using GemsCraft.AppSystem;
using GemsCraft.GUI;
using GemsCraft.Network;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

using static Microsoft.VisualBasic.Interaction;
namespace GemsCraftGUI
{
    public partial class MainScreen : MetroForm
    {
        public MainScreen()
        {
            InitializeComponent();
            if (File.Exists("Update.zip")) File.Delete("Update.zip");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string inputServerName = GetServerName(-1);
            DownloadServer(inputServerName);
        }
        
        private readonly Server _serverObj = new Server();
        private void DownloadServer(string name)
        {
            _serverObj.Name = name;
            _serverObj.Dir = name + "/";
            
            var window = new VersionSelector();
            window.Show();

            // Determine Legacy setup or modern
            _serverObj.TypeOfGems = window.SelectedVersion[0].ToString().ToLower() == "a" ? ApplicationType.Legacy : ApplicationType.Modern;
            _serverObj.SoftwareVersion = window.SelectedVersion;
            string downloadPath = "http://apotter96.com/software/GemsCraft/Download/" +
                                          window.SelectedVersion + ".zip";
            DownloadForm downloadWindow = new DownloadForm(downloadPath, "update.zip");
            downloadWindow.FormClosed += UnZip;
            downloadWindow.ShowDialog();
        }

        private void UnZip(object sender, FormClosedEventArgs e)
        {
            ZipArchive archive = ZipFile.Open("update.zip", ZipArchiveMode.Read);
            archive.ExtractToDirectory(_serverObj.Name + "/");

            string[] contents = File.ReadAllLines(_serverObj.Dir + "config.xml");
            int loopCount = 0;
            foreach (string x in contents)
            {
                if (x.Contains("key=\"ServerName\""))
                {
                    contents[loopCount] = "" +
                                          "<ConfigKey key=\"ServerName\" " +
                                          "value=\"" + _serverObj.Name + "\" default=\"[GemsCraft] Default\" />";
                    File.Delete(_serverObj.Dir + "config.xml");
                    var writer = File.CreateText(_serverObj.Dir + "config.xml");
                    foreach (var writeLine in contents)
                    {
                        writer.WriteLine(writeLine);
                    }
                    writer.Flush();
                    writer.Close();
                }
                loopCount++;
            }
            LocalServerList.Servers.Add(_serverObj);
            LocalServerList.Save();

            MetroFramework.MetroMessageBox.Show(this, "The server was successfully setup.");
        }
        /*
         * TODO
         * Create a SAMPLE
         * Config.xml for each version and add it to each download
         * So that when the software downloads the server, it can update the server name as well
         * 
         */
        private string GetServerName(int errorCode)
        {
            while (true)
            {
                string superName =
                    "Please enter a server name. The directory will be saved with your servername as its name. ";
                // ReSharper disable once ConvertIfStatementToSwitchStatement
                if (errorCode == 0)
                {
                    superName += " Value cannot be empty";
                }
                else if (errorCode == 1)
                {
                    superName += " Special characters other than a +, -, _, () are not allowed";
                }
                string result = InputBox(superName, "Server Name");
                if (result == "")
                {
                    errorCode = 0;
                    continue;
                }
                var regexItem = new Regex("^[a-zA-Z0-9 +-_()]*$");

                if (!regexItem.IsMatch(result))
                {
                    errorCode = 1;
                    continue;
                }
                DialogResult dResult = MetroMessageBox.Show(this, "Is the name " + result + " ok?", "Ok?", MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {
                    return result;
                }
                errorCode = -1;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            UpdateServerList();
            if (serverBox.Items.Count == 0)
            {
                DialogResult result = MetroMessageBox.Show(this,
                    "There are currently no servers. Would you like to add one? (Note: If a server already exists, hit \"No\" " +
                    "and hit \"Import Server\").", "Welcome", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    metroButton1_Click(sender, e);
                    UpdateServerList();
                }
            }
        }

        private void UpdateServerList()
        {
            serverBox.Items.Clear();
            foreach (Server server in LocalServerList.Servers)
            {
                serverBox.Items.Add(server.Name);
            }

        }
        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            int index = serverBox.SelectedIndex;
            if (index < 0)
            {
                MetroMessageBox.Show(this, "Please select a server to delete", "Select a Server");
                return;
            }

            DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to remove this server?",
                "Remove Server", MessageBoxButtons.YesNo);
            // ReSharper disable once InvertIf
            if (result == DialogResult.Yes)
            {
                LocalServerList.Servers.RemoveAt(index);
                LocalServerList.Save();
                UpdateServerList();
                result = MetroMessageBox.Show(this,
                    "Your server has been remove from the list. Do you want to delete the directory containing the server? This action cannot be undone",
                    "Delete Files", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(LocalServerList.Servers[index].Dir);
                    MetroMessageBox.Show(this, "The server has been completely removed. It no longer exists.");
                }
                else
                {
                    MetroMessageBox.Show(this, "The server has been removed fromt the list. The files remain still.");
                }
            }
        }

        private void btnImportServer_Click(object sender, EventArgs e)
        {
            StartImport();
        }

        private void StartImport()
        {
            Server server = new Server();
            ImportServerDialog.ShowDialog();
            string path = ImportServerDialog.SelectedPath;
            if (!Directory.Exists(path))
            {
                MetroMessageBox.Show(this, "Please select an existing directory");
                StartImport();
            }
            else
            {
                if (!File.Exists(path + "config.xml"))
                {
                    MetroMessageBox.Show(this,
                        "Unable to import server. config.xml does not exist.", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    server.Dir = path;
                    server.TypeOfGems = File.Exists(path + "GemsCraftGUI.exe") ? ApplicationType.Modern : ApplicationType.Legacy;
                    if (server.TypeOfGems == ApplicationType.Legacy)
                    {
                        if (!File.Exists("ServerGUI.exe"))
                        {
                            MetroMessageBox.Show(this,
                                "Unable to import server. ServerGUI.exe does not exist.", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XmlTextReader reader = new XmlTextReader(path + "config.xml");
                        while (reader.Read())
                        {
                            // Do some work here on the data.
                            MessageBox.Show(reader.Name);
                        }
                    }
                }
            }
        }
    }
}
