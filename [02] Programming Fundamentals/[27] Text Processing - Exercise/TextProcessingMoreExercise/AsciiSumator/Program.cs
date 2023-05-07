namespace AsciiSumator
{
    using System;

    class Program
    {
        static void Main()
        {
            char leftBorder = char.Parse(Console.ReadLine());
            char rightBorder = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            if (leftBorder > rightBorder)
            {
                char swap = rightBorder;

                rightBorder = leftBorder;
                leftBorder = swap;
            }

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (leftBorder < currentSymbol && currentSymbol < rightBorder)
                {
                    sum += currentSymbol;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
