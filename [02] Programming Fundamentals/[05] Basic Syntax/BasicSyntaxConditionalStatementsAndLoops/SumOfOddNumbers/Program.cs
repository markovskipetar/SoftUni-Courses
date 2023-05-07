using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowLength = int.Parse(Console.ReadLine());

            int currentOdd = 1;
            int sum = 0;

            for (int i = 0; i < rowLength; i++)
            {
                Console.WriteLine(currentOdd);

                sum += currentOdd;
                currentOdd += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
