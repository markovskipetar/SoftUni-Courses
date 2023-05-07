namespace PeriodicTable
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int elementsCount = int.Parse(Console.ReadLine());

            var uniqueElements = new HashSet<string>();

            for (int i = 0; i < elementsCount; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (var el in elements)
                {
                    uniqueElements.Add(el);
                }
            }

            uniqueElements = uniqueElements.OrderBy(el => el).ToHashSet();

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
