using System;
using Задание_2.Classes;
using static System.Console;
using static System.Convert;


namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer2 = "y";
            while (answer2 != "n")
            {
                Write("Выберите, что хотите создать:\n" +
               "1 - Товар\n" +
               "2 - Продукт\n" +
               "3 - Молочный продукт\n" +
               "4 - Игрушка\n");
                string answer = ReadLine();

                switch (answer)
                {
                    case "1":
                        Write("Введите название товара: ");
                        string tovarTitle = ReadLine();

                        Tovar tovar = new Tovar(tovarTitle);

                        tovar.GetTitle();
                        answer2 = ReadLine();
                        break;

                    case "2":
                        Write("Введите цену продукта: ");
                        double productPrice = ToDouble(ReadLine());

                        Write("Введите название продукта: ");
                        string productTitle = ReadLine();

                        Product product = new Product(productPrice, productTitle);

                        product.GetTitle(); product.GetPrice();
                        break;

                    case "3":
                        Write("Введите название молочного продукта: ");
                        string MilkProductTitle = ReadLine();

                        Write("Укажите объём молочного продукта: ");
                        double volume = ToDouble(ReadLine());

                        Write("Введите жирность молочного продукта: ");
                        double fat = ToDouble(ReadLine());

                        Write("Введите цену молочного продукта: ");
                        double MilkProductPrice = ToDouble(ReadLine());

                        MilkProduct MilkProduct = new MilkProduct(fat, volume, MilkProductTitle, MilkProductPrice);

                        MilkProduct.GetTitle(); MilkProduct.GetPrice(); MilkProduct.GetFat(); MilkProduct.GetVolume();
                        break;

                    case "4":
                        Write("Введите название игрушки: ");
                        string ToyTitle = ReadLine();

                        Write("Укажите тип игрушки: ");
                        string ToyType = ReadLine();

                        Write("Укажите материал игрушки: ");
                        string ToyMaterial = ReadLine();

                        Write("Введите цену игрушки: ");
                        double ToyPrice = ToDouble(ReadLine());

                        Toy toy = new Toy(ToyMaterial, ToyType, ToyPrice, ToyTitle);

                        toy.GetTitle(); toy.GetType(); toy.GetMaterial(); toy.GetPrice();
                        break;
                }


            }
        }
           


    }
}
