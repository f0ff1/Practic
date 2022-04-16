using System;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager stManager = new StringManager();
            Write("Введите строку: ");
            var myString = ReadLine();

            var replaced = stManager.ReplaceFistLast(myString);

            WriteLine(replaced);

            var reversed = stManager.MakeThirdReverse(myString);
            WriteLine(reversed);

            var newString = stManager.CutFirstWord(myString);
            WriteLine(newString);

            var gluedString = stManager.GlueSecondThird(myString);
            WriteLine(gluedString);

            

            ReadKey();
  
        }
    }
}
