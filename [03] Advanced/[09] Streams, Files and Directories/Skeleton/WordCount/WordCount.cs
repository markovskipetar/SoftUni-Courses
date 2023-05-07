namespace WordCount
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words = File.ReadAllText(wordsFilePath).Split(' ');
            string text = File.ReadAllText(textFilePath).ToLower();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string pattern = $@"\b{word.ToLower()}\b";

                MatchCollection matches = Regex.Matches(text, pattern);

                wordCount[word] = matches.Count;
            }

            using var writer = new StreamWriter(outputFilePath);

            wordCount = wordCount
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in wordCount)
            {
                writer.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
