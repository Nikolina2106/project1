using System;
using System.Collections.Generic;
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
            pmRole.Role = "pmrole";
            Console.Write("Project: ");
            pmRole.Project = Console.ReadLine();

            return pmRole;
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        protected override void DisplaySingle(PmRole model)
        {
            throw new NotImplementedException();
        }
    }
}
