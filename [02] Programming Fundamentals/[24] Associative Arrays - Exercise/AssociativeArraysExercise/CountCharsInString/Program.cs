namespace CountCharsInString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string text = string.Concat(input);

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char symbol in text)
            {
                if (!count.ContainsKey(symbol))
                {
                    count[symbol] = 0;
                }

                count[symbol]++;
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
