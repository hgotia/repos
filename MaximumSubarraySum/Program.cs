using System;
using System.Collections.Generic;

namespace MaximumSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int largestSum = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] > 0)
                {
                    list.Add(arr[i]);
                }
            }

            int[] arr2 = list.ToArray();
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                int sum = arr2[i] + arr2[i+1];
                if (largestSum < sum)
                {
                    largestSum = sum;
                }
            }

            Console.WriteLine(largestSum);

            //for (int i = 0; i < arr.Length; i ++)
            //{
            //    for (int j = 1; j < arr.Length; j ++)
            //    {
            //        if (i != j)
            //        {
            //            int sum = arr[i] + arr[j];

            //            Console.WriteLine($"{i} {j} {sum}");

            //            if (largestSum < sum)
            //            {
            //                largestSum = sum;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(largestSum);


        }    
    }
}
