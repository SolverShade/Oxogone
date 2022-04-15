using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.GameItems
{
    public static class WeaponBuilder
    {
        static readonly string WeaponsPath = @".\Items\Weapons.csv";

        public static Weapon BuildWeapon(string weaponType)
        {
            int weaponID = 0;

            if (PossibleWeapons().Contains(weaponType))
            {
                foreach (string line in File.ReadAllLines(WeaponsPath))
                {
                    string[] weaponTokens = line.Split(',');
                    if (weaponType == weaponTokens[0])
                    {
                        weaponID++;
                        return new Weapon(weaponID, weaponTokens[0], weaponTokens[1], weaponTokens[2], int.Parse(weaponTokens[3]), int.Parse(weaponTokens[4]));
                    }
                }
                throw new Exception("A Weapon Was incorrectly specified in the game files. fix format!");
            }
            else
            {
                throw new Exception("A Weapon Was incorrectly specified in the game files. fix format!");
            }
        }

        private static List<string> PossibleWeapons()
        {
            List<string> possibleWeapons = new List<string>();
            foreach (string line in File.ReadAllLines(WeaponsPath))
            {
                string[] weaponTokens = line.Split(',');
                possibleWeapons.Add(weaponTokens[0]);
            }
            return possibleWeapons;
        }

        public static Weapon BuildRandomWeapon()
        {
            Random random = new Random();

            string weaponType = PossibleWeapons()[random.Next(4)];

            return BuildWeapon(weaponType);
        }
    }
}

