/* 1. Why do we multiply the value from step 5 above by 4?
 *  - Becasue we only used the top right quadrant (pos x, pos y) with our calculations. To get the area of the full circle covered by the estimates, we need to multiply it by 4.
 * 2. What do you observe in the output when running your program with parameters of increasing size?
 *  - The bigger the increment size, the longer the program runs as it is asked to do more computes.
 * 3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
 *  - No. Specifically because pseudo random numbers are used which are automatically generated with every execution of the random object.
 * 4. Find a parameter that requires multiple seconds of run time. What is that parameter?
 *  - 100000000
 * 5. How accurate is th estimate value of pi?
 *  - The more estimates are run, the closer it gets to the real value of Pi.
 * 6. Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
 *  - The Monte-Carlo method can also be used to calculate for chance and risk. For example, what is the probablity of flipping a coin 
 *  and rolling a 1 with a dice? Given an almost infinite amount of tries, the probability can be accurately estimated.
 */

using System;

namespace MonteCarlo_DanVersion
{
    class Program
    {
        static (double, double) GetNextPoint(Random rand)
        {
            double x = rand.NextDouble();
            double y = rand.NextDouble();
            return (x, y);
        }

        static double DistanceFromOrigin(double x, double y) => Math.Sqrt(x * x + y * y);

        static void Main(string[] args)
        {
            Random rand = new Random();

            //int iterations = GetNumberOfPoints();
            int insideCircleCount = 0;
            int iterations = 0;
            
            if (args.Length > 0)
            {
                iterations = int.Parse(args[0]);
            }
             
            for (int i = 1; i <= iterations; i++)
            {
                Tuple<double, double> point = GetNextPoint(rand).ToTuple<double, double>();
                double length = DistanceFromOrigin(point.Item1, point.Item2);
                if (length <= 1.0)
                {
                    insideCircleCount++;
                }
            }

            if (iterations == 0)
            {
                Console.WriteLine("Nothing to run!");
            }
            else
            {
                double estimate = (double)insideCircleCount / (double)iterations * 4;
                Console.WriteLine($"Value = {estimate:0.00#}");

                double variance = Math.Abs(Math.PI - estimate);
                Console.WriteLine($"Delta = {variance}");
                Console.WriteLine($"{insideCircleCount} out of {iterations} went inside the circle");
            }
        }

        private static int GetNumberOfPoints()
        {
            Console.WriteLine("How many times do you want to run the estimation? ");
            return int.Parse(Console.ReadLine());
        }
    }
}
