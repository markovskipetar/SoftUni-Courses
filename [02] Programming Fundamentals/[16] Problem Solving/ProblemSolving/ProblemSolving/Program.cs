namespace ProblemSolving
{
    using System;

    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int result = GetSubPalindrome(input);

            Console.WriteLine(result);
        }

        static int GetSubPalindrome(string input)
        {
            int maxOddLengthPalindrome = GetLongestOddLengthSubPalindrome(input);
            int maxEvenLengthPalindrome = GetLongestEvenLengthSubPalindrome(input);


            if (maxOddLengthPalindrome > maxEvenLengthPalindrome)
            {
                return maxOddLengthPalindrome;
            }

            return maxEvenLengthPalindrome;
        }

        static int GetLongestOddLengthSubPalindrome(string input)
        {
            int maxLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int longestPalindromeWithCurrentLetter = CheckForSubPalindrome(input, i);

                if (longestPalindromeWithCurrentLetter > maxLength)
                {
                    maxLength = longestPalindromeWithCurrentLetter;
                }
            }

            return maxLength;
        }

        static int GetLongestEvenLengthSubPalindrome(string input)
        {
            int maxLength = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                char currentLetter = input[i];
                char nextLetter = input[i + 1];

                if (currentLetter == nextLetter)
                {
                    int longestPalindromeWithCurrentLetter = CheckForSubPalindrome(input, i, i + 1);

                    if (longestPalindromeWithCurrentLetter > maxLength)
                    {
                        maxLength = longestPalindromeWithCurrentLetter;
                    }
                }
            }

            return maxLength;
        }

        static int CheckForSubPalindrome(string input, int currentIndex)
        {
            int previousIndex = currentIndex - 1;
            int nextIndex = currentIndex + 1;

            int maxLength = 1;

            while (true)
            {
                if (previousIndex < 0 || nextIndex >= input.Length)
                {
                    break;
                }

                char leftLetter = input[previousIndex];
                char rightLetter = input[nextIndex];

                if (leftLetter == rightLetter)
                {
                    maxLength += 2;
                }
                else
                {
                    break;
                }

                previousIndex--;
                nextIndex++;
            }

            return maxLength;
        }

        static int CheckForSubPalindrome(string input, int currentIndexLeft, int currentIndexRight)
        {
            int previousIndex = currentIndexLeft - 1;
            int nextIndex = currentIndexRight + 1;

            int maxLength = 2;

            while (true)
            {
                if (previousIndex < 0 || nextIndex >= input.Length)
                {
                    break;
                }

                char leftLetter = input[previousIndex];
                char rightLetter = input[nextIndex];

                if (leftLetter == rightLetter)
                {
                    maxLength += 2;
                }
                else
                {
                    break;
                }

                previousIndex--;
                nextIndex++;
            }

            return maxLength;
        }
    }
}
