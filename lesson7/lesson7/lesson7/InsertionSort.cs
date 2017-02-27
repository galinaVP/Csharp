using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class InsertionSort<T> : Sorter<T> where T : IComparable<T>
    {
        public InsertionSort(T[] iArray) : base(iArray)
        {
        }

        public override void Sort()
        {
            for (int i = 0; i < iArrayInternalToSort.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (iArrayInternalToSort[j - 1].CompareTo(iArrayInternalToSort[j])>0)
                    {
                        SwapMethod(iArrayInternalToSort, j, j - 1);
                        j--;
                    }
                    else
                        break;
                }

            }
        }

    }
}
