using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using fCraft.Events;
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
            foreach (var d in PrisonData.Obj.Prisoners)
            {
                if (d.Username != p.Info.Name) continue;
                PrisonData.Obj.Prisoners.Remove(d);
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
        public static PrisonObj Obj = new PrisonObj();
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
            SetUpData();
            foreach (var w in WorldManager.Worlds)
            {
                if (w.Name == Obj.World)
                {
                    WorldManager.PrisonWorld = w;
                }
            }

            Logger.Log(LogType.SystemActivity, "There are currently " + Obj.Prisoners.Count + " players in Prison");

            Server.PlayerListChanged += CheckForIn;
            Player.JoiningWorld += CheckForIn;
            Player.Connected += SendMessage;
        }

        private static void SendMessage(object sender, PlayerConnectedEventArgs e)
        {
            var p = e.Player;
            if (p.IsPrisoner())
            {
                var timeStr = Obj.Prisoners.Where(
                    p2 => p2.Username == p.Info.Name).Aggregate(
                    "&4You are still a prisoner (Time left: ", 
                    (current, p2) => current + 
                    (p2.LeaveDate - DateTime.Now).ToMiniString());
                p.Message(timeStr + ")");
            }
        }


        public static void SetUpData()
        {
            if (File.Exists(PrisonDataFile))
            {
                Obj = JsonConvert.DeserializeObject<PrisonObj>(File.ReadAllText(PrisonDataFile));
                SaveData();
            }
            try
            {
                Obj.Prisoners = Obj.Prisoners.Where(p => p.LeaveDate > DateTime.Now).ToList();
                SaveData();
            }
            catch (ArgumentNullException)
            {
                File.Delete(PrisonDataFile);
                Obj.Prisoners = new List<PrisonData>();
                Init();
                return;
            }
        }
        private static void CheckForIn(object sender, EventArgs e)
        {
            foreach (var p2 in Server.Players)
            {
                if (p2.IsPrisoner())
                {
                    p2.JoinWorld(WorldManager.PrisonWorld, WorldChangeReason.Prisoner);
                }
            }
        }


        public static void SaveData()
        {
            var fileWriter = File.CreateText(PrisonDataFile);
            fileWriter.Write(JsonConvert.SerializeObject(Obj, Formatting.Indented));
            fileWriter.Flush();
            fileWriter.Close();
        }
        public static void EnterNewData(Player p, string reason, Player actingP, DateTime leaveDate)
        {
            Obj.Prisoners.Add(new PrisonData
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

    public class PrisonObj
    {
        public List<PrisonData> Prisoners = new List<PrisonData>();
        public string World;
    }
}
