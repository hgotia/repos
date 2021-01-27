using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Car(string Make = "Toyota", int _Year = 2021)
            {
                int _year = _Year;
                Console.WriteLine("The car year is {0}", _year);
            }
            void Car(string Make)
            {
                Car(Make, 2021);
            }
        }
    }
}
