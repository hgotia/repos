using System;

namespace Gojira
{
    public class Monsters
    {
        public string name;
        public string specie;
        public string noise;
        public string food;
        public string product;
        public string weapon;

        public void speakName()
        {
            Console.WriteLine($"My name is {name}!");
        }

        public void makeNoise()
        {
            Console.WriteLine($"I make a lot of {noise} noises.");
        }

        public void specieAnnounce()
        {
            Console.WriteLine($"I am a {specie}!");
        }

        public void eat()
        {
            Console.WriteLine($"I like eating {food}.");
        }

        public void knownFor()
        {
            Console.WriteLine($"I am known for {product}");
        }

        public void attack()
        {
            Console.WriteLine($"I attack using my {weapon}");
        }
    }
}
