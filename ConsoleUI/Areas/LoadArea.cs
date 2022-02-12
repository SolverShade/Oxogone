using ConsoleUI.LevelGui;
using ConsoleUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Areas
{
    public static class LoadArea
    {
        public static List<Area> areas = new List<Area>();
        static StoryText storyText = new StoryText();
        public static Area currentArea;

        public static void Start()
        {
            GetAreas();

            DefineMap.FillMap(areas);

            currentArea = areas[0];

            Load(currentArea);
        }

        //make areas a static list later? 
        public static void Load(Area nextArea)
        {           
            storyText.DisplayAreaText(nextArea);

            UpdateMap.Update();

            Actions.WritePossibleActions();

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
