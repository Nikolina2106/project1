using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class DsnService : BaseService<DSNRole>
    {
        public override void AddSpecific(DSNRole dsnrole)
        {
            dsnrole.Role = "dsnrole";
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
