using System;
using System.Collections.Generic;

namespace HashSetAndSortedSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hSet = new HashSet<string>();

            hSet.Add("TV");
            hSet.Add("Notebook");
            hSet.Add("Tablet");

            foreach (string p in hSet)
            {
                Console.WriteLine($"HashSet items: {p}");
            }

            Console.WriteLine($"\nHashSet Contains 'Notebook': {hSet.Contains("Notebook")}");

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.Write("\nGroup A: ");
            PrintCollection(a);
            Console.Write("Group B: ");
            PrintCollection(b);
            //union 
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("\nUnion With: "); PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("\nIntersect With: ");
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("\nExcept With: ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}
