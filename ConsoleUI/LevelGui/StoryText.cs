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
        const int maxStoryLines = 6;
        public void DisplayAreaText(Area area)
        {
            ClearLastAreaText();

            UILineEdit.setGuiLines(storyLine);
            foreach(string text in area.Text)
            {
                Console.WriteLine(text);
            }
        }

        private void ClearLastAreaText()
        {            
            for (int lineIndex = 0; lineIndex < maxStoryLines; lineIndex++)
            {
                UILineEdit.setGuiLines(storyLine + lineIndex);
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
        }


    }
}
