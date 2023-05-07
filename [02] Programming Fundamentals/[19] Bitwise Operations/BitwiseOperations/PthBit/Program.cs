namespace PthBit
{
    using System;

    public class Program
    {
        static void Main()
        {
            int numberInDec = int.Parse(Console.ReadLine());
            int shiftCounter = int.Parse(Console.ReadLine());

            string numberInBinAsText = String.Empty;

            while (numberInDec > 0)
            {
                int remainder = numberInDec % 2;

                numberInBinAsText = remainder.ToString() + numberInBinAsText;

                numberInDec /= 2;
            }

            if (shiftCounter >= numberInBinAsText.Length)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numberInBinAsText[numberInBinAsText.Length - (shiftCounter + 1)]);
            }
        }
    }
}
