﻿using ConsoleUI.LevelGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Mapping
{
    public class Player
    {
        public Cordinate Cordinate { get; set; }
        public int Oxygen = 100;
        public int AttackPoints = 20; // make class Weapon that holds a name and Attackpoints value 

        public Player(Cordinate cordinate)
        {
            Cordinate = cordinate;
        }
    }
}
