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
    public class AreaNavigator
    {
        public Map Map { get; set; }
        public Player Player { get; set; }

        public Cordinate CurrentCordinate;

        private List<string> bannedAreas = new List<string>() { "Wall", "LockedDoor" };     
        public AreaNavigator(Player player, Map map)
        {
            Player = player;
            Map = map;

            CurrentCordinate = Player.Cordinate;
        }

        public void MoveArea(char commandPrefix)
        {            
            CurrentCordinate = new Cordinate(Player.Cordinate.X, Player.Cordinate.Y);

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

            Player.Cordinate = CurrentCordinate;
        }

        public bool HasPlayerMoved()
        {
            if (!bannedAreas.Contains(Map.Areas[CurrentCordinate.X, CurrentCordinate.Y].Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
