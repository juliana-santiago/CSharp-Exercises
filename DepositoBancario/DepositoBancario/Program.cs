using System;
using System.Globalization;

namespace DepositoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            //Informaçoes da Conta
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            //Saldo
            if(resposta == 's' || resposta == 'S')
            {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial); 
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            //Conta Original
            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            //Deposito
            Console.Write("\nEntre um valor para Depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);

            //Saque
            Console.Write("\nEntre um valor para Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
