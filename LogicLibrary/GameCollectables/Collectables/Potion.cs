using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables.Collectables
{
    public class Potion: ICollectable
    {
        public int ID { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }

        public Potion(int id, int price, string name, string description, string effect)
        {
            ID = id;
            Price = price;
            Name = name;
            Description = description;
            Effect = effect; 
        }
    }
}
