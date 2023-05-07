namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            //Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var allFiles = Directory.GetFiles(inputFolderPath);

            return String.Join(Environment.NewLine, allFiles);
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string[] files = textContent.Split(Environment.NewLine);

            var orderedFiles = new Dictionary<string, Dictionary<string, decimal>>();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                string name = fileInfo.Name;
                string extension = fileInfo.Extension;
                decimal size = fileInfo.Length / 1024m;

                if (!orderedFiles.ContainsKey(extension))
                {
                    orderedFiles[extension] = new Dictionary<string, decimal>();
                }

                orderedFiles[extension][name] = size;
            }

            orderedFiles = orderedFiles
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var item in orderedFiles)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var kvp in item.Value.OrderBy(kvp => kvp.Value))
                {
                    Console.WriteLine($"--{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
