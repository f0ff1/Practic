using System;
using static System.Console;
using static Задание_1.Strategy;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            var countString = random.Next(100, 1000);

            var writers = new IConsoleWriter[] { new BlueConsoleWriter(), new RedConsoleWriter(), new YellowConsoleWriter() };

            for (int i = 0; i < countString; i++)
            {
                var index = i % writers.Length;
                var writer = writers[index];

                var text = Faker.Lorem.Paragraph();

                writer.WriteText(text);
            }

            ReadKey();
        }
    }
}
