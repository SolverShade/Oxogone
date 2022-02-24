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
    public class LoadArea
    {
        StoryText storyText = new StoryText();
        private Player player = new Player(10, 10);
        private CommandHandler commandHandler = new CommandHandler();

        public void Start()
        {
            Map.MakeEmptyMap();
            Map.ExtractAreas();

            Area lastArea = Map.mapAreas[player.XCordinate,player.YCordinate];

            Load(lastArea);
        }

        //make areas a static list later? 
        public void Load(Area curentArea)
        {
            storyText.DisplayAreaText(curentArea);

            MiniMap.Update(player);

            Actions.WritePossibleActions();

            commandHandler.EnterCommand(player);

            Load(commandHandler.NextArea);
        }

    }
}
