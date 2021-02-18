using System;

namespace CSVtransform
{
    public class ConvertToCSV
    {
        // {4,7,4,2,7} --> "4,7,4,2,7"

        public static string ArrayToCSV(int[] array)
        {
            // without using this --> return string.Join(",", array);

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
