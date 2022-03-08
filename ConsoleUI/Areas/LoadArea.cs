using ConsoleUI.LevelGui;
using ConsoleUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Mapping;
using ConsoleUI.Commands;

namespace ConsoleUI.Areas
{
    public class LoadArea
    {
        StoryText storyText = new StoryText();
        private Player player = new Player(new Cordinate(10,10));
        private Map map = new Map();
        private CommandHandler commandHandler;

        public void Start()
        {
            commandHandler = new CommandHandler(player, map);

            map.MakeEmptyMap();
            map.ExtractAreas();

            Area lastArea = map.MapAreas[player.Cordinate.X, player.Cordinate.Y];

            Load(lastArea);
        }

        //make areas a static list later? 
        public void Load(Area curentArea)
        {
            storyText.DisplayAreaText(curentArea);

            MiniMap.Update(player, map);

            Actions.WritePossibleActions();

            commandHandler.PrepareHandles();
            commandHandler.HandleCommand();        

            Load(map.MapAreas[player.Cordinate.X, player.Cordinate.Y]);
        }

    }
}
