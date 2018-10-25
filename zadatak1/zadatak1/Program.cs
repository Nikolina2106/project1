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

            Console.WriteLine("Available commands: Add <role name>, Remove, Display, List, <role_name>List, Help, Exit");
            
            while (true)
            {
                string command;
                string[] strCommand = new string[2];
                do
                {
                    Console.Write("Command: ");
                    command = Console.ReadLine();
                    command = command.ToLower();
                    strCommand = command.Split(' ');

                    if (strCommand[0] != "add" && strCommand[0] != "remove" && strCommand[0] != "display" && strCommand[0] != "list"
                        && strCommand[0] != "help" && strCommand[0] != "pmlist" && strCommand[0] != "ceolist" && strCommand[0] != "stlist"
                        && strCommand[0] != "devlist" && strCommand[0] != "dsnlist" && strCommand[0] != "exit")
                    {
                        Console.WriteLine("Wrong input. Check Help for possible commands.");
                    }
                }
                while (strCommand[0] != "add" && strCommand[0] != "remove" && strCommand[0] != "display" && strCommand[0] != "list"
                        && strCommand[0] != "help" && strCommand[0] != "pmlist" && strCommand[0] != "ceolist" && strCommand[0] != "stlist"
                        && strCommand[0] != "devlist" && strCommand[0] != "dsnlist" && strCommand[0] != "exit");
                
            
                if(strCommand[0] == "add")
                {                    
                    while (strCommand[1] != "ceo" && strCommand[1] != "pm" && strCommand[1] != "dev"
                            && strCommand[1] != "dsn" && strCommand[1] != "st")
                    {
                        Console.Write("Command: ");
                        command = Console.ReadLine();
                        command = command.ToLower();
                        strCommand = command.Split(' ');

                        if (strCommand[1] != "ceo" && strCommand[1] != "pm" && strCommand[1] != "dev"
                            && strCommand[1] != "dsn" && strCommand[1] != "st")
                        {
                            Console.WriteLine("Wrong input. Possible roles are: CEO, PM, DEV, DSN and ST.");
                        }
                    }

                    switch (strCommand[1])
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

                else if (strCommand[0] == "help")
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
                
                else if (command == "remove")
                {
                    Console.Write("Enter last name of employee you want to remove from list: ");
                    string removeLastname = Console.ReadLine();

                    commonService.Remove(removeLastname);
                }

                else if(command == "display")
                {
                    var displayList = commonService.FindAll();

                    foreach (var item in displayList)
                    {
                        Console.WriteLine($"Role: {item.Role}, First name: {item.FirstName}, Last name: {item.LastName}, Age: {item.Age}");
                    }
                }

                else if(command == "list")
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

                else if(command == "ceolist")
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

                else if(command == "exit")
                {
                    return;
                }
                
            }
        }
        
               
    }


}

