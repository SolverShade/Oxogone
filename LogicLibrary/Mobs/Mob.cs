#region usingStatements 
using LogicLibrary.Items;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.Mobs
{
    public class Mob : Spawnable
    {       
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Race { get; set; }
        public string CombatClass { get; set; }
        public int Health { get; set; } 
        public int Attack { get; set; }
        public string Weapon { get; set; }
        public List<string> Inventory { get; set; }
        public string Description { get; set; }

        //TODO: Class, Weapon, and Inventory will be randomly generated. currently they are only built at string placeholders

        public Mob(int id, string race, string name, string combatClass, int health, int attack, string weapon, List<string> inventory, string description)
        {
            ID = id;
            Name = name;
            Race = race;
            CombatClass = combatClass; 
            Health = health;
            Attack = attack;
            Weapon = weapon;
            Inventory = inventory;
            Description = description; 
        }

        public void IfDeadRemoveFromMap(Map map, Cordinate cordinate)
        {
            if(Health < 0)
            {
                
            }
        }
    }
}
