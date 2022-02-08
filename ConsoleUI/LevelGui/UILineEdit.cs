using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class UILineEdit
    {
        const int consoleLines = 28;
        const int storyLine = 1;

        private static string[] lineNums = new string[consoleLines];
        private static int currentLinePosition = consoleLines;

        public static void  setGuiLines(int lineLocation, int cursorPlacement = 0)
        {
            if(currentLinePosition < lineLocation)
            {
                GetUpperLine(lineLocation,  cursorPlacement);
            }
            else if(currentLinePosition > lineLocation)
            {
                GetLowerLine(lineLocation, cursorPlacement);
            }
        }

        private static void GetUpperLine(int lineLocation, int cursorPlacement)
        {
            int linesToRemove = currentLinePosition - lineLocation;
            Console.SetCursorPosition(cursorPlacement, (currentLinePosition - 1) - linesToRemove);
            currentLinePosition = currentLinePosition - linesToRemove;
        }

        private static void GetLowerLine(int lineLocation , int cursorPlacement)
        {
            int linesToAdd = lineLocation - currentLinePosition;
            Console.SetCursorPosition(cursorPlacement, (currentLinePosition - 1) + linesToAdd);
            currentLinePosition = currentLinePosition + linesToAdd;
        }
    }
}
