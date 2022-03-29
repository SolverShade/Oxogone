#region usingStatements 
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
        public List<string> Spawnable { get; set; } // Spawnable objects are a list of string that get conveted to mobs, items, treasure, ect. 
        public bool IsExit { get; set; } 

        public Area(int id, Cordinate cordinate, string description, string name, List<string> spawnable) 
        {
            ID = id;
            Cordinate = cordinate;
            Description = description;
            Name = name;
            Spawnable = spawnable; 
        }
    }
}
