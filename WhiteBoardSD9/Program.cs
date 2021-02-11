using System;
using System.Collections.Generic;
using Alphabetize;
using CamelCase;

namespace WhiteBoardSD9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 12, 19, 22 };

            Console.WriteLine(doSomething(numbers));
        }

        public static int doSomething(int[] numbers)
        {
            var num1 = int.MaxValue;
            var num2 = int.MaxValue;
 
            foreach (var item in numbers)
            {
                if (item < num1)
                {
                    num2 = num1;
                    num1 = item;
                }
                else if (item < num2)
                {
                    num2 = item;
                }
            }

            return num1 + num2;
        }
    }
}
