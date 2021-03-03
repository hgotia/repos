using System;
using System.Collections.Generic;
using System.Text;
using Enumerations;

namespace Ex7AMilitaryUnit
{
    public abstract class Person // abstract classes prevents the instantiation of this base class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public branch Branch { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName} from the {Branch}");
        }
    }
}
