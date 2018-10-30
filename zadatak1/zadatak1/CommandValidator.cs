using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class CommandValidator
    {
        public static bool IsValidCommand(string command)
        {
            //var c = command.Split(' ');
            var valid = !string.IsNullOrEmpty(command) &&
                   (string.Equals(command, Commands.List, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Add, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Remove, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Display, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Help, StringComparison.InvariantCultureIgnoreCase));

            //if(c.Length>1)
            //{
            //    var validWithRole = RoleValidator.IsValidRole(c[1]);
            //}
            
            if (!valid)
            {
                Console.WriteLine("Wrong input. Check Help for possible commands.");
            }

            return valid;
        }
    }
}
