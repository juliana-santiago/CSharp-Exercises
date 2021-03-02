using HashCollectionsExample.Entities;
using System;
using System.Collections.Generic;

namespace HashCollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> product = new HashSet<Product>();

            product.Add(new Product("TV", 900.0));
            product.Add(new Product("Notebook", 1200.0));

            HashSet<Point> point = new HashSet<Point>();

            point.Add(new Point(3, 4));
            point.Add(new Point(5, 10));

            //Classe precisa implementar o GetHashCode e o Equals para comparar o conteudo - Se nao tiver implementado isso na Classe em questão, a comparação sera feita por referecia (memória)
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(product.Contains(prod));

            //Em caso de struct a comparação é feita pelo conteudo sem a necessidade da implementação dos metodos GetHashCode e Equals
            Point p = new Point(5, 10);
            Console.WriteLine(point.Contains(p));
        }
    }
}
