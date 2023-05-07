namespace Race
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (var racer in input)
            {
                racers.Add(racer, 0);
            }

            string lettersPattern = @"[A-Za-z]";
            string digitsPattern = @"[0-9]";

            while (true)
            {
                string currentRacer = Console.ReadLine();

                if (currentRacer == "end of race")
                {
                    break;
                }

                MatchCollection letters = Regex.Matches(currentRacer, lettersPattern);
                string name = string.Empty;

                foreach (var letter in letters)
                {
                    name += letter;
                }

                if (racers.ContainsKey(name))
                {
                    MatchCollection digits = Regex.Matches(currentRacer, digitsPattern);
                    int distance = 0;

                    foreach (var digit in digits)
                    {
                        distance += int.Parse(digit.ToString());
                    }

                    racers[name] += distance;
                }
            }

            racers = racers
                .OrderByDescending(kvp => kvp.Value)
                .Take(3)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            string place = "1st";

            foreach (var racer in racers)
            {
                Console.WriteLine($"{place} place: {racer.Key}");

                if (place == "1st")
                {
                    place = "2nd";
                }
                else if (place == "2nd")
                {
                    place = "3rd";
                }
            }
        }
    }
}
