using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class ArrayProvider
    {
        public int[] MakeArray(int size)
        {
            const int START = -100;
            const int END = 100;
            int[] myMass = new int[size];
            Random randomNumber = new Random();

            for (int i = 0; i < myMass.Length; i++)
            {
                myMass[i] = randomNumber.Next(START, END);
            }

            return myMass;

        }

        public int[,] MakeArray(int sizeX, int sizeY)
        {
            const int START = -100;
            const int END = 100;
            int[,] myMass = new int[sizeX, sizeY];
            Random randomNumber = new Random();

            for (int i = 0; i < myMass.GetLength(0); i++)
            {
                for (int j = 0; j < myMass.GetLength(1); j++)
                {
                    myMass[i,j] = randomNumber.Next(START, END);
                }
                
            }

            return myMass;

        }

    }
}
