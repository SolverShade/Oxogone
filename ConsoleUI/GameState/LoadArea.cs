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
        private Player player = new Player(new Cordinate(10,10));
        private Map map = new Map(100,100);
        private Area currentArea;  
        private CommandHandler commandHandler;

        public void GenerateWorld()
        {
            commandHandler = new CommandHandler(player, map);

            map.Areas = map.MakeEmptyMap();
            map.Areas = map.AddCustomAreas(map.Areas); 

            currentArea = map.Areas[player.Cordinate.X, player.Cordinate.Y];

            UpdateWorld();
        }

        public void UpdateWorld()
        {
            StoryText.DisplayAreaText(currentArea);
            MiniMap.Update(player, map);
            ActionWriter.PossibleActions();

            CheckForCombat();         

            commandHandler.PrepareHandles(); //Forgot what this does debug TODO:
            commandHandler.HandleCommand();

            currentArea = map.Areas[player.Cordinate.X, player.Cordinate.Y];

            UpdateWorld();
        }

        private void CheckForCombat()
        {
            if(currentArea.Mob != null)
            {
                StoryText.DisplayCombatText();
                ActionWriter.CombatActions();
            }            
        }


    }
}
