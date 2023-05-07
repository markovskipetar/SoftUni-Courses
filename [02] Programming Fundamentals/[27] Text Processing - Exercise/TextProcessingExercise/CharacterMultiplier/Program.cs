namespace CharacterMultiplier
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string firstText = input[0];
            string secondText = input[1];

            int sum = 0;

            string shorterWord = firstText;
            string longerWord = secondText;

            if (firstText.Length > secondText.Length)
            {
                shorterWord = secondText;
                longerWord = firstText;
            }

            for (int i = 0; i < shorterWord.Length; i++)
            {
                int firstTextSymbol = shorterWord[i];
                int secondTextSymbol = longerWord[i];

                sum += firstTextSymbol * secondTextSymbol;
            }

            for (int j = shorterWord.Length; j < longerWord.Length; j++)
            {
                int currentSymbol = longerWord[j];

                sum += currentSymbol;
            }

            Console.WriteLine(sum);
        }
    }
}
