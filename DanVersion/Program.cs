using System;

namespace DanVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTestScores;
            int sumOfNumbers;
            double average;
            char letterGrade;

            numOfTestScores = GetNumberOfScores();
            sumOfNumbers = CollectSumof10Nums(numOfTestScores);
            average = CalculateAverage(sumOfNumbers, numOfTestScores);
            letterGrade = AssignLetterGrade(average);

            Console.WriteLine($"\nYour total sum is {sumOfNumbers}");
            Console.WriteLine($"The average of your {numOfTestScores} scores is {average:0.0#}");            
            Console.WriteLine($"Your Lettergrade is: {letterGrade}");
        }

        static int GetNumberOfScores()
        {
            Console.Write("How many scores do you have? ");
            return int.Parse(Console.ReadLine());
        }

        private static int GetNextScore()
        {
            Console.Write("Next Score: ");
            return int.Parse(Console.ReadLine());
        }

        static int CollectSumof10Nums(int numOfScores = 10)
        {
            int sum = 0;

            for (int i = 0; i < numOfScores; i++)
            {
                sum += GetNextScore();
                Console.WriteLine($"Running total is {sum}\n");
            }
            return sum;
        }

        static double CalculateAverage(int sum, int scoreNumbers) => (double)sum / scoreNumbers;

        static char AssignLetterGrade(double average)
        {
            if (average >= 90) return 'A';
            if (average >= 80) return 'B';
            if (average >= 70) return 'C';
            if (average >= 60) return 'D';
            else return 'F';
        }

    }
}
