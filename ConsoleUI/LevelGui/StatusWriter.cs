using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class StatusWriter
    {
        const int STATUSLINE = 20; 

        public static void DisplayStatusMessage(string message)
        {
            UILineEdit.ClearSpecifiedLines(STATUSLINE, 1);
            UILineEdit.setGuiLines(STATUSLINE, 0);
            Console.Write(message);
        }

    }
}
