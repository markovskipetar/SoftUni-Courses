namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] firstInput = File.ReadAllLines(firstInputFilePath);
            string[] secondInput = File.ReadAllLines(secondInputFilePath);

            int shorterLastIndex = Math.Min(firstInput.Length, secondInput.Length);

            string[] mergedInput = new string[firstInput.Length + secondInput.Length];
            int index = 0;

            for (int i = 0; i < shorterLastIndex; i++)
            {
                mergedInput[index++] = firstInput[i];
                mergedInput[index++] = secondInput[i];
            }

            if (firstInput.Length != secondInput.Length)
            {
                int lastIndex = Math.Max(firstInput.Length, secondInput.Length);
                string[] remaining = null;

                if (firstInput.Length > secondInput.Length)
                {
                    remaining = firstInput;
                }
                else
                {
                    remaining = secondInput;
                }

                int startIndex = lastIndex - shorterLastIndex;

                for (int i = startIndex; i < lastIndex; i++)
                {
                    mergedInput[index++] = remaining[i];
                }
            }

            Console.WriteLine(String.Join(" ", mergedInput));
        }
    }
}
