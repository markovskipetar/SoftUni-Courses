namespace ForceBook
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            var forceBook = new Dictionary<string, HashSet<string>>();
            var users = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains("|"))
                {
                    string[] input = line.Split(" | ");

                    string side = input[0];
                    string user = input[1];

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new HashSet<string>();
                    }

                    if (!users.Contains(user))
                    {
                        users.Add(user);
                        forceBook[side].Add(user);
                    }
                }
                else if (line.Contains("->"))
                {
                    string[] input = line.Split(" -> ");

                    string user = input[0];
                    string side = input[1];

                    if (users.Contains(user))
                    {
                        foreach (var (forceSide, sideUsers) in forceBook)
                        {
                            bool isFound = false;

                            foreach (var currentUser in sideUsers)
                            {
                                if (currentUser == user)
                                {
                                    Console.WriteLine($"{user} joins the {side} side!");

                                    if (!forceBook.ContainsKey(side))
                                    {
                                        forceBook[side] = new HashSet<string>();
                                    }

                                    forceBook[side].Add(user);
                                    forceBook[forceSide].Remove(user);
                                    isFound = true;

                                    break;
                                }
                            }

                            if (isFound)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        users.Add(user);

                        if (!forceBook.ContainsKey(side))
                        {
                            forceBook[side] = new HashSet<string>();
                        }

                        forceBook[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }

            forceBook = forceBook
                .Where(kvp => kvp.Value.Count > 0)
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var (side, forceUsers) in forceBook)
            {
                Console.WriteLine($"Side: {side}, Members: {forceUsers.Count}");

                foreach (var user in forceUsers.OrderBy(x=>x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
