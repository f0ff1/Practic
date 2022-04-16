using System;
using static System.Console;
using static System.Convert;
using System.Threading;
using System.Diagnostics;

namespace Задание_3
{
    class Program
    {
        static void FirstMethod(int a, int n)
        {
            double answer = 0;
            for (int i = 1; i < n; i++)
            {
                answer += Math.Pow(a, i);
            }

            WriteLine($"Сумма = {answer}\n");

        }

        static void SecondMethod(int a, int n)
        {
            double answer = 1;
            for (int i = 1; i < n; i++)
            {
                answer *= Math.Pow(a, i);
            }

            WriteLine($"Произведение = {answer}\n");
        }
        static void Main(string[] args)
        {
            Write("Введите А:");
            var a = ToInt32(ReadLine());
            Write("Введите N:");
            var n = ToInt32(ReadLine());

            Thread firstT = new Thread(new ThreadStart( () => FirstMethod(a, n)));
            Thread secondT = new Thread(new ThreadStart( () => FirstMethod(a, n)));

            Thread thirdT = new Thread(new ThreadStart( () => SecondMethod(a, n)));

            firstT.Start();
            secondT.Start();
            thirdT.Start();

            ReadKey();

        }
    }
}
