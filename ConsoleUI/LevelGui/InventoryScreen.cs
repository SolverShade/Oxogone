using LogicLibrary.GameCollectables;
using LogicLibrary.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelGui
{
    public static class InventoryScreen
    {
        const int INVENTORYCOMMANDLINE = 28;
        const int INVENTORYSTATUSLINE = 21;
        const int INVENTORYHELPLINE = 23;

        public static void DisplayInventory(Player player)
        {
            ClearInventoryDisplayLines();
            UILineEdit.setGuiLines(1, 0);
            foreach (ICollectable collectable in player.Inventory)
            {
                Console.WriteLine(collectable.GetType().Name + ": " + collectable.Name);
            }
        }

        public static void DisplayInventoryActions()
        {
            UILineEdit.setGuiLines(INVENTORYHELPLINE, 0);

            Console.WriteLine("-INVENTORY ACTIONS-");
            //Console.WriteLine("u(Use)");
            Console.WriteLine("t(Toss)");
            //Console.WriteLine("d(Describe");
            Console.WriteLine("e(Exit Inventory)");

            UILineEdit.setGuiLines(INVENTORYCOMMANDLINE, 0);
        }

        public static void DescribeItem(string itemDescription)
        {
            UILineEdit.setGuiLines(INVENTORYSTATUSLINE, 0);
            Console.WriteLine(itemDescription);
            UILineEdit.setGuiLines(INVENTORYCOMMANDLINE, 0);
        }

        public static void AskCollectableName(string collectableAction)
        {
            UILineEdit.setGuiLines(INVENTORYSTATUSLINE, 0);
            Console.WriteLine("Enter the name of the item you want to " + collectableAction);
            UILineEdit.setGuiLines(INVENTORYCOMMANDLINE, 0);
        }

        public static void DisplayNoSuchCollectableMessage(string requestedCollectable)
        {
            UILineEdit.setGuiLines(INVENTORYSTATUSLINE, 0);
            Console.WriteLine("The item " + requestedCollectable + " does not exist in the inventory.");

            UILineEdit.ClearUserInputLine();
            UILineEdit.setGuiLines(INVENTORYCOMMANDLINE, 0);
        }

        public static void ClearInventoryStatusLine()
        {
            UILineEdit.ClearSpecifiedLines(INVENTORYSTATUSLINE, 1);
        }

        public static void ClearInventoryDisplayLines()
        {
            UILineEdit.ClearSpecifiedLines(1, 20);
        }

    }
}
