﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public static class Actions
    {
        const int ACTIONLINE = 22;
        public static void WritePossibleActions()
        {
            UILineEdit.setGuiLines(ACTIONLINE, 0);
            Console.WriteLine("-Possible Actions-");
            Console.WriteLine("n(North), e(East), s(South), w(West)");
            Console.WriteLine("a(Attack)");
            Console.WriteLine("q(Quit)");
        }
    }
}