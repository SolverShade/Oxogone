#region usingStatements 
using LogicLibrary.GameCollectables.Collectables;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.Mobs
{
    public class Mob
    {       
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Race { get; set; }
        public string CombatClass { get; set; }
        public int Health { get; set; } 
        public int BaseAttack { get; set; }
        public Weapon Weapon { get; set; }
        public List<string> Inventory { get; set; }
        public string Description { get; set; }

        public Mob(int id, string race, string name, string combatClass, int health, int baseAttack, Weapon weapon, List<string> inventory, string description)
        {
            ID = id;
            Name = name;
            Race = race;
            CombatClass = combatClass; 
            Health = health;
            BaseAttack = baseAttack;
            Weapon = weapon;
            Inventory = inventory;
            Description = description; 
        }
    }
}
