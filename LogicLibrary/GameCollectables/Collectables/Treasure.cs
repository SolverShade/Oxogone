using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables.Collectables
{
    public class Treasure: ICollectable
    {
        public int ID { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsQuestItem { get; set; }

        public Treasure(int id, int price, string name, string description, bool isQuestItem)
        {
            ID = id;
            Price = price;
            Name = name;
            Description = description;
            IsQuestItem = isQuestItem;
        }
    }
}
