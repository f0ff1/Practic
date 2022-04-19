using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[2];
            MathManager mathManager = new MathManager();

            tasks[0] = Task.Run(() => 
            {
                WriteLine($"FirstAction: {mathManager.FirstAction(15):f2}\n");
                Thread.Sleep(1000);
            });
            tasks[0].Wait();
            tasks[1] = Task.Run(() => WriteLine($"SecondAction: {mathManager.SecondAction(20):f2}\n"));
            tasks[1].Wait();

            ReadKey();
        }
    }
}
