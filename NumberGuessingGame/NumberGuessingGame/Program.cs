using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int winningNum = random.Next(1, 10);
            int guess;
            int numberOfTries = 3;
            bool gameOver = false;

            Console.WriteLine(winningNum);
            Console.WriteLine("I'm thinking of a number between 1 and 9! What is it?");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfTries--;

                if (numberOfTries == 0 && guess != winningNum)
                {
                    Console.WriteLine("GAME OVER!!! It was {0}!", winningNum);
                    gameOver = true;
                }

                else if (guess == winningNum)
                {
                    Console.WriteLine("That's it! Congratulations");
                    gameOver = true;
                }

                else if (guess > winningNum)
                    Console.WriteLine("Too high. Guess lower.");

                else if (guess < winningNum)
                    Console.WriteLine("Too low. Guess higher.");
            }
        }
    }
}
