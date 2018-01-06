using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using GemsCraft.AppSystem;
using GemsCraft.Network;
using GemsCraftGUI;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.VisualBasic;

namespace GemsCraft.GUI
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
            UpdateServerList();
            MetroMessageBox.Show(this, "The server was successfully setup.");
        }

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
                string result = Interaction.InputBox(superName, "Server Name");
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
            metroLabel1.Text = UrlExecution.Execute("http://apotter96.com/php/Copyright.php?startyear=2013").Replace("&copy;", "©");
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
                    MetroMessageBox.Show(this, "The server has been removed from the list. The files remain still.");
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
                if (!File.Exists(path + "\\config.xml"))
                {
                    MetroMessageBox.Show(this,
                        "Unable to import server. config.xml does not exist.", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    server.Dir = path + "\\";
                    server.TypeOfGems = File.Exists(path + "\\GemsCraftGUI.exe") ? ApplicationType.Modern : ApplicationType.Legacy;
                    if (server.TypeOfGems == ApplicationType.Legacy)
                    {
                        if (!File.Exists(path + "\\ServerGUI.exe"))
                        {
                            MetroMessageBox.Show(this,
                                "Unable to import server. ServerGUI.exe does not exist.", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                    XmlTextReader reader = new XmlTextReader(path + "\\config.xml");
                    while (reader.Read())
                    {
                        // Reads the provided config for the name
                        if (reader.Name.ToLower() == "configkey")
                        {
                            string attribute = reader.GetAttribute("key");
                            if (attribute != null && attribute.ToLower() == "servername")
                            {
                                string attributeName = reader.GetAttribute("value");
                                server.Name = attributeName;
                            }
                        }
                    }
                    LocalServerList.Servers.Add(server);
                    LocalServerList.Save();
                }
            }
        }

        private void btnMoveDirectory_Click(object sender, EventArgs e)
        {
            int index = serverBox.SelectedIndex;
            if (index < 0)
            {
                MetroMessageBox.Show(this, "Please select a server to move", "Select a Server");
                return;
            }

            Server server = LocalServerList.Servers[index];
            DialogResult result = MetroMessageBox.Show(this,
                "This will overwrite any files that share the same name in this new directory. Continue?", "Warning",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                StartMove(server, index);
            }
        }

        private void StartMove(Server serverObj, int index)
        {
            Server server = serverObj;
            string oldPath = server.Dir;
            MoveServerDialog.ShowDialog();
            string path = MoveServerDialog.SelectedPath + "\\";
            if (!Directory.Exists(path))
            {
                MetroMessageBox.Show(this, "Please select an existing directory To place the contents in.\n" +
                    "If you need to make a new folder, click the new folder button on the dialog screen.");
                StartMove(server, index);
            }

            server.Dir = path;

            try
            {
                foreach (string file in Directory.GetFiles(oldPath))
                {
                    File.Copy(file, path + Path.GetFileName(file), true);
                    File.Delete(file);
                }
                Directory.Delete(oldPath);
                LocalServerList.Servers[index] = server;
                LocalServerList.Save();
            }
            catch
            {
                MetroMessageBox.Show(this,
                    "Unable to migrate the server. Please make sure you have the correct permissions", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openTimer_Tick(object sender, EventArgs e)
        {
            btnOpenServer.Enabled = serverBox.SelectedIndex >= 0;
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            LocalServerList.Servers[serverBox.SelectedIndex].OpenApplication();
        }
    }
}
