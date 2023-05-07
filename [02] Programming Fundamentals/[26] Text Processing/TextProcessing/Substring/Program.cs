namespace Substring
{
    using System;

    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            while (true)
            {
                int index = word.IndexOf(pattern);

                if (index == -1)
                {
                    break;
                }

                word = word.Remove(index, pattern.Length);
            }

            Console.WriteLine(word);
        }
    }
}
