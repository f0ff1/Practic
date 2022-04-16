using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите трёхзначное число: ");
                var myStringNumber = ReadLine();
                if (myStringNumber.Length < 3 || myStringNumber.Length > 3)
                {
                    throw new Exception("Длина числа не соответствует условию! ");
                }
                else
                {
                    var myIntNumber = ToInt32(myStringNumber);
                    int a, b, c;
                    List<int> digits = new List<int>();

                    static void GetDigit(int number, List<int> digits)
                    {
                        while (number != 0)
                        {
                            var d = number % 10; 
                            digits.Add(d);
                            number /= 10;
                        }
                    }
                    GetDigit(myIntNumber, digits);

                    foreach (var digit in digits)
                    {
                        WriteLine($"Цифра: {digit}");
                    }

                    string[] massiv = new string[] {"123", "132", "213", "231", "312", "321" };

                    for (int elem = 0; elem < massiv.Length; elem++)
                    {
                        var mask = massiv[elem];
                        var i1 = (int)char.GetNumericValue(mask[0]);
                        var i2 = (int)char.GetNumericValue(mask[1]);
                        var i3 = (int)char.GetNumericValue(mask[2]);

                        var number = digits[i1 - 1] * 100 +
                            digits[i2 - 1] * 10 +
                            digits[i3 - 1];

                        WriteLine(number); 
                    }


                }
                
            }
            
            catch (Exception myNumber)
            {
                WriteLine($"Ошибка: {myNumber.Message}");
            }
            finally
            {
                ReadKey();
            }    
        }
    }
}
