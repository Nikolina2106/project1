using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace zadatak1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        private readonly string Role;

        protected BaseService(string role)
        {
            Role = role;
        }

        public virtual void Add()
        {
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
            var result=Storage.Instance.Find(Role).Cast<T>();

            if(result != null && result.Any())
            {
                DisplayList(result);
            }
            return result;
        }

        protected IEnumerable<RoleProperties> FindAll()
        {
            return Storage.Instance.FindAll();
        }

        protected abstract T AddSpecific(T item);
        public abstract void DisplayList(IEnumerable<T> list);
        public abstract void DisplaySingle(T model);
        



    }
}
