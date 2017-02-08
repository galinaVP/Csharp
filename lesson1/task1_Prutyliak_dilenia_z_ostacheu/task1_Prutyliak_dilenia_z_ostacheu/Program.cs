using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Prutyliak_dilenia_z_ostacheu
{
    class Program
    {
        static void Main(string[] args)
        {
            int iFirst, iSecond, iResult;
                       
            Console.WriteLine("Enter first input number:");                   
            iFirst = Int32.Parse(Console.ReadLine());
                      
            Console.WriteLine("Enter secondary input number:");
            iSecond = Int32.Parse(Console.ReadLine());
        
            iResult = iSecond % iFirst;
            if (iResult == 0)
            {
                Console.WriteLine("Second number is divided into first entirely");
            }
            else
            {
                Console.WriteLine("Second number  divided into first with remainder");
            }
            Console.ReadLine();
        }
    }
}
