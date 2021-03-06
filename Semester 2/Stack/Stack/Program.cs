﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        public static Stack Stacker = new Stack();
        static void Main(string[] args)
        {
            int answer = -1;
            do
            {
                Console.WriteLine("1. Remove and return the First number of the Stack");
                Console.WriteLine("2. Add a value to the top of the stack");
                Console.WriteLine("3. Return the top element of the stack");
                Console.WriteLine("4. Print the entire Stack");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Int32.TryParse(Console.ReadLine(), out answer);

                //Pop
                if (answer == 1)
                {
                    try
                    {
                        int number = Stacker.Pop();
                        Console.WriteLine(number + " was popped");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("There is no elements in the Stack");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                }
                //Push
                if (answer == 2)
                {
                    int addnumber;
                    Console.Write("Enter the number you would like to add: ");
                    Int32.TryParse(Console.ReadLine(), out addnumber);
                    try
                    {
                        Stacker.Push(addnumber);
                        Console.WriteLine(addnumber + " was added to the stack.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("You must enter a number not anything else.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                }
                //Peek
                if (answer == 3)
                {
                    try
                    {
                        int peek = Stacker.peek();
                        Console.WriteLine(peek + " was the top element.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("There is no elements in the Stack");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                }
                //Print
                if (answer == 4)
                {
                    try
                    {
                        Stacker.Print();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("There is no elements in the Stack");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine();
                Console.Clear();
            } while (answer != 5);
        }
    }
}
