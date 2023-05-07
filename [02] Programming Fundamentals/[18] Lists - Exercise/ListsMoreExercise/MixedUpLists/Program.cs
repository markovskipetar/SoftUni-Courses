namespace MixedUpLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            List<int> borders = new List<int>();

            if (firstNumbers.Count > secondNumbers.Count)
            {
                borders.Add(firstNumbers[firstNumbers.Count - 2]);
                borders.Add(firstNumbers[firstNumbers.Count - 1]);
            }
            else
            {
                borders.Add(secondNumbers[0]);
                borders.Add(secondNumbers[1]);
            }

            borders.Sort();

            int leftBorder = borders[0];
            int rightBorder = borders[1];

            List<int> mergedList = MergeLists(firstNumbers, secondNumbers);
            
            PrintNumbers(mergedList, leftBorder, rightBorder);
        }

        static void PrintNumbers(List<int> mergedList, int leftBorder, int rightBorder)
        {
            List<int> resultNumbers = new List<int>();

            for (int i = 0; i < mergedList.Count; i++)
            {
                int currentNumber = mergedList[i];

                if (leftBorder < currentNumber && currentNumber < rightBorder)
                {
                    resultNumbers.Add(currentNumber);
                }
            }

            resultNumbers.Sort();

            Console.WriteLine(String.Join(" ", resultNumbers));
        }

        static List<int> MergeLists(List<int> firstNumbers, List<int> secondNumbers)
        {
            List<int> mergedList = new List<int>();

            int firstListIndex = 0;
            int secondListIndex = secondNumbers.Count - 1;

            for (int i = 0; i < Math.Min(firstNumbers.Count, secondNumbers.Count); i++)
            {
                int firstListNumber = firstNumbers[firstListIndex];
                int secondListNumber = secondNumbers[secondListIndex];

                mergedList.Add(firstListNumber);
                mergedList.Add(secondListNumber);

                firstListIndex++;
                secondListIndex--;
            }

            return mergedList;
        }
    }
}
