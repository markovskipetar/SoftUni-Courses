namespace LettersChangeNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentSequence = input[i];

                char leftLetter = currentSequence[0];
                char rightLetter = currentSequence[currentSequence.Length - 1];

                double number = double.Parse(currentSequence.Substring(1, currentSequence.Length - 2));

                int letterPosition = 0;

                if ('A' <= leftLetter && leftLetter <= 'Z')
                {
                    letterPosition = (leftLetter - 'A') + 1;

                    number /= letterPosition;
                }
                else
                {
                    letterPosition = (leftLetter - 'a') + 1;

                    number *= letterPosition;
                }

                if ('A' <= rightLetter && rightLetter <= 'Z')
                {
                    letterPosition = (rightLetter - 'A') + 1;

                    number -= letterPosition;
                }
                else
                {
                    letterPosition = (rightLetter - 'a') + 1;

                    number += letterPosition;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
