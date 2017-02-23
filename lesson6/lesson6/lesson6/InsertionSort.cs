using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class InsertionSort : Sorter
    {

        public InsertionSort(int[] iArray) : base(iArray)
        {

        }
      
       static int j;
       
        public override void Sort()
        {
            
            for (int i = 0; i < iArrayInternalToSort.Length-1; i++)
            {
                j = i;
                while (j > 0)
                {
                    if (iArrayInternalToSort[j - 1] > iArrayInternalToSort[j])
                    {
                        SwapMethod(i,j);
                        j--;
                    }
                    else
                        break;
                }
                
            }
        }
        
    }
}
