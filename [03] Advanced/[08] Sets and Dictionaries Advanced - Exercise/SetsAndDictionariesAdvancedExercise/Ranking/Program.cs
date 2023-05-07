namespace Ranking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            var contests = new Dictionary<string, string>();

            while (true)
            {
                string[] contestInfo = Console.ReadLine().Split(':');

                if (contestInfo[0] == "end of contests")
                {
                    break;
                }

                string contestName = contestInfo[0];
                string contestPassword = contestInfo[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = contestPassword;
                }
            }

            var usersContests = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("=>");

                if (input[0] == "end of submissions")
                {
                    break;
                }

                string contest = input[0];
                string password = input[1];
                string user = input[2];
                int points = int.Parse(input[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!usersContests.ContainsKey(user))
                    {
                        usersContests[user] = new Dictionary<string, int>();
                    }

                    if (!usersContests[user].ContainsKey(contest))
                    {
                        usersContests[user][contest] = points;
                    }
                    else
                    {
                        if (points > usersContests[user][contest])
                        {
                            usersContests[user][contest] = points;
                        }
                    }
                }
            }

            var best = usersContests
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .First();

            string bestName = best.Key;
            int bestPoints = best.Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestName} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            usersContests = usersContests
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var pair in usersContests)
            {
                Console.WriteLine(pair.Key);

                var resultDict = pair.Value.OrderByDescending(x => x.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                foreach (var contest in resultDict)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
