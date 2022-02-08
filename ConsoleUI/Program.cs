using ConsoleUI.Areas;
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

            loadArea.Start();

            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            //Console.WriteLine("Over previous line!!!");

            Console.ReadLine();
        }


    }
}
