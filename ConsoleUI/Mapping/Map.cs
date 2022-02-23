using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Mapping
{
    public static class Map
    {
        public static Area[,] mapAreas = new Area[100, 100];
        readonly static string AreaTypesPath = "C:/Users/HarambeCrompten/Documents/Important/College Documents/C#/csv/AreaInfo.csv";

        public static void ExtractAreas()
        {
            List<Area> customAreas = new List<Area>();

            foreach(string line in File.ReadLines(AreaTypesPath))
            {
                string[] tokens = line.Split(',');

                customAreas.Add(new Area((int.Parse(tokens[0]), int.Parse(tokens[1])), tokens[2], tokens[3]));
            }

            FillMap(customAreas);
        }

        public static void FillMap(List<Area> areas)
        {
            MakeEmptyMap();

            foreach (Area area in areas)
            {
                mapAreas[area.Cordinate.Item1, area.Cordinate.Item2] = area;
            }
        }

        public static void MakeEmptyMap()
        {
            for (int x = 0; x <= (mapAreas.GetLength(0) - 1); x++)
            {
                for (int y = 0; y < (mapAreas.GetLength(1)); y++)
                {
                    mapAreas[x, y] = new Area((x, y), "", "Wall" );
                }
            }
        }

    }
}
