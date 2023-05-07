namespace SoftUniExamResults
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("-").ToArray();

                if (input[0] == "exam finished")
                {
                    break;
                }

                if (input.Length == 3)
                {
                    string username = input[0];
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    if (!users.ContainsKey(username))
                    {
                        users[username] = 0;
                    }

                    if (points > users[username])
                    {
                        users[username] = points;
                    }

                    if (!languages.ContainsKey(language))
                    {
                        languages[language] = 0;
                    }

                    languages[language]++;
                }
                else
                {
                    string username = input[0];

                    users.Remove(username);
                }
            }

            users = users
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            languages = languages
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine("Results:");

            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in languages)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
