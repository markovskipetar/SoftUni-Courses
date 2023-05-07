namespace RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex pairsRegex = new Regex(@"[^0-9]+\d+");
            Regex symbolsNumberRegex = new Regex(@"([^0-9]+)(\d+)");

            MatchCollection matches = pairsRegex.Matches(input);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string matchValue = match.Value;
                Match currentMatch = symbolsNumberRegex.Match(matchValue);

                string text = currentMatch.Groups[1].Value.ToUpper();
                int number = int.Parse(currentMatch.Groups[2].Value);

                for (int i = 0; i < number; i++)
                {
                    sb.Append(text);
                }
            }

            List<char> uniqueSymbols = new List<char>(sb.ToString().ToCharArray().Distinct());

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(sb.ToString());
        }
    }
}
