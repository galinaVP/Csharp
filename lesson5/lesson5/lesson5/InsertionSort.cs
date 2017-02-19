using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class InsertionSort
    {
        static int[] iArrayInternalToSort;
        static int j;

        public InsertionSort(int[] iArray)
        {
            iArrayInternalToSort = iArray;
        }

        public void PrintArray()
        {
            for (int i = 0; i < iArrayInternalToSort.Length; i++)
            {
                Console.WriteLine("Element {0} {1}", i, iArrayInternalToSort[i]);
            }
            Console.WriteLine("----------------------------");
        }
        public void Sort()
        {
            for (int i = 0; i < iArrayInternalToSort.Length; i++)
            {
                j = i;
                while (j > 0)
                {
                    if (iArrayInternalToSort[j - 1] > iArrayInternalToSort[j])
                    {
                        SwapMethodInsertion();
                        
                    }
                    else
                        break;
                }
            }
        }
        static int[] SwapMethodInsertion()
        {
            int iTempforSwap;
            
            iTempforSwap = iArrayInternalToSort[j-1];
            iArrayInternalToSort[j - 1] = iArrayInternalToSort[j];
            iArrayInternalToSort[j] = iTempforSwap;
            j--;
            return iArrayInternalToSort;
        }
   
    }
}
