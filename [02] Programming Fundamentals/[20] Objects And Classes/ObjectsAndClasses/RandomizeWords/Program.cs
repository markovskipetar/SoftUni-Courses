namespace RandomizeWords
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<string> inputWords = Console.ReadLine()
                .Split()
                .ToList();

            Random random = new Random();

            for (int i = 0; i < inputWords.Count; i++)
            {
                int randomIndex = random.Next(0, inputWords.Count);

                string randomWord = inputWords[randomIndex];

                inputWords[randomIndex] = inputWords[i];
                inputWords[i] = randomWord;
            }

            Console.WriteLine(String.Join("\n", inputWords));
        }
    }
}
