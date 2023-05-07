using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result += (char)((int)input[i] + 3);
            }

            Console.WriteLine(result);
        }
    }
}
