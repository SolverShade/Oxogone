using LogicLibrary.GameCollectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables.Collectables
{
    public class Weapon : ICollectable
    {
        public string WeaponName { get; set; }
        public string Description { get; set; }
        public string DamageType { get; set; }

        public int Id { get; set; }
        public int Price { get; set; }
        public int Damage { get; set; }

        public Weapon(int id, string name, string description, string damageType, int price, int damage)
        {
            Id = id;
            WeaponName = name;
            Description = description;
            Price = price;
            DamageType = damageType;
            Damage = damage; 
        }
    }
}
