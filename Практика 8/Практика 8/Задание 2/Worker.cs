using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Worker
    {
        public static positions MakeWorker(string post)
        {
            if (!Enum.IsDefined(typeof(positions), post))
            {
                throw new Exception("Данные не верны");

            }

            if (post == "junior")
            {
                return positions.junior;
            }
            else if (post == "middle")
            {
                return positions.middle;
            }
            return positions.senior;

        }
    }
}