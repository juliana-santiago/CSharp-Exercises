using System;

namespace exercicios3_estrutura_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 
            /*
            int senha = 0;
            while(senha != 2002)
            {
                Console.WriteLine("Digite a senha a baixo:");
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida!");
                }
            }
            Console.WriteLine("Acesso Permitido");
            

            //Exercise 2

            Console.WriteLine("Informe dois valores para descobrir qual o seu Quarter:");
            string[] numeros = Console.ReadLine().Split(' ');
            int x = int.Parse(numeros[0]);
            int y = int.Parse(numeros[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                Console.WriteLine("Informe dois valores para descobrir qual o seu Quarter:");
                numeros = Console.ReadLine().Split(' ');
                x = int.Parse(numeros[0]);
                y = int.Parse(numeros[1]);
            }
            */

            //Exercise 03
            Console.WriteLine("Escolha  o combustivel de sua preferencia através dos códigos 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
            int opcao = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0; 

            while(opcao != 4)
            {
                if (opcao == 1)
                {
                        alcool++;
                }
                else if (opcao == 2)
                {
                        gasolina++;
                }
                else if (opcao == 3)
                {
                        diesel++;
                }
                else 
                {
                    Console.WriteLine("Numero invalido, tente novamente.");
                    Console.WriteLine("");
                }

                    Console.WriteLine("Escolha  o combustivel de sua preferencia através dos códigos 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
                   opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
