#region usingStatements 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.Mobs
{
    public class Enemy
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
    }
}
