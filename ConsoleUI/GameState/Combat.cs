#region usingStatements 
using Colors.Net;
using Colors.Net.StringColorExtensions;
using ConsoleUI.User;
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

        const int COMBATLINE = 20;

        public Combat(Player player)
        {
            _player = player;
        }

        public void AttackMob()
        {
            Random hitPointsRange = new Random();
            int attackValue = hitPointsRange.Next(0, _player.AttackPoints);

            UILineEdit.ClearSpecifiedLines(COMBATLINE, 1);
            UILineEdit.setGuiLines(COMBATLINE);
            ColoredConsole.Write("Player did " + $"{ attackValue.ToString()}".Green() + " damage to nothing");
        }


    }
}
