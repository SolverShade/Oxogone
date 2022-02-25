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

        public Player(int xCord, int yCord)
        {
            XCordinate = xCord;
            YCordinate = yCord;
        }
    }
}
