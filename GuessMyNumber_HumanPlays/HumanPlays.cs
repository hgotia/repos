using System;

namespace GuessMyNumber
{
    class HumanPlays
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            guessMyNumber(rand);
        }

        private static void guessMyNumber(Random rand)
        {
            Console.WriteLine("Welcome to a game of Guess My Number!");
            Console.WriteLine("You will get 10 attempts to guess a number from 1 to 1000. Good luck.\n");

            int computerNumber = rand.Next(1, 1001);
            int iteration = 0;
            int iterationLimit = 10;

            while (iteration <= iterationLimit)
            {
                int guess = getAndValidateInput();
                iteration++;

                if (bisection_algorithm(guess, computerNumber))
                {
                    Console.WriteLine("\n**You got it! You Win!**");
                    break;
                }
                else if (iteration == iterationLimit)
                {
                    Console.WriteLine($"\n**Game Over! The number was {computerNumber}.**");
                    break;
                }
                else
                {
                    Console.WriteLine($"Attempts left: {iterationLimit - iteration}\n");
                }

            }
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

        private static bool bisection_algorithm(int value, int computer)
        {
            int min = 0;
            int max = computer+1;

            if (true)
            {
                int mid = (min + max) / 2;

                if (value == mid) 
                    return true;

                else if (value < mid)
                {
                    max = mid;
                    Console.WriteLine("Guess too low!");
                    return false;
                }

                else if (value > mid)
                {
                    min = mid;
                    Console.WriteLine("Guess too high!");
                    return false;
                }
            }
            return false;
        }
    }
}
