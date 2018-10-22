using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    public static class Helper
    {
        public static uint ParseUserInput(string messageToDisplay)
        {
            bool isValid;
            uint parsedNumber;
            do
            {
                Console.Write(messageToDisplay);
                string userInput = Console.ReadLine();
                isValid = uint.TryParse(userInput, out parsedNumber);
                if(!isValid)
                {
                        Console.WriteLine("Input has to be a natural numeber.");
                    
                }
            }
            while (!isValid);

            return parsedNumber;
        }

        public static bool ParseBoolInput(string messageToDisplay)
        {
            bool isValid;
            bool parsedInput;

            do
            {
                Console.Write(messageToDisplay);
                string userInput = Console.ReadLine();
                isValid = bool.TryParse(userInput, out parsedInput);
                if (!isValid)
                {
                    Console.WriteLine("Input has to be true or false.");

                }
            }
            while (!isValid);

            return parsedInput;
        }

        
    }
}
