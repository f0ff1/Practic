using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_1
{
    public class StackManager
    {
        Stack<char> baseStack = new();

        string myString;
        public StackManager(string myString)
        {
            this.myString = myString;
        }

        public Stack<char> Delete()
        {
            for (int i = 0; i < myString.Length; i++)
            {
                if (char.IsLetter(myString[i]))
                {
                    baseStack.Push(myString[i]);
                }
                if (myString[i] == '#')
                {
                    if (baseStack.Count > 0)
                    {
                        baseStack.Pop();
                    }
                    
                }
            }

            return baseStack;
        }

        public void WriteStack(Stack<char> myStack)
        {
            
            if (myStack.Count > 0)
            {                
                
                foreach (var item in myStack.Reverse())
                {
                    Write(item);
                }
            }
            
        }

    }
}
