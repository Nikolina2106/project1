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
            Console.Write("UsesAutomatedTest: ");
            strole.UsesAutomatedTest = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
