﻿using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Mapping
{
    public class Map
    {
        public Area[,] MapAreas = new Area[100, 100];
        readonly string AreaTypesPath = @".\Places\AreaInfo.csv";

        public void ExtractAreas() // try-catch is used because Extract uses a file operation. the try catch is seperated so the method can be more readable.
        {
            try
            {
                Extract();
            }
            catch
            {
                throw new Exception("File not found or has incorrect format");
            }
        }

        private void Extract()
        {
            List<Area> customAreas = new List<Area>();

            foreach (string line in File.ReadLines(AreaTypesPath))
            {
                string[] tokens = line.Split(',');

                customAreas.Add(new Area(new Cordinate(int.Parse(tokens[0]), int.Parse(tokens[1])), tokens[2], tokens[3]));
            }

            FillMap(customAreas);
        }

        public void FillMap(List<Area> areas)
        {
            MakeEmptyMap();

            foreach (Area area in areas)
            {
                MapAreas[area.Cordinate.X, area.Cordinate.Y] = area;
            }
        }

        public void MakeEmptyMap()
        {
            for (int x = 0; x <= (MapAreas.GetLength(0) - 1); x++)
            {
                for (int y = 0; y < (MapAreas.GetLength(1)); y++)
                {
                    MapAreas[x, y] = new Area((new Cordinate(x,y)), "", "Wall" );
                }
            }
        }

    }
}
