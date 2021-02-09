using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciciosFixacaoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nFuncionario #{i + 1}:");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Salario:");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nInforme o Id do funcionario que terá um aumento de salario: ");
            int searchIdFunc = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == searchIdFunc);

            if(func != null)
            {
                Console.Write("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoDeSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("O Id informado não existe");
            }

            Console.WriteLine("\nLista de Funcionarios atualizada:");

            foreach(Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario);
            }

        }
    }
}
