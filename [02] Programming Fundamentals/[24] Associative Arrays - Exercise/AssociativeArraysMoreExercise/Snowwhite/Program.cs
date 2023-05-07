namespace Snowwhite
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" <:> ").ToArray();

                if (input[0] == "Once upon a time")
                {
                    break;
                }

                string dwarfName = input[0];
                string dwarfHatColor = input[1];
                int dwarfPhysics = int.Parse(input[2]);

                if (!dwarfs.ContainsKey(dwarfHatColor))
                {
                    dwarfs[dwarfHatColor] = new Dictionary<string, int>();

                    dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                }
                else
                {

                    if (!dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                    else
                    {
                        int requiredDwarfPhysics = dwarfs[dwarfHatColor][dwarfName];

                        if (dwarfPhysics > requiredDwarfPhysics)
                        {
                            dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                    }
                }
            }

            Dictionary<int, Dictionary<string, List<string>>> a = new Dictionary<int, Dictionary<string, List<string>>>();

            foreach (var kvp in dwarfs)
            {
                string hatColor = kvp.Key;

                var b = kvp.Value;

                foreach (var item in b)
                {
                    string name = item.Key;
                    int power = item.Value;

                    if (!a.ContainsKey(power))
                    {
                        a[power] = new Dictionary<string, List<string>>();
                        a[power][hatColor] = new List<string>();
                    }

                    if (!a[power].ContainsKey(hatColor))
                    {
                        a[power][hatColor] = new List<string>();
                    }

                    a[power][hatColor].Add(name);
                }
            }


            //Dictionary<int, Dictionary<string, List<string>>>
            a = a
                .OrderByDescending(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in a)
            {
                int power = kvp.Key;

                Dictionary<string, List<string>> asd = kvp.Value;
                asd=asd.OrderByDescending(kvp => kvp.Value.Count).ToDictionary(kvp => kvp.Key, kvp => kvp.Value); ;

                foreach (var kvp2 in asd)
                {
                    string hatColor = kvp2.Key;

                    for (int i = 0; i < kvp2.Value.Count; i++)
                    {
                        Console.WriteLine($"({kvp2.Key}) {kvp2.Value[i]} <-> {power}");
                    }
                }
            }
        }
    }
}
