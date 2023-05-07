namespace AnonymousThreat
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<string> textInput = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] commandsInput = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = commandsInput[0];

                if (command == "3:1")
                {
                    break;
                }

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandsInput[1]);
                    int endIndex = int.Parse(commandsInput[2]);

                    MergeCommand(startIndex, endIndex, textInput);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandsInput[1]);
                    int partitions = int.Parse(commandsInput[2]);

                    DivideCommand(index, partitions, textInput);
                }
            }

            Console.WriteLine(String.Join(" ", textInput));
        }

        static void DivideCommand(int index, int partitions, List<string> textInput)
        {
            string elementToDivide = textInput[index];

            int equalPartsLength = elementToDivide.Length / partitions;
            int lastElementAdditionalParts = elementToDivide.Length % partitions;

            string[] partsOfDividedElement = new string[partitions];
            int substringIndex = 0;

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    partsOfDividedElement[i] = elementToDivide.Substring(substringIndex, equalPartsLength + lastElementAdditionalParts);
                }
                else
                {
                    partsOfDividedElement[i] = elementToDivide.Substring(substringIndex, equalPartsLength);
                    substringIndex += equalPartsLength;
                }
            }

            textInput.RemoveAt(index);
            textInput.InsertRange(index, partsOfDividedElement);
        }

        static void MergeCommand(int startIndex, int endIndex, List<string> textInput)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= textInput.Count)
            {
                endIndex = textInput.Count - 1;
            }

            int couter = endIndex - startIndex;

            for (int i = 0; i < couter; i++)
            {
                textInput[startIndex] += textInput[startIndex + 1];
                textInput.RemoveAt(startIndex + 1);
            }
        }
    }
}
