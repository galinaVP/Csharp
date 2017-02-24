using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Buffer
    {
        
        public int[] iInternal;
        public int iInternalSize;
        public Buffer(int iArraySize)
        {
            iInternalSize = iArraySize;
            iInternal = new int[iInternalSize];
        }

        public virtual bool IsEmpty()
        {
            return true;
        }
        public virtual bool IsFull()
        {
            return true;
        }

        public virtual void Peek()
        {
        }

        public void Print()
        {
            foreach (int item in iInternal)
            {
                Console.WriteLine("Value --- {0} ", item);
            }

        }
    }
}
