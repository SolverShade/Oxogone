#region usingStatements 
using ConsoleUI.GameState;
using ConsoleUI.Menu;
using ConsoleUI.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleUI
{
    class Program
    {       
        static void Main(string[] args)
        {
            WindowListener.PreventResize();

            StartGame();

            Console.ReadLine();
        }

        static void StartGame()
        {
            LoadArea loadArea = new LoadArea();
            loadArea.GenerateWorld();
        }


    }
}
