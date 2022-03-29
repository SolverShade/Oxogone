using LogicLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.GameState
{
    class ItemManager
    {
       public Spawnable Spawnable; 
       public ItemManager(Spawnable spawnable)
       {
            Spawnable = spawnable; 
       }

       public void SpawnableAction()
       {

       }
    }
}
