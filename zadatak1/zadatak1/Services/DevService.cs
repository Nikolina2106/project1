using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class DevService : BaseService<DevRole>
    {
        public DevService() : base("dev")
        {
        }

        protected override DevRole AddSpecific(DevRole devRole)
        {
            devRole.Role = "dev";
            Console.Write("Project: ");
            devRole.Project = Console.ReadLine();
            devRole.IsStudent = Helper.ParseBoolInput("IsStudent: ");

            return devRole;
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<DevRole> DisplaySingle()
        {
            var devList = base.FindAll();
            var result = devList.Where(roles => roles.Role == "dev").Cast<DevRole>();

            return result;
        }
    }       
}
