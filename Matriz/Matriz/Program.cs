using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            Console.WriteLine("Quantidade de elementos da Matriz: "+ matriz.Length);

            Console.WriteLine("Quantidade de linhas da Matriz: " + matriz.Rank);

            Console.WriteLine("Quantidade de dimensões da Matriz: " + matriz.GetLength(0));

            Console.WriteLine("Quantidade de dimensões da Matriz: " + matriz.GetLength(1));
        }
    }
}
