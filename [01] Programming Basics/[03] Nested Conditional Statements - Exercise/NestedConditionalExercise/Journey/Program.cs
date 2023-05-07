using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spendMoney = 0.0;
            string destination = String.Empty;
            string placeToSleep = String.Empty;

            if (budget <= 100)
            {
                destination = "Somewhere in Bulgaria";

                if (season == "summer")
                {
                    placeToSleep = "Camp";
                    spendMoney = 0.3 * budget;
                }
                else if (season == "winter")
                {
                    placeToSleep = "Hotel";
                    spendMoney = 0.7 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Somewhere in Balkans";

                if (season == "summer")
                {
                    placeToSleep = "Camp";
                    spendMoney = 0.4 * budget;
                }
                else if (season == "winter")
                {
                    placeToSleep = "Hotel";
                    spendMoney = 0.8 * budget;
                }
            }
            else
            {
                destination = "Somewhere in Europe";
                placeToSleep = "Hotel";
                spendMoney = 0.9 * budget;
            }

            Console.WriteLine($"{destination}");
            Console.WriteLine($"{placeToSleep} - {spendMoney:f2}");
        }
    }
}
