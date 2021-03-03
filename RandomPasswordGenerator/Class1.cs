using System;

namespace RandomPasswordGenerator
{
    public static class PasswordGenerator
    {
        //Level One = characters only
        //Level Two = characters and numbers
        //Level Three = characters, numbers, and symbols
        public enum complexityLevel { one, two, three }

        public static string RandomPassword(int numberOfCharacters, complexityLevel level)
        {
            Random rand = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*_";
            string characters = letters + numbers + symbols;

            char[] charPassword = new char[numberOfCharacters];

            for (int i = 0; i < charPassword.Length; i++)
            {
                if (level == complexityLevel.one)
                {
                    charPassword[i] = characters[rand.Next(letters.Length)];
                }
                else if (level == complexityLevel.two)
                {
                    charPassword[i] = characters[rand.Next(letters.Length + numbers.Length)];
                }
                else if (level == complexityLevel.three)
                {
                    charPassword[i] = characters[rand.Next(characters.Length - 1)];
                }
            }
            return string.Join("", charPassword);
        }
    }
}