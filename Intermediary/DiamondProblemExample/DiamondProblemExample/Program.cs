using DiamondProblemExample.Devices;
using System;

namespace DiamondProblemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer()
            {
                SerialNumber = 1080
            };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner()
            {
                SerialNumber = 2003
            };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice cd = new ComboDevice()
            {
                SerialNumber = 3921
            };
            cd.ProcessDoc("My dissertation");
            cd.Print("My dissertation");
            Console.WriteLine(cd.Scan());
        }
    }
}
