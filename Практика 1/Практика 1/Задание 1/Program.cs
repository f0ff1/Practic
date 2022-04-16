using System;
using static System.Console;
using static System.Convert;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Введите число x: ");
                double x = ToDouble(ReadLine());

                double y;

                if (x <= Math.PI)
                {
                    y = x + 2 * x * Math.Sin(3 * x);
                }
                else
                {
                    y = Math.Cos(x) + 2;
                }

                WriteLine($"Y = {Math.Round(y,2)}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {

                ReadLine();
            }
            
            
        }
    }
}
