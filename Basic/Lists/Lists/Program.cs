using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Jacob");
            list.Add("Sarah");
            list.Insert(2, "Marco");

            Console.WriteLine("List Foreach: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList Count: " + list.Count);

            string search1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\nFirst 'A': " + search1);

            string search2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("\nLast 'A': " + search2);

            int position1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nFirst position: " + position1);

            int position2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("\nLast position: " + position2);

            Console.WriteLine("\nFind All: ");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList Remove: ");
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("\nList Remove At: ");
            list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList Remove Range: ");
            list.RemoveRange(2, 1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList Remove At: ");
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList Remove All: ");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
