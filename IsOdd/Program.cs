using System;

namespace IsOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd(5));
        }

        static bool IsOdd(int intValue)
        {
            return intValue % 2 != 0;
        }
    }
}
