using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class MyQueue
    {
        private int iHead, iTail, iCount, iInternalSize, iValue;                     //head - the first element which was recorded and will be read. tail - the last one. count - the amount of values(between head and tail)
        private int[] iInternal;

        public MyQueue(int iQueueSize)                                             //create empty array(queue) using size entered by user in main program
        {
            iInternalSize = iQueueSize;
            iInternal = new int[iInternalSize];
        }
        public void Enqueue(int valueQueue)
        {
            
            if (IsFull())
            {
                Console.WriteLine("Queue is full. to add new value you need to make deguene operation");
            }
            else
            {
                iInternal[iTail++] = valueQueue;                               //entered value will be inserted to tail position.started from 1. if tail go to the front of queue it starts from the begining
                if (iTail == iInternalSize)                                     //and the amount of values will be increased to 1
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
                iValue = iInternal[iHead++];                                                        //the same as for tail - but from another side. head value will go to some another temp value- will be used for example to be displayed somewhere as a result of execution
                if (iHead == iInternalSize)                                                         //amount of values will be less
                {
                    iHead = 0;
                }
                iCount--;
                Console.WriteLine("Dequeue value is: {0} from position {1}", iInternal[iHead], iHead);
                return iHead;
            }
        }

        public bool IsEmpty()                     //if there no any values in array - amount of them=0 - so queue is empty and can't be dequine
        {
            if ( iCount == 0)
            { return true; }
            else
            { return false; }
        }

        public bool IsFull()                          //if the amount of insered values is the same as array(quene) size - it's full
        {
            if (iCount == iInternalSize)
            { return true; }
            else
            { return false; }
         }

        public int Peek()
        {
            Console.WriteLine("Current head value is {0}", iInternal[iHead]);
            Console.WriteLine("Current tail value is {0}", iInternal[iTail]);
            Console.WriteLine("Current count of values is {0}", iCount);
            return iHead;
        }
        public void Print()
        {
            foreach (int item in iInternal)                                            //will show all values (array) including 0 - empty fields.
            {
                Console.WriteLine("Value {0}", item);
            }
            
        }
        
        }
    }


