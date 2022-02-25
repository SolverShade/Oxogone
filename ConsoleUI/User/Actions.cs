using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public static class Actions
    {
        const int ACTIONLINE = 26;
        public static void WritePossibleActions()
        {
            UILineEdit.setGuiLines(ACTIONLINE, 0);
            Console.Write("Possible Actions: n (North), e (East), s (South), w (West) ");
        }
    }
}
