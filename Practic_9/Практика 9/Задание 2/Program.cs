using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int MINVALUE = 1;
                const int MAXVALUE = 100;
                Write("Кол-во продуктов: ");
                var count = ToInt32(ReadLine());

                var wareHouse = new Warehouse();
                var myList = new List<Product>();
                for (int i = 0; i < count; i++)
                {
                    WriteLine("Название товара:");
                    string productName = ReadLine();

                    string shopName = Faker.Company.Name();

                    double cost = Math.Round(Faker.RandomNumber.Next(MINVALUE, MAXVALUE) * 0.1, 2);

                    int id = Faker.RandomNumber.Next(MINVALUE, MAXVALUE);

                    myList = wareHouse.MakeProductList(new Product(productName, shopName, cost, id));
                }

                var sorted = wareHouse.SortByProductCost(myList);

                wareHouse.WriteThis(sorted);

                WriteLine("Введите id продукта: ");
                var index = ToInt32(ReadLine());

                var findedByIndex = wareHouse.GetProductByIndex(myList, index);
                if (findedByIndex != null)
                {
                    wareHouse.WriteThis(findedByIndex);
                }
                else
                {
                    throw new NullReferenceException("Продукт с введённым ID не существует.");
                }

                Write("Введите id сравниваемых продуктов:\n" +
                    "id1 =  ");
                var firstId = ToInt32(ReadLine());

                Write("Введите id сравниваемых продуктов:\n" +
                    "id2 =  ");
                var secId = ToInt32(ReadLine());

                var firstFinded = wareHouse.GetProductByIndex(myList, firstId);
                var secFinded = wareHouse.GetProductByIndex(myList, secId);
                if (firstFinded == null || secFinded == null)
                {
                    throw new NullReferenceException("Один или несколько исхомых продуктов не существуют.");
                }
                else
                {
                    WriteLine($"\n{firstFinded.CompareTo(secFinded)}");

                }
            }
            catch (FormatException)
            {
                WriteLine("Неверный формат!");
            }
            catch(NullReferenceException ex)
            {
                WriteLine(ex.Message);
            }

            ReadKey();


        }
    }
}
