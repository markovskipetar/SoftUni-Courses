using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int printNumber = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{printNumber} ");
                }
                printNumber++;
                Console.WriteLine();
            }
        }
    }
}
