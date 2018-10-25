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

        public override IEnumerable<CeoRole> DisplaySingle()
        {
            var ceoList = base.FindAll();
            var result = ceoList.Where(roles => roles.Role == "ceo").Cast<CeoRole>();

            return result;
        }

        
    }
}
