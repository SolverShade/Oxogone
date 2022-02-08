using ConsoleUI.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public class StoryText
    {
        const int storyLine = 1;

        public void DisplayAreaText(Area area)
        {
            UILineEdit.setGuiLines(storyLine);
            foreach(string text in area.Text)
            {
                Console.WriteLine(text);
            }
        }


    }
}
