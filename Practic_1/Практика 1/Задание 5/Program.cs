using System;
using static System.Console;
using static System.Convert;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите стоимость 1кг конфет: ");
                double cost_1kg = ToDouble(ReadLine());

                if (cost_1kg >= 1 && cost_1kg <= 100)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        WriteLine($"{i}кг. стоит {Math.Round((cost_1kg * i), 2)}р.");
                    }
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
