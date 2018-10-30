using System;
using System.Linq;
using System.Collections.Generic;
using zadatak1.Services;
using zadatak1.Roles;

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

            CommonService commonService = new CommonService();
                       
            Console.WriteLine("Available commands: Add <role_name>, Remove, Display, List <role_name>, Help, Exit");

            string command;
            string role;
            string[] strCommand = new string[2];

            do
            {
                
                var valid = false;
                
                do
                {
                    Console.Write("Command: ");
                    command = Console.ReadLine();
                    strCommand = command.Split(' ');
                    valid = CommandValidator.IsValidCommand(strCommand[0]);
                    command = command.ToUpper();                                       
                }
                while (!valid);

                //add
                if (command==Commands.Add)
                {
                    do
                    {
                        Console.Write("Role: ");
                        role = Console.ReadLine();
                        valid = RoleValidator.IsValidRole(role);
                        role=role.ToUpper();
                    }
                    while (!valid);

                    switch (role)
                    {
                        case PossibleRoles.ceo:
                            ceoService.Add();
                            break;
                        case PossibleRoles.pm:
                            pmService.Add();
                            break;
                        case PossibleRoles.st:
                            stService.Add();
                            break;
                        case PossibleRoles.dsn:
                            dsnService.Add();
                            break;
                        case PossibleRoles.dev:
                            devService.Add();
                            break;
                    }
                }

                //add <role_name>
                else if (strCommand[0] == Commands.Add)
                {
                    do
                    {
                        //strCommand = command.Split(' ');
                        valid = RoleValidator.IsValidRole(strCommand[1]);
                        role = strCommand[1];
                    }
                    while (!valid);

                    switch (role)
                    {
                        case PossibleRoles.ceo:
                            ceoService.Add();
                            break;
                        case PossibleRoles.pm:
                            pmService.Add();
                            break;
                        case PossibleRoles.st:
                            stService.Add();
                            break;
                        case PossibleRoles.dsn:
                            dsnService.Add();
                            break;
                        case PossibleRoles.dev:
                            devService.Add();
                            break;
                    }
                }

                else if (command == Commands.Help)
                {
                    Console.WriteLine("Available commands: \n" +
                        "Help - displays available commands \n" +
                        "Add <role name> – used for adding new employee \n" +
                        "Display - used to display all employees(including you!) with their basic info \n" +
                        "List - used to display all employees(excluding you!) with their basic info \n" +
                        "<role_name>List - used to display all emplyees in a role (e.g. PMLIST – displays all project managers)" +
                        "with their full info \n" +
                        "Exit - used to terminate program \n");
                }

                else if (command == Commands.Remove)
                {
                    Console.Write("Enter last name of employee you want to remove from list: ");
                    string removeLastname = Console.ReadLine();

                    commonService.Remove(removeLastname);
                }

                else if (command == Commands.Display)
                {
                    var displayList = commonService.FindAll();

                    foreach (var item in displayList)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, Age: {item.Age}");
                    }
                }

                else if(command==Commands.List)
                {
                    devService.Find();
                    dsnService.Find();
                    pmService.Find();
                    stService.Find();
                }

                //else if (strCommand[0] == Commands.List)
                //{
                //    if (strCommand[1] != PossibleRoles.ceo && strCommand[1] != PossibleRoles.pm
                //            && strCommand[1] != PossibleRoles.dev && strCommand[1] != PossibleRoles.dsn && strCommand[1] != PossibleRoles.st)
                //    {
                //        Console.WriteLine("Wrong input. Possible roles are: CEO, PM, DEV, DSN and ST.");
                //    }
                   
                //    switch(strCommand[1])
                //    {
                //        case PossibleRoles.ceo:
                //            ceoService.Find();
                //            break;
                //        case PossibleRoles.dev:
                //            devService.Find();
                //            break;
                //        case PossibleRoles.dsn:
                //            dsnService.Find();
                //            break;
                //        case PossibleRoles.pm:
                //            pmService.Find();
                //            break;
                //        case PossibleRoles.st:
                //            stService.Find();
                //            break;
                //    }
                //}
            }
            while (command != Commands.Exit);
        }
        
               
    }


}

