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
        public Map Map { get; set; }
        public Player Player { get; set; }

        public bool movedArea;
        private List<string> bannedAreas = new List<string>() { "Wall", "LockedDoor" };     
        public MoveArea(Player player, Map map)
        {
            Player = player;
            Map = map;
        }

        public void EnterCommand(char commandPrefix)
        {            
            Cordinate CurrentCordinate = new Cordinate(Player.Cordinate.X, Player.Cordinate.Y);

            movedArea = false;

            switch (commandPrefix)
            {
                case 'n':
                    CurrentCordinate.Y++;
                    break;
                case 's':
                    CurrentCordinate.Y--;
                    break;
                case 'e':
                    CurrentCordinate.X++;
                    break;
                case 'w':
                    CurrentCordinate.X--;
                    break;
                default:
                    break;
            }

            if(!bannedAreas.Contains(Map.Areas[CurrentCordinate.X, CurrentCordinate.Y].Type))
            {
                Player.Cordinate = CurrentCordinate;
                movedArea = true;
                Console.Clear(); // find a way to clear the console smoothly. clear on fullscreen or remove miniMap bugging on fullscreen. 
            }
        }

    }
}
