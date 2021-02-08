using System;

namespace Sandbox1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = Console.ReadLine();

            Console.WriteLine(MultiplyYourself(inputNumber));
        }

        static int MultiplyYourself(int x)
        {
            if (x > 0)
            {
                return x* x;
            }
            else
            {
                return 0;
            }
        }
    }
}
