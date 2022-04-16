using System;
using static System.Console;
using static System.Convert;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 20;
            const int A = 0;
            const double B = Math.PI / 2;
            const double n = 2.1;
            const double e = 2.71;

            try
            {
                Write("Введите значение x: ");
                double x = ToDouble(ReadLine());
                x = Math.Sin(x) - Math.Cos(x);
                double H = (B - A) / M;

                for (double i = 0.1; i <= n; i += 0.1)
                {
                    double y = Math.Pow(x, 2) - Math.Pow(e, x);
                    x = x + H;
                    WriteLine($"Y = {Math.Round(y,2)}");
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                ReadKey();
            }
            

            
        }
    }
}
