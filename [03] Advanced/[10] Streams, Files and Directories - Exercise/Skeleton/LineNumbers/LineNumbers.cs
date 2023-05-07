namespace LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        public static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] allLines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < allLines.Length; i++)
            {
                string currentLine = allLines[i];

                //int[] lettersAndPunctiationalMarksCount = GetLettersAndPunctMarsCount(currentLine);

                int lettersCount = 1;/*lettersAndPunctiationalMarksCount[0];*/
                int marksCount = 2;/*lettersAndPunctiationalMarksCount[1];*/

                allLines[i] = $"Line {i + 1}: {currentLine} ({lettersCount})({marksCount})";
            }

            File.WriteAllLines(outputFilePath, allLines);
        }

        //public static int[] GetLettersAndPunctMarsCount(string currentLine)
        //{
        //    int marksCount = 0;
        //    int lettersCount = 0;

        //    for (int i = 0; i < currentLine.Length; i++)
        //    {
        //        if (char.IsPunctuation(currentLine[i]))
        //        {
        //            marksCount++;
        //        }

        //        if (char.IsLetter(currentLine[i]))
        //        {
        //            lettersCount++;
        //        }
        //    }

        //    return new int[] { lettersCount, marksCount };
        //}
    }
}
