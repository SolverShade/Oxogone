#region usingStatements 
using LogicLibrary.GameCollectables;
using LogicLibrary.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LogicLibrary.Mapping
{
    public class Area //<--- Room 
    {
        public int ID { get; set; }
        public Cordinate Cordinate { get; set; }
        public string Description { get; set; }
        public string RoomType { get; set; }
        public string Name { get; set; }
        public Mob Mob { get; set; }
        public int Exits { get; set; }
        public List<ICollectable> Collectables { get; set; } // TODO: change from list string to Spawnable Type

        public Area(int id, Cordinate cordinate, string description, string roomType, Mob mob, List<ICollectable> collectables, string name) 
        {
            ID = id;
            Cordinate = cordinate;
            Description = description;
            RoomType = roomType;
            Mob = mob;
            Collectables = collectables;
            Name = name;
        }
    }
}
