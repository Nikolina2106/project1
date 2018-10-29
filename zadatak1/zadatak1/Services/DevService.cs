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

        public override void DisplayList(IEnumerable<DevRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }

        }

        public override void DisplaySingle(DevRole model)
        {
            Console.WriteLine($"Role: {model.Role}, First name: {model.FirstName}, Last name: {model.LastName}, Age: {model.Age}, " +
                $"Project: {model.Project}, Is Student: {model.IsStudent}");
        }
    }       
}
