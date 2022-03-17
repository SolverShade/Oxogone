#region usingStatements 
using Colors.Net;
using Colors.Net.StringColorExtensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.Menu
{
    public static class Items
    {
        readonly static string AllItemsPath = @".\Items\";

        public static List<string> Rooms = new List<string>();
        public static List<string> Weapons = new List<string>();
        public static List<string> Potions = new List<string>();
        public static List<string> Treasure = new List<string>();
        public static List<string> UseableItems = new List<string>();
        public static List<string> Mobs = new List<string>();

        public static void LoadItems()
        {
            Weapons = ExtractItems("Weapons.csv");
            Potions = ExtractItems("Potions.csv");
            Treasure = ExtractItems("Treasure.csv");
            UseableItems = ExtractItems("UseableItems.csv");
            Mobs = ExtractItems("Mobs.csv");
            Rooms = ExtractItems("Rooms.csv");
        }

        private static List<string> ExtractItems(string fileName)
        {
            try
            {
                return Extract(fileName);
            }
            catch
            {
                ColoredConsole.WriteLine($"{"Oxogone experinced an error loading a file that is currently open, does not exist, or has been modified".Red()} \n");
                return null;
            }
        }

        private static List<string> Extract(string fileName)
        {
            List<string> fileItems = new List<string>();

            foreach (string line in File.ReadLines(AllItemsPath + fileName))
            {
                string[] tokens = line.Split(',');
                foreach(string item in tokens)
                {
                    fileItems.Add(item);
                }
            }

            return fileItems;
        }
    }
}
