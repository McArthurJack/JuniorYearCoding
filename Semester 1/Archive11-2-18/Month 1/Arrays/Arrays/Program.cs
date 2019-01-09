using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Arrays");
            //Random rand = new Random();

            //int[] myArray = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Input a number to put into the array");
            //    int answer = Convert.ToInt32(Console.ReadLine());
            //    if (answer > 10)
            //    {
            //        Console.WriteLine("Answer is greater than 10 soo it has become null");
            //        answer = 0;
            //        myArray[i] = answer;
            //    }
            //    else
            //        myArray[i] = answer;
            //    Console.WriteLine();
            //}
            //Writes each element in my Array
            //Console.WriteLine("All the elements in the Array");
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] myArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int i in myArray)
            //{
            //    myArray[i] = 0;
            //}

            //foreach (int i in myArray)
            //    Console.Write(i + ", ");

            //// Lists
            //Console.WriteLine("Lists");
            //List<int> myList = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    myList.Add(i);
            //}

            //foreach (int i in myList)
            //    Console.Write(i + ", ");

            //Console.WriteLine();
            //Console.WriteLine("Removing all Numbers from the List");

            //for (int i = myList.Count - 1; i > -1; i--)
            //    myList.RemoveAt(i);

            //foreach (int i in myList)
            //    Console.Write(i + ", ");

            // Lists
            Console.WriteLine("Lists");
            List<int> myList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            foreach (int i in myList)
                Console.Write(i + ", ");
            Console.WriteLine();

            for (int i = myList.Count-1; i > 5; i--)
            {
                myList.RemoveAt(i);
            }

            foreach (int i in myList)
                Console.Write(i + ", ");

            Console.ReadLine();
        }
    }
}