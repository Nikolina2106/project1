using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class PmService : BaseService<PMRole>

    {
        public override void AddSpecific(PMRole pmrole)
        {
            pmrole.Role = "pmrole";
            Console.Write("Project: ");
            pmrole.Project = Console.ReadLine();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
