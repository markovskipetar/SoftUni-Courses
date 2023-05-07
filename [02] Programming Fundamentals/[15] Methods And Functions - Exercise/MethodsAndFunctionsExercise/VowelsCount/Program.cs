using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToUpper();

            int result = GetVowelsCount(word);

            Console.WriteLine(result);
        }

        static int GetVowelsCount(string word)
        {
            string vowels = "AEIOU";

            int vowelsCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];

                if (vowels.Contains(currentLetter.ToString()))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
