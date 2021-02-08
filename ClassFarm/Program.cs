using System;

namespace Gojira
{
    class Program
    {
        static void Main(string[] args)
        {
            Kong kong = new Kong("Kong");
            Baphomet baph = new Baphomet("Baphomet");
            Kraken krak = new Kraken("Kraken");
            Mothra moth = new Mothra("Mothra");
            Godzilla gZilla = new Godzilla("Godzilla");

            kong.speakName();
            gZilla.makeNoise();
            krak.eat();
            baph.knownFor();
            moth.attack();
        }
    }
}
