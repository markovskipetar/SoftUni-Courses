using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacters(input);
        }

        static void PrintMiddleCharacters(string input)
        {
            int inputLength = input.Length;

            if (inputLength % 2 == 0)
            {
                char firstMiddleCharacter = input[(inputLength - 1) / 2];
                char secondMiddleCharacter = input[inputLength / 2];

                Console.WriteLine($"{firstMiddleCharacter}{secondMiddleCharacter}");
            }
            else
            {
                char middleCharacter = input[inputLength / 2];

                Console.WriteLine($"{middleCharacter}");
            }
        }
    }
}
