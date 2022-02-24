using ConsoleUI.Areas;
using ConsoleUI.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public class CommandHandler
    {
        public Area NextArea { get; set; }

        const int userInputLine = 29;
        const int visableConsoleLines = 120;

        //bury switches into thier own classes to make command handler more clear 
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

<<<<<<< HEAD
            foreach (Area area in Map.Areas)
=======
            foreach (Area area in LoadArea.areas)
>>>>>>> parent of 0ca53f8 (Implemented File reading for areas. still need to re-add all the old areas in this new format.)
            {
                if(area.Cordinate == (player.XCordinate,player.YCordinate))
                {
                    nextArea = area;
                }
            }

            Console.Clear(); // find a way to clear the console smoothly. clear on fullscreen or remove miniMap bugging on fullscreen. 

            NextArea = nextArea;
        }

        private void ClearUserInput()
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }

    }
}
