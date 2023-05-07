using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int yearInThePast = int.Parse(Console.ReadLine());

            int age = 18;
            double spentMoney = 0;

            for (int i = 1800; i <= yearInThePast; i++)
            {
                if (i % 2 == 0)
                {
                    spentMoney += 12000;
                }
                else
                {
                    spentMoney += 12000 + 50 * age;
                }

                age++;
            }

            if (availableMoney >= spentMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {availableMoney - spentMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {spentMoney - availableMoney:f2} dollars to survive.");
            }
        }
    }
}
