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
        public string AreaName { get; set; }
        public string Spawnable { get; set; } // Spawnable objects are interfaces that allows multiple objects to spawn in a room/area as a clearner soltuion than lists. 
        public bool IsExit { get; set; } //an exit is currently that way to win the game or enter a new map 

        public Area(Cordinate _cordinate, string _description, string _areaName, string _spawnable) 
        {
            ID = _cordinate.X + _cordinate.Y; 
            Cordinate = _cordinate;
            Description = _description;
            AreaName = _areaName;
            Spawnable = _spawnable; 
        }
    }
}
