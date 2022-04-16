using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Magistr : Student
    {
        private double _newScholarship;
        private double _rubles;
        private string _specialization;

        public Magistr(string specialization, double rubles, string studentName, double averageScore) : base(studentName, averageScore)
        {
            this._rubles = rubles;
            this._specialization = specialization;
        }

        public override void DetermScholarship() 
        {
            base.DetermScholarship();
            _newScholarship = Scholarship + _rubles;
        }

        public override string GetAllInfo() => $"Имя студента {studentName} | средний балл {averageScore:f2} | Изменённая стипендия: {_newScholarship} | Специализация магистра: {_specialization}";
    }
}
