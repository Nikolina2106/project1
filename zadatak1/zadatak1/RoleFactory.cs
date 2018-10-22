using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace zadatak1
{
    public class RoleFactory
    {
        public RoleProperties Create(string roleName)
        {
            switch(roleName)
                {
                case "ceo":
                    return new CeoRole();
                case "pm":
                    return new PmRole();
                case "dev":
                    return new DevRole();
                case "dsn":
                    return new DsnRole();
                case "st":
                    return new StRole();
                default:
                    return new RoleProperties();
            }
        }
    }
}
