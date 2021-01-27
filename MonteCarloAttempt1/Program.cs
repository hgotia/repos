using System;

namespace MonteCarloAttempt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many iterations? ");
            int iterations = int.Parse(Console.ReadLine());

            double hypoTotal = WentInCircle(iterations);

            double avequad = (hypoTotal / (double)iterations) * 4.0;
            double diff = Math.Abs(Math.PI - avequad);

            Console.WriteLine($"{avequad} - {Math.PI} = {diff}\nOff by {(diff / Math.PI) * 100:0.00#}%");
        }

        static Random rand = new Random();

        private static double WentInCircle(int iterations)
        {
            
            double hypoTotal = 0;

            for (int i = 0; i < iterations; i++)
            {
                double hypotenuse = Pythagorean(rand.NextDouble(), rand.NextDouble());
                if (hypotenuse <= 1) hypoTotal += 1;
            }
            return hypoTotal;
        }

        private static double Pythagorean(double x, double y)
        {
            double hypotenuse = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
            return hypotenuse;
        }
    }
}
