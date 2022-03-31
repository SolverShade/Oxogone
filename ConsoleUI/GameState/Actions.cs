#region usingStatements 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI.GameState
{
    public static class Actions
    {
        const int ACTIONLINE = 22;
        public static void WritePossibleActions()
        {
            UILineEdit.setGuiLines(ACTIONLINE, 0);
            Console.WriteLine("-Possible Actions-");
            Console.WriteLine("MOVEMENT: n(North), e(East), s(South), w(West) ");
            Console.WriteLine("COMBAT: a(Attack)");
            Console.WriteLine("MENU: q(Quit)");
        }
    }
}
