using System;
using static System.Console;
using static System.Convert;
using System.Threading;

namespace Задание_1
{
    class Program
    {
        static void FirstThread()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Write($"{i} | ");
            }
            WriteLine("\n");
        }

        static void SecondThread()
        {
            Thread.Sleep(1000);
            for (int i = 10; i < 20; i++)
            {
                Write($"{i} | ");
            }
            WriteLine("\n");
        }

        static void ThirdThread()
        {
            
            for (int i = 20; i < 30; i++)
            {
                Write($"{i} | ");
            }
            WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Thread firstThread = new Thread(new ThreadStart(FirstThread));
            Thread secondThread = new Thread(new ThreadStart(SecondThread));
            Thread thirdThread = new Thread(new ThreadStart(ThirdThread));

            firstThread.Start();
            firstThread.Join();
            

            secondThread.Start();
            

            thirdThread.Start();
            

            WriteLine("Главный поток молчит!");
            WriteLine("Завершение главного потока!");
            ReadLine();

        }
    }
}
