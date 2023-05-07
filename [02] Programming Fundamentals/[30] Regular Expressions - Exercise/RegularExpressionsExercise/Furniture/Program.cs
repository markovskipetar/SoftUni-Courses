namespace Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main()
        {
            string patter = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            List<string> furnitures = new List<string>();
            double totalPrice = 0;

            while (true)
            {
                string currentFurniture = Console.ReadLine();

                if (currentFurniture == "Purchase")
                {
                    break;
                }

                Match match = Regex.Match(currentFurniture, patter);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitures.Add(name);
                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
