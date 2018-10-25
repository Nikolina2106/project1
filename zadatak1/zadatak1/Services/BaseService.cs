using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace zadatak1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        private readonly string Role;
        //private readonly Storage storage;

        protected BaseService(string role)
        {
            Role = role;
        }

        public virtual void Add()
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

        public IEnumerable<T> Find()
        {

            return Storage.Instance.Find(Role).Cast<T>();
        }

        protected IEnumerable<RoleProperties> FindAll()
        {
            return Storage.Instance.FindAll();
        }

        protected abstract T AddSpecific(T item);
        public abstract IEnumerable<RoleProperties> DisplayList();
        public abstract IEnumerable<T> DisplaySingle();
        



    }
}
