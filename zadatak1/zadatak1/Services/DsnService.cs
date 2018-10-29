using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class DsnService : BaseService<DsnRole>
    {
        public DsnService() : base("dsn")
        {
        }
        
        protected override DsnRole AddSpecific(DsnRole dsnRole)
        {
            dsnRole.Role = "dsn";
            Console.Write("Project: ");
            dsnRole.Project = Console.ReadLine();
            dsnRole.CanDraw = Helper.ParseBoolInput("CanDraw: ");

            return dsnRole;
        }

        public override void DisplayList(IEnumerable<DsnRole> list)
        {
            foreach(var item in list)
            {
                DisplaySingle(item);
            }

        }

        public override void DisplaySingle(DsnRole model)
        {
            Console.WriteLine($"Role: {model.Role}, First name: {model.FirstName}, Last name: {model.LastName}, Age: {model.Age}, " +
                $"Project: {model.Project}, Can draw: {model.CanDraw}");
        }
        



    }
}
