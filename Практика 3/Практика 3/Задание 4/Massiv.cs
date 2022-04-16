using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Задание_4
{
    public class Massiv
    {
        public double[,] Numbers => numbers;
        
        double[,] numbers = default;
        public Massiv(int x, int y)
        {
            numbers = new double[x, y];
        }
        public Massiv(double[,] myMas)
        {
            numbers = myMas;
        }


       /// <summary>
       /// Создает двумерный массив и заполняет его рандомными числами типа double.
       /// </summary>
       /// <returns>Array double[,]</returns>
        public double[,] makeMas()
        {
            
            Random item_rnd = new Random(1);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = item_rnd.NextDouble() * item_rnd.Next(-5, 5);
                }

            }

            return numbers;
        }
        /// <summary>
        /// Вывод Array double[,] массив на консоль.
        /// </summary>
        public  void WriteMas()
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Write($"{numbers[i, j]:f1}  ");
                }
                WriteLine();
            }
        }

        /// <summary>
        /// Суммирует значения первого и указанного столбца.
        /// </summary>
        /// <param name="numbColumn">Номер выбранного столбца</param>
        /// <returns>new Array double[,] с изменёнными значениями</returns>
        public  double[,] makePlus(int numbColumn)
        {
            try
            {
                if (numbColumn > numbers.GetLength(1))
                {
                    throw new Exception("Ошибка: 'Выход за границы'. Такого стобца не существует. \n");
                }
                else
                {
                    for (int i = 0; i < numbers.GetLength(0); i++)
                    {
                        numbers[i, 0] += numbers[i, numbColumn - 1];

                    }

                }               

            }

            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            return numbers;           
        }
        /// <summary>
        /// Перегрузка оператора '+': суммирует значения первого стоблца с указанным (int)
        /// </summary>
        /// <param name="myMas"></param>
        /// <param name="columnNumber"></param>
        /// <returns>new Array double[,] с изменёнными значениями</returns>
        public static Massiv operator + (Massiv myMas, int columnNumber)
        {
            try
            {
                
                if (columnNumber > myMas.Numbers.GetLength(1))
                {
                    throw new Exception("Ошибка: 'Выход за границы'. Такого стобца не существует. \n");
                }
                else
                {
                    for (int i = 0; i < myMas.Numbers.GetLength(0); i++)
                    {
                        myMas.Numbers[i, 0] += myMas.Numbers[i, columnNumber - 1];

                    }

                }

            }

            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            return new Massiv(myMas.Numbers);
        }

        

    }
}
