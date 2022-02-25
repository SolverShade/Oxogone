using ConsoleUI.Areas;
using ConsoleUI.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Areas
{
    public class MoveArea
    {
        const int userInputLine = 29;
        const int visableConsoleLines = 120;
        public Area NextArea = new Area((10,10), "", "");
        private Area lastArea;
        private (int,int) nextCordinate;
        private List<string> bannedAreas = new List<string>() { "Wall", "LockedDoor" };

        public void EnterCommand(Map map)
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            string userCommand = Console.ReadLine();

            ClearUserInput();

            lastArea = NextArea;

            switch (userCommand)
            {
                case "n":
                    nextCordinate = (0, 1);
                    break;
                case "s":
                    nextCordinate = (0, -1);
                    break;
                case "e":
                    nextCordinate = (1, 0);
                    break;
                case "w":
                    nextCordinate = (-1, 0);
                    break;
                default:
                    break;
            }

            (int,int) requstedLocation = (NextArea.Cordinate.Item1 + nextCordinate.Item1, NextArea.Cordinate.Item2 + nextCordinate.Item2);

            foreach (Area area in map.mapAreas)
            {
                if (area.Cordinate == requstedLocation) 
                {
                    NextArea = map.mapAreas[requstedLocation.Item1, requstedLocation.Item2];
                }
            }

            if(bannedAreas.Contains(NextArea.Type))
            {
                NextArea = lastArea;
            }

            Console.Clear(); // find a way to clear the console smoothly. clear on fullscreen or remove miniMap bugging on fullscreen. 
        }

        private void ClearUserInput()
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }

    }
}
