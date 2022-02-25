using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Menu
{
    public static class DeveloperMenu
    {
        public static void WriteMenu()
        {
            Items.LoadItems(); //reorganize whole classes later

            Console.WriteLine("1. Display Rooms");
            Console.WriteLine("2. Display Weapons");
            Console.WriteLine("3. Display Potion");
            Console.WriteLine("4. Display Treasure");
            Console.WriteLine("5. Display Items");
            Console.WriteLine("6. Display Mobs");
            Console.WriteLine("7. Return to Main Menu");
        }

        public static void Command()
        {
            string command = Console.ReadLine();

            Console.Clear();

            switch (command)
            {
                case "1":
                    DisplayTextList(Items.Rooms);
                    break;
                case "2":
                    DisplayTextList(Items.Weapons);
                    break;
                case "3":
                    DisplayTextList(Items.Potions);
                    break;
                case "4":
                    DisplayTextList(Items.Treasure);
                    break;
                case "5":
                    DisplayTextList(Items.UseableItems);
                    break;
                case "6":
                    DisplayTextList(Items.Mobs);
                    break;
                case "7":
                    Console.Clear();
                    MainMenu.WriteMenu();
                    MainMenu.Command();
                    break;
                case "Room":
                    DisplayTextList(Items.Rooms);
                    break;
                default:
                    break;
            }
        }

        private static void DisplayTextList(List<string> plannedList)
        {           
            foreach (string plannedItem in plannedList)
            {
                Console.WriteLine(plannedItem);
            }
            DisplayExitText();
        }

        private static void DisplayTextArray(string[] plannedArray)
        {
            Array.Sort(plannedArray, (itemA, itemB) => String.Compare(itemA, itemB));
            foreach (string plannedItem in plannedArray)
            {
                Console.WriteLine(plannedItem);
            }
            DisplayExitText();
        }

        private static void DisplayExitText()
        {
            Console.WriteLine(" \n Press any key to return to developer menu");
            Console.ReadLine();
            Console.Clear();
            WriteMenu();
            Command();
        }
    }
}
