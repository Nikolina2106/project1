using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class DsnService : BaseService<DsnRole>
    {
        public override void AddSpecific(DsnRole dsnrole)
        {
            dsnrole.Role = "dsn";
            Console.Write("Project: ");
            dsnrole.Project = Console.ReadLine();
            dsnrole.CanDraw = Helper.ParseBoolInput("CanDraw: ");
        }

        public override void SpecificDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
