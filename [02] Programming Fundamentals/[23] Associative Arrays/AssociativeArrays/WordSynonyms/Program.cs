namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int pairsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < pairsCount; i++)
            {
                string currentWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(currentWord))
                {
                    words[currentWord] = new List<string>();
                }

                words[currentWord].Add(synonym);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
