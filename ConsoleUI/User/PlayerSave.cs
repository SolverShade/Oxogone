using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public class PlayerSave
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public PlayerSave(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
