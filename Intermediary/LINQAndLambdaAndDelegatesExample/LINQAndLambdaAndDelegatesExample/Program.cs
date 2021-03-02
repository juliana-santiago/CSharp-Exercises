using LINQAndLambdaAndDelegatesExample.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LINQAndLambdaAndDelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        var price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                    }
                } 
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0). Average();
            Console.WriteLine($"Average price: {avg.ToString("F2",CultureInfo.InvariantCulture)}");

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
