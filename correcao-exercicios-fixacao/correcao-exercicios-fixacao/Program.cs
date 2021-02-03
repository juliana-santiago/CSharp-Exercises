using System;
using System.Globalization;

namespace correcao_exercicios_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("EXERCICIO 1");

            Retangulo r = new Retangulo();

            Console.WriteLine("Informe os dados do Retangulo: ");

            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);
            Console.WriteLine();

            //Exercise 2
            Console.WriteLine("\nEXERCICIO 2");

            Funcionario f = new Funcionario();

            Console.WriteLine("Informe os dados do Funcionario: ");

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: " + f);


            //Exercise 3
            Console.WriteLine("\nEXERCICIO 3");

            Aluno a = new Aluno();

            Console.WriteLine("Informe os dados do Aluno: ");

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(a);
        }
    }
}
