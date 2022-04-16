using System;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        #region Method_and_Peregruzka
        public static double f (double x)
        {
            double y;
            if (x <=5)
            {
                y = Math.Pow(x, 2) + 5;
            }
            else if (x > 5 && x < 20)
            {
                y = 0;
            }
            else
            {
                y = 1;
            }
            return y;
        }

        public static double f(double x, out double y)
        {
            
            y = f(x);
            return y;
            

        }
        #endregion
        static void Main(string[] args)
        {
            Write("Введите а: ");
            double a = ToDouble(ReadLine());

            Write("Введите b: ");
            double b = ToDouble(ReadLine());

            Write("Введите шаг h: \n");
            double h = ToDouble(ReadLine());


            for (double i = a; i <= b; i+=h)
            {
                WriteLine($"{ f(i):f2}");
            }

            double y = 0;
            WriteLine("=======================\n");

            for (double i = a; i <= b; i += h)
            {
                y = f(i, out y);
                WriteLine($"{y:f2}");
            }

           
        }
    }
}
