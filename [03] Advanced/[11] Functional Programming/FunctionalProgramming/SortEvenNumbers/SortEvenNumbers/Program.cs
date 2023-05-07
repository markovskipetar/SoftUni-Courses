namespace SortEvenNumbers
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int[] result = Console
                .ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
