using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas e colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"infrome] um numero para a posição [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"matriz[{i},{i}]: {matriz[i, i]}");
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Quantidade de numeros negativos: {count}");
        }
    }
}
