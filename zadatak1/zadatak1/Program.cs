using System;

namespace zadatak1
{
    class Program
    {

        static void Main(string[] args)
        {
            CeoService ceoService = new CeoService();
            StService stService = new StService();
            PmService pmService = new PmService();
            DsnService dsnService = new DsnService();
            DevService devService = new DevService();


            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            Console.Write("Command: ");

            var command = Console.ReadLine();

            if(command.ToLower() =="add")
            {
                Console.Write("Role: ");
                var role = Console.ReadLine();

                switch (role.ToLower())
                {
                    case "ceo":
                        ceoService.Add();
                        break;
                    case "pm":
                        pmService.Add();
                        break;
                    case "st":
                        stService.Add();
                        break;
                    case "dsn":
                        dsnService.Add();
                        break;
                    case "dev":
                        devService.Add();
                        break;
                }
                
            }
            
        }

        //public STRole stRole = new STRole();
        //public DEVRole devRole = new DEVRole();
        //public CEORole ceoRole = new CEORole();
        //public DSNRole dsnRole = new DSNRole();
        //public PMRole pmRole = new PMRole();
               
    }


}

