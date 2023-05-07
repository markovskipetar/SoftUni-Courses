using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            bool isValid = true;

            if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
            {
                if (fruit == "banana")
                {
                    totalPrice = quantity * 2.50;
                }
                else if (fruit == "apple")
                {
                    totalPrice = quantity * 1.20;
                }
                else if (fruit == "orange")
                {
                    totalPrice = quantity * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = quantity * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = quantity * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = quantity * 5.50;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = quantity * 3.85;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (weekDay == "Saturday" || weekDay == "Sunday")
            {
                if (fruit == "banana")
                {
                    totalPrice = quantity * 2.70;
                }
                else if (fruit == "apple")
                {
                    totalPrice = quantity * 1.25;
                }
                else if (fruit == "orange")
                {
                    totalPrice = quantity * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    totalPrice = quantity * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    totalPrice = quantity * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    totalPrice = quantity * 5.60;
                }
                else if (fruit == "grapes")
                {
                    totalPrice = quantity * 4.20;
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }

            if (!isValid)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{totalPrice:f2}");

            }
        }
    }
}
