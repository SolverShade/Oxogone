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
#endregion

namespace ConsoleUI.GameState
{
    public class World
    {
        protected Player _player { get; set; }
        protected Area currentArea { get; set; }
        protected Map _map { get; set; }       
        protected ActionCommandHandler commandHandler { get; set; }
        public World(Player player, Map map)
        {
            _map = map;
            _player = player;        

            currentArea = _map.Areas[_player.Cordinate.X, _player.Cordinate.Y];
            commandHandler = new ActionCommandHandler(_player, _map);
        }

        public void UpdateWorld()
        {
            StoryWriter.DisplayAreaText(currentArea);
            MiniMap.Update(_player, _map);
            PlayerDisplay.DisplayPlayerStats(_player);
            ChoicesWriter.PossibleActions();

            CheckForCombat();         

            commandHandler.HandleCommand();

            currentArea = _map.Areas[_player.Cordinate.X, _player.Cordinate.Y];

            UpdateWorld();
        }

        private void CheckForCombat()
        {
            if(currentArea.Mob != null)
            {
                StoryWriter.ClearStoryLines();
                MiniMap.ClearMiniMap();
                PlayerDisplay.ClearPlayerLine();
                ChoicesWriter.CombatActions();

                Combat combat = new Combat(_player, currentArea.Mob);

                bool ContinueCombat = false;

                while (ContinueCombat == false)
                {
                    CombatDisplay.DisplayMobCombatStats(currentArea.Mob);
                    combat.PlayerCombatTurn();
                    ContinueCombat = combat.IsPlayerOrMobDead();
                }
                CombatDisplay.ClearCombatStatus(); // after this make normal UI re appear
            }            
        }


    }
}
