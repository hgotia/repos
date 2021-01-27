//Not very clean - had a bit of fun but at least the bottom 3 methods are actually optionals.
//This console app can be used to summon anyone from anywhere or your backyard! You can also choose to not summon and just hit the enter key.

using System;

namespace EX2BOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string announce;
            string name;
            string address;

            name = GetName();

            if (!string.IsNullOrEmpty(name))
            {
                address = GetAddress();

                if (!string.IsNullOrEmpty(address)) Console.WriteLine(Summons(name, address));

                else
                {
                    announce = Summons(name);
                    Console.WriteLine(announce);
                } 
            }
            else if (string.IsNullOrEmpty(name))
            {
                announce = Summons();
                Console.WriteLine(announce);
            }


        }

        private static string GetAddress()
        {
            Console.Write("From where?!(optional) ");
            return Console.ReadLine();
        }

        private static string GetName()
        {
            Console.Write("Who do we want to summon?!(optional) ");
            return Console.ReadLine();
        }

        private static string Summons(string name, string address)
        {
            return $"\nSummoning {name} from {address}!!!";
        }

        private static string Summons(string name)
        {
            return Summons(name, "your backyard");
        }

        private static string Summons()
        {
            return "\nYou didn't summon anyone!";
        }
    }
}
