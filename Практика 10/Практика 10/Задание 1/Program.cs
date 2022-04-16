using System;
using Задание_1.Constants;
using static System.Console;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Constant constant = new();

            var studentName = Faker.NameFaker.FirstName();
            var averageScore = Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()) * 0.1;
            Student student = new Student(studentName, averageScore);


            var specialization = Faker.NameFaker.LastName();
            Magistr magistr = new Magistr(specialization, Faker.NumberFaker.Number(constant.GetMinConst(), constant.GetMaxConst()), studentName, averageScore);

            student.DetermScholarship();
            WriteLine(student.GetAllInfo());

            magistr.DetermScholarship();
            WriteLine(magistr.GetAllInfo());

            ReadKey();


        }
    }
}
