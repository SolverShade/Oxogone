using Colors.Net;
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
        static readonly int[] spaceLines = new int[] { 6, 5, 4, 1, 4, 5, 6 };
        static readonly char[][] mapItems = new char[][] { new char[] { 'N' }, new char[] { '*', '*', '*', },
            new  char[] { '*', '*', '*', '*', '*', }, new char[] {'W', ' ',  '*', '*', '*', '*', '*', '*', '*', ' ', 'E' }, 
            new  char[] { '*', '*', '*', '*', '*', }, new char[] { '*', '*', '*', }, new  char[] {'S'} };

        public static void Update()
        {
            int mapIndex = 0;

            for (int lineIndex = 0; lineIndex < mapLines.Length; lineIndex++)
            {
                UILineEdit.setGuiLines(mapLines[lineIndex], spaceLines[lineIndex]);
                if(mapIndex < mapItems.Length)
                    foreach(char item in mapItems[mapIndex])
                    {
                        string colorValue = DefineMap.MapItemType(0, 0); // TO:DO get values from an array perhaps to get the areas's types near the player

                        ColoredConsole.Write(item);
                    }
                mapIndex++;
            }



        }
    }
}
