using System;
using System.Collections.Generic;

namespace UniqueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 5, 3, 4, 2, 1 };
            //ArraySort(array);
            //FindUnique();
            RemoveVowels();
        }

        private static void RemoveVowels()
        {
            string troll = "traioulloooll";



            Console.WriteLine(troll);
        }

        private static int[] ArraySort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int temp = 0;

                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            return array;
        }

        private static void FindUnique()
        {
            int[] items = { 1, 2, 3, 4, 3, 2, 1 };

            List<int> uniqueNumbers = new List<int>();
            bool isUnique = true;

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < i; j++)
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
        }

        private static void UniqueFinder()
        {
            int[] testarray = { 1, 2, 3, 2, 1 };
            List<int> uniqueValues = new List<int>();
            bool isUnique = true;

            for (int i = 0; i < testarray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (testarray[i] == testarray[j])
                    {
                        isUnique = false;
                        break;
                    }    

                    if (isUnique) uniqueValues.Add(testarray[i]);

                }
            }
        }
    }
}
