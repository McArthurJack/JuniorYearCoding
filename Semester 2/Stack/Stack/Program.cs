using System;
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
                        Console.WriteLine(number + "was popped");
                    }
                    catch
                    {
                        Console.WriteLine("There is no elements in the Stack");
                    }
                }
                //Push
                if (answer == 2)
                {
                    try
                    {

                    }
                    catch
                    {

                    }
                }
                //Peek
                if (answer == 3)
                {
                    try
                    {

                    }
                    catch
                    {

                    }
                }
                //Print
                if (answer == 4)
                {
                    try
                    {

                    }
                    catch
                    {

                    }
                }
                Console.WriteLine();
                Console.Clear();
            } while (answer != 5);
        }
    }
}
