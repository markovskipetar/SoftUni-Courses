namespace ListOfProducts
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string currentProdcut = Console.ReadLine();

                products.Add(currentProdcut);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
