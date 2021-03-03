using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7AMilitaryUnit
{
    class Van : Vehicle
    {
        public int MaxCapacity = 9;

        public override void Honk()
        {
            Console.WriteLine("TOOOOT TOOOOT");
        }
    }
}
