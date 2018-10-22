using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class DsnService : BaseService<DsnRole>
    {
        public DsnService() : base("dsn")
        {
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        protected override DsnRole AddSpecific(DsnRole dsnRole)
        {
            dsnRole.Role = "dsn";
            Console.Write("Project: ");
            dsnRole.Project = Console.ReadLine();
            dsnRole.CanDraw = Helper.ParseBoolInput("CanDraw: ");

            return dsnRole;
        }

       

        protected override void DisplaySingle(DsnRole model)
        {
            throw new NotImplementedException();
        }
    }
}
