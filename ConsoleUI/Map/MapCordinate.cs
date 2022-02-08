using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Areas
{
    class MapCordinate
    {
        public string Type { get; set; }
        public (int,int) Location { get; set; }
        public MapCordinate((int, int) _location, string _type)
        {
            Location = _location;
            Type = _type;
        }
    }
}
