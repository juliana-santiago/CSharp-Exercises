using DelegateExample.Services;
using System;

namespace DelegateExample
{
    //delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation(double n1, double n2);


    class Program
    {

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation operation = CalculationService.ShowSum;
            operation += CalculationService.ShowMax;

            operation(a, b);
            //double result = operation(a, b);
            //Console.WriteLine(result);
        }
    }
}
