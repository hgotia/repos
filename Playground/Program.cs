using System;
using System.Linq;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = "The Sound of Music";

            Console.WriteLine($"need {movie.Replace(" ", "").Length} letters!");

            for (char letter = 'A'; letter <= 'z'; letter++)
            {
                if (movie.Contains(letter))
                {
                    Console.WriteLine($"I need {CountLetter(letter, movie)} of letter {letter}");
                }
            }
        }

        static int CountLetter(char letter, string MovieTitle)
        {
            int count = 0;

            for (int i = 0; i < MovieTitle.Length; i++)
            {
                if (MovieTitle[i] == letter) count++;
            }

            return count;
        }
    }
}
