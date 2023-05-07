using System;
using System.Runtime.InteropServices;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int symbolsCount = int.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < symbolsCount; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());

                char messageChar = (char)((int)currentSymbol + key);

                message += messageChar;
            }

            Console.WriteLine(message);
        }
    }
}
