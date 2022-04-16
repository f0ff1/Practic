using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_1.Models
{
    public class MedSister : MedicalWorker
    {
        public int hourseCount { get; set; }
        private int _tempSalary = 10;

        public MedSister(string name, string position, int hourseCount)
        {
            this.name = name;
            this.position = position;
            this.hourseCount = hourseCount;
        }

       

        public override double GetSalary()
        {
            return _tempSalary * hourseCount;
                
        }

        


    }
}
