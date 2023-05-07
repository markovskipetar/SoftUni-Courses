namespace FindEvensOrOdds
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int[] bonds = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftBond = bonds[0];
            int rightBond = bonds[1];

            string numberType = Console.ReadLine();

            Predicate<int> predicate = numberType switch
            {
                "odd" => x => x % 2 == 1,
                "even" => x => x % 2 == 0
            };

            List<int> result = new List<int>();

            for (int i = leftBond; i <= rightBond; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
