using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class PmService : BaseService<PmRole>

    {
        public override void AddSpecific(PmRole pmrole)
        {
            pmrole.Role = "pmrole";
            Console.Write("Project: ");
            pmrole.Project = Console.ReadLine();
        }

        public override void SpecificDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
