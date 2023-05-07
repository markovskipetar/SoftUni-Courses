namespace KnightsOfHonor
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => $"Sir {n}")
                .ToArray();

            Action<string[]> printNames = text => Console.WriteLine(string.Join(Environment.NewLine, text));

            printNames(names);
        }
    }
}
