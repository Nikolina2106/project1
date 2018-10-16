using System;
using System.Linq;

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


            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List, Help, Exit");
            
            while (true)
            {
                Console.Write("Command: ");
                var command = Console.ReadLine();
                string role;
            
                if(command.ToLower() =="add")
                {
                   
                    do
                    {
                        Console.Write("Role: ");
                        role = Console.ReadLine();
                    }
                    while (role.ToLower() != "ceo" && role.ToLower()!="pm" && role.ToLower() != "dev" && role.ToLower() != "dsn" && role.ToLower() != "st");
                    switch (role.ToLower())
                    {
                        case "ceo":
                            if(Storage.Instance.CheckIfCeoExist()==false)
                            {
                                ceoService.Add();
                            }
                            else
                            {
                                Console.WriteLine("There is already one CEO.");
                            }
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
                else if (command.ToLower() == "help")
                {
                    Console.WriteLine("Available commands: \n" +
                        "Help - displays available commands \n" +
                        "Add – used for adding new employee Remove \n" +
                        "Display - used to display all employees(including you!) with their basic info \n" +
                        "List - used to display all employees(excluding you!) with their basic info \n" +
                        "<role_name>List - used to display all emplyees in a role (e.g. PMLIST – displays all project managers)" +
                        "with their full info \n" +
                        "Exit - used to terminate program \n");
                }

                else if (command.ToLower() == "remove")
                {
                    Storage.Instance.Remove();
                }

                else if(command.ToLower()=="display")
                {
                    Storage.Instance.Display();
                }
                else if(command.ToLower()=="list")
                {
                    Storage.Instance.List();
                }
                else if(command.ToLower()=="exit")
                {
                    return;
                }

            }
        }
        
               
    }


}

