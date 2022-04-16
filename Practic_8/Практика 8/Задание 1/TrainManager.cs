using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class TrainManager
    {
        private string destination;
        private int trainNumber;
        private DateTime departureTime;
        private int minNumber = 100;
        private int maxNumber = 1000;

        public Train[] MakeTrip()
        {
            var myTrains = new Train[8];

            for (int i = 0; i < 8; i++)
            {
                destination = Faker.Address.City();
                trainNumber = Faker.RandomNumber.Next(minNumber, maxNumber);
                departureTime = Faker.DateTimeFaker.DateTime(DateTime.Today, to: DateTime.Today.AddYears(2));

                myTrains[i] = new Train(destination, trainNumber, departureTime);
            }

            return myTrains;
        }

        public Train[] SortTrips(Train[] myTrains)
        {
            return myTrains.OrderBy(p => p.GetTrainNumber()).ToArray();
            
        }

        public void WriteTrainInformation(IEnumerable<Train> myTrains)
        {
            foreach (var train in myTrains)
            {
                train.WriteAllInfromation();
            }
        }

        public IEnumerable<Train> GetTrainByNumber(Train[] myTrips, int trainNumber)
        {
            return myTrips.Where(p => p.GetTrainNumber() == trainNumber);          
        }
    }
}
