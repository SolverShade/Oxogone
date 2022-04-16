#region usingStatements 
using ConsoleUI.LevelGui;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary.Mapping;
using ConsoleUI.User;
using System.Threading;
using ConsoleUI.GameState.States;
#endregion

namespace ConsoleUI.GameState
{
    public class World
    {
        public Player Player { get; set; }
        public Area CurrentArea { get; set; }
        public Map Map { get; set; }       
        public ActionCommandHandler CommandHandler { get; set; }
        public World(Player player, Map map)
        {
            Map = map;
            Player = player;        

            CurrentArea = Map.Areas[Player.Cordinate.X, Player.Cordinate.Y];
            CommandHandler = new ActionCommandHandler(Player, Map);
        }

        public void UpdateWorld()
        {
            CheckForCombat();

            StoryWriter.DisplayAreaText(CurrentArea);
            MiniMap.Update(Player, Map);
            PlayerDisplay.DisplayPlayerStats(Player);
            ChoicesWriter.PossibleActions();

            CommandHandler.HandleCommand();

            CurrentArea = Map.Areas[Player.Cordinate.X, Player.Cordinate.Y];

            UpdateWorld();
        }

        private void CheckForCombat()
        {
            if(CurrentArea.Mob != null)
            {
                StateManager.RunCombat(Player, CurrentArea);
            }            
        }


    }
}
