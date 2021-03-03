using System;
using System.Linq;
using System.Threading;

namespace RouletteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implemenet 0, and 00(39)

            int selectBetType;
            int bet;
            bool gameOver = false;

            // Introduce(-ish) the rules of the game
            int Capital = Introduction();

            do
            {
                int winningNumber = BetSelector.RandomBinSelector();

                // Provide information on bet types
                GameModes();

                // Get the users bet selection
                Console.Write("Select a bet type (Enter a non-integer to quit): ");
                try
                {
                    selectBetType = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nThat's not a valid input! Get outta here!");
                    break;
                }

                // Ask user how much they want to bet
                Console.Write("\nHow much would you like to bet? ");
                bet = int.Parse(Console.ReadLine());

                // don't let them bet more than they have!
                if (bet > Capital)
                {
                    Console.WriteLine("\nYou cannot bet more than your capital! Get outta here!");
                    Console.ReadLine();
                    break;
                }

                // Match user bet selection to random number/color/etc.
                Console.WriteLine($"\n{Playgame(selectBetType, ref Capital, bet, winningNumber)}");

                Console.WriteLine($"\nThe ball fell on bin {winningNumber}"); // TODO: add bin color later
                Console.WriteLine($"\nYou now have ${Capital} left in your account");

                if (Capital <= 0)
                {
                    Console.WriteLine("\nYou have run out of funds. Game Over!");
                    Console.ReadLine();
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("\nHit Enter to continue...");
                    Console.ReadLine();
                    continue;
                }
            } while (gameOver == false);
        }

        private static string Playgame(int selectBetType,ref int capital, int bet, int winningNumber)
        {
            BetSelector newBet = new BetSelector();
            string winLose = "";

            if (selectBetType == 1)
            {
                // Ask user for a number to bet on
                Console.Write("\nWhat number do you want to bet on? ");
                uint userBet = uint.Parse(Console.ReadLine());

                if (userBet == winningNumber)
                {
                    capital += bet*5; // 5x the win POGGERS
                    winLose = "You Win!";
                }
                else if (userBet != winningNumber)
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 2)
            {
                // Ask user if Odd or even 
                Console.Write("\nOdd or even? ");
                string userBet = Console.ReadLine().ToUpper();

                if (userBet == "ODD" && winningNumber % 2 != 0)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "EVEN" && winningNumber % 2 == 0)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 3)
            {
                // Ask user for red, black, or green
                Console.Write("\nRed, black, or green? ");
                string userBet = Console.ReadLine().ToUpper();

                if (userBet == "RED" && newBet.BinRed.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "BLACK" && newBet.BinBlack.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "GREEN" && newBet.BinGreen.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 4) // doesn't evaluate the first time
            {
                // Ask user for low or high
                Console.Write("\nHigh or Low? ");
                string userBet = Console.ReadLine().ToUpper();

                if (userBet == "HIGH" && winningNumber > 0 && winningNumber < 19)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "LOW" && winningNumber > 18 && winningNumber < 39)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 5)
            {
                // Ask user what dozen to bet on
                Console.Write("\nWhich dozen do you want to bet on?\n(Select: First, Second, or Third): ");
                string userBet = Console.ReadLine().ToUpper();

                if (userBet == "FIRST" && winningNumber > 0 && winningNumber < 19)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "SECOND" && winningNumber > 19 && winningNumber < 25)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "THIRD" && winningNumber >25 && winningNumber < 36)
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 6)
            {
                // Ask user what column to bet on
                Console.WriteLine("\nWhich column do you want to place your bet?");
                Console.WriteLine("First: 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34");
                Console.WriteLine("Second: 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 ");
                Console.WriteLine("Third: 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
                Console.Write("\nType First, Second, or Third: ");
                string userBet = Console.ReadLine().ToUpper();

                if (userBet == "FIRST" && newBet.BinFirstCol.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "SECOND" && newBet.BinSecondCol.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == "THIRD" && newBet.BinThirdCol.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 7)
            {
                // Ask user what column to bet on
                Console.WriteLine("\nWhich \"street\" do you want to place your bet?");
                Console.WriteLine("1  - 1, 2, 3");
                Console.WriteLine("2  - 4, 5, 6");
                Console.WriteLine("3  - 7, 8, 9");
                Console.WriteLine("4  - 10, 11, 12");
                Console.WriteLine("5  - 13, 14, 15");
                Console.WriteLine("6  - 16, 17, 18");
                Console.WriteLine("7  - 19, 20, 21");
                Console.WriteLine("8  - 22, 23, 24");
                Console.WriteLine("9  - 25, 26, 27");
                Console.WriteLine("10 - 28, 29, 30");
                Console.WriteLine("11 - 31, 32, 33");
                Console.WriteLine("12 - 34, 35, 36");
                Console.Write("\nType in your row selection (1 to 12): ");
                uint userBet = uint.Parse(Console.ReadLine());

                if (userBet == 1 && newBet.BinStreet1.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 2 && newBet.BinStreet2.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 3 && newBet.BinStreet3.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 4 && newBet.BinStreet4.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 5 && newBet.BinStreet5.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 6 && newBet.BinStreet6.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 7 && newBet.BinStreet7.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 8 && newBet.BinStreet8.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 9 && newBet.BinStreet9.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 10 && newBet.BinStreet10.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 11 && newBet.BinStreet11.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 12 && newBet.BinStreet12.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            else if (selectBetType == 8)
            {
                // Ask user what column to bet on
                Console.WriteLine("\nWhich \"double-row\" do you want to place your bet?");
                Console.WriteLine("1 - 1, 2, 3, 4, 5, 6 ");
                Console.WriteLine("2 - 4, 5, 6, 7, 8, 9 ");
                Console.WriteLine("3 - 7, 8, 9, 10, 11, 12 ");
                Console.WriteLine("4 - 10, 11, 12, 13, 14, 15  ");
                Console.WriteLine("5 - 13, 14, 15, 16, 17, 18  ");
                Console.WriteLine("6 - 16, 17, 18, 19, 20, 21  ");
                Console.WriteLine("7 - 19, 20, 21, 22, 23, 24  ");
                Console.WriteLine("8 - 22, 23, 24, 25, 26, 27  ");
                Console.WriteLine("9 - 25, 26, 27, 31, 32, 33  ");
                Console.WriteLine("10 - 31, 32, 33, 34, 35, 36 ");
                Console.Write("\nType in your double row selection (1 to 10): ");
                uint userBet = uint.Parse(Console.ReadLine());

                if (userBet == 2 && newBet.BinDouble1.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 3 && newBet.BinDouble2.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 4 && newBet.BinDouble3.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 5 && newBet.BinDouble4.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 6 && newBet.BinDouble5.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 7 && newBet.BinDouble6.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 8 && newBet.BinDouble7.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 9 && newBet.BinDouble8.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 10 && newBet.BinDouble9.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else if (userBet == 1 && newBet.BinDouble10.Contains(winningNumber))
                {
                    capital += bet;
                    winLose = "You Win!";
                }
                else
                {
                    capital -= bet;
                    winLose = "You Lose!";
                }
            }

            return winLose;
        }

        private static int Introduction()
        {
            Console.WriteLine("Welcome to Dan's Casino");
            Console.Write("How much money are you willing to lose?: $");
            int Capital = int.Parse(Console.ReadLine());
            Console.WriteLine("\nProcessing...\n");

            Thread.Sleep(1000);
            Console.WriteLine($"${Capital} it is! \nOnwards to the Roulette table!");

            Thread.Sleep(1000);
            return Capital;
        }

        public static void GameModes()
        {
            // Select bet - ChooseBet()
            Console.WriteLine("\nSelect a number to bet from the choices below:");
            Console.WriteLine("1.  Numbers");
            Console.WriteLine("2.  Even/Odd");
            Console.WriteLine("3.  Red/Black");
            Console.WriteLine("4.  Low/High: Low(1-18) High(19-38)");
            Console.WriteLine("5.  Dozens: 1-12, 13-24, 25-36");
            Console.WriteLine("6.  Columns: First, Second, Third.");
            Console.WriteLine("7.  Street: rows(1,2,3,4,etc.)");
            Console.WriteLine("8.  6 Numbers: Double rows.\n");
            //Console.WriteLine("9.  Split: at the edge of contiguous numbers.");
            //Console.WriteLine("10. Corner: at the intersection of any four contiguous numbers.\n");
        }
    }
}
