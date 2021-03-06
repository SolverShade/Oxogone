#region usingStatements 
using LogicLibrary.User;
using LogicLibrary.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.LevelGui;
using ConsoleUI.GameState.States;
#endregion

namespace ConsoleUI.GameState
{
    public class ChoiceCommandHandler
    {
        protected Player _player { get; set; }
        protected Map _map { get; set; }

        private AreaNavigator areaNavigator;

        const int userInputLine = 28;

        public ChoiceCommandHandler(Player player, Map map)
        {
            _player = player;
            _map = map;

            areaNavigator = new AreaNavigator(_player, _map);
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
                    areaNavigator.MoveArea(commandPrefix);
                    commandsHandled = areaNavigator.HasPlayerMoved();
                }
                else if (new List<char> { 'i' }.Contains(commandPrefix))
                {
                    StateManager.RunInventory(_player, _map.Areas[_player.Cordinate.X, _player.Cordinate.Y]);                    
                    commandsHandled = true;
                }
                else if (new List<char> { 'r' }.Contains(commandPrefix))
                {
                    areaNavigator.SearchArea();
                }
                else if (new List<char> { 'q' }.Contains(commandPrefix))
                {                    
                    Environment.Exit(0);
                }
            }

            CombatDisplay.ClearStatusLine();
        }
    }
}
