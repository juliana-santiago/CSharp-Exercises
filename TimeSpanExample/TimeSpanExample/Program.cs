using System;

namespace TimeSpanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = TimeSpan.FromDays(1.5);
            TimeSpan t4 = TimeSpan.FromHours(1.5);
            TimeSpan t5 = TimeSpan.FromMinutes(1.5);
            TimeSpan t6 = TimeSpan.FromSeconds(1.5);
            TimeSpan t7 = TimeSpan.FromMilliseconds(1);
            TimeSpan t8 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine($"\nTimeSpan: {t1}");
            Console.WriteLine($"TimeSpan: {t2}");
            Console.WriteLine($"FromDays: {t3}");
            Console.WriteLine($"FromHours: {t4}");
            Console.WriteLine($"FromMinutes: {t5}");
            Console.WriteLine($"FromSeconds: {t6}");
            Console.WriteLine($"FromMilliseconds: {t7}");
            Console.WriteLine($"FromTicks: {t8}");

            TimeSpan t9 = TimeSpan.MaxValue;
            TimeSpan t10 = TimeSpan.MinValue;
            TimeSpan t11 = TimeSpan.Zero;

            Console.WriteLine($"\nMaxValue: {t9}");
            Console.WriteLine($"MinValue: {t10}");
            Console.WriteLine($"Zero: {t11}");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine($"\nTimeSpan: {t}");
            Console.WriteLine($"\nDays: {t.Days}");
            Console.WriteLine($"Hours: {t.Hours}");
            Console.WriteLine($"Minutes: {t.Minutes}");
            Console.WriteLine($"Seconds: {t.Seconds}");
            Console.WriteLine($"Milliseconds: {t.Milliseconds}");
            Console.WriteLine($"Ticks: {t.Ticks}");

            Console.WriteLine($"\nTotalDays: {t.TotalDays}");
            Console.WriteLine($"TotalHours: {t.TotalHours}");
            Console.WriteLine($"TotalMinutes: {t.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {t.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds: {t.TotalMilliseconds}");

            Console.WriteLine($"TimeSpan: {t}");

            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts1.Add(ts2);
            TimeSpan dif = ts1.Subtract(ts2);
            TimeSpan mult = ts2.Multiply(2.0);
            TimeSpan div = ts2.Divide(2.0);

            Console.WriteLine($"\nts1.Add(ts2): {sum}");
            Console.WriteLine($"ts1.Subtract(ts2): {dif}");
            Console.WriteLine($"ts2.Multiply(2.0): {mult}");
            Console.WriteLine($"ts2.Divide(2.0): {div}");


        }
    }
}
