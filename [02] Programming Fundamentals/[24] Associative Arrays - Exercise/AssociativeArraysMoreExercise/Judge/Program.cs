namespace Judge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<User>> contests = new Dictionary<string, List<User>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "no more time")
                {
                    break;
                }

                string currentUsername = input[0];
                string currentContest = input[1];
                int points = int.Parse(input[2]);

                if (!contests.ContainsKey(currentContest))
                {
                    contests[currentContest] = new List<User>();

                    contests[currentContest].Add(new User(currentUsername, points));

                }
                else
                {
                    bool isCurrentUserExisting = false;
                    int currentUserIndex = 0;

                    for (int i = 0; i < contests[currentContest].Count; i++)
                    {
                        if (contests[currentContest][i].Name == currentUsername)
                        {
                            isCurrentUserExisting = true;
                            currentUserIndex = i;
                            break;
                        }
                    }

                    if (isCurrentUserExisting)
                    {
                        User requiredUser = contests[currentContest][currentUserIndex];

                        if (points > requiredUser.Points)
                        {
                            requiredUser.Points = points;
                        }
                    }
                    else
                    {
                        contests[currentContest].Add(new User(currentUsername, points));
                    }
                }
            }

            Dictionary<string, int> personalScores = new Dictionary<string, int>();

            foreach (var kvp in contests)
            {
                string contestName = kvp.Key;
                List<User> contestUsers = kvp.Value;

                contestUsers = contestUsers
                    .OrderByDescending(x => x.Points)
                    .ThenBy(x => x.Name)
                    .ToList();

                Console.WriteLine($"{contestName}: {contestUsers.Count} participants");

                for (int i = 0; i < contestUsers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {contestUsers[i].Name} <::> {contestUsers[i].Points}");

                    if (!personalScores.ContainsKey(contestUsers[i].Name))
                    {
                        personalScores[contestUsers[i].Name] = 0;
                    }

                    personalScores[contestUsers[i].Name] += contestUsers[i].Points;
                }
            }

            Console.WriteLine("Individual standings:");

            int position = 1;

            personalScores = personalScores
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var user in personalScores)
            {
                Console.WriteLine($"{position++}. {user.Key} -> {user.Value}");
            }
        }
    }
}
