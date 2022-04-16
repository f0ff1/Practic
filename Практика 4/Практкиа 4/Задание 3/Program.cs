using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
   
    class Program
    {
        public static int AddLeftDigit(int d, int k)
        {
            k = checked(int.Parse(d.ToString() + k.ToString()));
            return k;
        }

        public static int CheckRange(int d)
        {
            if (d >= 1 && d <= 9)
            {
                return d;
            }
            else
            {
                throw new IndexOutOfRangeException("Выход за границы 1 <= x <= 9");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Write("Введите целое число К: ");
                int k = ToInt32(ReadLine());

                for (int i = 1; i < 3; i++)
                {
                    Write($"Введите цифру D{i}: ");
                    int d = CheckRange(ToInt32(ReadLine()));
                    k = AddLeftDigit(d, k);
                    WriteLine($"\nK{i}({k})+ D{i}({d}) = {k}\n" +
                        $"=========================\n");

                }           
                          
            }
            catch (OverflowException ex)
            {
                WriteLine("Число слишком большое для INT32.");
            }
            catch (IndexOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                WriteLine(ex.Message);

            }

            ReadKey();
        }
    }
}
