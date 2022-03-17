#region usingStatements 
using Colors.Net;
using Colors.Net.StringColorExtensions;
using ConsoleUI.Mobs;
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
        public Player Player { get; set; }

        const int COMBATLINE = 20;

        public Combat(Player player)
        {
            Player = player;
        }

        public void AttackMob()
        {
            Random hitPointsRange = new Random();
            int attackValue = hitPointsRange.Next(0, Player.AttackPoints);

            UILineEdit.ClearLine(COMBATLINE);
            UILineEdit.setGuiLines(COMBATLINE);
            ColoredConsole.Write("Player did " + $"{ attackValue.ToString()}".Green() + " damage to nothing");
        }


    }
}
