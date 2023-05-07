namespace TriFunction
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int givenSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            foreach (var name in names)
            {
                int currentNameSum = GetAsciiSum(name);

                if (currentNameSum >= givenSum)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }

        static int GetAsciiSum(string word)
        {
            int sum = 0;

            foreach (var letter in word)
            {
                sum += letter;
            }

            return sum;
        }
    }
}
