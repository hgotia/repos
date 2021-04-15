using System;

namespace EncryptDecryptMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter plain text: ");
            string message = Console.ReadLine();

            Console.Write("Enter a keyword or letter: ");
            string keyWord = Console.ReadLine().ToUpper();

            string cleanMessage = removeNonLetters(message);
            string longKey = elongateWithRepeats(keyWord, cleanMessage);
            string anotherKey = keyMessageCombo(keyWord, cleanMessage);

            Console.WriteLine($"\nYou entered [{message}] as plain text.");
            Console.WriteLine($"You entered [{keyWord}] as your keyword.");

            string encryptedMsgWithRepeatKeys = Cipher(cleanMessage, longKey);
            string encryptedMsgWithAnotherKey = Cipher(cleanMessage, anotherKey);

            Console.WriteLine($"\nEncrypted message with keyword is [{encryptedMsgWithRepeatKeys}]");
            Console.WriteLine($"Encrypted message with keyword-plaintext combo is [{encryptedMsgWithAnotherKey}]");

            string decryptedMsgWithRepeatKeys = Decipher(encryptedMsgWithRepeatKeys, longKey);
            string decryptedMsgWithAnotherKey = Decipher(encryptedMsgWithAnotherKey, anotherKey);

            Console.WriteLine($"\nDecrypted message with keyword is [{decryptedMsgWithRepeatKeys}]");
            Console.WriteLine($"Decrypted message with keyword-plaintext combo is [{decryptedMsgWithAnotherKey}]");
        }

        private static string keyMessageCombo(string keyWord, string cleanMessage)
        {
            string word = keyWord + cleanMessage;
            string result = "";

            for (int i = 0; i < cleanMessage.Length; i++)
            {
                result += word[i];
            }
            return result;
        }

        private static string Cipher(string cleanMessage, string longKey)
        {
            // Use CharShift
            string result = "";
        
            for (int i = 0; i < cleanMessage.Length; i++)
            {
                result += charShift(cleanMessage[i], longKey[i]);
            }

            return result;
        }

        private static char charShift(char v1, char v2)
        {
            int item = v1;
            int shiftNumber = v2 - 64;

            int newItem = (item + shiftNumber);
           
            if (newItem > 90)
            {
                newItem -= 26;
            }
            return (char)newItem;
        }

        private static string Decipher(string EncryptedMessage, string longKey)
        {
            // Use CharShift
            string result = "";

            for (int i = 0; i < EncryptedMessage.Length; i++)
            {
                result += reverseCharShift(EncryptedMessage[i], longKey[i]);
            }

            return result;
        }

        private static char reverseCharShift(char v1, char v2)
        {
            int item = v1;
            int shiftNumber = v2 - 64;

            int newItem = (item - shiftNumber);

            if (newItem < 65)
            {
                newItem += 26;
            }
            return (char)newItem;
        }

        private static string elongateWithRepeats(string keyWord, string message)
        {
            int msgLength = message.Length;
            string longKey = "";
            int count = 0;

            while (longKey.Length != msgLength)
            {
                if (count > keyWord.Length-1)
                    count = 0;
                longKey += keyWord[count];
                count++;
            }
            return longKey;
        }

        private static string removeNonLetters(string message)
        {
            string result = "";

            foreach (char item in message.ToUpper())
            {
                if (item > 64 && item < 91)
                    result += item;
            }
            return result;
        }
    }
}
