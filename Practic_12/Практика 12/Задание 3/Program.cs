using System;
using static System.Console;

namespace Задание_3
{
    delegate string MyStringDelegate(string main);
    class Program
    {
        static void Main(string[] args)
        {
            StringManager stringManager = new();

            var join = new MyStringDelegate(stringManager.JoinString);

            Write("Введите строку: ");
            var mainString = ReadLine();

            var joinedString = join(mainString);
            WriteLine($"joined: {joinedString}");

            var remove = new MyStringDelegate(stringManager.RemoveString);

            var removedString = remove(joinedString);
            WriteLine($"removed: {removedString}");

            var upper = new MyStringDelegate(stringManager.MakeStringUpper);

            var upperedString = upper(removedString);
            WriteLine($"uppered: {upperedString}");

            ReadKey();


        }
    }
}
