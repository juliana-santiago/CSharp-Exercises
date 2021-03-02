using InterfaceIComparableExample.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\juliana.santiago\Desktop\myFolder\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee employee in list)
                    {
                        Console.WriteLine(employee);
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
