using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas da Matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas da Matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            Console.WriteLine("\nInforme os numeros da matriz: ");
            for (int i = 0; i < m; i++)
            {
                string[] numero = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(numero[j]);
                }
            }

            Console.WriteLine("\nMatriz: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nDigite um numero que esta na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine($"\nO numero {x} está na posição: matriz[{i}][{j}]");

                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda:  {matriz[i, j - 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Em cima: {matriz[i - 1, j]}");
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine($"Em baixo: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
