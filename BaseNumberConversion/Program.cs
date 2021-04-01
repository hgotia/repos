using System;

namespace BaseNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer to convert: ");
            string n1 = Console.ReadLine();
            int number = ValidateIntInput(n1);

            Console.Write("Please choose between the following to convert from [ 2 | 8 | 10 ]: ");
            string n2 = Console.ReadLine();
            int from = ValidateIntInput(n2);

            Console.WriteLine($"Number: {number}, Base: {from}");

            string result = "";

            if (from == 10)
            {
                result = baseConvert(number, 2);
                Console.WriteLine($"Binary conversion is {result}");
                result = baseConvert(number, 8);
                Console.WriteLine($"Octal conversion is {result}");
            }
            else if (from == 8)
            {
                result = baseConvert(number, 2);
                Console.WriteLine($"Binary conversion is {result}");
                result = baseConvert(number, 10);
                Console.WriteLine($"Decimal conversion is {result}");
            }
            else if (from == 2)
            {
                result = baseConvert(number, 8);
                Console.WriteLine($"Octal conversion is {result}");
                result = baseConvert(number, 10);
                Console.WriteLine($"Decimal conversion is {result}");
            }
            else
            {
                Console.WriteLine("Error in base to convert from.");
            }


            //string convert = baseConvert(number, from);
        }

        private static string baseConvert(int number, int from)
        {
            string output = "";

            while (number > 0)
            {
                output += number % from;
                number /= from;
            }

            string binary = reverseString(output);
            return binary;
        }

        public static string reverseString(string output)
        {
            var arr = output.ToCharArray();
            string reversed = "";

            for (int i = arr.Length-1; i >= 0; i--)
            {
                reversed += arr[i];
            }
            return reversed;
        }

        private static int ValidateIntInput(string input)
        {
            int inputValue;
            bool success = int.TryParse(input, out inputValue);

            while (!success || inputValue == 0)
            {
                Console.WriteLine("Invalid Input. Enter an integer. Try again!");
                Console.Write($"Enter a valid number :");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue);
            }

            return inputValue;
        }
    }
}
