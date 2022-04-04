#region usingStatements 
using ConsoleUI.GameState;
using ConsoleUI.Menu;
using ConsoleUI.Window;
using LogicLibrary.Mapping;
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

        public static void StartGame()
        {
            Map map = new Map(100, 100);
            map.Areas = map.MakeEmptyMap();
            map.Areas = map.AddCustomAreas(map.Areas);

            World world = new World(map);
            world.UpdateWorld();
        }


    }
}
