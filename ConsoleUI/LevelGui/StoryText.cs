﻿using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public class StoryText
    {
        const int STORYLINE = 1;
        const int MAXSTORYLINES = 6;
        public void DisplayAreaText(Area area)
        {
            ClearLastAreaText();

            UILineEdit.setGuiLines(STORYLINE);
            string[] textLines = area.Text.Split('>');
            foreach(string text in textLines)
            {
                Console.WriteLine(text);
            }
        }

        private void ClearLastAreaText()
        {            
            for (int lineIndex = 0; lineIndex < MAXSTORYLINES; lineIndex++)
            {
                UILineEdit.setGuiLines(STORYLINE + lineIndex);
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
        }


    }
}
