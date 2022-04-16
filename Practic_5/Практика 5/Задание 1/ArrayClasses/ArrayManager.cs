using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_1
{
    public class ArrayManager
    {
        public int GetNegativeNumbers(int[] myMass)
        {
            return myMass.Count(number => number < 0);

        }

        public int[] NewSeqMinMaxOut(int[] myMass)
        {
            return myMass.Where(p => p != myMass.Min() && p != myMass.Max()).ToArray();
        }

        public int BinarySearchNumber(int[] myMass, int number)
        {
            if (myMass.Contains(number))
            {
                var numberIndex = Array.BinarySearch(myMass, number);
                return numberIndex;

            }
            else
            {
                throw new Exception("Заданное число не найдено.");
            }
        }

        public double GetAverage(int[,] myMass, int number)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < myMass.GetLength(0); i++)
            {
                for (int j = 0; j < myMass.GetLength(1); j++)
                {
                    if (myMass[i, j] > number)
                    {
                        numbers.Add(myMass[i, j]);
                    }
                }
            }

            return numbers.Average(n => n);

        }

        public int GetCountOfEvenNum(int[,] myMass, int lineNum)
        {
            int count = 0;
            if (lineNum > myMass.GetLength(0))
            {
                throw new IndexOutOfRangeException("Выход за границы! Такой строки не существует.");
            }

            for (int j = 0; j < myMass.GetLength(1); j++)
            {
                if (myMass[lineNum, j] % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public void ComparisonOfAmounts(int[,] myMass)
        {
            int summa1 = 0;
            int summa2 = 0;

            for (int j = 0; j < myMass.GetLength(1); j++)
            {
                summa1 += myMass[0, j];
                summa2 += myMass[myMass.GetLength(0) - 1, j];
            }

            if (summa1 > summa2)
            {
                WriteLine($"В первой строке сумма больше. {summa1} > {summa2}\n");
            }
            else if (summa2 > summa1)
            {
                WriteLine($"Во второй строке сумма больше. {summa2} > {summa1}\n");
            }
            else
            {
                WriteLine($"Суммы чисел в строках равны {summa1} = {summa2}\n");
            }

            

            
        }
    }
}
