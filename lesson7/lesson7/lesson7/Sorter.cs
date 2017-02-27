using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    abstract class Sorter<T>:ISorter<T>
    {
        public T[] iArrayInternalToSort;
        public Sorter(T[] iArray)
        {
            iArrayInternalToSort = iArray;
        }

        public abstract void Sort();
        
        public T[] SwapMethod(T[] iArrayInternalToSort, int index1, int index2)
        {
            T iTempforSwap;

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
