using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using fCraft;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Color = System.Drawing.Color;
using static Microsoft.VisualBasic.Interaction;

namespace GemzLauncher
{
    public partial class MainForm : MetroForm
    {
        private int SelectedID = -1;
        private ServerButton _defaultButton = new ServerButton
        {
            Name = "_defaultButton",
            Width = 100,
            Height = 111,
            Text = "{Server}",
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.Transparent,
            ID = -1
        };
        // TODO - Setup new Updater and Server Launcher
        public MainForm()
        {
            InitializeComponent();
            _defaultButton.Click += ServerBtnClick;
            Text = "Gemz Launcher for GemsCraft " + Updater.GetCurrentOnline(true);
            LoadEverything();
        }

        private void LoadEverything()
        {
            serverPanel.Controls.Clear();
            LauncherConfig.Load();
            var loopCount = 0;
            foreach (ServerInfo sInfo in LauncherConfig.User.ServerPaths)
            {
                var btn = new ServerButton
                {
                    ID = loopCount,
                    Name = "button" + loopCount,
                    Tag = loopCount,
                    Text = _defaultButton.Text,
                    Height = _defaultButton.Height,
                    Width = _defaultButton.Width
                };
                btn.Text = btn.Text.Replace("{Server}", GetServerName(loopCount));
                serverPanel.Controls.Add(btn);
                loopCount++;
            }
        }

        private void ServerBtnClick(object sender, EventArgs e)
        {
            var button = (ServerButton)sender;
            if (button.ID < 0) return;
            SelectedID = button.ID;

            foreach (ServerButton btn in serverPanel.Controls)
            {
                button.BackColor = btn.ID == SelectedID ? Color.Aqua : Color.Transparent;
            }
        }

        private static string GetServerName(int id)
        {
            try
            {
                var paths = LauncherConfig.User.ServerPaths[id];
                var serverConfig = paths.MainPath() + "config.xml";
                var doc = new XmlDocument();
                doc.Load(serverConfig);
                var nodeObj = doc.DocumentElement.SelectSingleNode("/fCraftConfig/Settings");
                foreach (XmlNode n in nodeObj.ChildNodes)
                {
                    if (n.Name != "ConfigKey") continue;
                    if (n.Attributes[0].Value == "ServerName")
                    {
                        return n.Attributes[1].Value;
                    }
                }
            }
            catch
            {
                return "[GemsCraft] Default";
            }
            return null;
        }
        private void Start(int id)
        {
            var process =
                LauncherConfig.User.ServerPaths[id].PreferCli
                ? LauncherConfig.User.ServerPaths[id].CliPath
                : LauncherConfig.User.ServerPaths[id].GuiPath;
            Process.Start(new FileInfo(process).FullName);
            Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (SelectedID < 0) return;
            Start(SelectedID);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var dChooser = new VersionSelector();
            dChooser.ShowDialog();
            var chosen = dChooser.VersionSelected;
            var name = chosen.GetWords()[0];
            var code = chosen.Replace(name + " ", "");
            var webFile = "http://gemz.ml/Download/" + name + "/" + code + ".zip";
            var pathToDownload = GetPath(); // prompts for folder to unzip to

            new DownloadForm(webFile, pathToDownload).ShowDialog();
            var serverName = GetName(); // prompts for server name

            // Downloading default config.xml
            using (var client = new WebClient())
            {
                client.DownloadFile("http://gemz.ml/Download/config.xml", pathToDownload + "\\config.xml");
            }
            var xmlContext = File.ReadAllLines(pathToDownload + "\\config.xml");
            var newItems = 
                xmlContext.Select(line 
                => line.Contains("key=\"ServerName\"") 
                ? line.Replace("[GemsCraft] Default", serverName) 
                : line).ToList();
            var fileWriter = File.CreateText(pathToDownload + "\\config.xml");
            foreach (var line in newItems)
            {
                fileWriter.WriteLine(line);
            }
            fileWriter.Flush();
            fileWriter.Close();
            MessageBox.Show("Server by name of \"" + serverName +
                            "\" was successfully generated with GemsCraft Version " + chosen);
            LauncherConfig.User.ServerPaths.Add(
                new ServerInfo
                {
                    GuiPath = pathToDownload + "\\" + (name.ToLower() == "Alpha" ? "ConfigGUI.exe" : "GemsCraftGUI.exe"),
                    CliPath = pathToDownload + "\\ServerCLI.exe"
                });
            LauncherConfig.Save();
            LoadEverything();
        }

        private string GetPath()
        {
            while (true)
            {
                folderBrowserDialog1.ShowDialog();
                var selectedPath = folderBrowserDialog1.SelectedPath;
                if (selectedPath == null) continue;
                if (LauncherConfig.User.ServerPaths.All(folder => folder.MainPath() != selectedPath))
                    return selectedPath;
                MessageBox.Show(
                    "Please select a folder that does not contain a server already loaded by the Launcher.");
                return GetPath();
            }
        }

        static string GetName()
        {
            while (true)
            {
                var serverNameResponse = InputBox(
                    "Please enter the servername. Remember, it cannot be null", 
                    "Server name?", 
                    "[GemsCraft] Default");
                if (serverNameResponse != null) return serverNameResponse;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedID <= -1) return;
            var sServer = LauncherConfig.User.ServerPaths[SelectedID];
            var result =
                MessageBox.Show(
                    "WARNING: This operation cannot be undone. Once the server is deleted, it is gone forever.\n" +
                    "Are you sure you want to go through with deleting " + GetServerName(SelectedID) + "?",
                    "WARNING", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            Directory.Delete(sServer.MainPath(), true);
        }
    }

    internal class ServerButton : Button
    {
        public int ID;
    }
}
