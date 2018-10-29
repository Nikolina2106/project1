using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1
{
    public class StService : BaseService<StRole>
    {
        public StService():base("st")
        {
        }

        protected override StRole AddSpecific(StRole stRole)
        {
            stRole.Role = "st";
            Console.Write("Project: ");
            stRole.Project = Console.ReadLine();
            stRole.UsesAutomatedTest = Helper.ParseBoolInput("UsesAutomatedTest: ");

            return stRole;
        }

        public override void DisplayList(IEnumerable<StRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }

        }

        public override void DisplaySingle(StRole model)
        {
            Console.WriteLine($"Role: {model.Role}, First name: {model.FirstName}, Last name: {model.LastName}, Age: {model.Age}, " +
                $"Project: {model.Project}");
        }
        
    }
}
