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
        private MoveArea commandHandler = new MoveArea();
        private Map map = new Map();

        public void Start()
        {
            map.MakeEmptyMap();
            map.ExtractAreas();

            Area lastArea = map.mapAreas[player.XCordinate,player.YCordinate];

            Load(lastArea);
        }

        //make areas a static list later? 
        public void Load(Area curentArea)
        {
            storyText.DisplayAreaText(curentArea);

            MiniMap.Update(player, map);

            Actions.WritePossibleActions();

            commandHandler.EnterCommand(map);

            player.XCordinate = commandHandler.NextArea.Cordinate.Item1;
            player.YCordinate = commandHandler.NextArea.Cordinate.Item2;

            Load(commandHandler.NextArea);
        }

    }
}
