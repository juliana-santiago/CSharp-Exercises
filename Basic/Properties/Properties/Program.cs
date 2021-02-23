using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            p.Nome = "T";

            Console.WriteLine($"{p.Nome}, {p.Preco}, {p.Quantidade}");
        }
    }
}
