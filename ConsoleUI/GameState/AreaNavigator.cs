#region usingStatements 
using LogicLibrary.User;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary.GameCollectables;
using ConsoleUI.LevelGui;
#endregion

namespace ConsoleUI.GameState
{
    public class AreaNavigator
    {
        public Map Map { get; set; }
        public Player Player { get; set; }

        public Cordinate CurrentCordinate;
        public Area CurrentArea;

        private List<string> bannedAreas = new List<string>() { "Wall", "LockedDoor" };     
        public AreaNavigator(Player player, Map map)
        {
            Player = player;
            Map = map;

            CurrentCordinate = Player.Cordinate;
            CurrentArea = Map.Areas[Player.Cordinate.X, Player.Cordinate.Y];
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
        }

        public void SearchArea()
        {
            List<ICollectable> collectables = new List<ICollectable>();
            List<string> collectableNames = new List<string>();

            foreach(ICollectable collectable in CurrentArea.Collectables)
            {
                collectables.Add(collectable);
                collectableNames.Add(collectable.Name);
            }

            if(collectableNames.Count > 0)
            {
                foreach (string name in collectableNames)
                {
                    StatusWriter.DisplayStatusMessage("You Found: " + name + " + ");
                }
            }
            else
            {
                StatusWriter.DisplayStatusMessage("You Found Nothing");
            }
        }

        public bool HasPlayerMoved()
        {
            if (!bannedAreas.Contains(Map.Areas[CurrentCordinate.X, CurrentCordinate.Y].RoomType))
            {
                Player.Cordinate = CurrentCordinate;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
