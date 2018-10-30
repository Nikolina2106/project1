using System;
using System.Collections.Generic;
using System.Text;
using zadatak1.Roles;

namespace zadatak1
{
    class RoleValidator
    {
        public static bool IsValidRole(string roleName)
        {
            var valid = !string.IsNullOrEmpty(roleName) &&
                   (string.Equals(roleName, PossibleRoles.ceo, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, PossibleRoles.dev, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, PossibleRoles.dsn, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, PossibleRoles.pm, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, PossibleRoles.st, StringComparison.InvariantCultureIgnoreCase));

            if (!valid)
            {
                Console.WriteLine("Wrong input. Possible roles are: CEO, PM, DEV, DSN and ST.");
            }
            return valid;
        }
    }
}
