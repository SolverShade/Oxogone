#region usingStatements 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.LevelGui
{
    public static class ActionWriter
    {
        const int ACTIONLINE = 22;
        const int MAXLINES = 4;
        public static void PossibleActions()
        {

            UILineEdit.ClearSpecifiedLines(ACTIONLINE, MAXLINES);
            UILineEdit.setGuiLines(ACTIONLINE, 0);

            Console.WriteLine("-ACTIONS-");
            Console.WriteLine("Movement: n(North), e(East), s(South), w(West) ");
            Console.WriteLine("Combat: a(Attack)");
            Console.WriteLine("Menu: q(Quit)");
        }

        public static void CombatActions()
        {
            UILineEdit.ClearSpecifiedLines(ACTIONLINE, MAXLINES);
            UILineEdit.setGuiLines(ACTIONLINE, 0);

            Console.WriteLine("-COMBAT-");
            Console.WriteLine("Offense: a(Attack)");
        }
    }
}
