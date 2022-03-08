using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Mapping
{
    public class Cordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Cordinate(int xCord, int yCord)
        {
            X = xCord;
            Y = yCord;
        }
    }
}
