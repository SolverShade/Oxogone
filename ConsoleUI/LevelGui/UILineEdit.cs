#region usingStatements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI
{
    public static class UILineEdit
    {
        private static int USERINPUTLINE = 28;

        public static void setGuiLines(int lineLocation, int cursorPlacement = 0)
        {
            if (USERINPUTLINE < lineLocation)
            {
                GetUpperLine(lineLocation, cursorPlacement);
            }
            else if (USERINPUTLINE > lineLocation)
            {
                GetLowerLine(lineLocation, cursorPlacement);
            }
            else if (USERINPUTLINE == lineLocation)
            {
                Console.SetCursorPosition(cursorPlacement, (USERINPUTLINE - 1));
            }
        }

        private static void GetUpperLine(int lineLocation, int cursorPlacement)
        {
            int linesToRemove = USERINPUTLINE - lineLocation;
            Console.SetCursorPosition(cursorPlacement, (USERINPUTLINE - 1) - linesToRemove);
            USERINPUTLINE = USERINPUTLINE - linesToRemove;
        }

        private static void GetLowerLine(int lineLocation, int cursorPlacement)
        {
            int linesToAdd = lineLocation - USERINPUTLINE;
            Console.SetCursorPosition(cursorPlacement, (USERINPUTLINE - 1) + linesToAdd);
            USERINPUTLINE = USERINPUTLINE + linesToAdd;
        }

        public static void ClearSpecifiedLines(int startingLine, int linesToClear)
        {
            for (int lineIndex = 0; lineIndex < linesToClear; lineIndex++)
            {
                setGuiLines(startingLine + lineIndex);
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
        }

        public static void ClearAllLines()
        {
            ClearSpecifiedLines(1, 28);
            UILineEdit.setGuiLines(1);
        }

        public static void ClearUserInputLine()
        {
            ClearSpecifiedLines(28, 1);
        }
    }
}
