using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class Storage 
    {
        public List<RoleProperties> MyList = new List<RoleProperties>();

        

        //add, remove, display, list, <role_name>List
        public void Help()
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
        }

        public void Add(RoleProperties item)
        {            
            MyList.Add(item); 
        }
        public void Remove(RoleProperties item)
        {
            MyList.Remove(item);
        }
        public void Display()
        {

        }
        public void List()
        {

        }




    }
}
