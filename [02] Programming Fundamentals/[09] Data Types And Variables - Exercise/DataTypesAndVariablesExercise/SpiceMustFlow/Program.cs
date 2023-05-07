using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int workersConsumption = 26;
            int minedSpices = 0;
            int days = 0;

            while (true)
            {
                if (startingYield < 100)
                {
                    break;
                }

                minedSpices += startingYield;
                minedSpices -= workersConsumption;

                startingYield -= 10;
                days++;
            }

            if (minedSpices >= 26)
            {
                minedSpices -= workersConsumption;
            }

            Console.WriteLine(days);
            Console.WriteLine(minedSpices);
        }
    }
}
