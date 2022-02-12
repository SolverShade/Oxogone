using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Menu
{
    public static class PlannedItems
    {
        public static string[] Rooms = new string[]
        {
           "LivingQuartersCenter",
           "LivingQuartersBed",
           "LivingQuartersDoor",
            "LivingQuartersExit",
            "HallCenter",
            "HallEast",
            "HallWest",
        };

        public static string[] Weapons = new string[]
        {
            "Crowbar",
            "Zapper",
            "Fists",
            "Feet",
        };

        public static string[] Potions = new string[]
        {
            "Small Oxygen Canister",
            "Large Oxygen Canister"
        };

        public static string[] Treasure = new string[]
        {
            "Gold",
            "Classic CD's",
            "Vintage 80s jacket",
        };

        public static List<string> Items = new List<string>()
        {
            "Gravity Boots",
            "Oxygen Tank",
            "Space Suit",
            "Audio Tape",
            "Door Pass Card"
        };

        public static List<string> Mobs = new List<string>()
        {
            "Dangerous Steam pipe",
            "Alien",
            "Heavy Box",
            "Broken Elecrical System",
            "Broken Oxygen Tank",
        };
    }
}
