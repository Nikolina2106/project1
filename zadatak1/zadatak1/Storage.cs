using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public abstract class Storage : RoleProperties
    {
        InMemoryList memoryList= new InMemoryList();
        

        //add, remove, display, list, <role_name>List
        public void Help()
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
        }

        public abstract void STSpecificAdd(STRole item);
        public abstract void DEVSpecificAdd(DEVRole item);
        public abstract void DSNSpecificAdd(DSNRole item);
        public abstract void CEOSpecificAdd(CEORole item);
        public abstract void PMSpecificAdd(PMRole item);

        public void Add(RoleProperties item)
        {
            Console.Write("Role:");
            Role = Console.ReadLine();
            if(Role=="CEO")
            {
                Console.Write("CEOYears:");
                Console.ReadLine();
            }

            
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
