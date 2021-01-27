using System;

namespace MSSA.CS.Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the namespace MSSA.CS.Welcome define a method which 
            // prints your name and "Welcome to C#!" to the command line.
            
            Greet();           

            string input = "17"; // Given string input = "17", write code that:
            int count = int.Parse(input); // Converts input to an integer and store in a variable named count
            ++count; // Increments count using the pre-increment operator
            Console.WriteLine($"{count}"); // prints count to the console using the string interpolation syntax
        }

        private static void Greet()
        {
            string name = GetName();
            Console.WriteLine($"{name}, Welcome to C#!\n");
        }

        private static string GetName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }
    }
}
 