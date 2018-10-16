using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class DevService : BaseService<DevRole>
    {
        public override void AddSpecific(DevRole devRole)
        {
            devRole.Role = "dev";
            Console.Write("Project: ");
            devRole.Project = Console.ReadLine();
            devRole.IsStudent = Helper.ParseBoolInput("IsStudent: ");
            
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
