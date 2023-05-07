using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalMoney = 0.0;

            if (flowerType == "Roses")
            {
                totalMoney = flowersCount * 5;

                if (flowersCount > 80)
                {
                    totalMoney *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                totalMoney = flowersCount * 3.80;

                if (flowersCount > 90)
                {
                    totalMoney *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                totalMoney = flowersCount * 2.80;

                if (flowersCount > 80)
                {
                    totalMoney *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                totalMoney = flowersCount * 3;

                if (flowersCount < 120)
                {
                    totalMoney *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                totalMoney = flowersCount * 2.50;

                if (flowersCount < 80)
                {
                    totalMoney *= 1.20;
                }
            }

            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney;

                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moreMoneyNeeded = totalMoney - budget;

                Console.WriteLine($"Not enough money, you need {moreMoneyNeeded:f2} leva more.");
            }
        }
    }
}
