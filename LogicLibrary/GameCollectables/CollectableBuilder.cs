using LogicLibrary.GameCollectables.CollectableBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameCollectables
{
    public static class CollectableBuilder
    {
        public static List<ICollectable> GetCollectables(List<string> unBakedCollectables)
        {
            List<ICollectable> collectables = new List<ICollectable>();

            foreach (string unBakedCollectable in unBakedCollectables)
            {
                if (ItemBuilder.PossibleItems().Contains(unBakedCollectable))
                {
                    ICollectable bakedCollectable = ItemBuilder.BuildItem(unBakedCollectable);
                    collectables.Add(bakedCollectable);
                }
                else if (PotionBuilder.PossiblePotions().Contains(unBakedCollectable))
                {
                    ICollectable bakedCollectable = PotionBuilder.BuildPotion(unBakedCollectable);
                    collectables.Add(bakedCollectable);
                }
                else if (TreasureBuilder.PossibleTreasure().Contains(unBakedCollectable))
                {
                    ICollectable bakedCollectable = TreasureBuilder.BuildTreasure(unBakedCollectable);
                    collectables.Add(bakedCollectable);
                }
                else if (WeaponBuilder.PossibleWeapons().Contains(unBakedCollectable))
                {
                    ICollectable bakedCollectable = WeaponBuilder.BuildWeapon(unBakedCollectable);
                    collectables.Add(bakedCollectable);
                }
            }

            return collectables;
        }
    }
}
