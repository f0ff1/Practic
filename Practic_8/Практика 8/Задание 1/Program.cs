using System;
using static System.Console;
using static System.Convert;
using System.Linq;


namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TrainManager trainManger = new();
                var trips = trainManger.MakeTrip();

                var sortedTrips = trainManger.SortTrips(trips);

                foreach (var trip in sortedTrips)
                {
                    trip.WriteAllInfromation();
                }

                WriteLine("\nВведите номер поезда для его вывода: \n");
                var trainNumber = ToInt32(ReadLine());

                var findedTrain = trainManger.GetTrainByNumber(trips, trainNumber);

                if (findedTrain.Count() > 0)
                {
                    trainManger.WriteTrainInformation(findedTrain);
                }
                else
                {
                    throw new NullReferenceException("Поезд с данным номером не найден.");
                }
            }
            catch (NullReferenceException ex)
            {
                WriteLine(ex.Message);
            }
            ReadKey();
        }
    }
}
