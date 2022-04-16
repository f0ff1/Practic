using Задание_1;
using static System.Console;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var regColl = new RegularCollection();
            Write("Введите текст: ");
            var text = ReadLine();

            var findedNUmbers = regColl.FindNumbers(text);

            if (findedNUmbers.Count > 0)
            {
                regColl.PrintSome(findedNUmbers);
            }
            else
            {
                WriteLine("Цифры не найдены.");
            }

            ReadKey();
        
    }
    }
}
