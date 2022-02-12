using ConsoleUI.Areas;
using ConsoleUI.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public static class CommandHandler
    {
        const int userInputLine = 29;
        const int visableConsoleLines = 120;
        public static void EnterCommand()
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            string userCommand = Console.ReadLine();

            ClearUserInput();

            switch (userCommand)
            {
                case "n":
                    PlayerLocation.MoveArea(0, 1);
                    break;
                case "s":
                    PlayerLocation.MoveArea(0, -1);
                    break;
                case "e":
                    PlayerLocation.MoveArea(1, 0);
                    break;
                case "w":
                    PlayerLocation.MoveArea(-1, 0);
                    break;
                default:
                    break;
            }

            Area nextArea = null;

            foreach (Area area in LoadArea.areas)
            {
                if(area.Cordinate == PlayerLocation.Location)
                {
                    nextArea = area;
                }
            }

            Console.Clear(); // find a way to clear the console smoothly. clear on fullscreen or remove miniMap bugging on fullscreen. 

            LoadArea.Load(nextArea);
        }

        private static void ClearUserInput()
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }

    }
}
