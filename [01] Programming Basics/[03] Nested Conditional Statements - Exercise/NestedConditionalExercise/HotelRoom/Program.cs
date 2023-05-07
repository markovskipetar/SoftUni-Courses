using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double moneyForStudio = 0.0;
            double moneyForApartment = 0.0;

            if (month == "May" || month == "October")
            {
                moneyForStudio = nights * 50;
                moneyForApartment = nights * 65;

                if (nights > 14)
                {
                    moneyForStudio *= 0.70;
                }
                else if (nights > 7)
                {
                    moneyForStudio *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                moneyForStudio = nights * 75.20;
                moneyForApartment = nights * 68.70;

                if (nights > 14)
                {
                    moneyForStudio *= 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                moneyForStudio = nights * 76;
                moneyForApartment = nights * 77;
            }

            if (nights > 14)
            {
                moneyForApartment *= 0.90;
            }

            Console.WriteLine($"Apartment: {moneyForApartment:f2} lv.");
            Console.WriteLine($"Studio: {moneyForStudio:f2} lv.");
        }
    }
}
