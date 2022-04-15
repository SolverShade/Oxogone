using Colors.Net;
using Colors.Net.StringColorExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.User
{
    public static class PasswordValidator
    {
        public static bool PasswordMatches(PlayerSave selectedSave, string password)
        {
            if (password == selectedSave.Password)
            {
                return true;
            }
            else
            {
                ColoredConsole.WriteLine("\nThe password ".Red() + password + " doesnt match the one on record for ".Red() + selectedSave.Name + ". Try again".Red());
                return false;
            }
        }

        public static bool PasswordIsValid(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(c => !Char.IsLetterOrDigit(c)))
            {
                return true;
            }
            else
            {
                ColoredConsole.WriteLine("\nPassword must Contain 1 Capital Letter, 1 lowercase letter, 1 Special Character".Red());
                return false;
            }
        }

    }
}
