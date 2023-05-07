using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int i = 0; i < days; i++)
            {
                int currentDay = i + 1;

                double moneyForCurrentDay = 0;

                for (int j = 0; j < hoursPerDay; j++)
                {
                    int currentHour = j + 1;

                    if (currentDay % 2 == 0 && currentHour % 2 == 1)
                    {
                        moneyForCurrentDay += 2.50;
                    }
                    else if (currentDay % 2 == 1 && currentHour % 2 == 0)
                    {
                        moneyForCurrentDay += 1.25;
                    }
                    else
                    {
                        moneyForCurrentDay += 1;
                    }
                }

                totalMoney += moneyForCurrentDay;

                Console.WriteLine($"Day: {currentDay} - {moneyForCurrentDay:f2} leva");
            }

            Console.WriteLine($"Total: {totalMoney:f2} leva");
        }
    }
}
