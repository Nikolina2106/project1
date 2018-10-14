using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class StService : BaseService<STRole>
    {
        public override void AddSpecific(STRole strole)
        {
            strole.Role = "strole";
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
