using System;
using static System.Console;
using static System.Convert;
using System.Linq;


namespace Задание_1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            try
            {
                Write("Укажите размерность массива, не больше 1000 элементов: ");
                
                int massivSize = ToInt32(ReadLine());
                if (massivSize < 1000)
                {
                    ArrayProvider arProvider = new ArrayProvider();
                    ArrayViewer arViewer = new ArrayViewer();
                    ArrayManager arManager = new ArrayManager();

                    var myMassiv = arProvider.MakeArray(massivSize);
                    arViewer.WriteMassiv(myMassiv);

                    var countOfNegativeNumbers = arManager.GetNegativeNumbers(myMassiv);

                    WriteLine($"Количество отрицательных чисел: {countOfNegativeNumbers}");

                }
                else
                {
                    throw new IndexOutOfRangeException("Размерность массива превышена...");
                }

                

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
