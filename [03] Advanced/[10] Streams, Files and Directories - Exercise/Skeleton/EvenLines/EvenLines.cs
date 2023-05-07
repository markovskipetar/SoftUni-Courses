namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using var reader = new StreamReader(inputFilePath);

            char[] symbols = { '-', ',', '.', '!', '?' };

            int lineNumber = 0;

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (lineNumber++ % 2 == 0)
                {
                    line = ReplaceSymbols(symbols, '@', line);
                    sb.AppendLine(line);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string ReplaceSymbols(char[] symbolsToReplace, char replacer, string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (symbolsToReplace.Contains(currentSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(text[i]);
                }
            }

            List<string> words = sb.ToString().Split().ToList();
            words.Reverse();

            return String.Join(" ", words);
        }
    }
}
