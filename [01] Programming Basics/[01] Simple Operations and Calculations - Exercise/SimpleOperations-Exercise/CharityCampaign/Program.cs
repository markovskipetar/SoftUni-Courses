using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForTheEvent = int.Parse(Console.ReadLine());
            int CookersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            double moneyPerDay = ((cakesCount * 45) + (wafflesCount * 5.80) + (pancakesCount * 3.20)) * CookersCount;
            double allMoneyGot = moneyPerDay * daysForTheEvent;

            double costs = allMoneyGot / 8;

            double moneyLeft = allMoneyGot - costs;

            Console.WriteLine($"{moneyLeft:F2}");
        }
    }
}
