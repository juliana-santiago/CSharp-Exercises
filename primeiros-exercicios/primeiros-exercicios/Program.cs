using System;
using System.Globalization;

// Exercicios sobre funçoes. Primeiros exercicios - referentes a aula 40 do curso

namespace primeiros_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 01

            Pessoa A, B;

            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            A.Nome = Console.ReadLine();
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            B.Nome = Console.ReadLine();
            B.Idade = int.Parse(Console.ReadLine());

            if (A.Idade > B.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {A.Nome}");
            }
            else if (A.Idade < B.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {B.Nome}");
            }
            else
            {
                Console.WriteLine($"{A.Nome} e {B.Nome} possuem a mesma idade.");
            }

            // Exercise 02

            Funcionario C, D;

            C = new Funcionario();
            D = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            C.Nome = Console.ReadLine();
            C.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            D.Nome = Console.ReadLine();
            D.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (C.Salario + D.Salario) / 2.0;

            Console.WriteLine($"Salario médio: {mediaSalario:F2}");


        }
    }
}
