using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameItems
{
    public class Weapon
    {
        public string WeaponName;
        public string Description;
        public string DamageType;

        public int Id;
        public int Price;
        public int Damage;

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
