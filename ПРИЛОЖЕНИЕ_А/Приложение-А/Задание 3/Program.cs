using System;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double e = 2.7182818284;
            const double x = 6.4;
            
            

            try
            {
                var y = (Math.Pow(e, x) / Math.Cos(Math.Sqrt(x - 1))) + (2 * Math.Atan(Math.Pow(x, 2)) / 1 - x);
                WriteLine($"Ответ: {y}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            ReadKey();
        }
    }
}
