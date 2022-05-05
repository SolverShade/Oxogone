#region usingStatements 
using LogicLibrary.Creature;
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
    public class Mob : LivingCreature
    {       
        public List<string> Inventory { get; set; }
        public string Description { get; set; }

        public Mob(int id, string race, string name, string combatClass, int health, int baseAttack, Weapon weapon, List<string> inventory, string description)
              : base(id, name, health, race, combatClass, baseAttack, weapon)
        {           
            Inventory = inventory;
            Description = description; 
        }
    }
}
