// used https://github.com/Makairo/PasswordCracker for reference

using System;
using System.Diagnostics;
using System.Threading;

namespace PasswordCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPassword(string.Empty);
        }

        static char firstchar = ' ';
        static char midchar = 'O';
        static char lastchar = '~';
        static bool done = false;

        static string password = askPassword();
        static int passwordLength = password.Length - 1;
        static int iteration = 1;

        public static void FindPassword(string keys)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start(); 

            Thread thread1 = new(() => BruteForce(keys, firstchar, midchar));
            Thread thread2 = new(() => BruteForce(keys, midchar, lastchar));
            Thread thread3 = new(() => BruteForce(keys, lastchar, midchar));
            Thread thread4 = new(() => BruteForce(keys, midchar, firstchar));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string timeElapsed = $"\nTime taken(h:m:s:ms) - {ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds}";

            Console.WriteLine($"Number of guesses: {iteration:n0}");
            Console.WriteLine(timeElapsed);
        }

        private static string askPassword()
        {
            Console.Write("Enter a password to find: ");
            string password = Console.ReadLine();
            Console.WriteLine("\nMatching your password...\n");
            return password;
        }

        public static void BruteForce(string keys, char start, char end)
        {
            if (keys.Length > passwordLength || done == true) return;

            for (char c = start; c <= end; c++)
            {
                string something = keys + c;

                if (something == password) // Check if the password is a match
                {
                    done = true;
                    return;
                }

                iteration++;
                //Console.WriteLine(keys + c);
                BruteForce(keys + c, start, end);
            }
        }
    }
}
