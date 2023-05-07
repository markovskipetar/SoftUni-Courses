using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int personAge = int.Parse(Console.ReadLine());
            double washingMachniePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneyFromGifts = 0;
            int lastBdayMoney = 0;

            for (int i = 0; i < personAge; i++)
            {
                int currentAge = i + 1;

                if (currentAge % 2 == 0)
                {
                    moneyFromGifts += 10 + lastBdayMoney - 1;
                    lastBdayMoney += 10;
                }
                else
                {
                    moneyFromGifts += toyPrice;
                }
            }

            if (moneyFromGifts >= washingMachniePrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(washingMachniePrice - moneyFromGifts):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(washingMachniePrice - moneyFromGifts):f2}");
            }
        }
    }
}
