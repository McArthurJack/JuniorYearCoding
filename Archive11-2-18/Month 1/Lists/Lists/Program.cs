using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> myList = new List<int>(10);
            Console.WriteLine("Lists");

            // Adds random Numbers to the list.
            for (int i = 0; i < 10000; i++)
            {
                myList.Add(rand.Next(10000));
            }
            Console.Write("The numbers in your list are .... ");
            foreach (int i in myList)
            {
                Console.Write(i + ", ");
            }

            // User Input Code
            //while (myList.Count < 10)
            //{
            //    Console.WriteLine("You are adding Element " + "#" + (myList.Count+1) + " " + "to this list.");
            //    int answer = Convert.ToInt32(Console.ReadLine());
            //    myList.Add(answer);
            //}
            //Console.Write("The numbers in your list are.... ");
            //foreach (int i in myList)
            //{
            //    Console.Write(i + ", ");
            //}
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
