using System;

namespace TuitionCalculator
{
    class FeetToInches  
    {
        static void Main(string[] args)
        {
            double feet = getFeet();

            double inches = ToInches(feet);
            Console.WriteLine($"\n{feet} feet is {inches} inches.");
        }

        private static double getFeet()
        {
            Console.WriteLine("How many feet would you like to convert to inches?");
            return getDoubleValue();
        }

        private static double ToInches(double feet)
        {
            double inches = feet * 12;
            return inches;
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
