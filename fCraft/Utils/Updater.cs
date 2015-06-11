// Copyright 2009-2012 Matvei Stefarov <me@matvei.org>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using JetBrains.Annotations;
using fCraft.Network;
using System.Diagnostics;
using System.IO;

namespace fCraft
{
    /// <summary> Checks for updates, and keeps track of current version/revision. </summary>
    public static class Updater
    {
        public static string UserAgent
        {
            get { return "GemsCraft " + LatestStable(); }
        }
        public static readonly string[] FileList = {
            "ConfigGUI.exe",
            "fCraft.dll",
            "fCraftGUI.dll",
            "ServerCLI.exe",
            "ServerGUI.exe",
            "Tutorial.exe",
            "ServiceStack.Text.dll",
            "UpdateInstaller.exe"
        };

        
        static String website = "http://GemsCraft.net/Version/";
        public static String[] websiteVersion = new String[]
        {
            TitleExtractor.pageTitle(website + "Major.html"),
            TitleExtractor.pageTitle(website + "Minor.html"),
            TitleExtractor.pageTitle(website + "Build.html"),
            TitleExtractor.pageTitle(website + "Private.html")
        };
        public static string LatestStable()
        {
            return "2.0";
        }
        public static string LatestWebsite()
        {
            return websiteVersion[0] + "." + websiteVersion[1] + "." +
                websiteVersion[2] + "." + websiteVersion[3];
        }
        public static string UpdateUrl { get; set; }
        public static bool RunAtShutdown { get; set; }

        /// <summary>
        /// Gets if GemsCraft needs to be updated or not
        /// </summary>
        /// <returns>Returns update type</returns>
        public static UpdaterResult getUpdateStatus()
        {
            Version local, website;
            Version.TryParse(LatestStable(), out local);
            Version.TryParse(LatestWebsite(), out website);
            bool major = false, minor = false, build = false, privateA = false;
            if (local.Major == website.Major)
            {
                major = true;
                if (local.Minor == website.Minor)
                {
                    minor = true;
                    if (local.Build == null && website.Build == null) build = true;
                    else if (local.Build == null && !(website.Build == null)) return UpdaterResult.Outdated;
                    else if (!(local.Build == null) && website.Build == null) return UpdaterResult.Dev;
                    else if (local.Build == website.Build)
                    {
                        build = true;
                        if (local.Revision == null && website.Revision == null) privateA = true;
                        else if (local.Revision == null && !(website.Revision == null)) return UpdaterResult.Outdated;
                        else if (!(local.Revision == null) && website.Revision == null) return UpdaterResult.Dev;
                        else if (local.Revision == website.Revision)
                        {
                            privateA = true;
                        }
                    }
                }
                else if (local.Minor > website.Minor) return UpdaterResult.Dev;
                else if (local.Minor < website.Minor) return UpdaterResult.Outdated;
            }
            else if (local.Major > website.Major) return UpdaterResult.Dev;
            else if (local.Major < website.Major) return UpdaterResult.Outdated;
            if (major && minor && build && privateA) return UpdaterResult.Updated;
            else return UpdaterResult.Dev;
        }
        static int ToInt(object i)
        {
            return Convert.ToInt32(i);
        }
        public static String UpdaterMessage()
        {
            UpdaterResult uResult = Updater.getUpdateStatus();
            switch (uResult)
            {
                case UpdaterResult.Dev:
                    return "You are running an un-released version of GemsCraft. By continueing " +
                        "to use this version in a non-support time for it, you understand that " +
                        "many features might not work";
                case UpdaterResult.Outdated:
                    return "Your GemsCraft is outdated! For new features, update to the newest GemsCraft Version!";
                case UpdaterResult.Updated:
                    return "Your GemsCraft is updated to the most recent release!";
                default:
                    return null;
            }
        }
    }

    
    public enum UpdaterResult
    {
        Updated, //User is running an appropiate version of GemsCraft
        Outdated, //User needs to update
        Dev //Might be unstable
    }

    public sealed class ReleaseInfo
    {
        internal ReleaseInfo(int version, int revision, DateTime releaseDate,
                              string summary, string changeLog, ReleaseFlags releaseType)
        {
            Version = version;
            Revision = revision;
            Date = releaseDate;
            Summary = summary;
            ChangeLog = changeLog.Split(new[] { '\n' });
            Flags = releaseType;
        }

        public ReleaseFlags Flags { get; private set; }

        public string FlagsString { get { return ReleaseFlagsToString(Flags); } }

        public string[] FlagsList { get { return ReleaseFlagsToStringArray(Flags); } }

        public int Version { get; private set; }

        public int Revision { get; private set; }

        public DateTime Date { get; private set; }

        public TimeSpan Age
        {
            get
            {
                return DateTime.UtcNow.Subtract(Date);
            }
        }

        public string VersionString
        {
            get
            {
                string formatString = "{0:0.000}_r{1}";
                if (IsFlagged(ReleaseFlags.Dev))
                {
                    formatString += "_dev";
                }
                if (IsFlagged(ReleaseFlags.Unstable))
                {
                    formatString += "_u";
                }
                return String.Format(CultureInfo.InvariantCulture, formatString,
                                      Decimal.Divide(Version, 1000),
                                      Revision);
            }
        }

        public string Summary { get; private set; }

        public string[] ChangeLog { get; private set; }

        public static ReleaseFlags StringToReleaseFlags([NotNull] string str)
        {
            if (str == null) throw new ArgumentNullException("str");
            ReleaseFlags flags = ReleaseFlags.None;
            for (int i = 0; i < str.Length; i++)
            {
                switch (Char.ToUpper(str[i]))
                {
                    case 'A':
                        flags |= ReleaseFlags.APIChange;
                        break;
                    case 'B':
                        flags |= ReleaseFlags.Bugfix;
                        break;
                    case 'C':
                        flags |= ReleaseFlags.ConfigFormatChange;
                        break;
                    case 'D':
                        flags |= ReleaseFlags.Dev;
                        break;
                    case 'F':
                        flags |= ReleaseFlags.Feature;
                        break;
                    case 'M':
                        flags |= ReleaseFlags.MapFormatChange;
                        break;
                    case 'P':
                        flags |= ReleaseFlags.PlayerDBFormatChange;
                        break;
                    case 'S':
                        flags |= ReleaseFlags.Security;
                        break;
                    case 'U':
                        flags |= ReleaseFlags.Unstable;
                        break;
                    case 'O':
                        flags |= ReleaseFlags.Optimized;
                        break;
                }
            }
            return flags;
        }

        public static string ReleaseFlagsToString(ReleaseFlags flags)
        {
            StringBuilder sb = new StringBuilder();
            if ((flags & ReleaseFlags.APIChange) == ReleaseFlags.APIChange) sb.Append('A');
            if ((flags & ReleaseFlags.Bugfix) == ReleaseFlags.Bugfix) sb.Append('B');
            if ((flags & ReleaseFlags.ConfigFormatChange) == ReleaseFlags.ConfigFormatChange) sb.Append('C');
            if ((flags & ReleaseFlags.Dev) == ReleaseFlags.Dev) sb.Append('D');
            if ((flags & ReleaseFlags.Feature) == ReleaseFlags.Feature) sb.Append('F');
            if ((flags & ReleaseFlags.MapFormatChange) == ReleaseFlags.MapFormatChange) sb.Append('M');
            if ((flags & ReleaseFlags.PlayerDBFormatChange) == ReleaseFlags.PlayerDBFormatChange) sb.Append('P');
            if ((flags & ReleaseFlags.Security) == ReleaseFlags.Security) sb.Append('S');
            if ((flags & ReleaseFlags.Unstable) == ReleaseFlags.Unstable) sb.Append('U');
            if ((flags & ReleaseFlags.Optimized) == ReleaseFlags.Optimized) sb.Append('O');
            return sb.ToString();
        }

        public static string[] ReleaseFlagsToStringArray(ReleaseFlags flags)
        {
            List<string> list = new List<string>();
            if ((flags & ReleaseFlags.APIChange) == ReleaseFlags.APIChange) list.Add("API Changes");
            if ((flags & ReleaseFlags.Bugfix) == ReleaseFlags.Bugfix) list.Add("Fixes");
            if ((flags & ReleaseFlags.ConfigFormatChange) == ReleaseFlags.ConfigFormatChange) list.Add("Config Changes");
            if ((flags & ReleaseFlags.Dev) == ReleaseFlags.Dev) list.Add("Developer");
            if ((flags & ReleaseFlags.Feature) == ReleaseFlags.Feature) list.Add("New Features");
            if ((flags & ReleaseFlags.MapFormatChange) == ReleaseFlags.MapFormatChange) list.Add("Map Format Changes");
            if ((flags & ReleaseFlags.PlayerDBFormatChange) == ReleaseFlags.PlayerDBFormatChange) list.Add("PlayerDB Changes");
            if ((flags & ReleaseFlags.Security) == ReleaseFlags.Security) list.Add("Security Patch");
            if ((flags & ReleaseFlags.Unstable) == ReleaseFlags.Unstable) list.Add("Unstable");
            if ((flags & ReleaseFlags.Optimized) == ReleaseFlags.Optimized) list.Add("Optimized");
            return list.ToArray();
        }

        public bool IsFlagged(ReleaseFlags flag)
        {
            return (Flags & flag) == flag;
        }
    }


    #region Enums

    /// <summary> Updater behavior. </summary>
    public enum UpdaterMode
    {
        /// <summary> Does not check for updates. </summary>
        Disabled,

        /// <summary> Checks for updates and notifies of availability (in console/log). </summary>
        Notify,

        /// <summary> Checks for updates, downloads them if available, and prompts to install.
        /// Behavior is frontend-specific: in ServerGUI, a dialog is shown with the list of changes and
        /// options to update immediately or next time. In ServerCLI, asks to type in 'y' to confirm updating
        /// or press any other key to skip. '''Note: Requires user interaction
        /// (if you restart the server remotely while unattended, it may get stuck on this dialog).''' </summary>
        Prompt,

        /// <summary> Checks for updates, automatically downloads and installs the updates, and restarts the server. </summary>
        Auto,
    }


    /// <summary> A list of release flags/attributes.
    /// Use binary flag logic (value & flag == flag) or Release.IsFlagged() to test for flags. </summary>
    [Flags]
    public enum ReleaseFlags
    {
        None = 0,

        /// <summary> The API was notably changed in this release. </summary>
        APIChange = 1,

        /// <summary> Bugs were fixed in this release. </summary>
        Bugfix = 2,

        /// <summary> Config.xml format was changed (and version was incremented) in this release. </summary>
        ConfigFormatChange = 4,

        /// <summary> This is a developer-only release, not to be used on live servers.
        /// Untested/undertested releases are often marked as such. </summary>
        Dev = 8,

        /// <summary> A notable new feature was added in this release. </summary>
        Feature = 16,

        /// <summary> The map format was changed in this release (rare). </summary>
        MapFormatChange = 32,

        /// <summary> The PlayerDB format was changed in this release. </summary>
        PlayerDBFormatChange = 64,

        /// <summary> A security issue was addressed in this release. </summary>
        Security = 128,

        /// <summary> There are known or likely stability issues in this release. </summary>
        Unstable = 256,

        /// <summary> This release contains notable optimizations. </summary>
        Optimized = 512
    }

    #endregion
}


namespace fCraft.Events
{
    public sealed class CheckingForUpdatesEventArgs : EventArgs, ICancellableEvent
    {
        internal CheckingForUpdatesEventArgs(string url)
        {
            Url = url;
        }

        public string Url { get; set; }
        public bool Cancel { get; set; }
    }


    public sealed class CheckedForUpdatesEventArgs : EventArgs
    {
        internal CheckedForUpdatesEventArgs(string url, UpdaterResult result)
        {
            Url = url;
            Result = result;
        }

        public string Url { get; private set; }
        public UpdaterResult Result { get; private set; }
    }
}