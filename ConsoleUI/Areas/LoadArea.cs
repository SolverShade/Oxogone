using ConsoleUI.LevelGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Areas
{
    public class LoadArea
    {
        static List<Area> areas = new List<Area>();
        StoryText storyText = new StoryText();
        Area currentArea;

        public void Start()
        {
            GetAreas();

            DefineMap.FillMap(areas);

            Load();
        }

        //make areas a static list later? 
        private void Load()
        {
            currentArea = areas[0];

            storyText.DisplayAreaText(currentArea);

            UpdateMap.Update();
            

        }

        //temporary until areas will be loaded in a more manageable way 
        private Area LivingQuartersCenter = new Area((10, 10), new List<string>
        { "You find yourself in a small room with a metallic looking door.",
            "It seems like you are located is some sort of living quarters.",
            "In the room there is a terminal four diffrent buttons, a bed, and some personal belongings." },
            "Room");

        private Area LivingQuartersExit = new Area((10, 11), new List<string>
        { "The door is in front of you.",
            "A keypad is beside the door.",
            "On the keypad' panel are three buttons labeled JKL." },
            "Door");

        private void GetAreas()
        {
            areas.Add(LivingQuartersCenter);
            areas.Add(LivingQuartersExit);
        }

    }
}
