namespace StarEnigma
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            Regex lettersRegex = new Regex(@"[STARstar]");
            Regex planetRegex = new Regex(@"@(?<name>[A-Za-z]+)[^\@\-!:>]*:(?<population>[0-9]+)[^\@\-!:>]*!(?<attackType>A|D)![^\@\-!:>]*->(?<soldierCount>[0-9]+)");

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string encryptedMessage = Console.ReadLine();

                MatchCollection starLettersMatches = lettersRegex.Matches(encryptedMessage);
                int matchesCount = starLettersMatches.Count;

                string decryptedMessage = string.Empty;

                foreach (var symbol in encryptedMessage)
                {
                    decryptedMessage += (char)(symbol - matchesCount);
                }

                Match planet = planetRegex.Match(decryptedMessage);

                if (planet.Success)
                {
                    string name = planet.Groups["name"].Value;
                    string attackType = planet.Groups["attackType"].Value;

                    if (attackType=="A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
