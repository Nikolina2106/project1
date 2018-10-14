using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class DevService : BaseService<DEVRole>
    {
        public override void AddSpecific(DEVRole devrole)
        {
            devrole.Role = "devrole";
            Console.Write("Project: ");
            devrole.Project = Console.ReadLine();
            Console.Write("IsStudent: ");
            devrole.IsStudent = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
