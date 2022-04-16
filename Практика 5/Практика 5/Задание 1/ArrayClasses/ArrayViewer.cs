using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_1
{
    public class ArrayViewer
    {
        public void WriteMassiv(int[] myMass)
        {
            WriteLine("========================");
            foreach (var number in myMass)
            {
                Write($"{number} ");
            }
            WriteLine("\n========================");
        }

        public void WriteMassiv(int[,] myMass)
        {
            WriteLine("========================");
            for (int i = 0; i < myMass.GetLength(0); i++)
            {
                for (int j = 0; j < myMass.GetLength(1); j++)
                {
                    Write($"{myMass[i, j]:f1} ");
                }
                WriteLine();
            }
            WriteLine("\n========================");
        }

        public void WriteColorMassiv(int[] myMass, ConsoleColor color_min = ConsoleColor.Green, ConsoleColor color_max = ConsoleColor.Red)
        {
            WriteLine("========================");
            foreach (var number in myMass)
            {
                if (number == myMass.Min())
                {
                    ForegroundColor = color_min;
                    Write($"{number} ");
                    ForegroundColor = ConsoleColor.Black;

                }
                else if (number == myMass.Max())
                {
                    ForegroundColor = color_max;
                    Write($"{number} ");
                    ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    Write($"{number} ");
                }


            }
            WriteLine("\n========================");
        }
    }
}
