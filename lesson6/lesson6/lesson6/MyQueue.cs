﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class MyQueue : Buffer
    {
        private int iHead, iTail, iCount, iValue;                     
        
        public MyQueue(int iArray) : base(iArray)                                             
        {
        }
        public void Enqueue(int valueQueue)
        {

            if (IsFull())
            {
                Console.WriteLine("Queue is full. to add new value you need to make deguene operation");
            }
            else
            {
                iInternal[iTail++] = valueQueue;                               
                if (iTail == iInternalSize)                                     
                {
                    iTail = 0;
                }
                iCount++;

                Console.WriteLine("Value {0} added to the Queue to position {1}", valueQueue, iTail);
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty. Can do this action");
                return 0;
            }
            else
            {
                iValue = iInternal[iHead++];                                                        
                if (iHead == iInternalSize)                                                         
                {
                    iHead = 0;
                }
                iCount--;
                Console.WriteLine("Dequeue value is: {0} from position {1}", iInternal[iHead], iHead);
                return iHead;
            }
        }

        public override bool IsEmpty()                     
        {
            if (iCount == 0)
            { return true; }
            else
            { return false; }
        }

        public override bool IsFull()                          
        {
            if (iCount == iInternalSize)
            { return true; }
            else
            { return false; }
        }

        public override void Peek()
        {
            Console.WriteLine("Current head value is {0}", iInternal[iHead]);
            Console.WriteLine("Current tail value is {0}", iInternal[iTail]);
            Console.WriteLine("Current count of values is {0}", iCount);
        }
    }
}
