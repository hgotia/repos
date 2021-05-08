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
            //RemoveVowels();
            //FancySquares();
            //ReverseStringWords();
            //Console.WriteLine(CheckPalindrome("raceacar"));

            //Console.WriteLine(CheckPrime(5));

            //foreach (var item in FindAllPrimes(100))
            //{
            //    Console.WriteLine(item);
            //}

            ReturnSum();
        }

        private static void ReturnSum()
        {
            // Given an array, return the indeces for the ones that sum to a given int n
            // for example: { 1, 5, 7, 2 } and n = 8. return 0 and 2
        }

        private static List<int> FindAllPrimes(int Range)
        {
            List<int> Primes = new List<int>();

            for (int i = 2; i <= Range; i++)
            {
                if (CheckPrime(i) == true)
                {
                    Primes.Add(i);
                }
            }

            return Primes;
        }

        private static bool CheckPrime(int number)
        {
            for (int i = number - 1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckPalindrome(string word)
        {
            // return a boolean true if input is a palindrome, else false
            // loop through each character*, starting from the first character(n), comparing it to the 

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[(word.Length - 1) - i])
                    return false;
            }
            return true;
        }

        private static void ReverseStringWords()
        {
            //Reverse words in a string
            // the sky is blue => blue is sky the

            string sentence = "the sky is blue";
            string[] splitSentence = sentence.Split(' ');
            string newSentence = "";

            for (int i = splitSentence.Length -1; i >= 0; i--)
            {
                newSentence += splitSentence[i];

                if (splitSentence.Length != 0)
                {
                    newSentence += " ";
                }
            }

            Console.WriteLine(newSentence);
        }

        private static int FancySquares()
        {
            int number = 955;
            string output = "";

            string strNumbers = number.ToString();
            foreach (char item in strNumbers)
            {
                int num = int.Parse(item.ToString());
                output += (num * num);
            }
            Console.WriteLine(output);
            return int.Parse(output);
        }

        private static void RemoveVowels()
        {
            string troll = "traioulloooll";
            string vowels = "AEIOUaeiou";

            foreach (var item in vowels)
                troll = troll.Replace(item.ToString(), "");

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
