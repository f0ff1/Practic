using System;
using System.Collections.Generic;
using Задание_3.Enums;
using static System.Console;

namespace Задание_3
{
    class Program
    {     
        static void Main(string[] args)
        {
            List<Animal> animals = new();
           

            Random random = new Random();

            var countOfAnimals = random.Next(3, 10);
            string type;
            int age;

            string? name;
            for (int i = 0; i < countOfAnimals; i++)
            {

                var whatCreate = random.Next(0, 2);
                var ifName = random.Next(0, 2);
                age = random.Next(1, 20);


                if (whatCreate == 0)
                {
                    type = Faker.EnumFaker.SelectFrom<EnumForModels.TypeOfBird>().ToString();
                    double wingspan = random.NextDouble();
                    int beakLength = random.Next(3, 10);

                    if (ifName == 0)
                    {
                        name = Faker.Name.First();
                    }
                    else
                    {
                        name = null;
                    }

                    animals.Add(new Bird(wingspan, beakLength, type, name, age));

                }

                else
                {
                    type = Faker.EnumFaker.SelectFrom<EnumForModels.HorseType>().ToString(); // breed
                    var weight = random.Next(100, 300);
                    var color = Faker.EnumFaker.SelectFrom<EnumForModels.Color>().ToString();

                    if (ifName == 0)
                    {
                        name = Faker.Name.First();
                    }
                    else
                    {
                        name = null;
                    }

                    animals.Add(new Horse(weight,color, type, name, age));

                }
            }

            foreach (var animal in animals)
            {
                WriteLine(animal.Information());
            }

            ReadKey();
        }
    }
}
