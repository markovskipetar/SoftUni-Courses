using System;
using System.Xml;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                double insertedCoint = double.Parse(input);

                if (insertedCoint == 0.1 || insertedCoint == 0.2 || insertedCoint == 0.5 || insertedCoint == 1 || insertedCoint == 2)
                {
                    availableMoney += insertedCoint;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedCoint}");
                }
            }

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break;
                }

                double productPrice = 0;
                bool invalidProduct = false;

                switch (product)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;

                    case "Water":
                        productPrice = 0.7;
                        break;

                    case "Crisps":
                        productPrice = 1.5;
                        break;

                    case "Soda":
                        productPrice = 0.8;
                        break;

                    case "Coke":
                        productPrice = 1.0;
                        break;

                    default:
                        Console.WriteLine($"Invalid product");
                        invalidProduct = true;
                        break;
                }

                if (!invalidProduct)
                {
                    if (availableMoney >= productPrice)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");

                        availableMoney -= productPrice;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
            }

            Console.WriteLine($"Change: {availableMoney:F2}");
        }
    }
}
