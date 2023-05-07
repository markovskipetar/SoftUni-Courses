using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;

            double totalPrice = 0;

            if (roomType == "apartment")
            {
                totalPrice = nights * 25;

                if (days < 10)
                {
                    totalPrice *= 0.70;
                }
                else if (10 <= days && days <= 15)
                {
                    totalPrice *= 0.65;
                }
                else
                {
                    totalPrice *= 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                totalPrice = nights * 35;

                if (days < 10)
                {
                    totalPrice *= 0.90;
                }
                else if (10 <= days && days <= 15)
                {
                    totalPrice *= 0.85;
                }
                else
                {
                    totalPrice *= 0.80;
                }
            }
            else
            {
                totalPrice = nights * 18;
            }

            if (feedback == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
