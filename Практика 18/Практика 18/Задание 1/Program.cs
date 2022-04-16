using System;
using static System.Console;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите строку, элемент '#' = backspace: ");
            var myString = ReadLine();
            StackManager stackManager = new StackManager(myString);

            var myStack = stackManager.Delete();
            Write($"Исходная строка: {myString}\n");

            Write("Выходная строка: "); stackManager.WriteStack(myStack);



            ReadKey();
            
        }
    }
}
