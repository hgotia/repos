using System;

namespace Sandbox1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] ar = { 1, 2, 3, 4, 5,};

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < i; j++)
                {
                    Console.WriteLine($"{ar[i]} {ar[j]}");
                }
            }
        }
    }
}
