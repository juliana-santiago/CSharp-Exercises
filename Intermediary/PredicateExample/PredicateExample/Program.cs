using PredicateExample.Entities;
using System;
using System.Collections.Generic;

namespace PredicateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Lambda example:
            //list.RemoveAll(p => p.Price >= 100.0);

            //Predicate
            list.RemoveAll(ProductTest);

            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}
