using System;
using System.Collections.Generic;

namespace UniqueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 1, 2, 3, 4, 3, 2, 1 };
            int n = items.Length;
            List<int> uniqueNumbers = new List<int>();
            bool isUnique = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (items[i] == items[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueNumbers.Add(items[i]);
                }

            }

            foreach (var item in uniqueNumbers)
            {
                Console.WriteLine(item);
            }



            //int[] items = { 1, 2, 3, 4, 3, 2, 1 };
            //int n = items.Length;
            //List<int> uniqueItems = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    bool isDuplicate = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (items[i] == items[j])
            //        {
            //            isDuplicate = true;
            //            break;
            //        }
            //    }

            //    if (!isDuplicate)
            //    {
            //        uniqueItems.Add(items[i]);
            //    }
            //}

            //foreach (var item in uniqueItems)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
