using System;

namespace ConsoleApp1
{
    class Program
    {
        static int BalanceShit(string phrase)
        {
            char[] letter = phrase.ToCharArray();

            int countR = 0;
            int countL = 0;
            int same = 0;

            for (int i = 0; i < letter.Length; i++)
            {
                char c = letter[i];
                if (c == 'R')
                {
                    countR++;
                }
                else if (c == 'L')
                {
                    countL++;
                }

                if (countR == countL)
                {
                    same++;
                }
            }

            return same;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BalanceShit("RLRRRLLRLL"));
        }
    }
}
