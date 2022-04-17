#region usingStatements 
using LogicLibrary.GameCollectables;
using LogicLibrary.GameCollectables.Collectables;
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
        public Weapon PlayerWeapon { get; set; }
        public int Oxygen { get; set; } //Health
        public int BaseAttack { get; set; }
        public Cordinate Cordinate { get; set; } //Location
        public List<ICollectable> Inventory { get; set; }
        public List<string> Quests { get; set; }

        public Player(int id, string name, string race, string playerClass, Weapon weapon, int oxygen, int baseAttack, Cordinate cordinate, List<ICollectable> inventory, List<string> quests)
        {
            Cordinate = cordinate;
        }

        public Player(string name) //Default Player 
        {
            Name = name;

            ID = 8008;
            Race = "Human";
            PlayerClass = "Fighter";
            Oxygen = 100;
            PlayerWeapon = new Weapon(329874, "Spoon", "is sharp", "cut", 1, 5);
            BaseAttack = 20;
            Cordinate = new Cordinate(10, 10);
            Inventory = new List<ICollectable>() {new Potion(9009, 20, "small oxygen canister", "gives oxygen", "Heal")}; // starting item to test collectables. remove later. 
            Quests = new List<string>() { "Find a key to the locked door" };
        }
    }
}
