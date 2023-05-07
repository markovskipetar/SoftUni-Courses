using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= endNumber; i++)
            {
                char currentSymbol = (char)i;

                Console.Write($"{currentSymbol} ");
            }
            Console.WriteLine();
        }
    }
}
