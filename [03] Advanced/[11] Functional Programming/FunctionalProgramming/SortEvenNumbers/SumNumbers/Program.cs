namespace SumNumbers
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
                .ToArray();

            int sum = result.Sum();

            Console.WriteLine(result.Length);
            Console.WriteLine(sum);
        }
    }
}
