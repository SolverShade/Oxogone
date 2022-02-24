using ConsoleUI.Areas;
using ConsoleUI.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public class CommandHandler
    {
        const int userInputLine = 29;
        const int visableConsoleLines = 120;
        public Area NextArea;

        public void EnterCommand(Player player)
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            string userCommand = Console.ReadLine();

            ClearUserInput();

            switch (userCommand)
            {
                case "n":
                    player.MoveArea(0, 1);
                    break;
                case "s":
                    player.MoveArea(0, -1);
                    break;
                case "e":
                    player.MoveArea(1, 0);
                    break;
                case "w":
                    player.MoveArea(-1, 0);
                    break;
                default:
                    break;
            }

            Area nextArea = null;

            foreach (Area area in Map.mapAreas)
            {
                if(area.Cordinate == (player.XCordinate, player.YCordinate))
                {
                    nextArea = area;
                }
            }

            NextArea = nextArea;

            Console.Clear(); // find a way to clear the console smoothly. clear on fullscreen or remove miniMap bugging on fullscreen. 
        }

        private void ClearUserInput()
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }

    }
}
