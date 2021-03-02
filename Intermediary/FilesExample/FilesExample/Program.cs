using System;
using System.IO;

namespace FilesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\JULIAN~1.SAN\AppData\Local\Temp\File1.txt";
            string targetPath = @"C:\Users\JULIAN~1.SAN\AppData\Local\Temp\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
