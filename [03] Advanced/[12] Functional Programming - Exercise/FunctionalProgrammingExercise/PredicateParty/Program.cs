namespace PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Party!")
                {
                    break;
                }

                string command = input[0];
                string action = input[1];
                string argumnet = input[2];

                Predicate<string> validName = IsWordValid(action, argumnet);

                if (command == "Remove")
                {
                    names.RemoveAll(validName);
                }
                else if (command == "Double")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        string name = names[i];

                        if (validName(name))
                        {
                            names.Insert(i + 1, name);
                            i++;
                        }
                    }
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
        }

        static Predicate<string> IsWordValid(string action, string argument)
        {
            Predicate<string> predicate = action switch
            {
                "StartsWith" => w => w.StartsWith(argument),
                "EndsWith" => w => w.EndsWith(argument),
                "Length" => w => w.Length == int.Parse(argument)
            };

            return predicate;
        }
    }
}
