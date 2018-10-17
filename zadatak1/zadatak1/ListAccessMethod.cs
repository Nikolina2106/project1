using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class ListAccessMethod : BaseService<RoleProperties>
    {
        public override void AddSpecific(RoleProperties item)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Storage.Instance.Display();
        }
    }
}
