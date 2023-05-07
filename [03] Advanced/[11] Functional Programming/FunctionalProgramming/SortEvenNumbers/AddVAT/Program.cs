namespace AddVAT
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            Func<string, double> parse = x => double.Parse(x);
            Func<double, double> addVAT = x => x * 1.2;
            Func<double, string> toString = x => $"{x:f2}";

            Console
                .ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parse)
                .Select(addVAT)
                .Select(toString)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
