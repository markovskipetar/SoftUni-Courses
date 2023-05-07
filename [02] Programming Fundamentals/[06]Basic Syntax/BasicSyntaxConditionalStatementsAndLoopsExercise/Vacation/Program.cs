using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalPrice = 8.45 * peopleCount;
                        break;

                    case "Saturday":
                        totalPrice = 9.80 * peopleCount;
                        break;

                    case "Sunday":
                        totalPrice = 10.46 * peopleCount;
                        break;
                }

                if (peopleCount >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }

                switch (dayOfWeek)
                {
                    case "Friday":
                        totalPrice = 10.90 * peopleCount;
                        break;

                    case "Saturday":
                        totalPrice = 15.60 * peopleCount;
                        break;

                    case "Sunday":
                        totalPrice = 16 * peopleCount;
                        break;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalPrice = 15 * peopleCount;
                        break;

                    case "Saturday":
                        totalPrice = 20 * peopleCount;
                        break;

                    case "Sunday":
                        totalPrice = 22.50 * peopleCount;
                        break;
                }

                if (10 <= peopleCount && peopleCount <= 20)
                {
                    totalPrice *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
