using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class StService : BaseService<StRole>
    {
        public override void AddSpecific(StRole strole)
        {
            strole.Role = "st";
            Console.Write("Project: ");
            strole.Project = Console.ReadLine();
            strole.UsesAutomatedTest = Helper.ParseBoolInput("UsesAutomatedTest: ");
        }

        public override void SpecificDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
