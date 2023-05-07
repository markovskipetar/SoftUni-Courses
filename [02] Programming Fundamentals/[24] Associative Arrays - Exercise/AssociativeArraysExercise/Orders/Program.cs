namespace Orders
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Product> orders = new Dictionary<string, Product>();

            while (true)
            {
                string[] productInfo = Console.ReadLine().Split().ToArray();

                if (productInfo[0] == "buy")
                {
                    break;
                }

                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                Product currentProduct = new Product(name, price, quantity);

                if (!orders.ContainsKey(name))
                {
                    orders[name] = currentProduct;
                }
                else
                {
                    double currentProductPrice = orders[name].Price;

                    if (currentProductPrice != price)
                    {
                        orders[name].Price = price;
                    }

                    orders[name].Quantity += quantity;
                }
            }

            foreach (var kvp in orders)
            {
                kvp.Value.CalculateTotalPrice();

                Console.WriteLine(kvp.Value);
            }
        }
    }
}
