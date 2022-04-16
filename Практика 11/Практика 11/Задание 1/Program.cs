using System;
using Задание_1.Models;
using System.Linq;
using static System.Console;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINVALUE = 20;
            const int MAXVALUE = 100;

            MedicalWorker[] medicals = new MedicalWorker[] { new MedSister(Faker.NameFaker.FemaleFirstName(), "главная", Faker.NumberFaker.Number(MINVALUE, MAXVALUE)),
                                                             new MedSister(Faker.NameFaker.FemaleFirstName(), "младшая", Faker.NumberFaker.Number(MINVALUE, MAXVALUE)),
                                                             new MedSister(Faker.NameFaker.FemaleFirstName(), "главная", Faker.NumberFaker.Number(MINVALUE, MAXVALUE)),
                                                             new Doctor(Faker.NameFaker.MaleFirstName(), "Хирург", Faker.NumberFaker.Number(MINVALUE, MAXVALUE)),
                                                             new Doctor(Faker.NameFaker.MaleFirstName(), "Фельдшер", Faker.NumberFaker.Number(MINVALUE, MAXVALUE))};

            foreach (var item in medicals)
            {
                WriteLine($"Medical worker name: {item.name} | Medical worker position: {item.position} | Medical worker salary: {item.GetSalary()}\n" +
                    $"===================================================================================================== ");  
            }

            WriteLine($"Сумма зарплата: {medicals.Sum(p => p.GetSalary())}");

            ReadKey();

            
        }
    }
}
