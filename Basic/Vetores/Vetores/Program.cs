using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Example
            /*
            Console.Write("Informe o Tamanho do Vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            Console.WriteLine("Informe os valores do vetor:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"vect[{i}]: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i=0; i<n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine($"Average Height = {avg.ToString("F2", CultureInfo.InvariantCulture)}");  
            */

            //Second Example
            Console.Write("Informe a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product
                {
                    Name = name,
                    Price = price
                };
            }
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;

            Console.WriteLine($"\nAverage Height = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
