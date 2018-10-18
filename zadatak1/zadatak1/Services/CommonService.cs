using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1.Services
{
    public class CommonService 
    {
        //findAll i Get
        public void FindAll()
        {

        }

        public void Get()
        {

        }

        public void Remove(string removeLastName)
        {
            Storage.Instance.Remove(removeLastName);
        }

    }
}
