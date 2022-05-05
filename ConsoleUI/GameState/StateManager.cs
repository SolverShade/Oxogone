using ConsoleUI.LevelGui;
using LogicLibrary.Mapping;
using LogicLibrary.Mobs;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.GameState.States
{
    public static class StateManager
    {
        public static void RunCombat(Player player, Area currentArea)
        {
            ChoicesWriter.WriteCombatActions();
            CombatState combatState = new CombatState(player, currentArea.Mob);

            bool continueCombat = false;

            while (continueCombat == false)
            {
                CombatDisplay.DisplayMobAndPlayerCombatStatus(player, currentArea.Mob);
                combatState.CombatTurn();
                continueCombat = combatState.IsMobDead();
                IfPlayerDeadRunGameOver(player);                
            }
            currentArea.Mob = null;
            CombatDisplay.ClearCombatStatus(); // after this make normal UI re appear
        }

        public static void RunInventory(Player player, Area currentArea)
        {
            UILineEdit.ClearAllLines();
            InventoryScreen.DisplayInventory(player);
            InventoryScreen.DisplayInventoryActions();

            InventoryState inventoryState = new InventoryState(player, currentArea);
            inventoryState.HandleInventoryCommand();
            UILineEdit.ClearAllLines();
        }

        public static void IfPlayerDeadRunGameOver(Player player)
        {
            if (player.Health <= 0)
            {
                GameOverScreen.DisplayGameOverDialoug();
            }
        }
    }
}
