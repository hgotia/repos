using System;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "listen";
            string word2 = "silent";
            string word3 = "triangle";
            string word4 = "integral";

            bool result1 = IsAnagram(word1, word2); //true
            bool result2 = IsAnagram(word3, word4); //true
            bool result3 = IsAnagram(word1, word4); //false

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }

        private static bool IsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            int sum1 = 0;
            int sum2 = 0;

            foreach (var item in word1)
                sum1 += item;

            foreach (var item in word2)
                sum2 += item;

            if (sum1 == sum2)
                return true;
            else return false;
        }
    }
}
