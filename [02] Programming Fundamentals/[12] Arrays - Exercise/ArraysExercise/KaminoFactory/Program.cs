using System;
using System.Linq;
using System.IO;

namespace _09.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            string bestDNA = string.Empty;
            int bestLength = -1;
            int bestIndex = -1;
            int bestSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentMaxLength = 0;
                int maxStartIndex = 0;

                int currentDNALength = 0;
                int lastIndex = 0;

                int currentSum = currentDNA.Sum();


                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentDNALength++;

                        lastIndex = i;

                        if (currentDNALength > currentMaxLength)
                        {
                            currentMaxLength = currentDNALength;

                            maxStartIndex = lastIndex - currentMaxLength + 1;
                        }
                    }
                    else
                    {
                        currentDNALength = 0;
                    }
                }

                bool isCurrentDNABetter = false;

                if (currentMaxLength > bestLength)
                {
                    isCurrentDNABetter = true;
                }
                else if (currentMaxLength == bestLength)
                {
                    if (maxStartIndex < bestIndex)
                    {
                        isCurrentDNABetter = true;
                    }
                    else if (maxStartIndex == bestIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            isCurrentDNABetter = true;
                        }
                    }
                }

                if (isCurrentDNABetter)
                {
                    bestDNA = input;
                    bestLength = currentMaxLength;
                    bestIndex = maxStartIndex;
                    bestSum = currentSum;
                }
            }

            int[] result = bestDNA.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (bestLength == 0)
            {
                Console.WriteLine($"Best DNA sample {1} with sum: {bestSum}.");
            }
            else
            {
                Console.WriteLine($"Best DNA sample {bestIndex + 1} with sum: {bestSum}.");
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}