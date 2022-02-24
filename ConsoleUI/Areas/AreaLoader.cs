using ConsoleUI.LevelGui;
using ConsoleUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Mapping;
using ConsoleUI.Mapping.MiniMap;

namespace ConsoleUI.Areas
{
    public class AreaLoader
    {
        public static List<Area> areas = new List<Area>();
        static StoryText storyText = new StoryText();
        public static Area currentArea;
        private Player player = new Player(10, 10); // eventually will be in savedata.csv or similar solution 
        private CommandHandler commandHandler = new CommandHandler();

        public void Start()
        {
            Map.MakeEmptyMap();
            Map.ExtractAreas();

            currentArea = Map.Areas[10,10];

            Load(currentArea);
        }

        public void Load(Area nextArea)
        {
            storyText.DisplayAreaText(nextArea);

            MiniMap.Update(player);

            Actions.WritePossibleActions();

            commandHandler.EnterCommand(player);

            Load(commandHandler.NextArea);
        }

        public string retriveAreaGroup(int horizontalFromCenter, int verticalFromCenter)
        {
            int areaXCord = player.XCordinate + horizontalFromCenter;
            int areaYCord = player.YCordinate + verticalFromCenter;

            string areaType = Map.Areas[areaXCord, areaYCord].Type;

            if (horizontalFromCenter == 0 && verticalFromCenter == 0)
            {
                areaType = "Player";
            }

            return areaType;
        }

    }
}
