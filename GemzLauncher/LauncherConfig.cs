using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GemzLauncher
{
    internal class LauncherConfig
    {
        public static LauncherConfig User = new LauncherConfig();
        internal static string File = "launcher_config.json";
        public List<ServerInfo> ServerPaths = new List<ServerInfo>();

        internal static LauncherConfig Default = new LauncherConfig
        {
            ServerPaths = new List<ServerInfo>
            {
                new ServerInfo
                {
                    GuiPath = "GemsCraft/GemsCraftGUI.exe",
                    CliPath = "GemsCraft/ServerCLI.exe",
                    PreferCli = false,
                }
            },
        };

        public static void Save()
        {
            if (System.IO.File.Exists(File)) System.IO.File.Delete(File);
            var fileWriter = System.IO.File.CreateText(File);
            fileWriter.Write(JsonConvert.SerializeObject(User, Formatting.Indented));
            fileWriter.Flush();
            fileWriter.Close();
            return;
        }

        public static void Load()
        {
            User = 
                !System.IO.File.Exists(File) 
                ? Default 
                : JsonConvert.DeserializeObject<LauncherConfig>(System.IO.File.ReadAllText(File));
        }
    }

    public class ServerInfo
    {
        public string GuiPath = "GemsCraft/GemsCraftGUI.exe";
        public string CliPath = "GemsCraft/ServerCLI.exe";
        public bool PreferCli = false;

        public string MainPath()
        {
            return CliPath.Substring(0, CliPath.Replace("\\", "/").LastIndexOf("/")) + "/";
        }
    }
    
}
