using ConsoleUI.Areas;
using ConsoleUI.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    public class CommandHandler
    {
        public Player Player { get; set; }
        public Map Map { get; set; }

        private MoveArea moveArea;
        private Combat combat;

        const int userInputLine = 27;

        public CommandHandler(Player player, Map map)
        {
            Player = player;
            Map = map;
        }

        public void PrepareHandles()
        {
           moveArea = new MoveArea(Player, Map);
           combat = new Combat(Player);
        }   

        public void HandleCommand()
        {
            bool commandsHandled = false; 

            while(commandsHandled == false)
            {           
                UILineEdit.setGuiLines(userInputLine, 0);
                string userCommand = Console.ReadLine();
                char commandPrefix = 'z';

                if (userCommand.Length > 0)
                {
                 commandPrefix = userCommand.ToCharArray().ElementAt<char>(0);
                }

                ClearUserInput();

                if (new List<char>{ 'n', 'w', 's', 'e' }.Contains(commandPrefix))
                {
                    moveArea.EnterCommand(commandPrefix);
                    commandsHandled = moveArea.movedArea;
                }
                else if (new List<char> { 'a' }.Contains(commandPrefix))
                {
                    combat.AttackMob();
                }
                else if (new List<char> { 'q' }.Contains(commandPrefix))
                {

                }
                else
                {

                }
            }
        }

        private void ClearUserInput()
        {
            UILineEdit.setGuiLines(userInputLine, 0);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }
    }
}
