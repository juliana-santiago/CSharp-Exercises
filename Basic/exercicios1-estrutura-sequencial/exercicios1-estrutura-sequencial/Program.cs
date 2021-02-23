using System;

namespace exercicios1_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Console.WriteLine("Digite os dois numeros que deseja somar: ");
            Console.Write("Numero 1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Numero 2 = ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("A soma dos numeros é igual a " + soma);

            //Exercicio 2
            Console.Write("Informe o Raio de um Circulo para calcular a sua área: ");
            float raio = float.Parse(Console.ReadLine());
            double area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("A = " + area);

            //Exercicio 3
            Console.Write("Insira um valor inteiro A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor inteiro B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor inteiro C: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor inteiro D: ");
            int D = int.Parse(Console.ReadLine());
            int dif = A * B - C * D;
            Console.WriteLine("DIFERENCA = " + dif);

            //Exercicio 4
            Console.WriteLine("Informe os dados do Funcionario: ");
            Console.Write("Número do Funcionário: ");
            int numFunc = int.Parse(Console.ReadLine());
            Console.Write("Horas Trabalhadas: ");
            int horasTrab = int.Parse(Console.ReadLine());
            Console.Write("Salário por Hora: ");
            float salarioHora = float.Parse(Console.ReadLine());
            float salarioTotal = horasTrab * salarioHora;
            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine($"SALARY = U$ {salarioTotal:F2}");

            //Exercicio 5
            Console.Write("Insira o código, numero e o valor unitario da peça 1: ");
            string[] peca1 = Console.ReadLine().Split(" ");
            Console.Write("Insira o código, numero e o valor unitario da peça 2: ");
            string[] peca2 = Console.ReadLine().Split(" ");
            float resultado = float.Parse(peca1[1]) * float.Parse(peca1[2]) + float.Parse(peca2[1]) * float.Parse(peca2[2]);
            Console.WriteLine($"VALOR A PAGAR: {resultado:F2}");

            //Exercicio 6
            Console.Write("Insira tres valores: ");
            string[] valor = Console.ReadLine().Split(" ");
            float triangulo = float.Parse(valor[2]) * (float.Parse(valor[0]) / 2);
            float circulo = (float)3.14159 * float.Parse(valor[2]) * float.Parse(valor[2]);
            float trapézio = ((float.Parse(valor[0]) + float.Parse(valor[1])) * float.Parse(valor[2])) / 2;
            float quadrado = float.Parse(valor[1]) * float.Parse(valor[1]);
            float retangulo = float.Parse(valor[0]) * float.Parse(valor[1]);

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPÉZIO: {trapézio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}
