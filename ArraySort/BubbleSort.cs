using System;

namespace ArraySort
{
    public class BubbleSort
    {
        public static int[] ArraySort(int[] array)
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

        public static int[] DanSort(int[] array)
        {
            int[] SortedArray = new int[array.Length];

            int somethingBig = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                //find position of smallest number
                int min = findMinPosition(array);

                //add the smallest value to the array
                SortedArray[i]  = array[min];

                //change the smallest number to somethingbig
                array[min] = somethingBig;
            }
            return SortedArray;
        }

        // returns the index of the smallest number
        private static int findMinPosition(int[] array)
        {
            int index = 0;
            int smallest = array[index];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
