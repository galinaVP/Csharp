using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Sorter
    {
        public int[] iArrayInternalToSort;
        public Sorter(int[] iArray)
        {
            iArrayInternalToSort = iArray;
        }

        public virtual void Sort()
        {
        }
        public int[] SwapMethod(int[] iArrayInternalToSort, int index1, int index2)
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
