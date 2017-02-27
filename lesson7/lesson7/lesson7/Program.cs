using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //BUBLE
            int iMinArrayRange = 1, iMaxArrayRange = 10000;
            int[] iArrayFirst = new int[5];
            Random RandomArrayFirst = new Random();
            for (int i = 0; i < iArrayFirst.Length; i++)
            {
                iArrayFirst[i] = RandomArrayFirst.Next(iMinArrayRange, iMaxArrayRange);
            }
            //INSERTION
            int[] iArraySecond = new int[5];
            Random RandomArraySecond = new Random();
            for (int i = 0; i < iArraySecond.Length; i++)
            {
                iArraySecond[i] = RandomArraySecond.Next(iMinArrayRange, iMaxArrayRange);
            }

            // BUBLEsorting

            Console.WriteLine("Bubble Sorting Method:");
            var bubble = new BubbleSort <int> (iArrayFirst);
            bubble.PrintArray();
            bubble.Sort();
            bubble.PrintArray();


            // InsertionSorting
            Console.WriteLine("Insertion Sorting Method:");
            var insert = new InsertionSort <int>(iArraySecond);
            insert.PrintArray();
            insert.Sort();
            insert.PrintArray();

            Console.ReadKey();

        }
    }
}
