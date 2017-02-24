using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class MyStack : Buffer
    {
        private int iTop = -1;

        public MyStack(int iArray):base(iArray)
        {    
        }

        public int Pop()
        {
            if (IsEmpty())

            {
                Console.WriteLine("Stack is empty!");
                return iTop;
            }

            else
            {
                Console.WriteLine("Pop value is: {0} from position {1}", iInternal[iTop], iTop);
                iTop--;
                return iTop;
            }
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full, can't push any value");
            }
            else
            {
                iTop++;
                iInternal[iTop] = value;
                Console.WriteLine("Push {0} value on position {1}", iInternal[iTop], iTop);
            }

        }

        public override bool IsEmpty()
        {
            if (iTop == -1)
            { return true; }
            else
            { return false; }
        }

        public override bool IsFull()
        {
            
            if (iTop == (iInternalSize - 1))
            { return true; }
            else
            { return false; }
        }

        public override void Peek()
        {
            Console.WriteLine("Current top value is {0}", iInternal[iTop]);
        }
    }
}
