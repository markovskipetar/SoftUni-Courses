namespace BinaryDigitsCount
{
    using System;

    public class Program
    {
        static void Main()
        {
            int numberInDec = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int countOfDigit = 0;

            while (numberInDec > 0)
            {
                int remainder = numberInDec % 2;

                if (remainder == digit)
                {
                    countOfDigit++;
                }

                numberInDec /= 2;
            }

            Console.WriteLine(countOfDigit);
        }
    }
}
