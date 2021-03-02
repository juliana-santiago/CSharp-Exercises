using System;
using System.Globalization;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n1 = int.Parse(Console.ReadLine());
                var n2 = int.Parse(Console.ReadLine());
                var result = n1 / n2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed!");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error! {e.Message}");
            }
        }
        }
    }
