namespace ExtractSpecialBytes
{
    using System;
    using System.Text;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytesBin = File.ReadAllBytes(binaryFilePath);
            byte[] bytesArr = File.ReadAllBytes(bytesFilePath);
            List<>


            StringBuilder sb = new StringBuilder();

            foreach (var currByte in bytes)
            {
                for (int i = 0; i < bytesBin.Length; i++)
                {
                    if (bytesBin[i] == currByte)
                    {
                        sb.AppendLine()
                        break;
                    }
                }
            }
        }
    }
}
