using LogicLibrary.GameCollectables.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Creature
{
    public class LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Health { get; set; } 
        public string Race { get; set; }
        public string CombatClass { get; set; }
        public int BaseAttack { get; set; }
        public Weapon Weapon { get; set; }

        public LivingCreature(int id, string name, int health, string race, string combatClass, int baseAttack, Weapon weapon)
        {
            ID = id;
            Name = name;
            Health = health;
            Race = race;
            CombatClass = combatClass;
            BaseAttack = baseAttack;
            Weapon = weapon; 
        }
    }
}
