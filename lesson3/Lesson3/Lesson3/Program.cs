using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static int iMax, iMin, i; 
                
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size in range 1-214748300:");
            int iArraySize = Int32.Parse(Console.ReadLine());

            int[] iArray = new int[iArraySize];
            
            Console.WriteLine("Fill array with numbers. After each number click Enter button");

            for (i = 0; i < iArraySize; i++)
            {
                Console.Write("Enter {0}:", i);
                iArray[i] = Int32.Parse(Console.ReadLine());
            }

            int iMax = FindMax(iArray);
            int iMin = FindMin(iArray);

            Console.WriteLine("Maximum value is: {0}", iMax);
            Console.WriteLine("Minimum value is: {0}", iMin);
            Console.ReadLine();

        }

            static int FindMax(int[] iArray)
            {

            iMax = iArray[0];

            for (i = 0; i < iArray.Length; i++)
            {
                if (iMax < iArray[i])
                {
                    iMax = iArray[i];
                }
             }
            return iMax;
            }


        static int FindMin(int[] iArray)
        {

           iMin = iArray[0];

            for (i = 0; i < iArray.Length; i++)
            {
                if (iMin > iArray[i])
                {
                    iMin = iArray[i];
                }
            }
            return iMin;
        }
          
       
        
    }
}
