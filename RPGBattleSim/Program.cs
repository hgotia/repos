using System;

namespace RPGBattleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int heroHealth = 10;
            int monsterHealth = 10;

            int heroAttack = random.Next(1, 11);
            int monsterAttack = random.Next(1, 11);

            do
            {
                monsterHealth = monsterHealth - heroAttack; // hero attack first
                Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth}");

                if (monsterHealth <= 0)
                {
                    Console.WriteLine("Hero wins!");
                    break;
                }

                heroHealth = heroHealth - monsterAttack; // monster attacks
                Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth}");

                if (heroHealth <= 0)
                {
                    Console.WriteLine("Hero loses!");
                    break;
                }

            } while (heroHealth >= 0 && monsterHealth >= 0);

        }
    }
}
