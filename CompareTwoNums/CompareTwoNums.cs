using System;

namespace CompareTwoNums
{
    class CompareTwoNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompareNumbers());
        }

        private static string CompareNumbers()
        {
            Console.WriteLine("Enter the first number: ");
            double numOne = getDoubleValue();

            Console.WriteLine("Enter the second number: ");
            double numTwo = getDoubleValue();

            if (numOne > numTwo)
            {
                return $"\n{numOne} is greater than {numTwo}";
            }
            else return $"\n{numTwo} is greater than {numOne}";

        }

        private static double getDoubleValue()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter a valid integer!");
            }
            return num;
        }
    }
}
