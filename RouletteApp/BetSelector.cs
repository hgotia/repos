using System;

namespace RouletteApp
{
    public class BetSelector
    {
        public int[] Bin;

        public int[] BinBlack;
        public int[] BinRed;
        public int[] BinGreen;

        public int[] BinFirstCol;
        public int[] BinSecondCol;
        public int[] BinThirdCol;

        public int[] BinStreet1;
        public int[] BinStreet2;
        public int[] BinStreet3;
        public int[] BinStreet4;
        public int[] BinStreet5;
        public int[] BinStreet6;
        public int[] BinStreet7;
        public int[] BinStreet8;
        public int[] BinStreet9;
        public int[] BinStreet10;
        public int[] BinStreet11;
        public int[] BinStreet12;

        public int[] BinDouble1;
        public int[] BinDouble2;
        public int[] BinDouble3;
        public int[] BinDouble4;
        public int[] BinDouble5;
        public int[] BinDouble6;
        public int[] BinDouble7;
        public int[] BinDouble8;
        public int[] BinDouble9;
        public int[] BinDouble10;


        public BetSelector()
        {
            // Create a bin for all the numbers // 39 is going to be the same as '00'
            Bin = new int[39];
            for (int i = 1; i < Bin.Length; i++)
            {
                Bin[i] = i;
            }

            // Create separate bins for  reds and blacks // 39 is going to be the same as '00'
            BinBlack = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 29, 29, 31, 33, 35 };
            BinRed = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            BinGreen = new int[] { 0, 39 };

            BinFirstCol = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            BinSecondCol = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            BinThirdCol = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            BinStreet1 = new int[] { 1, 2, 3};
            BinStreet2 = new int[] { 4, 5, 6};
            BinStreet3 = new int[] { 7, 8, 9 };
            BinStreet4 = new int[]  {10, 11, 12};
            BinStreet5 = new int[]  {13, 14, 15};
            BinStreet6 = new int[]  {16, 17, 18};
            BinStreet7 = new int[]  {19, 20, 21};
            BinStreet8 = new int[]  {22, 23, 24};
            BinStreet9 = new int[]  {25, 26, 27};
            BinStreet10 = new int[] {28, 29, 30};
            BinStreet11 = new int[] {31, 32, 33};
            BinStreet12 = new int[] { 34, 35, 36 };

            BinDouble1  = new int[] { 1, 2, 3, 4, 5, 6 };
            BinDouble2  = new int[] { 4, 5, 6, 7, 8, 9 };
            BinDouble3  = new int[] { 7, 8, 9, 10, 11, 12 };
            BinDouble4  = new int[] {10, 11, 12, 13, 14, 15 };
            BinDouble5  = new int[] {13, 14, 15, 16, 17, 18 };
            BinDouble6  = new int[] {16, 17, 18, 19, 20, 21 };
            BinDouble7  = new int[] {19, 20, 21, 22, 23, 24 };
            BinDouble8  = new int[] {22, 23, 24, 25, 26, 27 };
            BinDouble9  = new int[] {25, 26, 27, 31, 32, 33 };
            BinDouble10 = new int[] { 31, 32, 33, 34, 35, 36 };
        }
        // Winning number selector
        public static int RandomBinSelector()
        {
            Random rand = new Random();
            int winningNumber = rand.Next(0, 40);

            if (winningNumber == 39)
            {
                winningNumber = 0;
            }

            // Announce Winning Number
            return winningNumber;
        }
    }
}