using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace zadatak1
{
    public class CeoService : BaseService<CeoRole>
    {
        public CeoService():base("ceo")
        {
        }

        public override void Add()
        {
            var ceoList = Find();

            if(ceoList.Count()==0)
            {
                base.Add();
            }
            else
            {
                Console.WriteLine("There is already one CEO.");
            }
        }

        protected override CeoRole AddSpecific(CeoRole ceoRole)
        {
            ceoRole.Role = "ceo";
            ceoRole.CeoYears = Helper.ParseUserInput("CeoYears: ");

            return ceoRole;
        }

        public override void DisplayList(IEnumerable<CeoRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
            if(list==null)
            {
                Console.WriteLine("List is empty.");
            }
        }

        public override void DisplaySingle(CeoRole model)
        {
            Console.WriteLine($"Role: {model.Role}, First name: {model.FirstName}, Last name: {model.LastName}, Age: {model.Age}, " +
                $"CeoYears: {model.CeoYears}");
        }
    }
}

