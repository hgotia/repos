using System;
using System.Collections.Generic;
using System.Text;
using Enumerations;

namespace Ex7AMilitaryUnit
{
    public class BloodDrive : Mission
    {
        public int ExpectedNumbers { get; set; }
        public Sites location { get; set; }

        public void SetBloodDrive(Sites site, int expected)
        {
            location = site;
            ExpectedNumbers = expected;
        }

        public void StateObjective()
        {
            Console.WriteLine($"The mission is to: Collect {ExpectedNumbers} units of blood at {location}");
        }
    }
}
