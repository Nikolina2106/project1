using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public class Storage : RoleProperties
    {
        InMemoryList memoryList= new InMemoryList();

        //add, remove, display, list, <role_name>List
        public void Help()
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
        }
        public void Add(RoleProperties item)
        {
            memoryList.MyList.Add(item); 

        }
        public void Remove(RoleProperties item)
        {
            memoryList.MyList.Remove(item);
        }
        public void Display()
        {

        }
        public void List()
        {

        }




    }
}
