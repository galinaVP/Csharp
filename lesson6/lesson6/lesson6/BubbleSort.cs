using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class BubbleSort : Sorter
    {
        public BubbleSort(int[] iArray) : base(iArray)
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
                    if (iArrayInternalToSort[i] > iArrayInternalToSort[i + 1])
                    {
                        SwapMethod(iArrayInternalToSort, i, i + 1);
                        bSwappingTrue = true;
                    }
                }
              }

            }

        }
}
