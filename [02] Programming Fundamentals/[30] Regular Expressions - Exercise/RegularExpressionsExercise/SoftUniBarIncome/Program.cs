namespace SoftUniBarIncome
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%.*<(?<product>\w+)>.*\|(?<count>\d+)\|[^\d]*(?<price>\d+\.?\d*)\$");

            double totalIncome = 0;

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "end of shift")
                {
                    break;
                }

                Match match = regex.Match(text);

                if (match.Success)
                {
                    string customerName = match.Groups["name"].Value;
                    string productName = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customerName}: {productName} - {totalPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
