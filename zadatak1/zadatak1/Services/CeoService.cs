using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class CeoService : BaseService<CeoRole>
    {
        

        public override void AddSpecific(CeoRole ceoRole)
        {
            ceoRole.Role = "ceo";
            ceoRole.CeoYears = Helper.ParseUserInput("CeoYears: ");
        }

        public override void Display()
        {
            
        }
    }
}
