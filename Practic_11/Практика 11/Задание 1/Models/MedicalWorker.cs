using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1.Models
{
    public class MedicalWorker
    {
        public string name { get; set; }
        public string position { get; set; }


        public virtual double GetSalary() => default; 
       
        
    }
}
