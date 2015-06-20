using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace GemsCraftGUI.ServerGUI
{
    public class CustomTheme
    {
        /*
     * --- {file.gctheme} ---
     * Name: [Name] // 0
     * #[MainBackColor] // 1
     * #[PlayerListBackColor] // 2
     * #[LogBackColor] // 3
     * #[TabBackColor] // 4
     * #[TextColor] // 5
     */
        //Line 0 must be the name. If not, theme will not load.
        //Colors must be in their relative position
        //If theme maker doesn't want to insert a color to that theme, they need to write #Default
        public string Name;
        public Color MainBackColor;
        public Color PlayerListBackColor;
        public Color LogBackColor;
        public Color TabBackColor;
        public Color TextColor;
        public const string FilePath = "Themes/";
        public static CustomTheme ParseTheme(string filename)
        {
            var buildingTheme = new CustomTheme();
            if (!Directory.Exists(FilePath))
            {
                throw new NoThemesInstalledException("Directory doesn't exist");
            }
            if (!File.Exists(filename))
            {
                throw new InvalidThemeException("Theme doesn't exist");
            }
            var fileLines = File.ReadAllLines(filename);
            if (fileLines[0].ToLower().Substring(0, 6).Equals("name: "))
            {
                buildingTheme.Name = fileLines[0].Substring(6);
            }
            var mainHex = fileLines[1];
            var playerHex = fileLines[2];
            var logHex = fileLines[3];
            var tabHex = fileLines[4];
            var textHex = fileLines[5];
            const string defString = "#default";
            buildingTheme.MainBackColor = mainHex.Equals(defString)
                ? DefaultTheme.MainBackColor
                : ParseHex(mainHex);
            buildingTheme.PlayerListBackColor = playerHex.Equals(defString)
                ? DefaultTheme.PlayerListBackColor
                : ParseHex(playerHex);
            buildingTheme.LogBackColor = logHex.Equals(defString)
                ? DefaultTheme.LogBackColor
                : ParseHex(logHex);
            buildingTheme.TabBackColor = tabHex.Equals(defString)
                ? DefaultTheme.TabBackColor
                : ParseHex(tabHex);
            buildingTheme.TextColor = textHex.Equals(defString)
                ? DefaultTheme.TextColor
                : ParseHex(textHex);
            return buildingTheme;
        }

        public override string ToString()
        {
            var fileLines = new List<string>
            {
                ToHex(MainBackColor),
                ToHex(PlayerListBackColor),
                ToHex(LogBackColor),
                ToHex(TabBackColor),
                ToHex(TextColor)
            };
            var sb = new StringBuilder("Name: " + Name);
            foreach (var lines in fileLines)
            {
                sb.Append("\n" + lines);
            }
            return sb.ToString();
        }
        private static string ToHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        public static CustomTheme DefaultTheme = new CustomTheme
        {
            Name = "Default Theme",
            MainBackColor = ParseHex("#000000"),
            PlayerListBackColor = ParseHex("#c0c0c0"),
            LogBackColor = ParseHex("#000000"),
            TabBackColor = ParseHex("#808080"),
            TextColor = ParseHex("#d3d3d3")
        };

        private static Color ParseHex(string hexcolor)
        {
            return ColorTranslator.FromHtml(hexcolor);
        }
    }


    public class NoThemesInstalledException : Exception
    {
        public NoThemesInstalledException()
        {

        }

        public NoThemesInstalledException(string message)
            : base(message)
        {

        }

        public NoThemesInstalledException(string message, Exception ex)
            : base(message, ex)
        {

        }

    }
    public class InvalidThemeException : Exception
    {
        public InvalidThemeException()
        {

        }

        public InvalidThemeException(string message)
            : base(message)
        {

        }

        public InvalidThemeException(string message, Exception ex)
            : base(message, ex)
        {

        }

    }

}
