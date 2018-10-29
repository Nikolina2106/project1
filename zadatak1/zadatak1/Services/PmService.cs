using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class PmService : BaseService<PmRole>
    {
        public PmService() : base("pm")
        {
        }

        protected override PmRole AddSpecific(PmRole pmRole)
        {
            pmRole.Role = "pm";
            Console.Write("Project: ");
            pmRole.Project = Console.ReadLine();

            return pmRole;
        }

        public override void DisplayList(IEnumerable<PmRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }

        }

        public override void DisplaySingle(PmRole model)
        {
            Console.WriteLine($"Role: {model.Role}, First name: {model.FirstName}, Last name: {model.LastName}, Age: {model.Age}, " +
                $"Project: {model.Project}");
        }
    }
}
