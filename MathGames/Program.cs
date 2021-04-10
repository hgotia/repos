using System;

namespace MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Games\n");
            int score = 0;
            (int probType, int numProb) = Initialize();

            if (probType == 1)
                score = Add(numProb);
            else if (probType == 2)
                score = Subtract(numProb);
            else if (probType == 3)
                score = Multiply(numProb);
            else if (probType == 4)
                score = Divide(numProb);

            string report = Report(score, numProb);
            Console.WriteLine(report);
        }

        public static string Report(int score, int numProb)
        {
            decimal percentScore = ((decimal)score / numProb)*100;
            return $"\nYou got {score} out of {numProb} correct and your grade is {percentScore}%";
        }

        public static int Divide(int numProb)
        {
            int score = 0;

            for (int i = 1; i < numProb + 1; i++)
            {
                int left, right;
                GenerateTwoRandoms(out left, out right);

                decimal calc = Math.Round((decimal)left / right, 2);
                string result = calc.ToString();

                Console.Write($"{i}. {left} / {right} = ");
                decimal userAnwser;
                string answer = Console.ReadLine();
                bool success = decimal.TryParse(answer, out userAnwser);

                while (success == false || userAnwser < 0)
                {
                    Console.Write("Enter a valid number. ");
                    answer = Console.ReadLine();
                    success = decimal.TryParse(answer, out userAnwser);
                }

                if (userAnwser.Equals(result) || userAnwser == calc)
                {
                    Console.WriteLine("Correct.");
                    score++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {result}.");
            }
            return score;
        }

        public static int Multiply(int numProb)
        {
            int score = 0;

            for (int i = 1; i < numProb + 1; i++)
            {
                int left, right;
                GenerateTwoRandoms(out left, out right);

                int result = left * right;
                Console.Write($"{i}. {left} x {right} = ");
                int userAnser = ValidateIntInput(0, 1000);

                if (userAnser == result)
                {
                    Console.WriteLine("Correct.");
                    score++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {result}.");
            }
            return score;
        }

        public static int Subtract(int numProb)
        {
            int score = 0;

            for (int i = 1; i < numProb + 1; i++)
            {
                int left, right;
                GenerateTwoRandoms(out left, out right);

                int result = left - right;
                Console.Write($"{i}. {left} - {right} = ");
                int userAnser = ValidateIntInput(0, 1000);

                if (userAnser == result)
                {
                    Console.WriteLine("Correct.");
                    score++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {result}.");
            }
            return score;
        }

        public static int Add(int numProb)
        {
            int score = 0;

            for (int i = 1; i < numProb+1; i++)
            {
                int left, right;
                GenerateTwoRandoms(out left, out right);

                int result = left + right;
                Console.Write($"{i}. {left} + {right} = ");
                int userAnser = ValidateIntInput(0, 1000);

                if (userAnser == result)
                {
                    Console.WriteLine("Correct.");
                    score++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {result}.");
            }
            return score;
        }

        public static void GenerateTwoRandoms(out int left, out int right)
        {
            left = rand.Next(1, 11);
            right = rand.Next(1, 11);
            if (right > left)
            {
                left = right + left;
                right = left - right;
                left = left - right;
            }
        }

        public static (int probType, int numProb) Initialize()
        {
            Console.WriteLine("  To add, enter 1");
            Console.WriteLine("  To subtract, enter 2");
            Console.WriteLine("  To multiply, enter 3");
            Console.WriteLine("  To divide, enter 4");
            
            int problemType = ProblemType();
            int numberProblems = NumberProblems();

            return (problemType, numberProblems);
        }

        public static int ProblemType()
        {
            Console.Write("\nChoose your problem type: ");
            return ValidateIntInput(1, 4);
        }

        public static int NumberProblems()
        {
            Console.Write("\nEnter the number of problems between 1 and 12: ");
            return ValidateIntInput(1, 12);
        }

        private static int ValidateIntInput(int min, int max)
        {
            int result;
            string userinput = Console.ReadLine();
            bool success = int.TryParse(userinput, out result);

            while (success == false || result > max || result < min)
            {
                Console.Write("Enter a valid input. Try again. ");
                userinput = Console.ReadLine();
                success = int.TryParse(userinput, out result);
            }
            return result;
        }

        static Random rand = new Random();
    }
}
