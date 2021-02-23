using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            p.SetNome("T");

            Console.WriteLine($"{p.GetNome()}, {p.GetPreco()}, {p.GetQuantidade()}");
        }
    }
}