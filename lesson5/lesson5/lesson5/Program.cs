using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
         
        static void Main(string[] args)
        {
            
            int iMinArrayRange = 1, iMaxArrayRange = 10000;
            int[] iArrayFirst = new int[10];
            Random RandomArrayFirst = new Random();
            for (int i = 0; i < iArrayFirst.Length; i++)
            {
                iArrayFirst[i] = RandomArrayFirst.Next(iMinArrayRange, iMaxArrayRange);
            }
            int[] iArraySecond = new int[20];
            Random RandomArraySecond = new Random();
            for (int i = 0; i < iArraySecond.Length; i++)
            {
                iArraySecond[i] = RandomArraySecond.Next(iMinArrayRange, iMaxArrayRange);
            }

            // sorting using bubble sort
            Console.WriteLine("Bubble Sorting Method:");
            BubbleSort bubble = new BubbleSort(iArrayFirst);                 //created instance "bubble" with type BubbleSort what is the type of class(same name). iArray - is the input created array. we send it to class
            bubble.PrintArray();                                        //will show elements before sorting
            bubble.Sort();                                              //calling Sort method from Class BubbleSort for which instance called "bubble"
            bubble.PrintArray();                                        //will show elements after sorting

           
            // sorting using insertion sort
            Console.WriteLine("Insertion Sorting Method:");
            InsertionSort insert = new InsertionSort(iArraySecond);
            insert.PrintArray();                                        //will show elements before sorting
            insert.Sort();                                              //calling Sort method from Class InsertionSort for which instance called "insert"
            insert.PrintArray();                                        //will show elements after sorting

            Console.ReadKey();

        }

        /// Method for printing array, which created at the begining 
            
        
        
    }
}
