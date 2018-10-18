using System;
using System.Linq;
using zadatak1.Services;

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

            ListDisplayMethod listDisplayMethod = new ListDisplayMethod();
            CommonService commonService = new CommonService();
                         

            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List, Help, Exit");
            
            while (true)
            {
                string command;
                do
                {
                    Console.Write("Command: ");
                    command = Console.ReadLine();
                    if(command.ToLower() != "add" && command.ToLower() != "remove" && command.ToLower() != "display" && command.ToLower() != "list" && command.ToLower() != "help"
                            && command.ToLower() != "pmlist" && command.ToLower() != "ceolist" && command.ToLower() != "stlist" && command.ToLower() != "devlist"
                            && command.ToLower() != "dsnlist" && command.ToLower() != "exit")
                    {
                        Console.WriteLine("Wrong input. Check Help for possible commands.");
                    }
                }
                while (command.ToLower() != "add" && command.ToLower() != "remove" && command.ToLower() != "display" && command.ToLower() != "list" && command.ToLower() != "help"
                            && command.ToLower() != "pmlist" && command.ToLower() != "ceolist" && command.ToLower() != "stlist" && command.ToLower() != "devlist"
                            && command.ToLower() != "dsnlist" && command.ToLower() != "exit");

                string role;
            
                if(command.ToLower() =="add")
                {
                    do
                    {
                        Console.Write("Role: ");
                        role = Console.ReadLine();

                        if(role.ToLower() != "ceo" && role.ToLower() != "pm" && role.ToLower() != "dev" && role.ToLower() != "dsn" && role.ToLower() != "st")
                        {
                            Console.WriteLine("Wrong input. Possible roles are: CEO, PM, DEV, DSN and ST.");
                        }
                    }
                    while (role.ToLower() != "ceo" && role.ToLower() != "pm" && role.ToLower() != "dev" && role.ToLower() != "dsn" && role.ToLower() != "st");

                    switch (role.ToLower())
                    {
                        case "ceo":
                            if(ceoService.SearchCeo()==false)
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
                    Console.Write("Enter last name of employee you want to remove from list: ");
                    string removeLastname = Console.ReadLine();
                    commonService.Remove(removeLastname);
                    //display pa remove
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

