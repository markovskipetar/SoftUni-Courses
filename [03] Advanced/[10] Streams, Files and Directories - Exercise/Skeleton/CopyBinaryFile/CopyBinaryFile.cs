namespace CopyBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream reader = new FileStream(inputFilePath, FileMode.Open);
            using FileStream writer = new FileStream(outputFilePath, FileMode.CreateNew);

            byte[] buffer = new byte[1024];

            while (true)
            {
                int bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesRead)
                        .ToArray();

                    writer.Write(buffer, 0, buffer.Length);

                    break;
                }

                writer.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
