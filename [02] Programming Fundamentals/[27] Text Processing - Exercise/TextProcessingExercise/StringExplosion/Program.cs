namespace StringExplosion
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int currentBombIndex = input.IndexOf('>');

            if (currentBombIndex > 0)
            {
                sb.Append(input.Substring(0, currentBombIndex));
            }

            int remainder = 0;

            while (true)
            {
                int nextBombIndex = input.IndexOf('>', currentBombIndex + 1);

                int power = int.Parse(input[currentBombIndex + 1].ToString()) + remainder;
                sb.Append('>');

                if (nextBombIndex == -1)
                {
                    int leftLetters = input.Length - currentBombIndex - 1;

                    if (power < leftLetters)
                    {

                        int startIndex = currentBombIndex + 1 + power;
                        int length = input.Length - startIndex;

                        sb.Append(input.Substring(startIndex, length));
                    }

                    break;
                }

                int difference = nextBombIndex - currentBombIndex - 1;

                if (power < difference)
                {
                    int startIndex = currentBombIndex + 1 + power;
                    int length = nextBombIndex - startIndex;

                    sb.Append(input.Substring(startIndex, length));
                }
                else if (power > difference)
                {
                    remainder = power - difference;
                }

                currentBombIndex = nextBombIndex;
            }

            Console.WriteLine(sb);

        }
    }
}
