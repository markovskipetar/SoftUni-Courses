namespace TreasureFinder
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;

            while (true)
            {
                string inputText = Console.ReadLine();

                if (inputText == "find")
                {
                    break;
                }

                char[] symbols = inputText.ToCharArray();

                for (int i = 0; i < inputText.Length; i++)
                {
                    int number = numbers[index++];

                    symbols[i] = (char)(symbols[i] - number);

                    if (index == numbers.Length)
                    {
                        index = 0;
                    }
                }

                index = 0;

                string result = new string(symbols);

                int treasureLeftIndex = result.IndexOf('&');
                int treasureRightIndex = result.IndexOf('&', treasureLeftIndex + 1);
                int treasureLength = treasureRightIndex - treasureLeftIndex - 1;

                string treasure = result.Substring(treasureLeftIndex + 1, treasureLength);

                int coordinatesLeftIndex = result.IndexOf('<');
                int coordinatesRightIndex = result.IndexOf('>');
                int coordinatesLength = coordinatesRightIndex - coordinatesLeftIndex - 1;

                string coordinates = result.Substring(coordinatesLeftIndex + 1, coordinatesLength);

                Console.WriteLine($"Found {treasure} at {coordinates}");
            }
        }
    }
}
