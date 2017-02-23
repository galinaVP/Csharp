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

                for (int i = 0; i < iArrayInternalToSort.Length-1; i++)
                {
                    for (int j = i + 1; j < iArrayInternalToSort.Length; j++)
                    {
                        if (iArrayInternalToSort[i] > iArrayInternalToSort[j] )
                        {
                            SwapMethod(i, j);
                            bSwappingTrue = true;
                        }
                    }
                    
                }
            }
        }
 
    }
}
