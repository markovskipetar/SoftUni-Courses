namespace MorseCodeTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string[] morseSymbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, char> morseToLetter = new Dictionary<string, char>()
            {
                {".-", 'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'},
                {".",'E'},
                {"..-.",'F'},
                {"--.",'G'},
                {"....",'H'},
                {"..",'I'},
                {".---",'J'},
                {"-.-",'K'},
                {".-..",'L'},
                {"--",'M'},
                {"-.",'N'},
                {"---",'O'},
                {".--.",'P'},
                {"--.-",'Q'},
                {".-.",'R'},
                {"...",'S'},
                {"-",'T'},
                {"..-",'U'},
                {"...-",'V'},
                {".--",'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                {"--..",'Z'}
            };

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < morseSymbols.Length; i++)
            {
                string currentSymbol = morseSymbols[i];

                if (currentSymbol == "|")
                {
                    sb.Append(" ");
                }
                else
                {
                    char letter = morseToLetter[currentSymbol];
                    sb.Append(letter);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
