namespace CountSymbols
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            var charCount = new Dictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!charCount.ContainsKey(symbol))
                {
                    charCount[symbol] = 0;
                }

                charCount[symbol]++;
            }

            charCount = charCount.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var (symbol, count) in charCount)
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}
