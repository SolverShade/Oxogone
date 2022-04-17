using ConsoleUI.LevelGui;
using LogicLibrary.GameCollectables;
using LogicLibrary.Mapping;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.GameState.States
{
    public class InventoryState
    {
        public Player Player { get; set; }
        public Area CurrentArea { get; set; }

        public InventoryState(Player player, Area currentArea)
        {
            Player = player;
            CurrentArea = currentArea; 
        }

        public void HandleInventoryCommand()
        {
            bool commandsHandled = false;

            while (commandsHandled == false)
            {
                InventoryScreen.ClearInventoryStatusLine();
                UILineEdit.ClearUserInputLine();
                UILineEdit.setGuiLines(28, 0);

                string userCommand = Console.ReadLine();
                char commandPrefix = 'z';

                if (userCommand.Length > 0) 
                {
                    commandPrefix = userCommand.ToCharArray().ElementAt<char>(0);
                    UILineEdit.ClearUserInputLine();
                }

                if (new List<char> { 'u' }.Contains(commandPrefix))
                {
                    // for using items. Implement later 
                }
                else if (new List<char> { 't' }.Contains(commandPrefix))
                {
                    InventoryScreen.AskCollectableName("Toss");
                    string collectableName = Console.ReadLine();
                    CheckInventoryForCollectalbe(collectableName);
                    InventoryScreen.DisplayInventory(Player);
                }
                else if (new List<char> { 'e' }.Contains(commandPrefix))
                {
                    commandsHandled = true;
                }
            }
        }

        private void CheckInventoryForCollectalbe(string collectableName)
        {
            ICollectable requestedCollectable = null;

            foreach (ICollectable collectable in Player.Inventory)
            {
                if (collectable.Name == collectableName)
                {
                    CurrentArea.Collectables.Add(collectable);
                    requestedCollectable = collectable;
                }
            }

            if(requestedCollectable == null)
            {
                InventoryScreen.DisplayNoSuchCollectableMessage(collectableName);
            }
            else
            {
                Player.Inventory.Remove(requestedCollectable);
            }
            
        }


    }
}

