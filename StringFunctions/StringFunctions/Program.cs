using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToLower();
            string s2 = original.ToUpper();
            string s3 = original.Trim();

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"ToLower: {s1}");
            Console.WriteLine($"ToUpper: {s2}");
            Console.WriteLine($"Trim: {s3}");
            Console.WriteLine($"Substring(3): {s4}");
            Console.WriteLine($"Substring(3,5): {s5}");
            Console.WriteLine($"Replace('a', 'x'): {s6}");
            Console.WriteLine($"Replace('abc', 'xy'): {s7}");

            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");

            Console.WriteLine($"IndexOf: {n1}");
            Console.WriteLine($"LastIndexOf: {n2}");
        }
    }
}