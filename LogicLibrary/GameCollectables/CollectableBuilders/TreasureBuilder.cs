using LogicLibrary.GameCollectables.Collectables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables.CollectableBuilders
{
    public class TreasureBuilder
    {
        static readonly string TreasurePath = @".\Items\Items.csv";

        public static Treasure BuildTreasure(string treasureType)
        {
            int treasureID = 0;

            if (PossibleTreasure().Contains(treasureType))
            {
                foreach (string line in File.ReadAllLines(TreasurePath))
                {
                    string[] treasureTokens = line.Split(',');
                    if (treasureType == treasureTokens[0])
                    {
                        treasureID++;
                        return new Treasure(treasureID, int.Parse(treasureTokens[0]), treasureTokens[1], treasureTokens[2], bool.Parse(treasureTokens[3]));
                    }
                }
                throw new Exception("A Treasure Was incorrectly specified in the game files. fix format!");
            }
            else
            {
                throw new Exception("A Treasure Was incorrectly specified in the game files. fix format!");
            }
        }

        public static List<string> PossibleTreasure()
        {
            List<string> possibleTreasures = new List<string>();
            foreach (string line in File.ReadAllLines(TreasurePath))
            {
                string[] treasureTokens = line.Split(',');
                possibleTreasures.Add(treasureTokens[0]);
            }
            return possibleTreasures;
        }

        public static Treasure BuildRandomTreasure()
        {
            Random random = new Random();

            string treasureType = PossibleTreasure()[random.Next(2)];

            return BuildTreasure(treasureType);
        }
    }
}
