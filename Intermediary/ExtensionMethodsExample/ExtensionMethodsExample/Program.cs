using System;

namespace ExtensionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2021, 01, 24, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            var s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
