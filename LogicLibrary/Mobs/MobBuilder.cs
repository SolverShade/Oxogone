using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Mobs
{
    public static class MobBuilder
    {
        static readonly string MobsPath = @".\Mobs\Mobs.csv";

        public static Mob GenerateMob(string mobType)
        {
            try
            {
                return GenerateMobOperation(mobType);
            }
            catch
            {
                throw new Exception("File not found or has incorrect format or file is currently open and should be closed");
            }
        }

        public static Mob GenerateMobOperation(string mobType)
        {
            int mobID = 0;

            if (PossibleMobs().Contains(mobType))
            {
                foreach (string line in File.ReadAllLines(MobsPath))
                {
                    string[] mobTokens = line.Split(',');
                    if(mobType == mobTokens[0])
                    {
                        mobID++;
                        string[] inventory = mobTokens[6].Split('-');
                        return new Mob(mobID, mobTokens[0], mobTokens[1], mobTokens[2], int.Parse(mobTokens[3]), int.Parse(mobTokens[4]), mobTokens[5], inventory.ToList<string>(), mobTokens[7]);
                    }
                }
                return null;
            }
            else
            {
                return null; 
            }
        }

        private static List<string> PossibleMobs()
        {
            List<string> possibleMobs = new List<string>();
            foreach(string line in File.ReadAllLines(MobsPath))
            {
                string[] mobTokens = line.Split(',');
                possibleMobs.Add(mobTokens[0]);
            }
            return possibleMobs;         
        }

        private static bool IsMob(string mobValues)
        {
            if (mobValues != "None" && mobValues != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
