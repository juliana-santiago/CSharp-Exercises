using System;

namespace ExercicioFixacaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            Estudante[] e = new Estudante[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                e[quarto] = new Estudante(quarto, email, nome);
            }

            Console.WriteLine("\nQuartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if(e[i] != null)
                Console.WriteLine(e[i]);
            }

        }
    }
}
