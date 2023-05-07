namespace SoftUniExamResults
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> userPoins = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "exam finished")
                {
                    break;
                }

                string name = input[0];
                string language = input[1];

                if (language == "banned")
                {
                    if (userPoins.ContainsKey(name))
                    {
                        userPoins.Remove(name);
                    }
                }
                else
                {
                    int points = int.Parse(input[2]);

                    if (!userPoins.ContainsKey(name))
                    {
                        userPoins[name] = 0;
                    }

                    if (points > userPoins[name])
                    {
                        userPoins[name] = points;
                    }

                    if (!languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions[language] = 0;
                    }

                    languageSubmissions[language]++;
                }
            }

            Console.WriteLine("Results:");

            userPoins = userPoins
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var (user, points) in userPoins)
            {
                Console.WriteLine($"{user} | {points}");
            }

            Console.WriteLine("Submissions:");

            languageSubmissions = languageSubmissions
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var (language, submission) in languageSubmissions)
            {
                Console.WriteLine($"{language} - {submission}");
            }
        }
    }
}
