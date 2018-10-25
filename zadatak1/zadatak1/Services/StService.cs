using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class StService : BaseService<StRole>
    {
        public StService():base("st")
        {
        }

        protected override StRole AddSpecific(StRole stRole)
        {
            stRole.Role = "st";
            Console.Write("Project: ");
            stRole.Project = Console.ReadLine();
            stRole.UsesAutomatedTest = Helper.ParseBoolInput("UsesAutomatedTest: ");

            return stRole;
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<StRole> DisplaySingle()
        {
            var stList = base.FindAll();
            var result = stList.Where(roles => roles.Role == "st").Cast<StRole>();

            return result;
        }
        
    }
}
