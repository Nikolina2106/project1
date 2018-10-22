using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace zadatak1
{
    public class CeoService : BaseService<CeoRole>
    {
        public CeoService():base("ceo")
        {
        }

        public override void Add()
        {
            var ceoList = Find();

            if(ceoList.Count()==0)
            {
                base.Add();
            }
            else
            {
                Console.WriteLine("There is already one CEO.");
            }
        }

        protected override CeoRole AddSpecific(CeoRole ceoRole)
        {
            ceoRole.Role = "ceo";
            ceoRole.CeoYears = Helper.ParseUserInput("CeoYears: ");

            return ceoRole;
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            throw new NotImplementedException();
        }

        protected override void DisplaySingle(CeoRole model)
        {
            Console.WriteLine($"{model.LastName} {model.FirstName}, {model.Age}, with {model.CeoYears} " +
                $"{(model.CeoYears <= 1 ? "year" : "years")} of experiance as CEO");
        }

    }
}
