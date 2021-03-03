using System;
using Alphabetize;
using static RandomPasswordGenerator.PasswordGenerator;

namespace AAA_Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = RandomPassword(15, complexityLevel.three);
            Console.WriteLine(password);
        }
    }
}