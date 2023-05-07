using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            string text = String.Empty;

            text += firstSymbol;
            text += secondSymbol;
            text += thirdSymbol;

            Console.WriteLine(text);
        }
    }
}
