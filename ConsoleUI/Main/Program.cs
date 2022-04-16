#region usingStatements 
using ConsoleUI.GameState;
using ConsoleUI.User;
using ConsoleUI.Window;
using LogicLibrary.Mapping;
using LogicLibrary.User;
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
            CharachterSelect.ExtractSavedCharachters();
            Player player = CharachterSelect.CreateOrLoadCharachter();
            Console.Clear();

            Map map = new Map(100, 100);
            map.Areas = map.MakeEmptyMap();
            map.Areas = map.AddCustomAreas(map.Areas);

            World world = new World(player, map);
            world.UpdateWorld();
        }


    }
}
