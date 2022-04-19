using System;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_4
{
    class Program
    {
        private static void SinCos(int digit, Action<string> action)
        {
            action($"{Math.Cos(digit) - Math.Sin(digit):f2}");
            
        }
        
        static void Main(string[] args)
        {
            Parallel.For(-6, 6, (str) => SinCos(str, WriteLine));

            ReadKey();
        }

    }
}
