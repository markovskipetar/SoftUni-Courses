using System;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (0 <= age && age <= 18)
            {
                if (period == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (period == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (period == "Holiday")
                {
                    ticketPrice = 5;
                }
            }
            if (18 < age && age <= 64)
            {
                if (period == "Weekday")
                {
                    ticketPrice = 18;
                }
                else if (period == "Weekend")
                {
                    ticketPrice = 20;
                }
                else if (period == "Holiday")
                {
                    ticketPrice = 12;
                }
            }
            if (64 < age && age <= 122)
            {
                if (period == "Weekday")
                {
                    ticketPrice = 12;
                }
                else if (period == "Weekend")
                {
                    ticketPrice = 15;
                }
                else if (period == "Holiday")
                {
                    ticketPrice = 10;
                }
            }

            if (age < 0 || age > 122)
            {
                Console.WriteLine($"Error!");
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
