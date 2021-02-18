using System;

namespace EX_6A___CS__Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("Sum: " + GetSum(arrayA));
            Console.WriteLine("Mean: " + ArrayMean(arrayA));
            Console.WriteLine("Length: " + arrayA.Length);
            Console.WriteLine();

            int[] array = ReverseArray(arrayA);
            Console.WriteLine("Reversed Array: ");
            printArray(array);
            Console.WriteLine("\n");

            int[] array2 = RotateArray("right", 2, arrayA);
            Console.WriteLine("Rotated Array: ");
            printArray(array2);
            Console.WriteLine("\n");

            int[] array3 = SortArray(arrayC);
            Console.WriteLine("Sorted Array: ");
            printArray(array3);
            Console.WriteLine();
        }

        private static int[] SortArray(int[] array)
        {
            int[] copy = array;
            int temp = 0;

            for (int i = 0; i < copy.Length - 1; i++)
            {
                for (int j = i+1; j < copy.Length - 1; j++)
                {
                    if (copy[i] > copy[j])
                    {
                        temp = copy[j];
                        copy[j] = copy[i];
                        copy[i] = temp;
                    }
                }
            }
            return copy;
        }

        private static int[] RotateArray(string direction, int numberOfPlaces, int[] array)
        {
            int[] rotated = new int[array.Length];
            int move = array.Length % numberOfPlaces;

            if (direction == "left")
            {
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    rotated[i] = array[move];
                    move++;

                    if (move > array.Length - 1)
                    {
                        move = 0;
                    }
                }
            }

            if (direction == "right")
            {
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    move = i + numberOfPlaces;

                    if (move >= array.Length)
                    {
                        move -= array.Length;
                    }

                    rotated[move] = array[i];
                }
            }
            return rotated;
        }

        private static void printArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        private static int[] ReverseArray(int[] array)
        {
            int[] reverse = new int[array.Length];
            int count = 0;

            for (int i = array.Length - 1; i > 0; i--)
                reverse[count++] = array[i];

            return reverse;
        }

        private static int ArrayMean(int[] array)
        {
            int sum = GetSum(array);
            return sum / array.Length;
        }

        private static int GetSum(int[] array)
        {
            int sum = 0;

            foreach (var item in array)
                sum += item;
            return sum;
        }
    }
}
