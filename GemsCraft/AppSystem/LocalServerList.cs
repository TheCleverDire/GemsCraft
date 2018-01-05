using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemsCraftGUI;
using Newtonsoft.Json;

namespace GemsCraft.AppSystem
{
    public class LocalServerList
    {
        public static List<Server> Servers { get; private set; }
        private const string ListFile = "server_list.json";

        internal static void FirstStart()
        {
            Servers = new List<Server>();
            Save();
        }

        public static bool Load()
        {
            try
            {
                Servers = JsonConvert.DeserializeObject<List<Server>>(File.ReadAllText(ListFile));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Servers, Formatting.Indented);
                StreamWriter fileWriter = File.CreateText(ListFile);

                fileWriter.Write(json);
                fileWriter.Flush();
                fileWriter.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
