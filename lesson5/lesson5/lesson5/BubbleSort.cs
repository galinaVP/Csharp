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
            
            bool bSwappingTrue = true;
            while (bSwappingTrue)
            {
                bSwappingTrue = false;
                
                for (int i = 0; i < iArrayInternalToSort.Length - 1; i++)
                {
                    if (iArrayInternalToSort[i] > iArrayInternalToSort[i+1])
                    {
                        SwapMethod(iArrayInternalToSort, i, i+1);
                        bSwappingTrue = true;
                    }
                }
            }
        }

        static int[] SwapMethod(int[] iArrayInternalToSort, int index1, int index2)                                 // static method - will be used and seen only in this class
        {
            int iTempforSwap;
            
            iTempforSwap = iArrayInternalToSort[index1];
            iArrayInternalToSort[index1] = iArrayInternalToSort[index2];
            iArrayInternalToSort[index2] = iTempforSwap;
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
