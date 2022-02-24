using ConsoleUI.LevelGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Mapping
{
    public class Player
    {
        public int XCordinate { get; set; }
        public int YCordinate { get; set; }

        private List<string> bannedAreas = new List<string>() { "Wall", "LockedDoor" };

        //Add other things that the user defines like name later.
        public Player(int xCord, int yCord)
        {
            XCordinate = xCord;
            YCordinate = yCord; 
        }

        public void MoveArea(int horizontalMove, int verticalMove)
        {
            string requstedArea = Map.Areas[(XCordinate + horizontalMove), (YCordinate + verticalMove)].Type;
            if (bannedAreas.Contains(requstedArea))
            {
                Console.WriteLine("CANT GO THERE!!!");
            }
            else
            {
                XCordinate += horizontalMove;
                YCordinate += verticalMove;
            }
        }
    }
}
