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
<<<<<<< HEAD
=======

            currentArea = areas[0];
>>>>>>> parent of 0ca53f8 (Implemented File reading for areas. still need to re-add all the old areas in this new format.)

            Load();
        }

        //make areas a static list later? 
<<<<<<< HEAD
        private void Load()
        {
            currentArea = areas[0];

            storyText.DisplayAreaText(currentArea);
=======
        public static void Load(Area nextArea)
        {           
            storyText.DisplayAreaText(nextArea);
>>>>>>> parent of 0ca53f8 (Implemented File reading for areas. still need to re-add all the old areas in this new format.)

            UpdateMap.Update();
            

        }

        //temporary until areas will be loaded in a more manageable way 
        private Area LivingQuartersCenter = new Area((10, 10), new List<string>
        { "You find yourself in a small room with a metallic looking door.",
            "It seems like you are located is some sort of living quarters.",
            "In the room there is a terminal four diffrent buttons, a bed, and some personal belongings." },
            "Room");

<<<<<<< HEAD
        private Area LivingQuartersExit = new Area((10, 11), new List<string>
        { "The door is in front of you.",
            "A keypad is beside the door.",
            "On the keypad' panel are three buttons labeled JKL." },
            "Door");

        private void GetAreas()
        {
            areas.Add(LivingQuartersCenter);
            areas.Add(LivingQuartersExit);
=======
            CommandHandler.EnterCommand();       
        }

        // DONT FORGET TO ADD ROOMS HERE!!!
        private static void GetAreas()
        {
            areas.Add(LivingQuartersCenter);
            areas.Add(LivingQuartersBed);
            areas.Add(LivingQuartersDoor);
            areas.Add(LivingQuartersExit);
            areas.Add(HallCenter);
            areas.Add(HallEast);
            areas.Add(HallWest);
>>>>>>> parent of 0ca53f8 (Implemented File reading for areas. still need to re-add all the old areas in this new format.)
        }

        //temporary until areas will be loaded in a more manageable way. probabbly by accesing XML files 
        private static Area LivingQuartersCenter = new Area((10, 10), new List<string>
        { "You find yourself in a small room with a metallic looking door.",
            "It seems like you are located is some sort of living quarters.",
            "In the room there is a terminal four diffrent buttons, a bed, and some personal belongings." },
            "Room");

        private static Area LivingQuartersDoor = new Area((10, 12), new List<string>
        { "You Phase through the door to your amazement.", 
        "Inbetween the door was a note from someone named the developer", 
        "-Implement a physics system next week-"},
            "Door");

        private static Area LivingQuartersExit = new Area((10, 11), new List<string>
        { "The door is in front of you.",
            "A keypad is beside the door.",
            "On the keypad's panel are three buttons labeled JKL." },
            "Room");

        private static Area LivingQuartersBed = new Area((10, 9), new List<string>
        { "There is a bed in front of you.",
            "On the bed is a small audio tape."},
           "Room");

        private static Area HallCenter = new Area((10, 13), new List<string>
        { "A Hallway with nothing in it..... yet.",
            ""},
          "Room");

        private static Area HallWest = new Area((9, 13), new List<string>
        { "A Hallway with nothing in it..... yet.",
            ""},
        "Room");

        private static Area HallEast = new Area((11, 13), new List<string>
        { "A Hallway with nothing in it..... yet.",
            ""},
        "Room");
    }
}
