using System;
using System.Collections.Generic;

namespace DictionaryAndSortedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99999999";
            cookies["phone"] = "99888880";

            Console.WriteLine($"Email: {cookies["email"]}");
            Console.WriteLine($"Phone: {cookies["phone"]}");

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("\nThere is no 'email' key");
            }

            Console.WriteLine($"\nSize: {cookies.Count}");

            Console.WriteLine("\nALL COOKIES:");

            foreach(var item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}