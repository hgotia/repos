using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PasswordAuthAndEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSelection();
        }

        public static void Authenticate()
        {
            Console.Write("\nEnter a username: ");
            string username = Console.ReadLine();

            foreach (var user in UserAccounts.Keys)
            {
                if (username == user)
                {
                    CheckPassword(user);
                }
            }
            Console.WriteLine("Username not found. Try again.");
            Authenticate();
        }

        public static void CheckPassword(string user)
        {
            Console.Write("\nEnter your password: ");
            string password = Encrypt(Console.ReadLine());

            if (password == UserAccounts[user])
            {
                Console.WriteLine("\n\n*** CONGRATULATIONS! User and password matched! ***\n");
                GoMainMenu();
            }
            else
            {
                Console.WriteLine("\nPassword mismatch. Try again.");
                CheckPassword(user);
            }
        }
        public static string Encrypt(string password)
        {
            int shift = 10;
            string shiftedPassword = "";

            foreach (var item in password)
            {
                int shiftedItem = item + shift;

                if (shiftedItem > 127)
                     shiftedItem -= 95;

                shiftedPassword += (char)shiftedItem;
            }
            return shiftedPassword;
        }
        private static object Decrypt(string value)
        {
            int shift = 10;
            string shiftedPassword = "";

            foreach (var item in value)
            {
                int shiftedItem = item - shift;

                if (shiftedItem < 32)
                    shiftedItem += 95;

                shiftedPassword += (char)shiftedItem;
            }
            return shiftedPassword;
        }
        public static void GetSelection()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM\n");
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1. Create an account\n2. Authenticate a user and password\n3. Exit the system");
            Console.WriteLine("--------------------------------------");

            int selection = GetUserInput();
            
            if (selection == 1)
                SignUp();
            else if (selection == 2)
                Authenticate();
            else if (selection == 3)
            {
                Console.WriteLine("Accounts made:");
                Console.WriteLine("[username, encrypted password]");

                for (int i = 0; i < UserAccounts.Count; i++)
                {
                    Console.WriteLine(value: $"Username: {UserAccounts.ElementAt(i).Key} - Password: {Decrypt(UserAccounts.ElementAt(i).Value)}");
                }

                System.Environment.Exit(0);
            }
        }


        public static void GoMainMenu()
        {
            Console.WriteLine("\nTaking you back to the Main Menu...");
            Thread.Sleep(1 * 1000);

            GetSelection();
        }
        public static int GetUserInput()
        {
            Console.Write("\nEnter selection: ");
            string selection = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(selection, out inputValue);

            while (!success || 
                    inputValue == 0 ||
                    inputValue < 1 ||
                    inputValue > 3)
            {
                Console.WriteLine("Error! Enter a valid selection!");
                Console.Write("\nEnter selection: ");
                selection = Console.ReadLine();
                success = int.TryParse(selection, out inputValue);
            }

            return inputValue;
        }
        public static void SignUp()
        {
            Console.Write("\nEnter a username: ");
            string username = Console.ReadLine();

            foreach (var user in UserAccounts.Keys)
            {
                if (username == user)
                {
                    Console.WriteLine("Username already exists!. Try a different one.");
                    SignUp();
                }
            }

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            string encryptedPassword = Encrypt(password);

            Console.WriteLine("\n*** ENCRYPTING PASSWORD ***");
            Thread.Sleep(1 * 1000);
            Console.WriteLine($"Encrypted password is {encryptedPassword}");

            UserAccounts.Add(username, encryptedPassword);
            GoMainMenu();
        }
        static Dictionary<string, string> UserAccounts = new Dictionary<string, string>();
    }
}
