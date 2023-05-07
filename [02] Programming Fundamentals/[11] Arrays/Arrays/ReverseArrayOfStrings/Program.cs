using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().Split();

            bool isPalindrome = true;

            for (int i = 0; i < text.Length / 2; i++)
            {
                string leftElement = text[i];
                string rightElement = text[texts.Length - i - 1];

                if (leftElement != rightElement)
                {
                    isPalindrome = false;
                }
            }

            Console.WriteLine(string.Join(" ", texts));
        }
    }
}
