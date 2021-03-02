using System;
using System.IO;

namespace DirectoryAndDirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\juliana.santiago\Desktop\myFolder";

            try
            {
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(@$"{path}\newFolder");

                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFOLDERS:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
