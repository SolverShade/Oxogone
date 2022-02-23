using ConsoleUI.LevelGui;
using ConsoleUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Mapping;

namespace ConsoleUI.Areas
{
    public static class LoadArea
    {
        public static List<Area> areas = new List<Area>();
        static StoryText storyText = new StoryText();
        public static Area currentArea;

        public static void Start()
        {
            Map.MakeEmptyMap();
            Map.ExtractAreas();

            currentArea = Map.mapAreas[10,10];

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

    }
}
