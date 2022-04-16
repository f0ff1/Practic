using System;
using System.Collections.Generic;
using Задание_1.Services;
using static System.Console;

namespace Задание_1 // Задание № 1-2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int MIN = 1;
                const int MAX = 100; 

                var d1Summa = new Action<Action<string>, int, int>(DelegateService.WriteSumm);
                var d2Diff = new Action<Action<string>, int, int>(DelegateService.WriteDiff);
                var d3Div = new Action<Action<string>, int, int>(DelegateService.WriteDiv);

                d1Summa(WriteLine, Faker.RandomNumber.Next(MIN, MAX), Faker.RandomNumber.Next(MIN, MAX));
                d2Diff(WriteLine, Faker.RandomNumber.Next(MIN, MAX), Faker.RandomNumber.Next(MIN, MAX));
                d3Div(WriteLine, Faker.RandomNumber.Next(MIN, MAX), Faker.RandomNumber.Next(MIN, MAX));

            }
            catch (DivideByZeroException)
            {
                WriteLine("Невозможно делить на 0!");
            }
            

            ReadKey();
        }
    }
}
