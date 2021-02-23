using System;
using System.Globalization;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
           
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:08:05", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine($"\n{d}");
            Console.WriteLine($"01) Date: {d.Date}");
            Console.WriteLine($"02) Day: {d.Day}");
            Console.WriteLine($"03) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"04) DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"05) Month: {d.Month}");
            Console.WriteLine($"06) Year: {d.Year}");
            Console.WriteLine($"07) Millisecond: {d.Millisecond}");
            Console.WriteLine($"08) Second: {d.Second}");
            Console.WriteLine($"09) Minute: {d.Minute}");
            Console.WriteLine($"10) Hour: {d.Hour}");
            Console.WriteLine($"11) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"12) Ticks: {d.Ticks}");
            Console.WriteLine($"13) Kind: {d.Kind}");

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH-mm-ss");
            string s7 = d.ToString("yyyy-MM-dd HH-mm-ss.fff");

            Console.WriteLine($"\nToLongDateString: {s1}");
            Console.WriteLine($"ToLongTimeString: {s2}");
            Console.WriteLine($"ToShortDateString: {s3}");
            Console.WriteLine($"ToShortTimeString: {s4}");
            Console.WriteLine($"ToString: {s5}");
            Console.WriteLine($"ToString('yyyy-MM-dd HH-mm-ss'): {s6}");
            Console.WriteLine($"ToString('yyyy-MM-dd HH-mm-ss.fff'): {s7}");


            DateTime d3 = d.AddHours(2);

            DateTime d4 = new DateTime(2000, 10, 15);
            DateTime d5 = new DateTime(2000, 10, 18);

            TimeSpan t = d5.Subtract(d4);

            Console.WriteLine($"\nHora atual: {d} - Mais duas horas: {d3}");
            Console.WriteLine($"Subtrack: {t}");
        }
    }
}
