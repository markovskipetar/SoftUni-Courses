using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            string result = GetNewRepeatedString(pattern, repeats);

            Console.WriteLine(result);
        }

        static string GetNewRepeatedString(string pattern, int counter)
        {
            string newString = String.Empty;

            for (int i = 0; i < counter; i++)
            {
                newString += pattern;
            }

            return newString;
        }
    }
}
