using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        
        //add, remove, display, list, <role_name>List
        public void Add(RoleProperties item)
        {
            MyList.Add(item); 
        }

        public void Remove(string removeLastName)
        {
            MyList.Remove(MyList.Where(roles => roles.LastName == removeLastName).FirstOrDefault());
        }

        public void Display()
        {
            //List<RoleProperties> result = MyList.CommonService.FindAll();
            foreach (RoleProperties displayItem in MyList)
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", displayItem.Role,
                    displayItem.FirstName, displayItem.LastName, displayItem.Age);
            }
        }

        public void List()
        {
            foreach(RoleProperties listItem in MyList.Where(item => item.Role != "ceo"))
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", listItem.Role,
                    listItem.FirstName, listItem.LastName, listItem.Age);
            }
        }

        public void RoleNameList()
        {
            Console.Write("Enter role name of employees you want to display: ");
            string roleName = Console.ReadLine();

            foreach(RoleProperties roleNameListItem in MyList.Where(item => item.Role == roleName))
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", roleNameListItem.Role,
                    roleNameListItem.FirstName, roleNameListItem.LastName, roleNameListItem.Age);
            }
            
        }

        //Ceo search
        public bool CheckIfCeoExist()
        {
            bool ceoExistance;
            var ceoExistanceCheck=MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();
            if(ceoExistanceCheck==null)
            {
                ceoExistance = false;
            }
            else
            {
                ceoExistance = true;
            }
            return ceoExistance;
        }




    }
}
