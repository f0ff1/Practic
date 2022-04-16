using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class QueueManager
    {
        private Queue<char> myQueueWithDigits = new();
        private Queue<char> myQueueNoDigits = new();

        string myText;

        public QueueManager()
        {
           
        }

        public void Checking()
        {
            if (true)
            {

            }
        }

        public void AddToDigitQueue(char symbol)
        {
            myQueueWithDigits.Enqueue(symbol);
        }
        
        public void AddToNoDigitQueue(char symbol)
        {
            myQueueNoDigits.Enqueue(symbol);
        }

        private Queue<char> GetNormalizedQueue(Queue<char> myQueue)
        {
            if (myQueue.Count > 0)
            {
                return myQueue;
            }
            return default;
        }

        public Queue<char> GetQueueDigits()
        {
            return GetNormalizedQueue(myQueueWithDigits);
            
        }

        public Queue<char> GetQueueNoDigits()
        {
            return GetNormalizedQueue(myQueueNoDigits);
        }


    }
}
