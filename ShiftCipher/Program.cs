using System;

namespace CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string insertStringHere = "Happy";
            int shiftNumber = 999;

            string encrypted = CeasarCipher.CharShift(insertStringHere, shiftNumber);
            Console.WriteLine($"Shifting forward: {encrypted}");

            string decrypted = CeasarCipher.ReverseShift(encrypted, shiftNumber);
            Console.WriteLine($"Shifting back: {decrypted}");
        }

    }

    public static class CeasarCipher
    {
        public static string CharShift(string insertStringHere, int number)
        {
            string upInput = insertStringHere.ToUpper();
            string result = "";
            int shiftNumber = number % 26;

            foreach (char item in upInput)
            {
                int newItem = (item+shiftNumber);

                if (newItem > 90)
                {
                    newItem -= 26;    
                }
                result += (char)newItem;
            }
            return result;
        }

        public static string ReverseShift(string insertStringHere, int number)
        {
            string upInput = insertStringHere.ToUpper();
            string result = "";
            int shiftNumber = number % 26;

            foreach (char item in upInput)
            {
                int newItem = (item - shiftNumber);

                if (newItem < 65)
                {
                    newItem += 26;
                }
                result += (char)newItem;
            }
            return result;
        }
    }
}
