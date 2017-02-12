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
            Console.WriteLine("Enter Array size:");
            int iArraySize = Int32.Parse(Console.ReadLine());
            int i;
            int[] iArray = new int[iArraySize];
                     
            Console.WriteLine("Fill array with numbers. After each number click Enter button");
       
            for (i = 0; i < iArraySize; i++)
            {
                Console.Write("Enter {0}:", i);
                iArray[i] = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("You entered next values:");
            for (i = 0; i < iArraySize; i++)
            {
                Console.WriteLine(iArray[i]);
            }
            Console.ReadLine();
        }
        
    }
}
