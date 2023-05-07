namespace StoreBoxes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] input = inputLine
                    .Split()
                    .ToArray();

                string serialNumber = input[0];
                string itemName = input[1];
                double itemQuantity = double.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);

                Item item = new Item(itemName, itemPrice);

                Box box = new Box(serialNumber, item, itemQuantity);
                box.CalculatePriceForBox();

                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}
