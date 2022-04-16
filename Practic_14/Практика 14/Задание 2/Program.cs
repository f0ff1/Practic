using System;
using static System.Console;
using static System.Convert;
using System.Threading;
using System.Diagnostics;

namespace Задание_2
{
    class Program
    {
        
        static void NumbersSum()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            long summa = 0;
            for (long i = 1; i < 1000000; i++)
            {
                summa += i;
            }
            
            stopwatch.Stop();
            WriteLine($"Сумма: {summa}");
            WriteLine($"Поток занял {stopwatch.ElapsedMilliseconds.ToString()} мс.");
        }

        static void Main(string[] args)
        {         

            Thread firstT = new Thread(new ThreadStart(NumbersSum));                       
            firstT.Start();

            firstT.Join();
            Thread secondT = new Thread(new ThreadStart(NumbersSum));
            
            secondT.Start();
            secondT.Join();
            
            ReadKey();
        }
    }
}
