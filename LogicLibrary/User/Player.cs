#region usingStatements 
using LogicLibrary.Items;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.User
{
    public class Player
    {
        //Password is included in the player save class to seperate saving with Player
        public int ID { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string PlayerClass { get; set; }
        public int Oxygen { get; set; } //Health
        public int BaseAttack { get; set; }
        public Cordinate Cordinate { get; set; } //Location
        public List<string> Inventory { get; set; }
        public List<string> Quests { get; set; }

        public Player(int id, string name, string race, string playerClass, int oxygen, int baseAttack, Cordinate cordinate, List<string> inventory, List<string> quests)
        {
            Cordinate = cordinate;
        }

        public Player(string name) 
        {
            Name = name;

            ID = 8008;
            Race = "Human";
            PlayerClass = "Fighter";
            Oxygen = 100;
            BaseAttack = 20;
            Cordinate = new Cordinate(10, 10);
            Inventory = new List<string>() {""};
            Quests = new List<string>() { "Find a key to the locked door" };
        }
    }
}
