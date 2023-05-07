namespace BitAtPositionOne
{
    using System;

    public class Program
    {
        static void Main()
        {
            int numberInDec = int.Parse(Console.ReadLine());
            string numberInBin = String.Empty;

            while (numberInDec > 0)
            {
                int remainder = numberInDec % 2;

                numberInBin = remainder.ToString() + numberInBin;

                numberInDec /= 2;
            }

            char bitAtPositionOne = numberInBin[numberInBin.Length - 2];

            Console.WriteLine(bitAtPositionOne);
        }
    }
}
