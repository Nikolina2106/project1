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
            Console.Write("CanDraw: ");
            dsnrole.CanDraw = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
