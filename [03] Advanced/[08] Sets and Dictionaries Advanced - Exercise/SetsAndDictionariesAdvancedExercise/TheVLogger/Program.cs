namespace TheVLogger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            var vloggerFollowers = new Dictionary<string, HashSet<string>>();
            var vloggerFollowing = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Statistics")
                {
                    break;
                }

                string command = input[1];

                if (command == "joined")
                {
                    string vlogger = input[0];

                    if (!vloggerFollowers.ContainsKey(vlogger))
                    {
                        vloggerFollowers[vlogger] = new HashSet<string>();
                    }

                    if (!vloggerFollowing.ContainsKey(vlogger))
                    {
                        vloggerFollowing[vlogger] = new HashSet<string>();
                    }
                }
                else if (command == "followed")
                {
                    string vlogger = input[0];
                    string followedVloger = input[2];

                    bool areBothExsiting = vloggerFollowing.ContainsKey(vlogger) && vloggerFollowing.ContainsKey(followedVloger);
                    bool areBothSameVloggers = vlogger == followedVloger;

                    if (areBothExsiting && !areBothSameVloggers)
                    {
                        if (!vloggerFollowing[vlogger].Contains(followedVloger))
                        {
                            vloggerFollowing[vlogger].Add(followedVloger);
                            vloggerFollowers[followedVloger].Add(vlogger);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerFollowers.Count} vloggers in its logs.");

            vloggerFollowers = vloggerFollowers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => vloggerFollowing[x.Key].Count)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            int count = 0;

            foreach (var vlogger in vloggerFollowers)
            {
                string name = vlogger.Key;
                int followers = vlogger.Value.Count;
                int following = vloggerFollowing[name].Count;

                Console.WriteLine($"{++count}. {name} : {followers} followers, {following} following");

                if (count == 1)
                {
                    foreach (var follower in vloggerFollowers[name].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
