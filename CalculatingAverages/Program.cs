using System;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            tenSum();
        }

        // sum of 10 numbers

        public static void tenSum()
        {
            int totalcount = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Provide 1 number between 0 and 100: ");
                totalcount += int.Parse(Console.ReadLine());

                int runningTotal = totalcount;
                Console.WriteLine($"Entries left {10 - i}: ");
                Console.WriteLine($"Running total is: {runningTotal}");
            }

            Console.WriteLine($"\nYour total is {totalcount}");

            double average = (double)totalcount / 10;

            Console.WriteLine($"\nYour average is {average}");

            if (average > 90)
            {
                Console.WriteLine("You got an A!");
            }
            else if (average > 80)
            {
                Console.WriteLine("You got an B!");
            }
            else if (average > 70)
            {
                Console.WriteLine("You got an C!");
            }
            else
            {
                Console.WriteLine("You failed your class!");
            }
        }

        // Average a specific number of scores

        // Average a non-specific number of scores

    }
}