using LogicLibrary.GameCollectables.Collectables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables.CollectableBuilders
{
    public class PotionBuilder
    {
        static readonly string PotionsPath = @".\Items\Items.csv";

        public static Potion BuildPotion(string potionType)
        {
            int PotionID = 0;

            if (PossiblePotions().Contains(potionType))
            {
                foreach (string line in File.ReadAllLines(PotionsPath))
                {
                    string[] potionTokens = line.Split(',');
                    if (potionType == potionTokens[0])
                    {
                        PotionID++;
                        return new Potion(PotionID, int.Parse(potionTokens[0]), potionTokens[1], potionTokens[2], potionTokens[3]);
                    }
                }
                throw new Exception("A Potion Was incorrectly specified in the game files. fix format!");
            }
            else
            {
                throw new Exception("A Potion Was incorrectly specified in the game files. fix format!");
            }
        }

        public static List<string> PossiblePotions()
        {
            List<string> possiblePotions = new List<string>();
            foreach (string line in File.ReadAllLines(PotionsPath))
            {
                string[] potionTokens = line.Split(',');
                possiblePotions.Add(potionTokens[0]);
            }
            return possiblePotions;
        }

        public static Potion BuildRandomPotion()
        {
            Random random = new Random();

            string potionType = PossiblePotions()[random.Next(2)];

            return BuildPotion(potionType);
        }
    }
}
