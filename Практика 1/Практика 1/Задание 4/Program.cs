using System;
using static System.Console;
using static System.Convert;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите курс доллара: ");
                double dollar_rate = ToDouble(ReadLine());
                double rubles;
                WriteLine("----------------\n");



                for (int i = 5; i <= 500; i += 5)
                {
                    rubles = i * dollar_rate;
                    WriteLine($"{i}$ = {rubles} р. |");
                }

                WriteLine("----------------\n" +
                    "Цикл FOR\n");

                int dollar = 5;
                while (dollar <= 500)
                {
                    rubles = dollar * dollar_rate;
                    WriteLine($"{dollar}$ = {rubles} р. |");
                    dollar += 5;
                }

                WriteLine("----------------\n" +
                    "Цикл WHILE \n");

                int temp_dollar = 5;
                do
                {
                    rubles = temp_dollar * dollar_rate;
                    WriteLine($"{temp_dollar}$ = {rubles} р. |");
                    temp_dollar += 5;

                } while (temp_dollar <= 500);

                WriteLine("----------------\n" +
                    "Цикл DO WHILE \n");
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
