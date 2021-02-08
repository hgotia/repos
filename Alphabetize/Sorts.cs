using System;

namespace Alphabetize
{
    public class Sorts
    {
        // write a method to return a string in alphabetical order
        public static string StringSort(string inputString)
        {
            string outputstring = "";
            string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"; // in this order

            foreach (char a in alphabet)
                for (int i = 0; i < inputString.Length; i++)
                    if (a == inputString[i]) outputstring += a;
            return outputstring;
        }
    }
}
