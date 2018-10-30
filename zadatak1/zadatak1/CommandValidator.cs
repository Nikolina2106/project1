using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class CommandValidator
    {
        public static bool IsValidCommand(string command)
        {
            var c = command.Split(' ');
            var valid = !string.IsNullOrEmpty(c[0]) &&
                   (string.Equals(c[0], Commands.List, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(c[0], Commands.Add, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(c[0], Commands.Remove, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(c[0], Commands.Display, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(c[0], Commands.Help, StringComparison.InvariantCultureIgnoreCase));

            if (c.Length > 1)
            {
                var validWithRole = RoleValidator.IsValidRole(c[1]);
            }

            if (!valid)
            {
                Console.WriteLine("Wrong input. Check Help for possible commands.");
            }

            return valid;
        }
    }
}
