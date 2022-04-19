using System;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Задание_1
{
    class Program
    {

        private static void  GetDigitsOfDigit(int digit)
        {
            try
            {
                DigitManager digitManager = new DigitManager();
                var digits = digitManager.GetDigits(digit);

                digitManager.WriteDigits(digits);
                WriteLine();
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {

            
            // Первый способ создания Task
            Task firstTask = new Task(() =>
            {
                Write("Введите число для firstTask: ");
                var digit = ToInt32(ReadLine());
                GetDigitsOfDigit(digit);                
            });
            firstTask.Start();
            firstTask.Wait();

            // Второй способ создания Task
            Task secondTask = Task.Factory.StartNew(() =>
            {
                Write("Введите число для secondTask: ");
                var digit = ToInt32(ReadLine());
                GetDigitsOfDigit(digit);
            });
            secondTask.Wait();

            // Третий способ создания Task
            Task thirdTask = Task.Run(() =>
            {
                Write("Введите число для secondTask: ");
                var digit = ToInt32(ReadLine());
                GetDigitsOfDigit(digit);
            });
            thirdTask.Wait();

            ReadKey();
        }
    }
}
