using System;
using System.Globalization;

namespace exercicios4_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 01
            Console.WriteLine("Digite um numero:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numeros impares até o numero {num}");

            for (int i = 0; i < num + 1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Exercise 02
            Console.WriteLine("Digite um valor:");
            int j = int.Parse(Console.ReadLine());
            int s = 0, n = 0;

            Console.WriteLine("Digite um numero:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < j; i++)
            {
                if (x >= 10 && x <= 20)
                {
                    s++;
                }
                else
                {
                    n++;
                }
                Console.WriteLine("Digite um numero:");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{s} in");
            Console.WriteLine($"{n} out");

            //Exercise 03
            Console.WriteLine("Digite um numero:");
            int vetJ = int.Parse(Console.ReadLine());
            double media;
            string[] vetor;

            for (int i = 0; i < vetJ; i++)
            {
                vetor = Console.ReadLine().Split(' ');

                media = ((double.Parse(vetor[0], CultureInfo.InvariantCulture) * 2) + (double.Parse(vetor[1], CultureInfo.InvariantCulture) * 3) + (double.Parse(vetor[2], CultureInfo.InvariantCulture) * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            //Exercise 04
            Console.WriteLine("Digite um numero:");
            int divJ = int.Parse(Console.ReadLine());
            double divisao;
            string[] vetor1;

            for (int i = 0; i < divJ; i++)
            {
                vetor1 = Console.ReadLine().Split(' ');

                if (double.Parse(vetor1[1], CultureInfo.InvariantCulture) == 0)
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else
                {
                    divisao = double.Parse(vetor1[0], CultureInfo.InvariantCulture) / double.Parse(vetor1[1], CultureInfo.InvariantCulture);
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            //Exercise 05
            Console.WriteLine("Digite um numero para descobrir seu fatorial:");
            int numFat = int.Parse(Console.ReadLine());
            int fatN = 1;

            if (numFat == 0)
            {
                Console.WriteLine(numFat + 1);
            }
            else
            {
                for (int i = 1; i <= numFat; i++)
                {
                    fatN = fatN * i;
                }
                Console.WriteLine(fatN);
            }

            //Exercise 06
            Console.WriteLine("Digite um numero para descobrir seus dividendos:");
            int divN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= divN; i++)
            {
                if (divN % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Exercise 07
            Console.WriteLine("Digite um numero para descobrir o quadrado e o cubo:");
            int multN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= multN; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}
