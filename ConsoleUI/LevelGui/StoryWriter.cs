#region usingStatements
using ConsoleUI.GameState;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.LevelGui
{
    public static class StoryWriter
    {
        const int STORYLINE = 1;
        const int MAXSTORYLINES = 3;
        public static void DisplayAreaText(Area area)
        {
            ClearStoryLines();

            string[] textLines = area.Description.Split('>');
            foreach(string text in textLines)
            {
                Console.WriteLine(text);
            }
        }

        public static void ClearStoryLines()
        {
            UILineEdit.ClearSpecifiedLines(STORYLINE, MAXSTORYLINES);
            UILineEdit.setGuiLines(STORYLINE);
        }
    }
}
