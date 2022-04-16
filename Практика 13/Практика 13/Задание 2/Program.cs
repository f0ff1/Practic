using System;

namespace Задание_2 // Задание № 3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInfo = new MyInfo(Faker.NameFaker.MaleFirstName());
            var CIAclass = new CIA();

            myInfo.NameChanged += CIAclass.CheckName;

            myInfo.ChangeName(Faker.NameFaker.MaleFirstName());

            var dictionary = CIAclass.GetDictionary;

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Объект № {Faker.RandomNumber.Next()} -  {item.Key} сменил имя на {item.Value} ");
            }

            Console.ReadKey();
        }
    }
}
