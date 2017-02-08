using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Prytuliak
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumber=0, iRemainder=0;
            

            while (iNumber++ < 100)
            {
                if (iNumber % 5 == iRemainder && iNumber % 3 == iRemainder)
                {
                    Console.WriteLine("{0}", "FizzBuzz");
                }
                else if (iNumber % 3 == iRemainder)
                {
                   Console.WriteLine("{0}", "Fizz");
                }
                else if (iNumber % 5 == iRemainder)
                {
                   Console.WriteLine("{0}", "Buzz");
                 }
              
                else
                {
                    Console.WriteLine(iNumber);
                }
                
            }

            Console.ReadLine();
        }
    }
}
