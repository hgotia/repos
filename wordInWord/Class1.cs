using System;

namespace wordInWord
{
    public class SearchWord
    {
        public static bool WordSearch(string input1, string input2)
        {
            bool isFound = false;
            string sw = "";
            string lw = "";

            //check if inputs are either null or empty
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
                return false;

            // assign shorter input to short word(sw) and long word(lw) to the longer word/sentence
            if (input1.Length < input2.Length)
            {
                //might as well normalize the inputs to lowercase
                sw = input1.ToLower();
                lw = input2.ToLower();
            }

            // compare the sw to a substring of the lw with sw.length as the range
            for (int i = 0; i < lw.Length-(sw.Length-1); i++)
            {
                if (sw == lw.Substring(i, sw.Length))
                {
                    isFound = true;
                }
            }

            return isFound;
        }
    }
}
