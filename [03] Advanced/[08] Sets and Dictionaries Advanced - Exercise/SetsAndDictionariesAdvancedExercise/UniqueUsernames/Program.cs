namespace UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int namesCount = int.Parse(Console.ReadLine());

            HashSet<string> uniqeNames = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();

                uniqeNames.Add(name);
            }

            foreach (var name in uniqeNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
