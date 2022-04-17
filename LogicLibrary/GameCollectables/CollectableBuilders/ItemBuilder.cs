using LogicLibrary.GameCollectables.Collectables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables.CollectableBuilders
{
    public class ItemBuilder
    {
        static readonly string ItemsPath = @".\Items\Items.csv";

        public static Item BuildItem(string itemType)
        {
            int itemID = 0;

            if (PossibleItems().Contains(itemType))
            {
                foreach (string line in File.ReadAllLines(ItemsPath))
                {
                    string[] itemTokens = line.Split(',');
                    if (itemType == itemTokens[0])
                    {
                        itemID++;
                        return new Item(itemID, int.Parse(itemTokens[0]), itemTokens[1], itemTokens[2], bool.Parse(itemTokens[3]), bool.Parse(itemTokens[4]));
                    }
                }
                throw new Exception("A Item Was incorrectly specified in the game files. fix format!");
            }
            else
            {
                throw new Exception("A Item Was incorrectly specified in the game files. fix format!");
            }
        }

        public static List<string> PossibleItems()
        {
            List<string> possibleItems = new List<string>();
            foreach (string line in File.ReadAllLines(ItemsPath))
            {
                string[] itemTokens = line.Split(',');
                possibleItems.Add(itemTokens[0]);
            }
            return possibleItems;
        }

        public static Item BuildRandomItem()
        {
            Random random = new Random();

            string itemType = PossibleItems()[random.Next(2)];

            return BuildItem(itemType);
        }
    }
}
