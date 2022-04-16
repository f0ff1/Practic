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
                Write("Введите строку: ");
                var input_string = ReadLine();

                var replacedString = input_string.Replace(" ", "");

                if (replacedString.AreStringPolindrom())
                {
                    WriteLine("Срока является полиндромом.");
                }
                else
                {
                    WriteLine("Срока не является полиндромом.");
                }

            }
            catch (FormatException ex)
            {
                WriteLine(ex.Message);                
            }
            
            

            ReadKey();
        }
    }
}
