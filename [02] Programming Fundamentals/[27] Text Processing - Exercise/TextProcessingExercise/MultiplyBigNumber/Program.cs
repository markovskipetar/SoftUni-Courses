namespace MultiplyBigNumber
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string numberAsText = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = numberAsText.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(numberAsText[i].ToString());

                int sum = currentDigit * multiplier + remainder;

                int resultNum = sum % 10;
                remainder = sum / 10;

                sb.Insert(0, resultNum);
            }

            if (remainder != 0)
            {
                sb.Insert(0, remainder);
            }

            string result = sb.ToString().TrimStart('0');

            if (result.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
