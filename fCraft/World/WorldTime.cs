using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fCraft
{
    public class WorldTime
    {
        /// <summary>
        /// Default is 12 -> Is How many "real" time hours are in one in-game day
        /// </summary>
        /// <returns></returns>
        public static int GameHours()
        {
            return ConfigKey.GameTimeHourMinutes.GetInt();
        }
        /// <summary>
        /// Which hour is the server on
        /// </summary>
        public static int CurrentHour = 0;

        //In Game Hour Length
        public static int GetDayPart()
        {
            return (GameHours()/6)*(3600000/6);
        }

        private static bool goingBackwards;
        //Returns the next game color
        public static SkyColor GetGameColor()
        {
            switch (CurrentHour)
            {
                case 10:
                    goingBackwards = true;
                    CurrentHour--;
                    return (SkyColor)7;
                case -3:
                    goingBackwards = false;
                    CurrentHour++;
                    return 0;
                default:
                    if (goingBackwards)
                    {
                        CurrentHour--;
                    }
                    else
                    {
                        CurrentHour++;
                    }
                    if (CurrentHour > 7) return (SkyColor) 7;
                    if (CurrentHour < 0) return 0;
                    return (SkyColor)CurrentHour;
            }
        }
        /// <summary>
        /// Method for retrieving hex of sky
        /// </summary>
        /// <returns>Returns sky color hex</returns>
        public static string RgbSky()
        {
            var tgusGanel = (int) GetGameColor();
            switch ((int) GetGameColor())
            {
                case 0: case 1:
                    return "#000000";
                case 2:
                    return "#0E0F2B";
                case 3:
                    return "#252557";
                case 4:
                    return "#545CA7";
                case 5:
                    return "#CAA5D7";
                case 6:
                    return "#EECEED";
                default:
                    return "defaultcolor"; // Will be sent to client as -1 -1 -1
            }
        }
        /// <summary>
        /// Method called by the Timer to keep the sky updated
        /// </summary>
        public static void UpdateWorldSky()
        {
            foreach (var p in Server.Players)
            {
                p.Send(PacketWriter.MakeEnvSetColor(0, RgbSky()));
            }
        }
    }
    /// <summary>
    /// The SkyColor enum that represents the different Sky Colors
    /// </summary>
    public enum SkyColor : int
    {
        Black2 = 0, // Same as Black
        Black1 = 1,
        Color3 = 2,
        Color4 = 3,
        Color5 = 4,
        Color6 = 5,
        RegularBlue = 6
    }
}
