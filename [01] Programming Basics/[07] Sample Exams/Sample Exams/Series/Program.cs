using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int tvSeriesCount = int.Parse(Console.ReadLine());

            double spentMoney = 0;

            for (int i = 0; i < tvSeriesCount; i++)
            {
                string tvSeriesName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                switch (tvSeriesName)
                {
                    case "Thrones":
                        spentMoney += 0.5 * price;
                        break;

                    case "Lucifer":
                        spentMoney += 0.6 * price;
                        break;

                    case "Protector":
                        spentMoney += 0.7 * price;
                        break;

                    case "TotalDrama":
                        spentMoney += 0.8 * price;
                        break;

                    case "Area":
                        spentMoney += 0.9 * price;
                        break;

                    default:
                        spentMoney += price;
                        break;
                }
            }

            if (budget >= spentMoney)
            {
                Console.WriteLine($"You bought all the series and left with {budget - spentMoney:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {spentMoney - budget:f2} lv. more to buy the series!");
            }
        }
    }
}
