using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredMoney = int.Parse(Console.ReadLine());

            double moneyFromCash = 0;
            double moneyFromCard = 0;

            int payingWithCashCount = 0;
            int payingWithCardCount = 0;
            bool isSumCollected = false;

            int counter = 1;

            string currentPrice = Console.ReadLine();

            while (currentPrice != "End")
            {
                if (counter % 2 == 1)
                {
                    if (int.Parse(currentPrice) > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");

                        moneyFromCash += int.Parse(currentPrice);
                        payingWithCashCount++;
                    }
                }
                else
                {
                    if (int.Parse(currentPrice) < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");

                        moneyFromCard += int.Parse(currentPrice);
                        payingWithCardCount++;
                    }
                }

                if (moneyFromCash + moneyFromCard >= requiredMoney)
                {
                    isSumCollected = true;
                    break;
                }

                counter++;
                currentPrice = Console.ReadLine();
            }

            if (isSumCollected)
            {
                Console.WriteLine($"Average CS: {moneyFromCash / payingWithCashCount:f2}");
                Console.WriteLine($"Average CC: {moneyFromCard / payingWithCardCount:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
