#region usingStatements 
using ConsoleUI.LevelGui;
using ConsoleUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary.Mapping;
#endregion

namespace ConsoleUI.GameState
{
    public class LoadArea
    {
        StoryText storyText = new StoryText();
        private Player player = new Player(new Cordinate(10,10));
        private Map map = new Map(100,100);
        private CommandHandler commandHandler;

        public void GenerateWorld()
        {
            commandHandler = new CommandHandler(player, map);

            map.Areas = map.MakeEmptyMap();
            map.Areas = map.AddCustomAreas(map.Areas); 

            Area lastArea = map.Areas[player.Cordinate.X, player.Cordinate.Y];

            UpdateWorld(lastArea);
        }

        public void UpdateWorld(Area curentArea)
        {
            storyText.DisplayAreaText(curentArea);

            //Clear Minimap and display combat UI if an enemy is present TODO:

            MiniMap.Update(player, map);

            Actions.WritePossibleActions();

            commandHandler.PrepareHandles();
            commandHandler.HandleCommand();        

            UpdateWorld(map.Areas[player.Cordinate.X, player.Cordinate.Y]);
        }

    }
}
