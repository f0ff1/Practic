using System;
using static System.Console;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            foreach (var item in myList)
            {
                Write($"{item} | ");
            }

            var count = myList.count;

            WriteLine($"\nКоличество элементов: {count}");

            WriteLine($"\n3й элемент: {myList[2]}");

            ReadLine();
        }
    }
}
