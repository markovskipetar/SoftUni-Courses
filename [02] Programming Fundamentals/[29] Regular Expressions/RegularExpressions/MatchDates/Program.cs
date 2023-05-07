namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"\b(\d{2})([-.\/])([A-Z][a-z]{2})(\2)(\d{4})\b");

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string day = match.Groups[1].ToString();
                string month = match.Groups[3].ToString();
                string year = match.Groups[5].ToString();

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
