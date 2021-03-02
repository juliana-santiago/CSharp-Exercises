using InterfaceAndInheritanceExample.Model.Entities;
using InterfaceAndInheritanceExample.Model.Enums;
using System;

namespace InterfaceAndInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White};
            IShape s2 = new Rectangle() { Color = Color.Black, Width = 3.5, Height = 4.2 };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
