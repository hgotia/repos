using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = GetWord();
            
            // checks letters by position
            Console.WriteLine($"Version1: {IsPalindrome(word)}"); 

            // reverse the string
            Console.WriteLine($"Reversed {word} is {reverseString(word)}");

            // checks the entire word to the reversed word
            Console.WriteLine($"Version2: {IsPalindrome2(word)}"); 

            
        }

        private static string GetWord()
        {
            Console.Write("What word do you want to check if palindrome? ");
            return Console.ReadLine();
        }

        private static bool IsPalindrome2(string word)
        {
            string reversed = reverseString(word);
            if (word == reversed) return true;
            else return false;
        }

        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-1-i]) return false;
            }
            return true;
        }

        static string reverseString(string word)
        {
            string reverse = "";
            for (int i = 0; i <= word.Length-1; i++)
            {
                reverse += word[word.Length - 1 - i];
            }
            return reverse;
        }

        
    }
}
