#region usingStatements 
using Colors.Net;
using Colors.Net.StringColorExtensions;
using LogicLibrary.User;
using LogicLibrary.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.LevelGui;
#endregion

namespace ConsoleUI.GameState
{
    public class Combat
    {
        protected Player _player { get; set; }
        protected Mob _mob { get; set; }

        const int userInputLine = 27;

        public Combat(Player player, Mob mob)
        {
            _player = player;
            _mob = mob;
        }

        public void PlayerCombatTurn()
        {
            string userCommand = Console.ReadLine();
            char commandPrefix = userCommand.ToCharArray().ElementAt<char>(0); 

            if (userCommand.Length > 0) // gets user input and erases it after is has been entered 
            {
                UILineEdit.setGuiLines(userInputLine, 0);
            }

            if (new List<char> { 'n', 'w', 's', 'e' }.Contains(commandPrefix))
            {
                //DisplayStatus.
            }
            else if (new List<char> { 'a' }.Contains(commandPrefix))
            {
                _player.Oxygen -= _mob.BaseAttack;
                _mob.Health -= _player.BaseAttack; 
            }
            else if (new List<char> { 'q' }.Contains(commandPrefix))
            {
                Environment.Exit(0);
            }            
        }         

        public bool IsPlayerOrMobDead()
        {
            if(_player.Oxygen <= 0 || _mob.Health <= 0) // add game over and victory option 
            {
                return true; 
            }
            else
            {
                return false;
            }
        }


    }
}
