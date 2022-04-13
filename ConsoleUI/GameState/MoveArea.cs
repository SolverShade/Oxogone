#region usingStatements 
using LogicLibrary.User;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.GameState
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

            if(!bannedAreas.Contains(Map.Areas[CurrentCordinate.X, CurrentCordinate.Y].Name))
            {
                Player.Cordinate = CurrentCordinate;
                movedArea = true;
            }
        }

    }
}
