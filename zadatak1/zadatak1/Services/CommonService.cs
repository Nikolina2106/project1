using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak1.Services
{
    public class CommonService : BaseService<RoleProperties>
    {
        public CommonService() : base(string.Empty)
        {
        }

        protected override RoleProperties AddSpecific(RoleProperties item)
        {
            throw new NotImplementedException();
        }

        //findAll i Get
        public new IEnumerable<RoleProperties> FindAll()
        {
            return base.FindAll();
        }

        public void Get()
        {

        }

        public void Remove(string removeLastName)
        {
            Storage.Instance.Remove(removeLastName);
        }

        public override IEnumerable<RoleProperties> DisplayList()
        {
            var listWithCeo=base.FindAll();
            var result= listWithCeo.Where(roles => roles.Role != "ceo");

            return result;
        }

        public override IEnumerable<RoleProperties> DisplaySingle()
        {
            throw new NotImplementedException();
        }

       
    }
}
