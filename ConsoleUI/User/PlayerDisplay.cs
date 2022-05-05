using Colors.Net;
using Colors.Net.StringColorExtensions;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public static class PlayerDisplay
    {
        private const int PLAYERLINE = 22;

        public static void DisplayPlayerStats(Player player)
        {
            ClearPlayerLine();

            ColoredConsole.WriteLine("Player Oxogone: " + $"{player.Health}".Green());
        }

        public static void ClearPlayerLine()
        {
            UILineEdit.ClearSpecifiedLines(PLAYERLINE, 1);
            UILineEdit.setGuiLines(PLAYERLINE, 0);
        }
    }
}
