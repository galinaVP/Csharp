using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class InsertionSort : Sorter                                     //base class is Sorter which containes Print and 
    {
        public InsertionSort(int[] iArray) : base(iArray)
        {
        }

        public override void Sort()
        {
            for (int i = 0; i < iArrayInternalToSort.Length-1; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (iArrayInternalToSort[j - 1] > iArrayInternalToSort[j])
                    {
                        SwapMethod(iArrayInternalToSort,j, j-1);
                        j--;
                    }
                    else
                        break;
                }
                
            }
        }
        
    }
}
