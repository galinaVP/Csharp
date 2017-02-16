using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static int i, j;
        static void Main(string[] args)
        {
            Console.WriteLine("Array will be created randomly from the range of numbers: 1-1000");
            Console.WriteLine("Enter the array size you want to see for next operations:");
            int iArraySize = Int32.Parse(Console.ReadLine());
            int iMinArrayRange = 1, iMaxArrayRange = 1000;
            int[] iArray = new int[iArraySize];
            Random RandomArray = new Random();

            for (i = 0; i < iArray.Length; i++)
            {
                iArray[i] = RandomArray.Next(iMinArrayRange, iMaxArrayRange);
            }

            PrintArray(iArray);
            Console.WriteLine("Sorted with Bubble method array: ");
            Bubble(iArray);

            Console.ReadLine();
        }

        static void Bubble(int[] iArray)
        {
            bool bSwappingTrue = true;

            while (bSwappingTrue)
            {
                bSwappingTrue = false;
                j++;
                for (i = 0; i < iArray.Length; i++)
                {
                    for (j = i + 1; j < iArray.Length; j++)
                    {
                        if (iArray[i] > iArray[j])
                        {
                            SwapMethod(iArray);
                            bSwappingTrue = true;
                        }
                    }
                } 
            }
            PrintArray(iArray);
        }

        static int[] SwapMethod(int[] iArray)
        {
            int iTempforSwap;

            iTempforSwap = iArray[i];
            iArray[i] = iArray[i + 1];
            iArray[i + 1] = iTempforSwap;
            return iArray;
        }

        static void PrintArray(int[] iArray)
        {
            for (i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine("Element {0} {1}", i, iArray[i]);
            }
        }

    }
   
}
