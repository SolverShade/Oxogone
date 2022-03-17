#region usingStatements 

#endregion

using ConsoleUI.GameState;
using ConsoleUI.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadArea loadArea = new LoadArea();
            loadArea.GenerateWorld();

            //MainMenu.WriteMenu();
            //MainMenu.Command();

            Console.ReadLine();
        }


    }
}
