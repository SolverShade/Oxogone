#region usingStatements 
using LogicLibrary.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.Mapping
{
    public class Area
    {
        public int ID { get; set; }
        public Cordinate Cordinate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Mob Mob { get; set; }
        public int Exits { get; set; }
        public List<string> Spawnable { get; set; } // TODO: change from list string to Spawnable Type

        public Area(int id, Cordinate cordinate, string description, string name, Mob mob, List<string> spawnable) 
        {
            ID = id;
            Cordinate = cordinate;
            Description = description;
            Name = name;
            Mob = mob;
            Spawnable = spawnable; 
        }
    }
}
