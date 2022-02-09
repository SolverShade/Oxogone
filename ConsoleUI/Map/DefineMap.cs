using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class DefineMap
    {
        static string[,] mapAreas = new string[100, 100];
        static (int, int) playerLocation = (0, 0);

        public static void FillMap(List<Area> areas)
        {
            MakeEmptyMap();

            foreach (Area area in areas)
            {
                mapAreas[area.Cordinate.Item1, area.Cordinate.Item2] = area.Type;
            }
        }

        private static void MakeEmptyMap()
        {
            for (int x = 0; x <= (mapAreas.GetLength(0) - 1); x++)
            {
                for (int y = 0; y < (mapAreas.GetLength(1) - 1); y++)
                {
                    mapAreas[x, y] = "Wall";
                }
            }
        }

        public static string MapItemType(int horizontalFromPoint, int verticalFromPoint)
        {
            string itemType = mapAreas[(playerLocation.Item1 + horizontalFromPoint), (playerLocation.Item2 + verticalFromPoint)];
            return itemType;
        }



    }
}
