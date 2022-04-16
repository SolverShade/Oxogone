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
            CheckForCombat();

            StoryWriter.DisplayAreaText(currentArea);
            MiniMap.Update(_player, _map);
            PlayerDisplay.DisplayPlayerStats(_player);
            ChoicesWriter.PossibleActions();

            commandHandler.HandleCommand();

            currentArea = _map.Areas[_player.Cordinate.X, _player.Cordinate.Y];

            UpdateWorld();
        }

        private void CheckForCombat()
        {
            if(currentArea.Mob != null)
            {
                ChoicesWriter.WriteCombatActions();

                Combat combat = new Combat(_player, currentArea.Mob);
                bool ContinueCombat = false;

                while (ContinueCombat == false)
                {
                    CombatDisplay.DisplayMobCombatStats(currentArea.Mob);
                    CombatDisplay.DisplayPlayerCombatStats(_player);
                    combat.PlayerCombatTurn();
                    combat.IfPlayerDeadRunGameOver();
                    ContinueCombat = combat.IsMobDead();
                }
                currentArea.Mob = null; // remove mob because Victory
                //make victory screen in new class
                CombatDisplay.ClearCombatStatus(); // after this make normal UI re appear
            }            
        }


    }
}
