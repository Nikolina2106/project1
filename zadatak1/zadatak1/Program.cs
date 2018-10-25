using System;
using System.Linq;
using System.Collections.Generic;
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

            CommonService commonService = new CommonService();

            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List, Help, Exit");
            
            while (true)
            {
                string command;
                do
                {
                    Console.Write("Command: ");
                    command = Console.ReadLine();
                    command = command.ToLower();
                    if (command != "add" && command != "remove" && command != "display" && command != "list" 
                        && command != "help" && command != "pmlist" && command != "ceolist" && command != "stlist" 
                        && command != "devlist" && command != "dsnlist" && command != "exit" && command != "add ceo"
                && command != "add dev" && command != "add dsn" && command != "add pm" && command != "add st")
                    {
                        Console.WriteLine("Wrong input. Check Help for possible commands.");
                    }
                }
                while (command != "add" && command != "remove" && command !="display" && command != "list" 
                && command != "help" && command != "pmlist" && command != "ceolist" && command != "stlist" 
                && command != "devlist" && command != "dsnlist" && command != "exit" && command !="add ceo" 
                && command != "add dev" && command != "add dsn" && command != "add pm" && command != "add st");

                string role;
            
                if(command =="add")
                {
                    do
                    {
                        Console.Write("Role: ");
                        role = Console.ReadLine();
                        role = role.ToLower();

                        if(role != "ceo" && role != "pm" && role != "dev" && role != "dsn" && role != "st")
                        {
                            Console.WriteLine("Wrong input. Possible roles are: CEO, PM, DEV, DSN and ST.");
                        }
                    }
                    while (role != "ceo" && role != "pm" && role != "dev" && role != "dsn" && role != "st");

                    switch (role)
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

                else if( command == "add ceo")
                {
                    ceoService.Add();
                }

                else if (command == "add dev")
                {
                    devService.Add();
                }

                else if (command == "add dsn")
                {
                    dsnService.Add();
                }

                else if (command == "add pm")
                {
                    pmService.Add();
                }

                else if (command == "add st")
                {
                    stService.Add();
                }

                else if (command == "help")
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
                
                else if (command == "remove")
                {
                    Console.Write("Enter last name of employee you want to remove from list: ");
                    string removeLastname = Console.ReadLine();

                    commonService.Remove(removeLastname);
                }

                else if(command=="display")
                {
                    var displayList = commonService.FindAll();

                    foreach (var item in displayList)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, Age: {item.Age}");
                    }
                }

                else if(command=="list")
                {
                    var result=commonService.DisplayList();
                    
                    if(result.Count()==0)
                    {
                        Console.WriteLine("List has no employees.");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, Age: {item.Age}");
                        }
                    }              
                }

                else if(command=="ceolist")
                {
                    var result= ceoService.DisplaySingle();

                    foreach(var item in result)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, " +
                            $"Last name: {item.LastName}, Age: {item.Age}, CeoYears: {item.CeoYears}");
                    }
                }

                else if (command == "devlist")
                { 
                    var result = devService.DisplaySingle();

                    foreach (var item in result)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, " +
                            $"Age: {item.Age}, Project: {item.Project}, IsStudent: {item.IsStudent}");
                    }
                }
            

                else if (command == "dsnlist")
                {
                    var result = dsnService.DisplaySingle();

                    foreach (var item in result)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, " +
                            $"Age: {item.Age}, Project: {item.Project}, CanDraw: {item.CanDraw}");
                    }
                }

                else if (command == "pmlist")
                {
                    var result = pmService.DisplaySingle();

                    foreach (var item in result)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, " +
                            $"Age: {item.Age}, Project: {item.Project}");
                    }
                }

                else if (command == "stlist")
                {
                    var result = stService.DisplaySingle();

                    foreach (var item in result)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, " +
                            $"Age: {item.Age}, Project: {item.Project}, UsesAutomatedTest: {item.UsesAutomatedTest}");
                    }
                }

                else if(command=="exit")
                {
                    return;
                }

               

            }
        }
        
               
    }


}

