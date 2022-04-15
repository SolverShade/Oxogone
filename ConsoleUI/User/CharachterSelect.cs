#region usingStatements 
using Colors.Net;
using Colors.Net.StringColorExtensions;
using ConsoleUI.GameState;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.User
{
    public static class CharachterSelect
    {
        const string PlayersPath = @".\Users\Players.csv";

        static private List<PlayerSave> playerSaves = new List<PlayerSave>();

        public static void RunCharachterSelect()
        {
            ExtractSavedCharachters();
            CreateOrLoadCharachter();
            Console.Clear();
        }

        public static void ExtractSavedCharachters()
        {
            playerSaves.Clear();

            foreach (string line in File.ReadLines(PlayersPath))
            {
                string[] playerTokens = line.Split(',');

                if (playerTokens[0] != "")
                {
                    playerSaves.Add(new PlayerSave(playerTokens[0], playerTokens[1]));
                }
            }
        }

        public static Player CreateOrLoadCharachter()
        {
            Console.WriteLine("Enter your charachters name");
            string charachterName = Console.ReadLine();
            
            PlayerSave selectedSave = null;

            foreach(PlayerSave save in playerSaves)
            {
                if(save.Name == charachterName)
                {
                    selectedSave = save;
                }
            }

            if(selectedSave != null)
            {
                return LoadCharachter(selectedSave);
            }
            else
            {
                return CreateCharachter(charachterName);
            }          
            
        }

        private static Player LoadCharachter(PlayerSave selectedSave)
        {
            ColoredConsole.WriteLine("\nEnter the password for the charachter on record named " + $"{selectedSave.Name}".Green());
            string password = Console.ReadLine();
            if(PasswordValidator.PasswordMatches(selectedSave, password))
            {
                return new Player(selectedSave.Name);
            }
            else
            {
                return LoadCharachter (selectedSave); //try again if wrong pass
            }
        }
        

        private static Player CreateCharachter(string charachterName)
        {
            ColoredConsole.WriteLine("\nEnter a " + "password".Cyan() + " for your new charachter named " + $"{ charachterName}".Magenta());
            string password = Console.ReadLine();

            if (PasswordValidator.PasswordIsValid(password))
            {
                SaveNewCharacter(charachterName, password);
                return new Player(charachterName);
            }
            else
            {
                return CreateCharachter(charachterName); //try again if wrong pass
            }            
        }     

        private static void SaveNewCharacter(string charachterName, string password)
        {
            try
            {
                StreamWriter streamWriter = File.AppendText(PlayersPath);
                string UserLine = string.Format("{0},{1}", charachterName, password);
                streamWriter.WriteLine(UserLine);
                streamWriter.Close();
            }
            catch
            {
                ColoredConsole.WriteLine("\nName entered was not in a correct format or files in the game are currently open on the user's end".Red());
                Console.ReadLine();
            }
        }
    }
}
