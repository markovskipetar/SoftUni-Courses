using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PrintLine(i);
            }

            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int lastNumber)
        {
            for (int j = 1; j <= lastNumber; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
