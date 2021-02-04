using System;
using System.Globalization;

namespace ExercicioFuncaoEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cotação do Dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantia em Dolares: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais é igual a " + ConversorDeMoeda.Conversao(dolar, quantia).ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
