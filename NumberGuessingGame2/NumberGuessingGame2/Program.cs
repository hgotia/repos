using System;

namespace NumberGuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(1, 11);
            int guessAttempts = 3;
            bool gameOver = false;
            
            Console.WriteLine("I'm thinking of a number between 1 and 10. Guess what it is?");

            do
            {
                string value = Console.ReadLine();
                int guess = Convert.ToInt32(value);
                guessAttempts--;

                if (guess > r)
                    Console.WriteLine("Number too HIGH, try again. You have {0} attempts remaining.", guessAttempts);

                else if (guess < r)
                    Console.WriteLine("Number too LOW, try again. You have {0} attempts remaining.", guessAttempts);

                else if (guess == r)
                {
                    Console.WriteLine("That's it! You WIN!");
                    gameOver = true;
                }

                if (guess != r && guessAttempts == 0)
                {
                    Console.WriteLine("But you're also out of guesses! YOU LOSE!");
                    gameOver = true;
                }

            } while (gameOver == false);

            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();

        }
    }
}
