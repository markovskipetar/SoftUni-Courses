using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthsCount = int.Parse(Console.ReadLine());

            double moneyForElectricity = 0;
            double moneyForWater = monthsCount * 20;
            double moneyForInternet = monthsCount * 15;
            double moneyForOthers = 0;


            for (int i = 0; i < monthsCount; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());

                moneyForElectricity += electricityPrice;
                moneyForOthers += (electricityPrice + 20 + 15) * 1.2;
            }

            double requiredMoneyForThePeriod = moneyForElectricity + moneyForWater + moneyForInternet + moneyForOthers;
            double averagePerMonth = requiredMoneyForThePeriod / monthsCount;

            Console.WriteLine($"Electricity: {moneyForElectricity:f2} lv");
            Console.WriteLine($"Water: {moneyForWater:f2} lv");
            Console.WriteLine($"Internet: {moneyForInternet:f2} lv");
            Console.WriteLine($"Other: {moneyForOthers:f2} lv");
            Console.WriteLine($"Average: {averagePerMonth:f2} lv");
        }
    }
}
