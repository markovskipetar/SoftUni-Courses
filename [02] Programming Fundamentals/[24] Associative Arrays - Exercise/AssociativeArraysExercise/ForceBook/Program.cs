namespace ForceBook
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains("|"))
                {
                    string[] commandInfo = input.Split(" | ").ToArray();

                    string forceSide = commandInfo[0];
                    string forceUser = commandInfo[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook[forceSide] = new List<string>();
                    }

                    bool doesForceUserExist = false;

                    foreach (var kvp in forceBook)
                    {
                        List<string> currentForceSideUsers = kvp.Value;

                        if (currentForceSideUsers.Contains(forceUser))
                        {
                            doesForceUserExist = true;
                            break;
                        }
                    }

                    if (!doesForceUserExist)
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] commandInfo = input.Split(" -> ").ToArray();

                    string forceUser = commandInfo[0];
                    string forceSide = commandInfo[1];

                    bool doesForceUserExist = false;
                    string currentForceUserSide = String.Empty;

                    foreach (var kvp in forceBook)
                    {
                        List<string> currentForceSideUsers = kvp.Value;

                        if (currentForceSideUsers.Contains(forceUser))
                        {
                            doesForceUserExist = true;
                            currentForceUserSide = kvp.Key;
                            break;
                        }
                    }

                    if (doesForceUserExist)
                    {
                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook[forceSide] = new List<string>();
                        }

                        forceBook[currentForceUserSide].Remove(forceUser);

                        forceBook[forceSide].Add(forceUser);
                    }
                    else
                    {
                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook[forceSide] = new List<string>();
                        }

                        forceBook[forceSide].Add(forceUser);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            forceBook = forceBook
                .Where(kvp => kvp.Value.Count > 0)
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in forceBook)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var forceUser in kvp.Value)
                {
                    Console.WriteLine($"! {forceUser}");
                }
            }
        }
    }
}
