using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Задание_1
{
    public struct Train
    {
        public string destination;
        public int trainNumber;
        public DateTime departureTime;

        public Train(string destination = "Hrodno", int trainNumber = 32535, DateTime departureTime = default)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public void WriteAllInfromation() => WriteLine($"Пункт назначения: {destination} | номер поезда: {trainNumber} | время отправления: {departureTime}");

        public string GetDestination()
        {
            return destination;
        }

        public int GetTrainNumber()
        {
            return trainNumber;
        }

        public DateTime GetDepartureTime()
        {
            return departureTime;
        }

        

    }
}
