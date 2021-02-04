using System;
using System.Globalization;

namespace FuncaoEstatica
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Informe o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferencia: " + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

       
    }
}
