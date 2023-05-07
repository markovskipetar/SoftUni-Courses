namespace OddOccurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                string wordToLower = word.ToLower();

                if (!words.ContainsKey(wordToLower))
                {
                    words[wordToLower] = 0;
                }

                words[wordToLower]++;
            }

            List<string> result = words
                .Where(kvp => kvp.Value % 2 == 1)
                .Select(kvp => kvp.Key)
                .ToList();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
