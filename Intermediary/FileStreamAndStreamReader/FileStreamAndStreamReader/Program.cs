using System;
using System.IO;


namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JULIAN~1.SAN\AppData\Local\Temp\File1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine($"An error accurred: {e.Message}");
            }
            finally
            {
                if( sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
