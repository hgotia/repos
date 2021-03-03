using System;

namespace Arrays
{
    public class ConvertToCSV
    {
        // {4,7,4,2,7} --> "4,7,4,2,7"
        // without using this --> return string.Join(",", array);

        public static string ArrayToCSV(int[] array)
        {
            string result = "";

            for (int i = 0; i < array.Length - 1; i++)
            {
                result += array[i];

                if (i < array.Length - 1)
                {
                    result += ",";
                }
            }

            return result;
        }
    }
}
