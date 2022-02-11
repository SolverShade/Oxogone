using Colors.Net;
using Colors.Net.StringColorExtensions;
using ConsoleUI.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class UpdateMap
    {
        const int MINIMAPLINE = 7;
        const int MINIMAPSPACE = 10;
        static readonly int[] marks = new int[] { 3, 5, 7, 5, 3};

        public static void Update()
        {

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
                     pendingMark = "*".Gray();
                    break;
                case "Room":
                    pendingMark = "*".White();
                    break;
                default:
                    pendingMark = "*".Red();
                    break;
            }

                    return pendingMark;
        }

    }
}
