using System;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                while (true)
                {
                    Write("Введите а: ");
                    double a = ToDouble(ReadLine());
                    Write("Введите b: ");
                    double b = ToDouble(ReadLine());
                    Write("Введите c: ");
                    double c = ToDouble(ReadLine());

                    Polynomial myPoly = new Polynomial(a, b, c);
                    myPoly.WritePoly();

                    WriteLine("Введите аргумент х: ");
                    double x = ToDouble(ReadLine());

                    WriteLine($"Решение многочлена = {myPoly.Calculate(x)}");

                    Write("Введите а2: ");
                    double a2 = ToDouble(ReadLine());
                    Write("Введите b2: ");
                    double b2 = ToDouble(ReadLine());
                    Write("Введите c2: ");
                    double c2 = ToDouble(ReadLine());

                    Polynomial myPoly2 = new Polynomial(a2, b2, c2);
                    myPoly2.WritePoly();

                    WriteLine("Введите аргумент х1: ");
                    double x2 = ToDouble(ReadLine());

                    WriteLine($"Решение многочлена = {myPoly2.Calculate(x2)}");

                    var plusPoly = myPoly + myPoly2;
                    var minusPoly = myPoly - myPoly2;
                    var umnPoly = myPoly * myPoly2;

                    WriteLine("==================================");
                    WriteLine("Сложение многочленов: ");
                    plusPoly.WritePoly();
                    WriteLine("\nВычитание многочленов: ");
                    minusPoly.WritePoly();
                    WriteLine("\nУмножение многочленов: ");
                    umnPoly.WritePoly();
                    WriteLine("==================================");



                    bool continueKey;
                    Write("Нажмите Y - продолжить, любую клавишу - закончить...\n");
                    if (ReadKey().Key == ConsoleKey.Y)
                    {
                        continueKey = true;
                    }

                }
                
                
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);


            }
            

        }
    }
}
