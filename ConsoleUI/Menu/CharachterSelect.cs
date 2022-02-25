using Colors.Net;
using Colors.Net.StringColorExtensions;
using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Menu
{
    public class CharachterSelect
    {
        private List<string> playerSaveSlots = new List<string>(); 

        public void WriteCharachterOptions()
        {
            playerSaveSlots.Clear();

            foreach (string charachter in File.ReadLines(@".\Users\Players.txt"))
            {
                if(charachter != "")
                {
                    playerSaveSlots.Add(charachter);
                }
            }

            if(playerSaveSlots.Count == 0)
            {
                Console.WriteLine("Make a new charachter \n y/n");       
            }
            else
            {
                Console.WriteLine("Choose a save slot \n");
                for(int slotIndex = 0; slotIndex  < playerSaveSlots.Count; slotIndex++)
                {                    
                    Console.WriteLine((1 + slotIndex).ToString() + ". " + playerSaveSlots[slotIndex]);
                }
                Console.WriteLine("\n" + "Make a new Charachter?" + "---> Type Create ");
                Console.WriteLine("\n" + "Delete All Saves?" + "---> Type Clear ");
                Console.WriteLine("\n" + "Return to main menu?" + "---> Type MainMenu ");
            }
        }

        public void ChooseCharachter()
        {
            string userCommand = Console.ReadLine();
            int charachterIndex;
            bool enteredCharachterIndex = int.TryParse(userCommand, out charachterIndex);

            if(playerSaveSlots.Count == 0)
            {
                switch (userCommand)
                {
                    case "y":
                        CreateCharachter();
                        break;
                    case "n":
                        Console.Clear();
                        MainMenu.WriteMenu(); 
                        MainMenu.Command();
                        break;
                    default:
                        Console.WriteLine("Enter a valid command");
                        ChooseCharachter();
                        break;
                }
            }
            else if(charachterIndex > 0 && charachterIndex <= playerSaveSlots.Count) 
            {
                Console.Clear();
                LoadArea loadArea = new LoadArea();
                loadArea.Start();
            }
            else
            {
                switch (userCommand)
                {
                    case "Create":
                        CreateCharachter();
                        break;
                    case "MainMenu":
                        Console.Clear();
                        MainMenu.WriteMenu();
                        MainMenu.Command();
                        break;
                    case "Clear":
                        File.WriteAllText(@".\Users\Players.txt", string.Empty);
                        Console.Clear();
                        WriteCharachterOptions();
                        ChooseCharachter();
                        break;
                    default:
                        Console.WriteLine("Enter a valid command");
                        ChooseCharachter();
                        break;
                }
            }
        }
        

        public void CreateCharachter()
        {
            Console.Clear();
            Console.WriteLine("Enter your Charachters Name");
            string name = Console.ReadLine();
            try
            {
                StreamWriter streamWriter = File.AppendText(@".\Users\Players.txt");
                streamWriter.WriteLine(name);               
                streamWriter.Close();
            }
            catch
            {
                ColoredConsole.WriteLine("Name entered was not in a correct format or files in the game are currently open on the user's end".Red());
                Console.ReadLine();
            }

            Console.Clear();
            WriteCharachterOptions();
            ChooseCharachter();
        }
    }
}
