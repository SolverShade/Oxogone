#region usingStatements 
using LogicLibrary.Items;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.Mobs
{
    public class Enemy : Spawnable
    {       
        public int Health { get; set; } 
        public int Defense { get; set; }
        public int Attack { get; set; }

        public Enemy(int health, int defense, int attack)
        {
            Health = health;
            Defense = defense;
            Attack = attack;
        }

        public void IfDeadRemoveFromMap(Map map, Cordinate cordinate)
        {
            if(Health < 0)
            {
                map.Areas[cordinate.X, cordinate.Y].Spawnable = ""; //removes itself from the map 
            }
        }
    }
}
