using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class UpdateMap
    {
        static readonly int[] mapLines = new int[] {7 ,9, 10, 11, 12, 13, 15};

        public static void Update()
        {
            UILineEdit.setGuiLines(mapLines[0], 6);

            Console.Write("N");

            // create a loop that add each char with color based on its area. 

            UILineEdit.setGuiLines(mapLines[1], 5);
            Console.Write("*" + "*" + "*" );
            UILineEdit.setGuiLines(mapLines[2], 4);
            Console.Write("*" + "*" + "*" + "*" + "*");
            UILineEdit.setGuiLines(mapLines[3], 1);
            Console.Write("W " + "*" + "*" + "*" + "*" + "*" + "*" + "*" + " E");
            UILineEdit.setGuiLines(mapLines[4], 4);
            Console.Write("*" + "*" + "*" + "*" + "*");
            UILineEdit.setGuiLines(mapLines[5], 5);
            Console.Write("*" + "*" + "*" );
            UILineEdit.setGuiLines(mapLines[6], 6);
            Console.Write("S");
        }
    }
}
