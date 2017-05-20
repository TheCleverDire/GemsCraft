// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using fCraft.Network;
using JetBrains.Annotations;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace fCraft {
    
    /// <summary> Checks for updates, and keeps track of current version/revision. </summary>
    public static class Updater
    {
        public const string CurrentVersionUrl = "http://gemz.ml/Download/Version.php";

        public static List<string> LatestStableList = new List<string>()
        {
            "Cobblestone", "1", "0", "1", null
        };

        public struct UpdaterVars
        {
            public string Name;
            public string Major;
            public string Minor;
            public string Revision;
            public string Build;
        }

        public static string ExecutePhp(string url)
        {
            var req = (HttpWebRequest)WebRequest.Create(url.Replace("@", "%40"));
            var res = req.GetResponse();
            // Obtain a 'Stream' object associated with the response object.
            var receiveStream = res.GetResponseStream();

            var encode = Encoding.GetEncoding("utf-8");

            // Pipe the stream to a higher level stream reader with the required encoding format. 
            Debug.Assert(receiveStream != null, "receiveStream != null");
            var readStream = new StreamReader(receiveStream, encode);
            var read = new char[256];

            // Read 256 charcters at a time.    
            var count = readStream.Read(read, 0, 256);

            var strf = "";
            while (count > 0)
            {
                // Dump the 256 characters on a string and display the string onto the console.
                var str = new string(read, 0, count);
                Console.Write(str);
                count = readStream.Read(read, 0, 256);
                strf = str;
            }

            Console.WriteLine("");
            // Release the resources of stream object.
            readStream.Close();

            // Release the resources of response object.
            res.Close();
            return strf;
        }
        public static string UserAgent => "GemsCraft " + LatestStable(false);

        public static string GetOnlineName()
        {
            var dataObj = GetCurrentOnline();
            return dataObj.Name;
        }
        public static string GetCurrentOnline(bool printName)
        {
            var dataObj = GetCurrentOnline();
            string finalVersion = dataObj.Major + "." + dataObj.Minor;
            if (printName) finalVersion = dataObj.Name + " " + finalVersion;
            if (dataObj.Revision != "empty")
            {
                finalVersion += "." + dataObj.Revision;
                if (dataObj.Build != "empty")
                {
                    finalVersion += "." + dataObj.Build;
                }
            }
            return finalVersion;
        }

        public static UpdaterVars GetCurrentOnline()
        {
            var webResult = ExecutePhp("http://gemz.ml/Download/Version.php");
            var dataObj = JsonConvert.DeserializeObject<UpdaterVars>(webResult);
            return dataObj;
        }
        #region Comparing

        private static readonly string[] Alphabet = {
            "a", "b", "c", "d", "e", "f",
            "g", "h", "i", "j", "k", "l",
            "m", "n", "o", "p", "q", "s",
            "t", "u", "v", "w", "x", "y",
            "z",
        };
        public enum CompareResult { Var1, Var2 }
        public static CompareResult CompareName(UpdaterVars uv1, UpdaterVars uv2)
        {
            // First, check phase
            var p1 = uv1.Name.ToCharArray()[0].ToString();
            int phase1 = -1;
            var loopCount = 0;
            foreach (var letter in Alphabet)
            {
                if (letter.ToLower() == p1.ToLower())
                {
                    phase1 = loopCount;
                }
                loopCount++;
            }
            loopCount = 0;
            var p2 = uv2.Name.ToCharArray()[0].ToString();
            int phase2 = -1;
            foreach (var letter in Alphabet)
            {
                if (letter.ToLower() == p2.ToLower())
                {
                    phase2 = loopCount;
                }
                loopCount++;
            }
            if (phase1 == phase2) return CompareResult.Var1;
            return phase1 > phase2 ? CompareResult.Var1 : CompareResult.Var2;
        }

        public static CompareResult CompareMajor(UpdaterVars uv1, UpdaterVars uv2)
        {
            var v1 = int.Parse(uv1.Major);
            var v2 = int.Parse(uv2.Major);
            if (v1 == v2) return CompareResult.Var1;
            return v1 > v2 ? CompareResult.Var1 : CompareResult.Var2;
        }

        public static CompareResult CompareMinor(UpdaterVars uv1, UpdaterVars uv2)
        {
            var v1 = int.Parse(uv1.Minor);
            var v2 = int.Parse(uv2.Minor);
            if (v1 == v2) return CompareResult.Var1;
            return v1 > v2 ? CompareResult.Var1 : CompareResult.Var2;
        }

        public static CompareResult CompareRevision(UpdaterVars uv1, UpdaterVars uv2)
        {
            var v1 = int.Parse(uv1.Revision);
            var v2 = int.Parse(uv2.Revision);
            if (v1 == v2) return CompareResult.Var1;
            return v1 > v2 ? CompareResult.Var1 : CompareResult.Var2;
        }

        public static CompareResult CompareBuild(UpdaterVars uv1, UpdaterVars uv2)
        {
            var v1 = int.Parse(uv1.Major);
            var v2 = int.Parse(uv2.Major);
            if (v1 == v2) return CompareResult.Var1;
            return v1 > v2 ? CompareResult.Var1 : CompareResult.Var2;
        }

        public static bool IsUpdated()
        {
            var user = LatestStable();
            var online = GetCurrentOnline();

            var name = CompareName(user, online);
            var major = CompareMajor(user, online);
            var minor = CompareMinor(user, online);
            
            
            var GoodResult = true;

            // Check Name
            GoodResult = name != CompareResult.Var2;
            if (!GoodResult) return false;

            // Check Major
            GoodResult = major != CompareResult.Var2;
            if (!GoodResult) return false;

            // Check Minor
            GoodResult = minor != CompareResult.Var2;
            if (!GoodResult) return false;

            if (online.Revision == "empty")
            {
                return GoodResult;
            }
            // Check Revision
            if (user.Revision != null)
            {
                var revision = CompareRevision(user, online);
                GoodResult = revision != CompareResult.Var2;
                if (!GoodResult) return false;
                if (online.Build == "empty")
                {
                    return GoodResult;
                }
                // Check Build
                if (user.Build != null)
                {
                    var build = CompareBuild(user, online);
                    GoodResult = build != CompareResult.Var2;
                    if (!GoodResult) return false;
                }
            }
            return GoodResult;
        }

        #endregion

        

        public static UpdaterVars LatestStable()
        {
            return new UpdaterVars
            {
                Name = LatestStableList[0],
                Major = LatestStableList[1],
                Minor = LatestStableList[2],
                Revision = LatestStableList[3],
                Build = LatestStableList[4]
            };
        }
        public static string LatestStable(bool printName)
        {
            var dataObj = LatestStable();
            string finalVersion = dataObj.Major + "." + dataObj.Minor;
            if (printName) finalVersion = dataObj.Name + " " + finalVersion;
            if (dataObj.Revision != null)
            {
                finalVersion += "." + dataObj.Revision;
                if (dataObj.Build != null)
                {
                    finalVersion += "." + dataObj.Build;
                }
            }
            return finalVersion;
        }
        public static string UpdateUrl { get; set; }

        public static bool RunAtShutdown { get; set; }

        public static List<string> AllVersions()
        {
            return GetUrlSourceAsList("http://gemz.ml/Download/AllVersions.txt");
        }
        public static List<string> GetUrlSourceAsList(string urlF)
        {
            var temp = "webcheck";
            var c = File.CreateText(temp);

            c.Close();
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(urlF, temp);
                }
                catch (Exception)
                {
                    Logger.Log(LogType.Warning, "Unable to access webfile!");
                }

            }
            return File.ReadAllLines(temp).ToList();
        }
    }
    

    
}

