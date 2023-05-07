namespace FastFood
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int availableFoodQuantity = int.Parse(Console.ReadLine());

            int[] cusomers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var customersOrders = new Queue<int>(cusomers);
            int maxOrder = 0;

            while (customersOrders.Any())
            {
                int currentCustomerFood = customersOrders.Peek();

                if (availableFoodQuantity >= currentCustomerFood)
                {
                    if (currentCustomerFood > maxOrder)
                    {
                        maxOrder = currentCustomerFood;
                    }

                    availableFoodQuantity -= currentCustomerFood;
                    customersOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (customersOrders.Any())
            {
                if (customersOrders.Max() > maxOrder)
                {
                    maxOrder = customersOrders.Max();
                }

                Console.WriteLine(maxOrder);
                Console.WriteLine($"Orders left: {string.Join(" ", customersOrders)}");
            }
            else
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine($"Orders complete");
            }
        }
    }
}
