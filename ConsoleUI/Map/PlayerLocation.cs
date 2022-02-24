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
        public static (int, int) location = (10, 10);

        public static void Update(string direction)
        {
<<<<<<< HEAD:ConsoleUI/Map/PlayerLocation.cs
            switch (direction)
=======
            string requstedArea = DefineMap.mapAreas[(Location.Item1 + horizontalMove), (Location.Item2 + verticalMove)];
            if (bannedAreas.Contains(requstedArea))
>>>>>>> parent of 0ca53f8 (Implemented File reading for areas. still need to re-add all the old areas in this new format.):ConsoleUI/Mapping/PlayerLocation.cs
            {
                case "N":
                    location.Item2++;
                    break;
                case "S":
                    location.Item2--;
                    break;
                case "E":
                    location.Item1++;
                    break;
                case "W":
                    location.Item1--;
                    break;
                default:
                    break;
            } 
        }

        //inclusive numbers could get confusing. refactor to make more sense? 
        public static string retriveAreaGroup(int currentMark, int areasInLine, int currentLine, int lines)
        {
            int middleLine = (int)(Math.Ceiling((double)lines / 2));
            int middleArea = (int)(Math.Ceiling((double)areasInLine / 2));

            int horizontalFromPlayer = (middleArea - areasInLine) + currentMark;
            int verticalFromPlayer = (lines - middleLine) - currentLine;

            int xCordinate = location.Item1 + horizontalFromPlayer;
            int yCordinate = location.Item2 + verticalFromPlayer;

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
