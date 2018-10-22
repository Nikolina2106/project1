using System;
using System.Collections.Generic;
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

        protected override void DisplaySingle(DevRole model)
        {
            throw new NotImplementedException();
        }
    }
}
