using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int i = 0; i < customers; i++)
            {
                double currentCustomerBill = 0;
                int productsCount = 0;

                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Finish")
                    {
                        break;
                    }

                    switch (product)
                    {
                        case "basket":
                            currentCustomerBill += 1.50;
                            break;

                        case "wreath":
                            currentCustomerBill += 3.80;
                            break;

                        case "chocolate bunny":
                            currentCustomerBill += 7.00;
                            break;
                    }

                    productsCount++;
                }

                if (productsCount % 2 == 0)
                {
                    currentCustomerBill *= 0.8;
                }

                Console.WriteLine($"You purchased {productsCount} items for {currentCustomerBill:f2} leva.");

                totalMoney += currentCustomerBill;
            }

            double averagePerCustomer = totalMoney / customers;

            Console.WriteLine($"Average bill per client is: {averagePerCustomer:F2} leva.");
        }
    }
}
