namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"(^|(?<=\s))(?:(?!-)(?<name>[a-z0-9]+[-._]*[a-z0-9]+)@(?<domain>[a-z]+[-]?[a-z]*(\.[a-z]+[-]?[a-z]*)+))");

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
