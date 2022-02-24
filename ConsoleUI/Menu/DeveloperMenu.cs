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
            Console.WriteLine("1. Display Rooms");
            Console.WriteLine("2. Display Weapons");
            Console.WriteLine("3. Display Potion");
            Console.WriteLine("4. Display Treasure");
            Console.WriteLine("5. Display Items");
            Console.WriteLine("6. Display Mobs");
            Console.WriteLine("7. Exit");
            Console.WriteLine("\n 8. Play Game \n");
        }

        public static void UserCommand()
        {
            string command = Console.ReadLine();

            Console.Clear();

            switch (command)
            {
                case "1":
                    DisplayTextArray(PlannedItems.Rooms);
                    break;
                case "2":
                    DisplayTextArray(PlannedItems.Weapons);
                    break;
                case "3":
                    DisplayTextArray(PlannedItems.Potions);
                    break;
                case "4":
                    DisplayTextArray(PlannedItems.Treasure);
                    break;
                case "5":
                    DisplayTextList(PlannedItems.Items);
                    break;
                case "6":
                    DisplayTextList(PlannedItems.Mobs);
                    break;
                case "7":
                    Console.WriteLine("Press Any Key To Exit");
                    break;
                case "8":
                    AreaLoader areaLoader = new AreaLoader();
                    areaLoader.Start(); //WILL CHANGE ONCE MENU SYSTEM IS IMPLEMENTED. Absolutly not clean <<------ REMEBER TO CHANGE WHEN MENU SYSTEM BEGINS IMPLEMENTATION 
                    break;
                case "Room":
                    DisplayTextArray(PlannedItems.Rooms);
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
            UserCommand();
        }
    }
}
