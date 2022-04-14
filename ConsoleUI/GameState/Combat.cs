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
#endregion

namespace ConsoleUI.GameState
{
    public class Combat
    {
        protected Player _player { get; set; }
        protected Mob _mob { get; set; }

        public const int ATTACKLINE = 20;

        public Combat(Player player, Mob mob)
        {
            _player = player;
            _mob = mob;
        }

        public void RunCombatAndDisplayStats()
        {
            bool commandsHandled = false;

            while (commandsHandled == false)
            {
                _mob.Health -= _player.BaseAttack;
                _player.Oxygen -= _mob.BaseAttack;

            }
        }      

        public static void NoMobToAttack()
        {
            UILineEdit.ClearSpecifiedLines(ATTACKLINE, 1);
            UILineEdit.setGuiLines(ATTACKLINE);
            ColoredConsole.Write("There is currently no mob present in the room to attack...");
        }


    }
}
