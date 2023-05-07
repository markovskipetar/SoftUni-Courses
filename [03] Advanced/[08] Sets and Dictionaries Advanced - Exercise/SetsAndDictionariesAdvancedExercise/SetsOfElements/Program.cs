namespace SetsOfElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                firstSet.Add(num);
            }

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());

                secondSet.Add(num);
            }

            HashSet<int> result = new HashSet<int>();

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    result.Add(num);
                }
            }

            string output = string.Join(" ", result);

            Console.WriteLine(output);
        }
    }
}
