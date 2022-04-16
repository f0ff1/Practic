using System;
using static System.Console;
using static System.Convert;
using System.Linq;
using Задание_1;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int ARRAYSIZE = 99;
                ArrayProvider arProvider = new ArrayProvider();
                ArrayViewer arViewer = new ArrayViewer();
                ArrayManager arManager = new ArrayManager();

                var myMassiv = arProvider.MakeArray(ARRAYSIZE);

                arViewer.WriteColorMassiv(myMassiv);
                WriteLine("\nМассив после изменений");

                var newMassiv = arManager.NewSeqMinMaxOut(myMassiv);
                arViewer.WriteColorMassiv(newMassiv);

                Array.Sort(myMassiv);

                arViewer.WriteMassiv(newMassiv);
                Write("Укажите число для бинарного поиска: ");

                int number = ToInt32(ReadLine());

                WriteLine($"Индекс числа: { arManager.BinarySearchNumber(newMassiv, number)}");
            }

            catch (FormatException ex)
            {
                WriteLine(ex.Message);
                
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                
            }
            

            ReadKey();
        }
    }
}
