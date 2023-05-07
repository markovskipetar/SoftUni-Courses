using System;
using System.Linq;
using System.Net.Sockets;
using System.Xml;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringSequencesCount = int.Parse(Console.ReadLine());

            int[] stringSums = new int[stringSequencesCount];

            char[] vowels = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < stringSequencesCount; i++)
            {
                string currentString = Console.ReadLine();

                int currentStringSum = 0;

                for (int j = 0; j < currentString.Length; j++)
                {
                    char currentDigit = currentString[j];
                    int currentDigitAscii = currentDigit;

                    if (vowels.Contains(currentDigit))
                    {
                        currentStringSum += currentDigitAscii * currentString.Length;
                    }
                    else
                    {
                        currentStringSum += currentDigitAscii / currentString.Length;
                    }
                }

                stringSums[i] = currentStringSum;
            }

            for (int i = 0; i < stringSums.Length - 1; i++)
            {
                for (int j = 0; j < stringSums.Length - 1; j++)
                {
                    if (stringSums[j] > stringSums[j + 1])
                    {
                        int swapVar = stringSums[j];
                        stringSums[j] = stringSums[j + 1];
                        stringSums[j + 1] = swapVar;
                    }
                }
            }

            for (int i = 0; i < stringSums.Length; i++)
            {
                Console.WriteLine(stringSums[i]);
            }
        }
    }
}
