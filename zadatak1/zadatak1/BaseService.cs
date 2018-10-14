﻿using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        protected Storage storage = new Storage();

        public void Add()
        {
            //model
            T model = new T(); 
            

            Console.Write("First name: ");
            model.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            model.LastName=Console.ReadLine();
            Console.Write("Age: ");
            model.Age=Convert.ToInt32(Console.ReadLine());

            AddSpecific(model);

            storage.Add(model);
            
        }

        public abstract void AddSpecific(T item);
        public abstract void Display();

    }
}
