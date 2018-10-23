using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class DsnService : BaseService<DsnRole>
    {
        public DsnService() : base("dsn")
        {
        }
        
        protected override DsnRole AddSpecific(DsnRole dsnRole)
        {
            dsnRole.Role = "dsn";
            Console.Write("Project: ");
            dsnRole.Project = Console.ReadLine();
            dsnRole.CanDraw = Helper.ParseBoolInput("CanDraw: ");

            return dsnRole;
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<DsnRole> DisplaySingle()
        {
            var dsnList = base.FindAll();
            var result = dsnList.Where(roles => roles.Role == "dsn").Cast<DsnRole>();

            return result;
        }



    }
}
