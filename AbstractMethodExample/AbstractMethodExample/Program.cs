using AbstractMethodExample.Entities;
using AbstractMethodExample.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                var ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    var width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    var heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    var radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine("\nSHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine($"Area: {shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
