using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisermenCount = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            if (season == "Spring")
            {
                totalMoney = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totalMoney = 4200;
            }
            else if (season == "Winter")
            {
                totalMoney = 2600;
            }

            if (fisermenCount <= 6)
            {
                totalMoney *= 0.9;
            }
            else if (7 <= fisermenCount && fisermenCount <= 11)
            {
                totalMoney *= 0.85;
            }
            else
            {
                totalMoney *= 0.75;
            }

            if (fisermenCount % 2 == 0 && season != "Autumn")
            {
                totalMoney *= 0.95;
            }

            if (budget >= totalMoney)
            {
                double leftMoney = budget - totalMoney;

                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
            {
                double moreMoneyNeeded = totalMoney - budget;

                Console.WriteLine($"Not enough money! You need {moreMoneyNeeded:f2} leva.");
            }
        }
    }
}
