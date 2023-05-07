using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{quantity * GetSinglePrice(product):f2}");
        }

        static double GetSinglePrice(string product)
        {
            double singlePrice = 0;

            switch (product)
            {
                case "coffee":
                    singlePrice = 1.50;
                    break;

                case "water":
                    singlePrice = 1;
                    break;

                case "coke":
                    singlePrice = 1.40;
                    break;

                case "snacks":
                    singlePrice = 2;
                    break;
            }

            return singlePrice;
        }
    }
}
