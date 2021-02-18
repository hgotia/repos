using System;

namespace MonteCarloAttempt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many iterations? ");
            int userInput = int.Parse(Console.ReadLine());

            Random rand = new Random();
            double[] array = new double[userInput];

            for (int i = 0; i < userInput - 1 ; i++)
            {
                array[i] = new Coordinates(rand).CalcHypotenuse();
            }

            int counter = CountInCircle(array);

            double estimatedPi = (double)counter / (double)userInput * 4;

            Console.WriteLine($"Estimated PI with {userInput} iterations: {estimatedPi}");
            double difference = Math.Abs(Math.PI - estimatedPi);
            Console.WriteLine($"Difference from Math.Pi: {difference} or {(difference/Math.PI):P4}");
        }

        private static int CountInCircle(double[] array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item <= 1)
                {
                    counter++;
                }
            }

            return counter;
        }

        struct Coordinates
        {
            public double x;
            public double y;

            public Coordinates(double a, double b)
            {
                x = a;
                y = b;
            }

            public Coordinates(Random random)
            {
                x = random.NextDouble();
                y = random.NextDouble();
            }

            public double CalcHypotenuse()
            {
                return (double)Math.Sqrt(x * x + y * y);
            }
        }
    }
}


/*	1.Why do we multiply the value from step 5 above by 4?
 *	    - We multply by 4 because we're only calculating for 1 quadrant. Multiplying it by 4 ensures that we cover the entire circle.
 *	
 *	2.What do you observe in the output when running your program with parameters of increasing size?
 *	    - As the size of the parameters increase, so does the accuracy.
 *	    
 *	3.If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
 *	    - No. Unless the parameter being changed is the random parameter (to non-random), the value will not change.
 *	    
 *	4.Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π?
 *	    - 100000000 runs for over a second. The higher the parameter, the more the estimated values go into calculating its average 
 *	    which results in a more accurate estimation for Pi.
 *	
 *	5.Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
 *	    - The monte carlo can also be used to calculate probabilities. For example, if you want to calculate the odds of getting heads 6 times in a row,
 *	    monte carlo can do that.
 */