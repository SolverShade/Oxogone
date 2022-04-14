#region usingStatements 
using ConsoleUI.LevelGui;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary.Mapping;
#endregion

namespace ConsoleUI.GameState
{
    public class World
    {
        protected Player _player { get; set; }
        protected Area currentArea { get; set; }
        protected Map _map { get; set; }       
        protected ActionCommandHandler commandHandler { get; set; }
        public World(Map map)
        {
            _map = map;
            _player = new Player(new Cordinate(10, 10));            
            currentArea = _map.Areas[_player.Cordinate.X, _player.Cordinate.Y];
            commandHandler = new ActionCommandHandler(_player, _map);
        }

        public void UpdateWorld()
        {
            StoryWriter.DisplayAreaText(currentArea);
            MiniMap.Update(_player, _map);
            DisplayStatus.DisplayPlayerStats(_player);
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
                StoryWriter.DisplayCombatText();
                MiniMap.ClearMiniMap();
                ChoicesWriter.CombatActions();

                Combat combat = new Combat(_player, currentArea.Mob);

                bool ContinueCombat = false;

                while (ContinueCombat == false)
                {
                    DisplayStatus.DisplayMobCombatStats(currentArea.Mob);
                    combat.PlayerCombatTurn();
                    ContinueCombat = combat.IsPlayerOrMobDead();
                }
            }            
        }


    }
}
