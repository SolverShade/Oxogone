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
        const int consoleLines = 28;
        private static int currentLinePosition = consoleLines;

        public static void setGuiLines(int lineLocation, int cursorPlacement = 0)
        {
            if (currentLinePosition < lineLocation)
            {
                GetUpperLine(lineLocation, cursorPlacement);
            }
            else if (currentLinePosition > lineLocation)
            {
                GetLowerLine(lineLocation, cursorPlacement);
            }
            else if (currentLinePosition == lineLocation)
            {
                Console.SetCursorPosition(cursorPlacement, (currentLinePosition - 1));
            }
        }

        private static void GetUpperLine(int lineLocation, int cursorPlacement)
        {
            int linesToRemove = currentLinePosition - lineLocation;
            Console.SetCursorPosition(cursorPlacement, (currentLinePosition - 1) - linesToRemove);
            currentLinePosition = currentLinePosition - linesToRemove;
        }

        private static void GetLowerLine(int lineLocation, int cursorPlacement)
        {
            int linesToAdd = lineLocation - currentLinePosition;
            Console.SetCursorPosition(cursorPlacement, (currentLinePosition - 1) + linesToAdd);
            currentLinePosition = currentLinePosition + linesToAdd;
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
        }
    }
}
