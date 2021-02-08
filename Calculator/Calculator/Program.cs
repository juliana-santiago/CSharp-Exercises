using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int Double;
            Calculator.Double(a, out Double);
            Calculator.Triple(ref a);
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);
            Console.WriteLine(a);
            Console.WriteLine(Double);
        }
    }
}
