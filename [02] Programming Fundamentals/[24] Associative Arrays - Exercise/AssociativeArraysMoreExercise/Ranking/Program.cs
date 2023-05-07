namespace Ranking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (true)
            {
                string[] contestInfo = Console.ReadLine().Split(":").ToArray();

                if (contestInfo[0] == "end of contests")
                {
                    break;
                }

                string name = contestInfo[0];
                string password = contestInfo[1];

                contests[name] = password;
            }

            Dictionary<string, User> users = new Dictionary<string, User>();

            while (true)
            {
                string[] submissionInfo = Console.ReadLine().Split("=>").ToArray();

                if (submissionInfo[0] == "end of submissions")
                {
                    break;
                }

                string currentContest = submissionInfo[0];
                string currentPassword = submissionInfo[1];
                string username = submissionInfo[2];
                int currentPoints = int.Parse(submissionInfo[3]);

                bool isCurrentContestValid = contests.ContainsKey(currentContest);

                if (isCurrentContestValid)
                {
                    bool isCurrentPasswordValid = contests[currentContest] == currentPassword;

                    if (isCurrentPasswordValid)
                    {
                        if (!users.ContainsKey(username))
                        {
                            users[username] = new User();
                        }

                        if (!users[username].Contests.ContainsKey(currentContest))
                        {
                            users[username].Contests[currentContest] = 0;
                        }

                        if (currentPoints > users[username].Contests[currentContest])
                        {
                            users[username].Contests[currentContest] = currentPoints;
                        }
                    }
                }
            }

            string winnerName = string.Empty;
            int winnerPoints = 0;

            foreach (var kvp in users)
            {
                kvp.Value.GetTotalPoints();

                if (kvp.Value.TotalPoints > winnerPoints)
                {
                    winnerPoints = kvp.Value.TotalPoints;
                    winnerName = kvp.Key;
                }

                kvp.Value.Sort();
            }

            Console.WriteLine($"Best candidate is {winnerName} with total {winnerPoints} points.");

            users = users
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine("Ranking:");

            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var item in kvp.Value.Contests)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
