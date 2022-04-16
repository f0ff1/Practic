using System;
using Задание_1.Constants;
using static System.Console;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Constant constant = new();

            ClassA classA = new ClassA(Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()),
                                       Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()));

            ClassB classB = new ClassB(Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()),
                                       Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()),
                                       Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()));

            WriteLine($"CLASS_A: a = {classA.GetA()} b = {classA.GetB()} | c = {classA.C()}");

            WriteLine($"CLASS_B: a = {classB.GetA()} b = {classB.GetB()} | d = {classB.GetD()} | c = {classB.C2()}");

            ReadKey();


        }
    }
}
