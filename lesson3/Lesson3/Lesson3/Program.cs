using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size from 1 to :");

            int iArraySize = Int32.Parse(Console.ReadLine());
            int[] iArray = new int[iArraySize];
            int i, iMax, iMin;
                    
            Console.WriteLine("Fill array with numbers. After each number click Enter button");
       
            for (i = 0; i < iArraySize; i++)
            {
                Console.Write("Enter {0}:", i);
                iArray[i] = Int32.Parse(Console.ReadLine());
            }
    
            iMax = iArray[0];
            iMin = iArray[0];

            for (i = 0; i < iArraySize; i++)
            {
                if (iMax < iArray[i])
                {
                    iMax = iArray[i];
                }
            }

            Console.WriteLine("Maximum value is: {0}", +iMax);

            for (i = 0; i < iArraySize; i++)
            {
                if (iMin > iArray[i])
                {
                    iMin = iArray[i];
                }
            }

            Console.WriteLine("Minimum value is: {0}", +iMin);
            
            Console.ReadLine();
        }
        
    }
}
