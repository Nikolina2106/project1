using System;

namespace zadatak1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            Console.Write("Command: ");
        }

        public STRole stRole = new STRole();
        public DEVRole devRole = new DEVRole();
        public CEORole ceoRole = new CEORole();
        public DSNRole dsnRole = new DSNRole();
        public PMRole pmRole = new PMRole();
               
    }


}

