using System;
using System.Collections.Generic;

namespace LinearRegression
{
    class Program
    {


        static void Main(string[] args)
        {           
            int[,] set = new int[,]
            {
                { 165, 66 },
                { 185, 71 },
                { 190, 70 },
                { 210, 72 },
                { 180, 72 },
                { 150, 67 },
                { 180, 68 }
            };

            // calculate all the base variables to help calculate the slope and the y-intercept
            double sigmaX = calcSigma(set, "x", 1);
            double sigmaXSq = calcSigma(set, "x", 2);
            double sigmaY = calcSigma(set, "y", 1);
            double sigmaXY = calcSigma(set, "y", 3); // 3 is for multiplying X and Y
            int n = set.Length / 2;

            double alpha = ((sigmaY * sigmaXSq) - (sigmaX * sigmaXY)) / ((n * sigmaXSq) - Math.Pow(sigmaX, 2));
            double beta = ((n * sigmaXY) - (sigmaX * sigmaY)) / ((n * sigmaXSq) - Math.Pow(sigmaX, 2));

            Console.WriteLine("Given the data below:\n");
            Console.WriteLine(" X | Y ");
            Console.WriteLine("-------");

            for (int i = 0; i < set.Length/2; i++)
            {
                Console.WriteLine($"{set[i,0]} | {set[i,1]}");
            }

            Console.WriteLine($"\nThe value of alpha is: {alpha:0.00000}");
            Console.WriteLine($"The value of beta is: {beta:0.00000}");
            Console.WriteLine($"The formula is: y = {beta:0.00000} * X + {alpha:0.00000}");

            Console.Write("\nEnter an integer for X: ");
            int x = GetUserInput();

            double y = (beta * x) + alpha;

            Console.WriteLine($"y = {y:0.00000}");
        }

        private static int GetUserInput()
        {
            string x = Console.ReadLine();
            int number;
            bool success = int.TryParse(x, out number);

            if (!success)
            {
                Console.WriteLine("\nInvalid input. Try again!");
                Console.Write("Enter a valid integer: ");
                x = Console.ReadLine();
                success = int.TryParse(x, out number);
            }

            return number;
        }

        private static double calcSigma(int[,] set, string n, int number)
        {
            double sum = 0;
            int point = 0;

            if (n.ToLower() == "y")
                point = 1;

            if (number == 3)
            {
                for (int i = 0; i < set.Length / 2; i++)
                    sum += set[i, 0] * set[i, 1];
            }
            else
            {
                for (int i = 0; i < set.Length / 2; i++)
                    sum += Math.Pow((set[i, point]), number);
            }

            return sum;
        }
    }
}
