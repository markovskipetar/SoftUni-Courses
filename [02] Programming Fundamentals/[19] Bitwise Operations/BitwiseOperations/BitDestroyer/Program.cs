namespace BitDestroyer
{
    using System;

    public class Program
    {
        static void Main()
        {
            int numberInDec = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            string numberInBin = String.Empty;

            while (numberInDec > 0)
            {
                int remainder = numberInDec % 2;

                numberInBin = remainder.ToString() + numberInBin;

                numberInDec /= 2;
            }
            
            string newNumber = String.Empty;

            for (int i = 0; i < numberInBin.Length; i++)
            {
                char currentDigit = numberInBin[numberInBin.Length - i - 1];

                if (i == position)
                {
                    if (currentDigit == '0')
                    {
                        currentDigit = '1';
                    }
                    else
                    {
                        currentDigit = '0';
                    }
                }

                newNumber = currentDigit + newNumber;
            }

            Console.WriteLine(Convert.ToInt32(newNumber, 2));
        }
    }
}
