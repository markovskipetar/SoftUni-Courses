namespace CupsAndBottles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int[] cupsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var cups = new Queue<int>(cupsInput);
            var bottles = new Stack<int>(bottlesInput);

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int cupCapacity = cups.Peek();

                while (bottlesInput.Any())
                {
                    int bottleCapacity = bottles.Pop();

                    if (bottleCapacity >= cupCapacity)
                    {
                        cups.Dequeue();
                        wastedWater += bottleCapacity - cupCapacity;

                        break;
                    }

                    cupCapacity -= bottleCapacity;
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine("Bottles: " + String.Join(" ", bottles));
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine("Cups: " + String.Join(" ", cups));
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
