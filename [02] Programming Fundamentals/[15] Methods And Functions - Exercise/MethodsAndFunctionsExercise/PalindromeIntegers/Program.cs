using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                int number = int.Parse(input);

                bool isNumberPalindrome = CheckIfNumberIsPalindrome(number);

                if (isNumberPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }

        static bool CheckIfNumberIsPalindrome(int number)
        {
            string numberAsText = number.ToString();

            for (int i = 0; i < numberAsText.Length / 2; i++)
            {
                if (numberAsText[i] != numberAsText[numberAsText.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
