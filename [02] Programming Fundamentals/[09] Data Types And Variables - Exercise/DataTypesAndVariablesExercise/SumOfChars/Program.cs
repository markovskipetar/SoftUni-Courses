using System;
using System.Runtime.InteropServices;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbolsCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < symbolsCount; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());

                sum += currentSymbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
