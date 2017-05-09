using System;
using System.Linq;
using System.Timers;

namespace fCraft.fSystem
{
    public enum MessageType
    {
        Chat,
        Announcement,
        Br1, Br2, Br3,
        Status1, Status2, Status3
    }
    public class MessageTypeManagement
    {
        public static bool TypeEnabled(MessageType mt)
        {
            switch (mt)
            {
                case MessageType.Chat:
                    return true; // Always true
                case MessageType.Announcement:
                    return ConfigKey.AnnouncementsAtTop.Enabled();
                case MessageType.Br1:
                    return ConfigKey.Br1Enabled.Enabled();
                case MessageType.Br2:
                    return ConfigKey.Br2Enabled.Enabled();
                case MessageType.Br3:
                    return ConfigKey.Br3Enabled.Enabled();
                case MessageType.Status1:
                    return ConfigKey.Status1Enabled.Enabled();
                case MessageType.Status2:
                    return ConfigKey.Status2Enabled.Enabled();
                case MessageType.Status3:
                    return ConfigKey.Status3Enabled.Enabled();
                default:
                    return false; // Type not recognized
            }
        }
        public static string HandleContent(string content, Player p)
        {
            var newContent = content;
            var watchingContent = new[] {"servername", "world", "rank", "version", "player", "lastcmd"};
            newContent = watchingContent.Where(contents 
                => content.ToLower().Contains(contents)).Aggregate(newContent, (current, contents) 
                    => current.Replace("{" + contents + "}", ContentReturn(contents, p)));
            return newContent;
        }

        public static Timer MessageTimer;

        private static string[] UpdateContents()
        {
            return new[]
            {
                ConfigKey.Br1Text.GetString(), ConfigKey.Br2Text.GetString(), ConfigKey.Br3Text.GetString(),
                ConfigKey.Status1Text.GetString(), ConfigKey.Status2Text.GetString(), ConfigKey.Status3Text.GetString()
            };
        }

        public static void OnUpdateEvent(Object source, ElapsedEventArgs e)
        {
            if (!ConfigKey.MessageTypeEnabled.Enabled()) return;
            try
            {
                foreach (var p in Server.Players)
                {
                    if (ConfigKey.Br1Enabled.Enabled())
                    {
                        p.Message(
                            UpdateContents()[0] == null
                                ? HandleContent(ConfigKey.Br1Text.GetDefault().ToString(), p)
                                : HandleContent(UpdateContents()[0], p),
                            MessageType.Br1);
                    }

                    if (ConfigKey.Br2Enabled.Enabled())
                    {
                        p.Message(
                            UpdateContents()[1] == null
                                ? HandleContent(ConfigKey.Br2Text.GetDefault().ToString(), p)
                                : HandleContent(UpdateContents()[1], p),
                            MessageType.Br2);
                    }

                    if (ConfigKey.Br3Enabled.Enabled())
                    {
                        p.Message(
                            UpdateContents()[2] == null
                                ? HandleContent(ConfigKey.Br3Text.GetDefault().ToString(), p)
                                : HandleContent(UpdateContents()[2], p),
                            MessageType.Br3);
                    }

                    if (ConfigKey.Status1Enabled.Enabled())
                    {
                        p.Message(
                            UpdateContents()[3] == null
                                ? HandleContent(ConfigKey.Status1Text.GetDefault().ToString(), p)
                                : HandleContent(UpdateContents()[3], p),
                            MessageType.Status1);
                    }

                    if (ConfigKey.Status2Enabled.Enabled())
                    {
                        p.Message(
                            UpdateContents()[4] == null
                                ? HandleContent(ConfigKey.Status2Text.GetDefault().ToString(), p)
                                : HandleContent(UpdateContents()[4], p),
                            MessageType.Status2);
                    }

                    if (ConfigKey.Status3Enabled.Enabled())
                    {
                        p.Message(
                            UpdateContents()[5] == null
                                ? HandleContent(ConfigKey.Status3Text.GetDefault().ToString(), p)
                                : HandleContent(UpdateContents()[5], p),
                            MessageType.Status3);
                    }
                }
            }
            catch (Exception)
            {
                // Ignored -> Server has just started and nothing has been done
            }
        }

        private static string ContentReturn(string myContent, Player p)
        {
            switch (myContent.ToLower())
            {
                case "servername":
                    return ConfigKey.ServerName.GetString();
                case "world":
                    return p.World?.Name ?? "&4World Look Failed";
                case "rank":
                    return p.Info.Rank.Name;
                case "version":
                    return Updater.LatestStable(true);
                case "player":
                    return p.Info.Name;
                case "lastcmd":
                    return p.LastCommand != null ? p.LastCommand.Name : "No Commands Yet";
                default:
                    return "ERROR: Incorrectly specificed replacement string";
            }
        }

        public static byte TypeToByte(MessageType mT)
        {
            byte typeByte = 0;
            switch (mT)
            {
                case MessageType.Chat:
                    typeByte = 0;
                    break;
                case MessageType.Status1:
                    typeByte = 1;
                    break;
                case MessageType.Status2:
                    typeByte = 2;
                    break;
                case MessageType.Status3:
                    typeByte = 3;
                    break;
                case MessageType.Br1:
                    typeByte = 11;
                    break;
                case MessageType.Br2:
                    typeByte = 12;
                    break;
                case MessageType.Br3:
                    typeByte = 13;
                    break;
                case MessageType.Announcement:
                    typeByte = 100;
                    break;
            }
            return typeByte;
        }
    }
}
