using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Areas
{
    public class Area
    {
        public (int,int) Cordinate { get; set; }
        public List<string> Text { get; set; }
        public string Type { get; set; }

        public Area((int, int) _cordinate, List<string> _text, string _type) 
        {
            Cordinate = _cordinate;
            Text = _text;
            Type = _type; 
        }
    }
}
