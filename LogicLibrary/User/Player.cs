#region usingStatements 
using LogicLibrary.GameCollectables;
using LogicLibrary.GameCollectables.Collectables;
using LogicLibrary.Creature;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.User
{
    public class Player : LivingCreature 
    {
        //Password is included in the player save class to seperate saving with Player
        public Cordinate Cordinate { get; set; } //Location
        public List<ICollectable> Inventory { get; set; }
        public List<string> Quests { get; set; }

        public Player(int id, string name, string race, string playerClass, Weapon weapon, int health, int baseAttack, Cordinate cordinate, List<ICollectable> inventory, List<string> quests)
            :base(id, name, health, race, playerClass, baseAttack, weapon)
        {
            Cordinate = cordinate;
        }

        public Player(string name) //Default Player 
            : base(8008, name, 200, "Human", "Fighter", 20, new Weapon(329874, "Spoon", "is sharp", "cut", 1, 5))
        {
            Cordinate = new Cordinate(10, 10);
            Inventory = new List<ICollectable>() {new Potion(9009, 20, "small oxygen canister", "gives oxygen", "Heal")}; // starting item to test collectables. remove later. 
            Quests = new List<string>() { "Find a key to the locked door" };
        }
    }
}
