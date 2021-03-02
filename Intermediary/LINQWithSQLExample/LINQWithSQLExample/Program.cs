﻿using LINQWithSQLExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQWithSQLExample
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900: ", r1);

            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2);

            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", r3);

            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER ORDER BY PRICE THEN BY NAME: ", r4);

            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

            var r6 = (from p in products select p).FirstOrDefault();
            Console.WriteLine($"First Or Default test1: {r6}");

            var r7 = (from p in products where p.Price > 3000.0 select p).FirstOrDefault();
            Console.WriteLine($"First Or Default test1: {r7}\n");

            var r8 = (from p in products where p.Id == 3 select p).SingleOrDefault();
            Console.WriteLine($"Single Or Default test1: {r8}");

            var r9 = (from p in products where p.Id == 30 select p).SingleOrDefault();
            Console.WriteLine($"Single Or Default test2: {r9}\n");

            var r10 = (from p in products select p).Max(p => p.Price);
            Console.WriteLine($"Max Price: {r10}");
            var r11 = (from p in products select p).Min(p => p.Price);
            Console.WriteLine($"Min Price: {r11}");
            var r12 = (from p in products where p.Category.Id == 1 select p).Sum(p => p.Price);
            Console.WriteLine($"Category 1 Sum Prices: {r12}");
            var r13 = (from p in products where p.Category.Id == 1 select p).Average(p => p.Price);
            Console.WriteLine($"Category 1 Average Prices: {r13}");
            var r14 = (from p in products where p.Category.Id == 1 select p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 Average Prices: {r14}");
            var r15 = (from p in products where p.Category.Id == 1 select p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Category 1 aggregate sum: {r15}\n");


            var r16 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category {group.Key.Name}: ");
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
