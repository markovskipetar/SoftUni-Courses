﻿namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"copyMe.png";
            string zipArchiveFile = @"copied.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            //var fileNameOnly = Path.GetFileName(inputFile);
            //ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using ZipArchive zip = ZipFile.Open("archived.zip", ZipArchiveMode.Create);

            zip.CreateEntryFromFile(inputFilePath, zipArchiveFilePath);
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
