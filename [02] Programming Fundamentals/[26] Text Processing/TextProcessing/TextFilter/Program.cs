namespace TextFilter
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string currentBannedWord = bannedWords[i];

                string asterisks = new string('*', currentBannedWord.Length);

                text = text.Replace(currentBannedWord, asterisks);
            }

            Console.WriteLine(text);
        }
    }
}
