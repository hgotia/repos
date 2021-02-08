using System;

namespace CamelCase
{
    public class StringMethods
    {
        // turns a string of words into camelCase
        public static string camelCase(string inputString)
        {
            string normalWord = normalizer(inputString);

            string[] splitWord = normalWord.Split(' '); // splits input into array
            string outputstring = "";

            // turn first letter into lower case
            string firstLetterFirstWord = splitWord[0][0].ToString().ToLower();

            // capitalize all the first letters of words after the first word
            for (int i = 1; i < splitWord.Length; i++)
            {
                outputstring += splitWord[i][0].ToString().ToUpper(); 
                outputstring += splitWord[i].Substring(1, splitWord[i].Length - 1); 
            }
            // first letter of first word + the rest of the first word + all the other words with capitalized first letters
            return firstLetterFirstWord + splitWord[0].Substring(1,splitWord[0].Length-1) + outputstring; 
        }

        // turns a string of words into PascalCase
        public static string PascalCase(string inputString)
        {
            string normalWord = normalizer(inputString);

            string outputstring = "";
            string[] splitWord = inputString.Split(' '); // word, word, word

            for (int i = 0; i < splitWord.Length; i++)
            {
                outputstring += splitWord[i][0].ToString().ToUpper();
                outputstring += splitWord[i].Substring(1, splitWord[i].Length - 1);
            }
            return  outputstring;
        }

        // Make sure each letter is an actual letter
        public static string checkInput(string inputString)
        {
            foreach (var c in inputString)
            {
                try
                {
                    if (c == ' ' || c >= 'A' && c <= 'z')
                    {
                    }
                    else
                    {
                        throw new Exception("Only letters allowed!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }               
            }
            return inputString;
        }

        // Removes excess spaces in between words
        public static string normalizer(string splitWord)
        {
            string[] split = splitWord.Split(' ');
            string output = "";

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] != "")
                {
                    output += " " + split[i];
                }
            }
            return checkInput(output.Trim());
        }
    }
}
