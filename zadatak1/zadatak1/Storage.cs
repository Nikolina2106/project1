using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak1
{
    public class Storage
    {
        protected static Storage instance;
        private Storage() { }
        public static Storage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Storage();
                }
                return instance;
            }
        }

        private List<RoleProperties> MyList = new List<RoleProperties>();
        
        public void Add(RoleProperties item)
        {
            MyList.Add(item); 
        }

        public void Remove(string removeLastName)
        {
            MyList.Remove(MyList.Where(roles => roles.LastName == removeLastName).FirstOrDefault());
        }

        public IEnumerable<RoleProperties> Find(string role)
        {
            return MyList.Where(r => r.Role == role).ToList();
        }

        public IEnumerable<RoleProperties> FindAll()
        {
            return MyList.ToList();
        }
        



    }
}
