#region usingStatements 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.LevelGui
{
    public static class ChoicesWriter
    {
        const int CHOICELINE = 24;
        const int MAXLINES = 4;
        public static void PossibleActions()
        {
            ClearChoices();

            Console.WriteLine("-CHOICES-");
            Console.WriteLine("Movement: n(North), e(East), s(South), w(West) ");
            Console.WriteLine("Actions: i(Inventory), r(rummage)");
            Console.WriteLine("Menu: q(Quit)");
        }

        public static void WriteCombatActions()
        {
            ClearChoices();

            Console.WriteLine("-COMBAT-");
            Console.WriteLine("Offense: a(Attack)");
        }

        public static void ClearChoices()
        {
            UILineEdit.ClearSpecifiedLines(CHOICELINE, MAXLINES);
            UILineEdit.setGuiLines(CHOICELINE, 0);
        }

        
    }
}
