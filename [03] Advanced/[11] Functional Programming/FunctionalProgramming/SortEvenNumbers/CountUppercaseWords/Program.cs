namespace CountUppercaseWords
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            Func<string, bool> isUpper = w => char.IsUpper(w[0]);

            Console
                .ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(isUpper)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
