namespace ExtractFile
{
    using System;

    class Program
    {
        static void Main()
        {
            string filePath = Console.ReadLine();

            int index = filePath.LastIndexOf('\\');

            string file = filePath.Substring(index + 1);
            int dotIndex = file.IndexOf('.');

            string extension = file.Substring(dotIndex + 1);
            string fileName = file.Substring(0, (dotIndex));

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
