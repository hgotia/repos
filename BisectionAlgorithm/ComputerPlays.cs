using System;

namespace BisectionAlgorithm
{
    class ComputerPlays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Let's find out how well the bisection algorithm works!");
            Console.WriteLine("Enter a number from 1 to 1000 for the algorithm to find.\n");

            int guessMax = 1000;
            int value = getAndValidate(guessMax);

            bisection_search(value, guessMax);
        }

        private static int getAndValidate(int guessMax)
        {
            Console.Write($"Enter an integer from 1 to {guessMax}: ");

            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue);

            while (!success || inputValue > guessMax || inputValue == 0)
            {
                Console.WriteLine("Invalid Input. Try again!");
                Console.Write($"Enter a valid number :");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue);
            }
            return inputValue;
        }

        private static bool bisection_search(int value, int guessMax)
        {
            int attempts = 15; // so it doesn't get out of control
            int min = 0;
            int max = guessMax+1;

            int iteration = 1;
            int iterationLimit = attempts;

            while (iteration <= iterationLimit)
            {
                int mid = (min + max) / 2;

                Console.WriteLine($"The algorithm chooses {mid}");

                if (value == mid)
                {
                    Console.WriteLine($"\nThe algorithm found your number in {iteration} iterations!"); 
                    return true;
                }

                else if (value < mid)
                {
                    max = mid;
                    iteration++;
                    continue;
                }

                else if (value > mid)
                {
                    min = mid;
                    iteration++;
                    continue;
                }
            }

            Console.WriteLine("\nThe algorithm failed to find your number within the given iteration limit.");
            return false;
        }
    }
}
