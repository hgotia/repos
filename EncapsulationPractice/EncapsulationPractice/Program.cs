using System;

namespace EncapsulationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog1 = new Animal();
            Cat catsy = new Cat();

            catsy.animalName = "Smelly Cat";
            dog1.animalName = "Shelty";

            dog1.MakeSound();
            catsy.animal_type();
            catsy.MakeSound();
        }
    }
}
