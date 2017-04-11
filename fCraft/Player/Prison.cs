using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace fCraft
{
    public class Prison
    {
        
        public static void AddPlayer(Player p, string reason, Player actingP, DateTime leaveDate)
        {
            PrisonData.EnterNewData(p, reason, actingP, leaveDate);
            p.Message("&4You have been thrown in prison &f(" + reason + "&f) by " + actingP.ClassyName);
            Server.Message(p, "&4" + p.ClassyName + " &4has been thrown in prison &f(" + reason + "&f) by " +
                           actingP.ClassyName);
            PrisonData.SaveData();
        }

        public static void RemovePlayer(Player p, string reason, Player actingP)
        {
            foreach (var d in PrisonData.Data)
            {
                if (d.Username != p.Info.Name) continue;
                PrisonData.Data.Remove(d);
                p.Message("&2You have been freed from prison &f(" + reason + "&f) by " + actingP.ClassyName);
                Server.Message(p, "&2" + p.ClassyName + " &4has been freed prison &f(" + reason + "&f) by " +
                                  actingP.ClassyName);
            }
            PrisonData.SaveData();
        }
    }
    
    public class PrisonData
    {
        public static string PrisonDataFile = "Prison/data.json";
        public static List<PrisonData> Data = new List<PrisonData>();
        private static bool _messageShown;
        public static void Init()
        {
            if (!ConfigKey.PrisonEnabled.Enabled()) return;
            if (!_messageShown)
            {
                Logger.Log(LogType.SystemActivity, "Initiating the Prison System...");
                _messageShown = true;
            }
            if (!Directory.Exists("Prison/")) Directory.CreateDirectory("Prison/");
            if (File.Exists(PrisonDataFile))
            {
                Data = JsonConvert.DeserializeObject<List<PrisonData>>(File.ReadAllText(PrisonDataFile));
            }
            try
            {
                Data = Data.Where(p => p.LeaveDate > DateTime.Now).ToList();
            }
            catch (ArgumentNullException)
            {
                File.Delete(PrisonDataFile);
                Data = new List<PrisonData>();
                Init();
                return;
            }
            Logger.Log(LogType.SystemActivity, "There are currently " + Data.Count + " players in Prison");
        }

        public static void SaveData()
        {
            var fileWriter = File.CreateText(PrisonDataFile);
            fileWriter.Write(JsonConvert.SerializeObject(Data, Formatting.Indented));
            fileWriter.Flush();
            fileWriter.Close();
        }
        public static void EnterNewData(Player p, string reason, Player actingP, DateTime leaveDate)
        {
            Data.Add(new PrisonData
            {
                Username = p.Info.Name,
                EnterDate = DateTime.Now,
                LeaveDate = leaveDate,
                Reason = reason,
                EnforcerUsername = actingP.Info.Name,
                Active = true
            });
        }
        


        public string Username;
        public DateTime EnterDate;
        public DateTime LeaveDate;
        public string Reason;
        public string EnforcerUsername;
        public bool Active;
    }
}
