using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[]
            {
                "Maria", "Alex", "Bob"
            };

            Console.WriteLine("For:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("\nForeach: ");
            foreach (string vet in vetor)
            {
                Console.WriteLine(vet);
            }
        }
    }
}
