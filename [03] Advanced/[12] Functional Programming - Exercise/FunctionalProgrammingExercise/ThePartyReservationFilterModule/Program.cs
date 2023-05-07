namespace ThePartyReservationFilterModule
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ');

            List<string> filters = new List<string>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Print")
                {
                    break;
                }

                string[] input = inputLine.Split(';');

                string command = input[0];
                string type = input[1];
                string parametar = input[2];

                if (command == "Add filter")
                {
                    filters.Add(inputLine);
                }
                else if (command == "Remove filter")
                {
                    filters.Remove($"Add filter;{type};{parametar}");
                }
            }

            for (int i = 0; i < filters.Count; i++)
            {
                string[] input = filters[i].Split(';');

                string type = input[1];
                string parameter = input[2];

                Func<string, bool> filter = type switch
                {
                    "Starts with" => word => !word.StartsWith(parameter),
                    "Ends with" => word => !word.EndsWith(parameter),
                    "Length" => word => word.Length != int.Parse(parameter),
                    "Contains" => word => !word.Contains(parameter),
                };

                names = names.Where(filter).ToArray();
            }

            Console.WriteLine(String.Join(" ", names));
        }
    }
}
