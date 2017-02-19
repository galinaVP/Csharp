using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class BubbleSort
    {
        static int[] iArrayInternalToSort;               // internal var for current class. will use it for next sorting flow to do not corrupt hole array
        public BubbleSort(int[] iArray)
        {
            iArrayInternalToSort = iArray;
        }

        public void Sort()                                //should be public - to have access from main programm where instance created
        {
            int i;
            bool bSwappingTrue = true;
            while (bSwappingTrue)
            {
                bSwappingTrue = false;
                
                for (i = 0; i < iArrayInternalToSort.Length - 1; i++)
                {
                    if (iArrayInternalToSort[i] > iArrayInternalToSort[i+1])
                    {
                        SwapMethod(i);
                        bSwappingTrue = true;
                    }
                }
            }
        }

        static int[] SwapMethod(int i)                                 // static method - will be used and seen only in this class
        {
            int iTempforSwap;
            
            iTempforSwap = iArrayInternalToSort[i];
            iArrayInternalToSort[i] = iArrayInternalToSort[i+1];
            iArrayInternalToSort[i+1] = iTempforSwap;
            return iArrayInternalToSort;
        }
        

        public void PrintArray()
        {
            for (int i = 0; i < iArrayInternalToSort.Length; i++)
            {
                Console.WriteLine("Element {0} {1}", i, iArrayInternalToSort[i]);
            }
            Console.WriteLine("----------------------------");
        }
        

    }
}
