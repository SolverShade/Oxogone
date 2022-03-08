﻿using ConsoleUI.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Areas
{
    public class Area
    {
        public Cordinate Cordinate { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }

        public Area(Cordinate _cordinate, string _text, string _type) 
        {
            Cordinate = _cordinate;
            Text = _text;
            Type = _type; 
        }
    }
}
