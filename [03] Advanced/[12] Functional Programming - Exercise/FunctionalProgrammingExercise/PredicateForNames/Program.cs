namespace PredicateForNames
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            Func<string, bool> isShorterOrEqual = new Func<string, bool>(name =>
            {
                return name.Length <= lenght;
            });

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(isShorterOrEqual)
                .ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
