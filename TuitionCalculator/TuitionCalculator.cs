using System;

namespace TuitionCalculator
{
    class TuitionCalculator 
    {
        static void Main(string[] args)
        {
            double tuition = GetTuition();
            double years = GetYears();
            double incRate = GetRate();
            
            double TotalTuition = CalcTuition(tuition, years, incRate);
            Console.WriteLine($"After {years}, your total tuition will be {TotalTuition:0.00}");
        }

        private static double CalcTuition(double tuition, double years, double incRate)
        {
            double interest;
            interest = tuition * Math.Pow((1 + incRate/100), years) - tuition;

            double totalTuition;
            totalTuition = tuition * years + interest;
            return totalTuition;
        }

        private static double GetRate()
        {
            Console.WriteLine("What's the percent interest rate?");
            double rate = getDoubleValue();
            return rate;
        }

        private static double GetYears()
        {
            Console.WriteLine("For how many years?");
            double years = getDoubleValue();
            return years;
        }

        private static double GetTuition()
        {
            Console.WriteLine("How much is your tuition?");
            double tuition = getDoubleValue();
            return tuition;
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