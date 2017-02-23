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
        public void SwapMethod(int i, int j)
        {
            int iTempforSwap;

            iTempforSwap = iArrayInternalToSort[i];
            iArrayInternalToSort[i] = iArrayInternalToSort[j];
            iArrayInternalToSort[j] = iTempforSwap;
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
