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
                int j = i;
                while (j > 0)
                {
                    if (iArrayInternalToSort[j - 1] > iArrayInternalToSort[j])
                    {
                        SwapMethod(iArrayInternalToSort, j, j-1);
                        j--;
                    }
                    else
                        break;
                }
            }
        }
        static int[] SwapMethod(int[] iArrayInternalToSort, int index1, int index2)
        {
            int iTempforSwap;
            
            iTempforSwap = iArrayInternalToSort[index1];
            iArrayInternalToSort[index1] = iArrayInternalToSort[index2];
            iArrayInternalToSort[index2] = iTempforSwap;
            return iArrayInternalToSort;
        }
   
    }
}
