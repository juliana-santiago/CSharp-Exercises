using System;
using System.Globalization;

namespace TernaryCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20 ? preco * 0.1 : preco * 0.05);

            Console.WriteLine(desconto);
        }
    }
}
