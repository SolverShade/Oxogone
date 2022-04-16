using Colors.Net;
using Colors.Net.StringColorExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class GameOver
    {
        public static void DIsplayGameOverDialoug()
        {
            UILineEdit.ClearAllLines();
            ColoredConsole.WriteLine("Game Over!".White());

            GameOverChoice();           
        }

        private static void GameOverChoice()
        {
            ColoredConsole.WriteLine("\nTry Again? (y/n)");
            string command = Console.ReadLine();

            if (command.ToCharArray().ElementAt(0) == 'y')
            {
                UILineEdit.ClearAllLines();
                Program.StartGame();
            }
            else if (command.ToCharArray().ElementAt(0) == 'n')
            {
                Environment.Exit(0);
            }
            else
            {
                ColoredConsole.WriteLine("\n Enter a valid command (must be lowercase)".Red());
                GameOverChoice();
            }
        }
    }
}
