using System;
using System.IO;

namespace StreamWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\JULIAN~1.SAN\AppData\Local\Temp\File1.txt";
            string targetPath = @"C:\Users\JULIAN~1.SAN\AppData\Local\Temp\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
