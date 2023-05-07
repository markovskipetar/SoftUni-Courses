using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            char lastDigit = (char)(number + 97 - 1);

            for (char i = 'a'; i <= lastDigit; i++)
            {
                for (char j = 'a'; j <= lastDigit; j++)
                {
                    for (char k = 'a'; k <= lastDigit; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
