namespace PosTOffice
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            string firstPartPattern = @"(\#|\$|\*|\&)([A-Z]+)(\1)";
            string secondPartPattern = @"(\d{2}):(\d{2})";

            string[] textParts = Console.ReadLine().Split('|').ToArray();

            string firstPart = textParts[0];
            string secondPart = textParts[1];
            string thirdPart = textParts[2];

            string letters = Regex.Match(firstPart, firstPartPattern).Groups[2].Value;

            MatchCollection matches = Regex.Matches(secondPart, secondPartPattern);

            Dictionary<int, int> numberPairs = new Dictionary<int, int>();

            foreach (Match match in matches)
            {
                int asciiCode = int.Parse(match.Groups[1].Value);

                if (65 <= asciiCode && asciiCode <= 90)
                {
                    int length = int.Parse(match.Groups[2].Value);

                    numberPairs[asciiCode] = length;
                }
            }

            foreach (var letter in letters)
            {
                int letterAsciiValue = letter;
                int length = numberPairs[letterAsciiValue];

                Match match = Regex.Match(thirdPart, $@"(^|\s)([{{{letter}}}][^\s]{{{length}}})\b");

                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
