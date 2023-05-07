namespace RepeatStrings
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    result += currentWord;
                }
            }

            Console.WriteLine(result);
        }
    }
}
