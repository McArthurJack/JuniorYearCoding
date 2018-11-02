using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_things_with_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Results();
        }

        public static void Results()
        {
            int answer = 0;
            do
            {
                Console.WriteLine("1. Adds 5 + 6, and prints the result");
                Console.WriteLine("2. Adds 11 + 13, and prints the result");
                Console.WriteLine("3. Adds 3 + 9, and prints the result");
                Console.WriteLine("4. Multiplys 1-100 by themselves");
                Console.WriteLine("5. EXIT THE PROGRAM");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine();
                    Add1();
                    Console.WriteLine();
                }
                else if (answer == 2)
                {
                    Console.WriteLine();
                    Add2();
                    Console.WriteLine();
                }
                else if (answer == 3)
                {
                    Console.WriteLine();
                    Add3();
                    Console.WriteLine();
                }
                else if (answer == 4)
                {
                    Console.WriteLine();
                    Mult1();
                    Console.WriteLine();
                }
                Console.ReadLine();
            } while (answer != 5);
        }

        static void Add1()
        {
            Console.WriteLine(5 + 6);
        }

        static void Add2()
        {
            Console.WriteLine(11 + 13);
        }

        static void Add3()
        {
            Console.WriteLine(3 + 9);
        }

        static void Mult1()
        {
            for (int i = 0; i < 10001; i++)
            {
                Console.Write(i + " Squared = " + (i * i));
                Console.Write("     I / I = ");
                Console.Write(1 / (i + 1));
                Console.WriteLine();
            }
        }
    }
}
