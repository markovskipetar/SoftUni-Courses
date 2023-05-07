using System;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol > lastSymbol)
            {
                PrintSymbols(lastSymbol, firstSymbol);
            }
            else
            {
                PrintSymbols(firstSymbol, lastSymbol);
            }

        }

        static void PrintSymbols(char firstSymbol, char lastSymbol)
        {
            firstSymbol++;

            for (char i = firstSymbol; i < lastSymbol; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
