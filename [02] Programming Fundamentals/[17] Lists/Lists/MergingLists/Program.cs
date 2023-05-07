namespace MergingLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int longerListCount = Math.Max(firstNumbers.Count, secondNumbers.Count);

            for (int i = 0; i < longerListCount; i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }

                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
