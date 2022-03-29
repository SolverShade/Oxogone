#region usingStatements 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.Mapping
{
    public class Map
    {
        public Area[,] Areas;
        readonly string AreaTypesPath = @".\Places\AreaInfo.csv";

        public Map(int rows, int columns)
        {
            Areas = new Area[rows, columns];
        }

        public Area[,] AddCustomAreas(Area[,] currentAreas) // try-catch is used because Extract uses a file operation. the try catch is seperated so the method can be more readable.
        {
            try
            {
                return ExtractCustomAreas(currentAreas);
            }
            catch
            {
                throw new Exception("File not found or has incorrect format or file is currently open and should be closed");
            }
        }

        private Area[,] ExtractCustomAreas(Area[,] currentMap)
        {
            List<Area> customAreas = new List<Area>();

            for (int areaIndex = 0; areaIndex < File.ReadLines(AreaTypesPath).Count(); areaIndex++)
            {
                string line = File.ReadLines(AreaTypesPath).ElementAt(areaIndex);
                string[] AreaIdentifers = line.Split(',');
                List<string> AreaContent = AreaIdentifers[4].Split('-').ToList<string>();
                customAreas.Add(new Area(areaIndex, new Cordinate(int.Parse(AreaIdentifers[0]), int.Parse(AreaIdentifers[1])), AreaIdentifers[2], AreaIdentifers[3], AreaContent));
            }

            foreach (Area area in customAreas)
            {
                currentMap[area.Cordinate.X, area.Cordinate.Y] = area;
            }

            return currentMap;
        }

        public Area[,] MakeEmptyMap()
        {
            Area[,] areas = new Area[Areas.GetLength(0), Areas.GetLength(1)];

            for (int x = 0; x <= (Areas.GetLength(0) - 1); x++)
            {
                for (int y = 0; y < (Areas.GetLength(1)); y++)
                {
                    areas[x, y] = new Area(-1, (new Cordinate(x, y)), "", "Wall", new List<string> { "" });
                }
            }
            return areas;
        }

    }
}
