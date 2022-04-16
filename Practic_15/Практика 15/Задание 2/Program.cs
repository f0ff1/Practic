using System;
using static System.Console;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();

            for (int i = 0; i < 5; i++)
            {
                myDict.Add(Faker.Address.City(), Faker.Company.Name());
            }

            foreach (var item in myDict)
            {
                Write($"{item.key} | {item.value}\n");

            }

            WriteLine($"Количество пар: {myDict.Count}");

            WriteLine("Выберите: ");
            var key = ReadLine();
            WriteLine($"{myDict[key]}");

            ReadLine();
        }
    }
}
