using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class Storage : RoleProperties
    {
        public List<RoleProperties> MyList { get; set; }
        

        //add, remove, display, list, <role_name>List
        public void Help()
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
        }

        public void Add(RoleProperties item)
        {
            //Console.Write("Role:");
            //Role = Console.ReadLine();
            //if(Role=="CEO")
            //{
            //    Console.Write("CEOYears:");
            //    Console.ReadLine();
            //}

            
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
