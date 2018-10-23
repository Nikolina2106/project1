using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class PmService : BaseService<PmRole>
    {
        public PmService():base("pm")
        {
        }

        protected override PmRole AddSpecific(PmRole pmRole)
        {
            pmRole.Role = "pm";
            Console.Write("Project: ");
            pmRole.Project = Console.ReadLine();

            return pmRole;
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<PmRole> DisplaySingle()
        {
            var pmList = base.FindAll();
            var result = pmList.Where(roles => roles.Role == "pm").Cast<PmRole>();

            return result;
        }
    }
}
