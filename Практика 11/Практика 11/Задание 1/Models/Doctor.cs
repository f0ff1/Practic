using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_1.Models
{
    class Doctor : MedicalWorker
    {
        public int peopleCount { get; set; }
        private int _tempSalary = 8;

        public Doctor(string name, string position, int peopleCount)
        {
            this.name = name;
            this.position = position;
            this.peopleCount = peopleCount;
        }


        public override double GetSalary()
        {
            return _tempSalary * peopleCount;
        }
    }
}
