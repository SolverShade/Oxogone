using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Menu
{
    public static class MainMenu
    {
        private static CharachterSelect charachterSelect = new CharachterSelect();
        private static List<string> commands = new List<string> { "1. Play Game", "2. Developer Menu (shows Lists of items gotten from files)", "3. Quit" };

        public static void WriteMenu()
        {
            foreach(string command in commands)
            {
                Console.WriteLine(command);
            }
        }

        public static void Command()
        {
            string userCommand = Console.ReadLine();

            switch (userCommand)
            {
                case "1":
                    Console.Clear();
                    charachterSelect.WriteCharachterOptions();
                    charachterSelect.ChooseCharachter();
                    //LoadArea loadArea = new LoadArea();
                    //loadArea.Start();
                    break;
                case "2":
                    Console.Clear();
                    DeveloperMenu.WriteMenu();
                    DeveloperMenu.Command();
                    break;
                case "3":
                    Environment.Exit(0);
                    break; 


            }
        }
    }
}
