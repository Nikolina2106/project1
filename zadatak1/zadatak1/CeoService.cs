using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class CeoService : BaseService<CEORole>
    {
        public override void AddSpecific(CEORole ceorole)
        {
            ceorole.Role = "ceo";
            Console.Write("CEOYears: ");
            ceorole.CeoYears = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            
        }
    }
}
