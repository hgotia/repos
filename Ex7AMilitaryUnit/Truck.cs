using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7AMilitaryUnit
{
    class Truck : Vehicle
    {
        public int MaxCapacity = 2;

        public override void Honk()
        {
            Console.WriteLine("MRGLGLRGLRLGLRLGRLLRLLRGLGLG");
        }
    }
}
