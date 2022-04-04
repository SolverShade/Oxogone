#region usingStatements 
using ConsoleUI.User;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.GameState
{
    public class CommandHandler
    {
        protected Player _player { get; set; }
        protected Map _map { get; set; }

        private MoveArea moveArea;
        private Combat combat;

        const int userInputLine = 27;

        public CommandHandler(Player player, Map map)
        {
            _player = player;
            _map = map;

            moveArea = new MoveArea(_player, _map);
            combat = new Combat(_player);
        }

        public void HandleCommand()
        {
            bool commandsHandled = false; 

            while(commandsHandled == false)
            {           
                UILineEdit.setGuiLines(userInputLine, 0);
                string userCommand = Console.ReadLine();
                char commandPrefix = 'z';

                if (userCommand.Length > 0) // gets user input and erases it after is has been entered 
                {
                 commandPrefix = userCommand.ToCharArray().ElementAt<char>(0);
                 UILineEdit.ClearSpecifiedLines(userInputLine, 1); 
                }

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
                    Environment.Exit(0);
                }
            }
        }
    }
}
