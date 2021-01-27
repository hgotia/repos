using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationPractice
{
    class Animal
    {
        public string animalName { get; set; }

        public void animal_type()
        {
            Console.WriteLine("I am a {0}", animalName);
        }
        
        public void Move()
        {
            Console.WriteLine("moving");
        }

        public void MakeSound()
        {
            Console.WriteLine("the {0} is making a loud noise", animalName);
        }

        public void Eat()
        {
            Console.WriteLine("the {0} is eating", animalName);
        }
    }
}
