using System;

namespace IntReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -12345;
            int number2 = 998811;
            int number3 = -100;

            Console.WriteLine(ReverseInt(number));
            Console.WriteLine(ReverseInt(number2));
            Console.WriteLine(ReverseInt(number3));

            Console.WriteLine();

            Console.WriteLine(ReverseInt(number));
            Console.WriteLine(Switcheroo(number2));
            Console.WriteLine(Switcheroo(number3));
        }

        private static int Switcheroo(int number)
        {
            string output = "";

            if (number < 0)
                output = "-";

            number = Math.Abs(number);

            while(number > 0)
            {
                output += number % 10;
                number /= 10;
            }
            return int.Parse(output);
        }

        private static int ReverseInt(int number)
        {
            string output = "";
            
            if (number < 0)
                output = "-";

            string strNumber = Math.Abs(number).ToString();

            for (int i = strNumber.Length - 1; i >= 0; i--)
                output += strNumber[i];

            return int.Parse(output);
        }
    }
}
