using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_1
{
    class MyList<T> : IEnumerable<T>
    {
        public int count { get { return array.Length; } }
        T[] array = new T[0];
        public void Add(T item)
        {

            Array.Resize(ref array, array.Length + 1);

            array[^1] = item;
        }

        //public void WriteList()
        //{
        //    foreach (var item in array)
        //    {
        //        Write($"{item} | ");
        //    }
        //}

        public IEnumerator<T> GetEnumerator() 
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
