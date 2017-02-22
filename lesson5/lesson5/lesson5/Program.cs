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
            //create array for Bubble sorting
            int[] iArrayFirst = new int[10];
            Random RandomArrayFirst = new Random();
            for (int i = 0; i < iArrayFirst.Length; i++)
            {
                iArrayFirst[i] = RandomArrayFirst.Next(iMinArrayRange, iMaxArrayRange);
            }
            //Create array for Insertion sorting
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

           
            //enter stack size 
            Console.WriteLine("Enter stack size from 1 to 50:");
            int iStackSize = Int32.Parse(Console.ReadLine());

            MyStack StackInterface = new MyStack(iStackSize);              //instanse to work with MyStack class - will give iStackSize to  this class

            Console.WriteLine("Enter queue size from 1 to 50:");
            int iQueueSize = Int32.Parse(Console.ReadLine());

            MyQueue QueueInterface = new MyQueue(iQueueSize);

            while (true)                                                   //selecting what you want to do with Stack. While is True forever. 
                                                                           //Clicking 5 to exit from work with Stack
            {

                Console.WriteLine("Menu:");
                Console.WriteLine("--1--Add new value to Stack");
                Console.WriteLine("--2--Show top value of Stack");
                Console.WriteLine("--3--Delete last value in Stack");
                Console.WriteLine("--4--Show all values of Stack");
                Console.WriteLine("--5--Add new value to Quene");
                Console.WriteLine("--6--Show current head, tail, count");
                Console.WriteLine("--7--Delete last value in Queue");
                Console.WriteLine("--8--Show all values in Queue");
                Console.WriteLine("--9--Don't want to select any option. Exit.");
                Console.Write("Enter what you want to do from 1 to 9:");
                int iToDo = Int32.Parse(Console.ReadLine());

                switch (iToDo)
                {
                    case 1:
                        Console.WriteLine("Enter new value you want to add:   ");
                        int value = Int32.Parse(Console.ReadLine());
                        StackInterface.Push(value);
                        break;

                    case 2:
                        Console.WriteLine("The top position is {0}", StackInterface.Peek());
                        break;

                    case 3:
                        StackInterface.Pop();
                        break;

                    case 4:
                        Console.WriteLine("Current Stack state:");
                        StackInterface.Print();
                        break;
                    case 5:
                        Console.WriteLine("Enter new value you want to add:   ");
                        int valueQueue = Int32.Parse(Console.ReadLine());
                        QueueInterface.Enqueue(valueQueue);
                        break;

                    case 6:
                        QueueInterface.Peek();
                        break;

                    case 7:
                        QueueInterface.Dequeue();
                        break;

                    case 8:
                        Console.WriteLine("Current Queue state:");
                        QueueInterface.Print();
                        break;

                    case 9:
                        System.Environment.Exit(1);
                        break;
                }
            }                                                
      }
              
    }
}
