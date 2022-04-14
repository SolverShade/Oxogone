using Colors.Net;
using Colors.Net.StringColorExtensions;
using LogicLibrary.Mobs;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class DisplayStatus
    {

        private const int STATUSLINE = 20;
        private const int PLAYERLINE = 22;

        private const int COMBATLINE = 6;
        private const int MAXCOMBATLINES = 10;

        public static void DisplayPlayerStats(Player player)
        {
            ClearStatusLine();

            ColoredConsole.WriteLine("Player Oxogone: " + $"{player.Oxygen}".Green());
        }

        public static void DisplayMobCombatStats(Mob mob)
        {
            UILineEdit.ClearSpecifiedLines(COMBATLINE, MAXCOMBATLINES);
            UILineEdit.setGuiLines(COMBATLINE);

            ColoredConsole.WriteLine("Enemy".Red());
            ColoredConsole.WriteLine("------------------------------------------------".Yellow());
            ColoredConsole.WriteLine(" Name: " + $"{mob.Name}");
            ColoredConsole.WriteLine(" Weapon: " + $"{mob.Weapon}");
            ColoredConsole.WriteLine("\n Race: " + $"{mob.Race}");
            ColoredConsole.WriteLine(" Class: " + $"{mob.CombatClass}");
            ColoredConsole.WriteLine("\n Description: " + mob.Description);
            ColoredConsole.WriteLine("\n Health: " + $"{mob.Health}".Cyan() + "     " + "BaseAttack: " + $"{mob.BaseAttack}".Magenta());
            ColoredConsole.WriteLine("------------------------------------------------".Yellow());            
        }

        public static void NoMobToAttack()
        {
            ClearStatusLine();

            Console.WriteLine("There is currently no mob present in the room to attack...");
        }

        public static void ClearStatusLine()
        {
            UILineEdit.ClearSpecifiedLines(STATUSLINE, 1);
            UILineEdit.setGuiLines(STATUSLINE);
        }
    }
}
