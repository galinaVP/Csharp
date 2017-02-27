using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class BubbleSort <T> : Sorter<T> where T:IComparable<T> 
    {
        public BubbleSort(T [] iArray) : base(iArray)
        {
        }

        public override void Sort()
        {
            bool bSwappingTrue = true;
            while (bSwappingTrue)
            {
                bSwappingTrue = false;

                for (int i = 0; i < iArrayInternalToSort.Length - 1; i++)
                {
                    if (iArrayInternalToSort[i].CompareTo(iArrayInternalToSort[i + 1])>0)
                    {
                        SwapMethod(iArrayInternalToSort, i, i + 1);
                        bSwappingTrue = true;
                    }
                }
            }

        }
    }
}
