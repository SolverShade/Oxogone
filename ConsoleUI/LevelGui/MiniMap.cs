#region usingStatements
using Colors.Net;
using Colors.Net.StringColorExtensions;
using LogicLibrary.User;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.LevelGui
{
    public static class MiniMap
    {
        const int MINIMAPLINE = 9;
        const int MINIMAPSPACE = 6;
        const int MAXMINIMAPLINES = 8;

        static readonly int[] marks = new int[] { 3, 5, 7, 5, 3};

        public static void Update(Player player, Map map)
        {
            UILineEdit.ClearSpecifiedLines(MINIMAPLINE, MAXMINIMAPLINES);
            DisplayPlayerCordinate(player);
            LoadIdenitifers();

            for(int lineIndex = 0; lineIndex < marks.Length; lineIndex++)   //Gets the correct cordinates where the next line should be written. the horizontal spacing is the median of each marks value.
            {              
                UILineEdit.setGuiLines((MINIMAPLINE + lineIndex), (MINIMAPSPACE - marks[lineIndex]/2));

                for (int markIndex = 0; markIndex < marks[lineIndex]; markIndex++)
                {
                    int halfOfLines = (int)(Math.Ceiling((double)marks.Length / 2));
                    int halfOfLineMarks = (int)(Math.Ceiling((double)marks[lineIndex] / 2));

                    int horizontalFromPlayer = (halfOfLineMarks - marks[lineIndex]) + markIndex;
                    int verticalFromPlayer = (marks.Length - halfOfLines) - lineIndex;

                    int mapXCordinate = player.Cordinate.X + horizontalFromPlayer;
                    int mapYCordinate = player.Cordinate.Y + verticalFromPlayer;

                    string areaType = map.Areas[mapXCordinate, mapYCordinate].Name;

                    if (horizontalFromPlayer == 0 && verticalFromPlayer == 0)
                    {
                        areaType = "Player";
                    }

                    RichString coloredMark = setMarkType(areaType);
                    ColoredConsole.Write($"{coloredMark}");
                }
            }
        }

        private static RichString setMarkType(string areaType)
        {
            RichString pendingMark;

            switch (areaType)
            {
                case "Player":
                     pendingMark = "*".Green();
                    break;
                case "Wall":
                     pendingMark = "*".DarkGray();
                    break;
                case "Room":
                    pendingMark = "*".White();
                    break;
                case "Door":
                    pendingMark = "*".Yellow();
                    break;
                default:
                    pendingMark = "*".Red();
                    break;
            }

                    return pendingMark;
        }

        //cleanup... use  constants? 
        private static void LoadIdenitifers()
        {
            UILineEdit.setGuiLines((MINIMAPLINE - 2), MINIMAPSPACE);
            ColoredConsole.Write("N".Red());
            UILineEdit.setGuiLines((MINIMAPLINE + marks.Length + 1), MINIMAPSPACE);
            ColoredConsole.Write("S".Cyan());
            UILineEdit.setGuiLines((MINIMAPLINE + 2), MINIMAPSPACE - 5);
            ColoredConsole.Write("W".Yellow());
            UILineEdit.setGuiLines((MINIMAPLINE + 2), MINIMAPSPACE + 5);
            ColoredConsole.Write("E".Green());
        }

        private static void DisplayPlayerCordinate(Player player)
        {
            UILineEdit.setGuiLines((MINIMAPLINE - 4), MINIMAPSPACE - 3);
            Console.Write("(" + player.Cordinate.X.ToString() + "," + player.Cordinate.Y.ToString() + ")");
        }
    }
}
