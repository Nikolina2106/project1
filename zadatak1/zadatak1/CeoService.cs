using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class CeoService : BaseService<CEORole>
    {
        public override void AddSpecific(CEORole item)
        {
            CEORole model = new CEORole();
            Console.Write("CEOYears: ");
            model.CeoYears = Console.ReadLine();
        }

        public override void Display()
        {
            
        }
    }
}
