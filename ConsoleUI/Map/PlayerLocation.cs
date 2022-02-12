using ConsoleUI.LevelGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Map
{
    public static class PlayerLocation
    {
        public static (int, int) Location = (10, 10);

        private static List<string> bannedAreas = new List<string>() { "Wall", "LockedDoor" };

        public static void MoveArea(int horizontalMove, int verticalMove)
        {
            string requstedArea = DefineMap.mapAreas[(Location.Item1 + horizontalMove), (Location.Item2 + verticalMove)];
            if (bannedAreas.Contains(requstedArea))
            {
                Console.WriteLine("CANT GO THERE!!!");
            }
            else
            {
                Location = ((Location.Item1 + horizontalMove), (Location.Item2 + verticalMove));
            }
        }

        //inclusive numbers could get confusing. refactor to make more sense? 
        public static string retriveAreaGroup(int currentMark, int areasInLine, int currentLine, int lines)
        {
            int middleLine = (int)(Math.Ceiling((double)lines / 2));
            int middleArea = (int)(Math.Ceiling((double)areasInLine / 2));

            int horizontalFromPlayer = (middleArea - areasInLine) + currentMark;
            int verticalFromPlayer = (lines - middleLine) - currentLine;

            int xCordinate = Location.Item1 + horizontalFromPlayer;
            int yCordinate = Location.Item2 + verticalFromPlayer;

            string areaType;

            if(horizontalFromPlayer == 0 && verticalFromPlayer == 0)
            {
                areaType = "Player";
            }
            else
            {
                areaType = DefineMap.mapAreas[xCordinate, yCordinate];
            }
             
            return areaType;
        }
    }
}
