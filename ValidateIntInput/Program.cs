using System;

namespace ValidateIntInput
{
    class Program
    {
        static void Main(string[] args)
        {
            getAndValidateInput();
        }

        private static int getAndValidateInput()
        {
            Console.Write($"Enter an integer: ");

            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue);

            while (!success || inputValue == 0)
            {
                Console.WriteLine("Invalid Input. Try again!");
                Console.Write($"Enter a valid number :");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue);
            }

            return inputValue;
        }
    }
}                                                              