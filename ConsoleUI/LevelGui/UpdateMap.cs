using Colors.Net;
using Colors.Net.StringColorExtensions;
using ConsoleUI.Areas;
using ConsoleUI.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class UpdateMap
    {
        const int MINIMAPLINE = 12;
        const int MINIMAPSPACE = 8;
        const int MAXMINIMAPLINES = 8;

        static readonly int[] marks = new int[] { 3, 5, 7, 5, 3};

        public static void Update()
        {
            ClearMiniMap();

            LoadIdenitifers();

            for(int lineIndex = 0; lineIndex < marks.Length; lineIndex++)
            {
                //Gets the correct cordinates where the next next should be written. the horizontal spacing is the median of each marks value.
                UILineEdit.setGuiLines((MINIMAPLINE + lineIndex), (MINIMAPSPACE - marks[lineIndex]/2));

                for (int markIndex = 0; markIndex < marks[lineIndex]; markIndex++)
                {
                    string areaType = PlayerLocation.retriveAreaGroup(markIndex, marks[lineIndex], lineIndex, marks.Length);
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
            UILineEdit.setGuiLines((MINIMAPLINE - 4), MINIMAPSPACE - 2);
            Console.WriteLine(LoadArea.currentArea.Type);
            UILineEdit.setGuiLines((MINIMAPLINE - 2), MINIMAPSPACE);
            ColoredConsole.Write("N".Red());
            UILineEdit.setGuiLines((MINIMAPLINE + marks.Length + 1), MINIMAPSPACE);
            ColoredConsole.Write("S".Cyan());
            UILineEdit.setGuiLines((MINIMAPLINE + 2), MINIMAPSPACE - 5);
            ColoredConsole.Write("W".Yellow());
            UILineEdit.setGuiLines((MINIMAPLINE + 2), MINIMAPSPACE + 5);
            ColoredConsole.Write("E".Green());
        }

        private static void ClearMiniMap()
        {
            for (int lineIndex = 0; lineIndex < MAXMINIMAPLINES; lineIndex++)
            {
                UILineEdit.setGuiLines(MINIMAPLINE + lineIndex);
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
        }

    }
}
