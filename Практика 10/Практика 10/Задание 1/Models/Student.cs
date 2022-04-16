using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Student
    {
        protected string studentName;
        protected double averageScore;
        protected double Scholarship;

        public Student(string studentName, double averageScore)
        {
            this.studentName = studentName;
            this.averageScore = averageScore;
        }

        

        public virtual void DetermScholarship()
        {
             Scholarship = 300000 + 10000 * (averageScore - 5);
        }
        public virtual string GetAllInfo() => $"Имя стундента: {studentName} | средний балл {averageScore:f2} | Стипендия: {Scholarship} \n";

        public double Determ { get { return Scholarship; } set { Scholarship = value; } }


    }
}
