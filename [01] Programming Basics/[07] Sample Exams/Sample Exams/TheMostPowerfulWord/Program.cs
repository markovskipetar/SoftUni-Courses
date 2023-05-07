using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string powerfulWord = String.Empty;
            double points = 0;

            while (true)
            {
                string word = Console.ReadLine();

                if (word == "End of words")
                {
                    break;
                }

                double currentWordASCIISum = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    currentWordASCIISum += word[i];
                }

                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' ||
                    word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    currentWordASCIISum *= word.Length;
                }
                else
                {
                    currentWordASCIISum = Math.Floor(currentWordASCIISum / word.Length);
                }

                if (currentWordASCIISum > points)
                {
                    points = currentWordASCIISum;
                    powerfulWord = word;
                }
            }
            Console.WriteLine($"The most powerful word is {powerfulWord} - {points}");
        }
    }
}
