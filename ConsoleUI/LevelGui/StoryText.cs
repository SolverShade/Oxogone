#region usingStatements
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.LevelGui
{
    public static class StoryText
    {
        const int STORYLINE = 1;
        const int MAXSTORYLINES = 3;
        public static void DisplayAreaText(Area area)
        {
            UILineEdit.ClearSpecifiedLines(STORYLINE, MAXSTORYLINES);
            UILineEdit.setGuiLines(STORYLINE);

            string[] textLines = area.Description.Split('>');
            foreach(string text in textLines)
            {
                Console.WriteLine(text);
            }
        }

        public static void DisplayCombatText()
        {
            UILineEdit.ClearSpecifiedLines(STORYLINE, MAXSTORYLINES);
            UILineEdit.setGuiLines(STORYLINE);

            Console.WriteLine("You are currently in combat and cannot escape until you or the enemy are no longer standing"); 
        }
    }
}
