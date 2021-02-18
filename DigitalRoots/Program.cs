using System;

namespace DigitalRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This script calculates the sum of your given number. Enter a number:");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DigitalRoot(UserInput));
        }

        public static int DigitalRoot(int n)
        {
            int number = sumOfRoots(n);
            return CalculateRoot(number);
        }

        private static int CalculateRoot(int number)
        {
            if (number.ToString().Length > 1)
            {
                number = sumOfRoots(number);
            }
            return number;
        }

        private static int sumOfRoots(int n)
        {
			string numbers = n.ToString();
			int sum = 0;

			foreach (int num in numbers)
			{
				sum += (int)char.GetNumericValue((char)num);
			}

			return sum;
		}
	}
}
