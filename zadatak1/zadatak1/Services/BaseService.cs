using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {

        public void Add()
        {
            //model
            T model = new T();
            
            Console.Write("First name: ");
            model.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            model.LastName=Console.ReadLine();
            model.Age= Helper.ParseUserInput("Age: ");

            AddSpecific(model);

            Storage.Instance.Add(model);
            
        }

        public abstract void AddSpecific(T item);
        public abstract void SpecificDisplay();

        

    }
}
