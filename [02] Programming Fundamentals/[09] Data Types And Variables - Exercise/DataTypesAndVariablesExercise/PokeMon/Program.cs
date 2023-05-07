using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int startingPower = power;
            int pokesCount = 0;

            while (true)
            {
                if (power < distance)
                {
                    break;
                }

                power -= distance;
                pokesCount++;

                if (power == 0.5 * startingPower && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(pokesCount);
        }
    }
}
