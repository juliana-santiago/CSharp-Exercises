using System;
using System.Globalization;

namespace exercicios2_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:
            Console.WriteLine("Digite um numero inteiro: ");
            String num = Console.ReadLine();

            if (Convert.ToInt32(num) >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            //Exercise 2:
            Console.WriteLine("Digite um numero inteiro: ");
            String num1 = Console.ReadLine();

            if (Convert.ToInt32(num1) % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }

            //Exercise 3
            Console.WriteLine("Digite um numero inteiro: ");
            String[] num2 = Console.ReadLine().Split(' ');

            if (Convert.ToInt32(num2[0]) % 2 == 0 && Convert.ToInt32(num2[1]) % 2 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }

            //Exercise 4
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            //Exercise 5
            Console.WriteLine("MENU:");
            String[] item = new String[]
            {

                        "1 Cachorro-Quente R$ 4,00",


                        "2 X-Salada R$ 4,50",


                        "3 X-Bacon R$ 5,00",


                        "4 Torrada-Simples R$ 2,00",


                        "5 Refrigerante R$ 1,50"

            };

            Console.WriteLine("CÓDIGO - ESPECIFICAÇÃO - PREÇO");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(item[i]);
            }
            Console.WriteLine("Digite o item e a quantidade: ");
            String[] choice = Console.ReadLine().Split(' ');
            String[] choiceItem = item[Convert.ToInt32(choice[0]) - 1].Split(' ');
            float result = (float)(Convert.ToDouble(choiceItem[3]) * Convert.ToDouble(choice[1]));
            Console.WriteLine($"Total: R$ {result:F2}");

            //Exercise 6
            Console.WriteLine("Digite um numero e encontre o intervalo que ele pertence:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora de Intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intevalo [0, 25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intevalo [25, 50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intevalo [50, 75]");
            }
            else
            {
                Console.WriteLine("Intevalo [75, 100]");
            }

            //Exercise 7
            Console.WriteLine("Informe dois numeros para localizar o Quarter:");
            String[] quarter = Console.ReadLine().Split(' ');
            double lineX = double.Parse(quarter[0]);
            double lineY = double.Parse(quarter[1]);

            if (lineX == 0.0 && lineY == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (lineX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (lineY == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (lineX > 0.0 && lineY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (lineX < 0.0 && lineY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (lineX < 0.0 && lineY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            //Exercise 8
            Console.WriteLine("Informe seu salario:");
            float salario = float.Parse(Console.ReadLine());
            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
