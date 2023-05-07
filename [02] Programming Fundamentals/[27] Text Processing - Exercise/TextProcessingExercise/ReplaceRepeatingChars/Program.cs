namespace ReplaceRepeatingChars
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (currentSymbol != sb[sb.Length - 1])
                {
                    sb.Append(currentSymbol);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
